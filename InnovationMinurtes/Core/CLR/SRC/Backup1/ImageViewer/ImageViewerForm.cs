using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace ImageViewer
{
  public partial class ImageViewerForm : Form
  {
    public IDisposable imageLister;
    public IDisposable thumbnailLoader;
    public IDisposable imageLoader;

    public ISubject<ListViewItem> itemObservable = new Subject<ListViewItem>();
    
    public ImageViewerForm()
    {
      InitializeComponent();

      this.textImagesPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
    }

    private static KeyValuePair<A, B> MakePair<A,B>(A a, B b)
    {
      return new KeyValuePair<A, B>(a, b);
    }

    private static Image LoadThumbnail(string filename)
    {
      var image = Image.FromFile(filename);
      var thumb = new Bitmap(image, new Size(64, 64));
      image.Dispose();
      return thumb;
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      // Create a subject to make it easy to listen for thumbnail images and update them on the winforms thread.
      var thumbnailSubject = new Subject<KeyValuePair<ListViewItem, Image>>();

      // Observes thumbnailSubject on the winforms thread and puts the thumbnail into the image list and the listview.
      thumbnailSubject.ObserveOn(this).Subscribe(item =>
      {
        this.imageList.Images.Add(item.Key.Text, item.Value);
        item.Key.ImageKey = item.Key.Text;
      });

      // We want to receive item notifications on a different thread, so we 
      // make use of the Delay() method to place the observable sequence on 
      // the Scheduler.Later pool.
      var thumbnailLoader = from listItem in itemObservable.Delay(Scheduler.Later, TimeSpan.FromSeconds(0.5))
                            let filename = listItem.Text
                            let thumb = LoadThumbnail(filename)
                            select MakePair(listItem, (Image)thumb);

      // We can't just call thumbnailLoader.Subscribe(thumbnailSubject) because when the thumbnailLaoder 
      // finishes it will call the subjets OnComplete(), and that will stop our thumbnails loading on a different directory.
      thumbnailLoader.Subscribe(a => thumbnailSubject.OnNext(a));

      // Create an observable based on the SelectedIndexChanged event on the list 
      // view, and provide objects describing the selected item and the filename for that item.
      //
      // Using the Delay() at the end ensures that the items provided will be on a different thread.
      var selectedFilename = (from index in Observable.FromEvent<EventArgs>(this.listViewThumbnails, "SelectedIndexChanged")
                             where this.listViewThumbnails.SelectedItems.Count > 0
                             select new
                             {
                               Item = this.listViewThumbnails.SelectedItems[0],
                               Filename = this.listViewThumbnails.SelectedItems[0].Text
                             }).Delay(Scheduler.Later, TimeSpan.FromMilliseconds(10));

      // Transform the selectedFilename observable into one that loads in images from the selectedFilename observable.
      var selectedImage = (from item in selectedFilename
                          let filename = item.Filename
                          let image = Image.FromFile(filename)
                          let thumb = new Bitmap(image, new Size(64, 64))
                          select new
                          {
                            Item = item.Item,
                            Filename = item.Filename,
                            Image = image,
                            Thumb = thumb
                          }).Publish();

      // Observe the selectedImage and construct an object the the thumbnailSubject understands
      var selectedImageThumb = from item in selectedImage
                               select MakePair(item.Item, (Image)item.Thumb);

      // Connect the selected thumb image to the thumbnail subject so when we load the selected image, the thumbnail updates.
      selectedImageThumb.Subscribe(a => thumbnailSubject.OnNext(a));

      // Observe selectedImage on the WinForms thread to show the selected image in the main window.
      selectedImage.ObserveOn(this).Subscribe(item => ShowImage(item.Image));
    }

    /// <summary>
    /// Sets the current image on display, and also disposes the old one if we don't need it any more.
    /// </summary>
    /// <param name="image"></param>
    private void ShowImage(Image image)
    {
      if (this.pictureCurrent.Image != null && !object.ReferenceEquals(this.pictureCurrent.Image, image))
      {
        var oldImage = this.pictureCurrent.Image;
        this.pictureCurrent.Image = null;
        oldImage.Dispose();
      }
      this.pictureCurrent.Image = image;
    }

    private void butFindImages_Click(object sender, EventArgs e)
    {
      this.listViewThumbnails.Clear();

      var path = this.textImagesPath.Text;

      var files = FindImageFiles(path).ToObservable(Scheduler.Later).ObserveOn(this);

      var items = from f in files
                  let item = this.listViewThumbnails.Items.Add(f)
                  select item;

      items.Subscribe(item => itemObservable.OnNext(item));
    }

    /// <summary>
    /// Gets the enumeration of files names in the given <paramref name="path"/> that have an image extension.
    /// </summary>
    /// <param name="path">The path to search</param>
    /// <returns>The image filenames in the directory <paramref name="path"/></returns>
    private static IEnumerable<string> FindImageFiles(string path)
    {
      var extensions = new string[] { 
        ".jpg", ".jpeg", ".bmp", ".png"
      };

      var files = from f in Directory.GetFiles(path)
                  where extensions.Any(ex => f.EndsWith(ex, StringComparison.OrdinalIgnoreCase))
                  select f;

      foreach (var f in files)
      {
        yield return f;
      }
    }
  }

}
