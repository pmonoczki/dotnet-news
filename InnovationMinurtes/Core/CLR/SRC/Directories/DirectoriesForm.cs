using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Directories
{
  /// <summary>
  /// Provides an example of using the RxFramework to get directory listings using a background thread.
  /// </summary>
  public partial class DirectoriesForm : Form
  {
    /// <summary>
    /// An observable providing a directory as soon as it is encountered.
    /// </summary>
    IObservable<string> directories;

    /// <summary>
    /// An observable providing directories in groups.
    /// </summary>
    IObservable<IEnumerable<string>> bufferedDirectories;

    /// <summary>
    /// The current observer that is observing on one of the observables.
    /// </summary>
    IDisposable observer;

    public DirectoriesForm()
    {
      InitializeComponent();

      // Observe the enumeration of all directories using the winforms thread.
      this.directories = Observable.ToObservable(GetAllDirectories(@"c:\")).ObserveOn(this);

      // Observe the enumeratino of all directories, but buffered in groups 
      // of 1 second, and then observe that group on the winforms thread.
      this.bufferedDirectories =
        Observable.ToObservable(GetAllDirectories(@"c:\"))
        .Buffer(TimeSpan.FromSeconds(1))
        .ObserveOn(this);

      this.butStop.Enabled = false;
    }

    private void butStop_Click(object sender, EventArgs e)
    {
      // Clear out the running observer
      if (this.observer != null)
      {
        this.observer.Dispose();
        this.observer = null;
        this.butStop.Enabled = false;
        this.butObserverSingle.Enabled = true;
        this.butObserveBuffered.Enabled = true;
      }
    }

    private void butObserverSingle_Click(object sender, EventArgs e)
    {
      this.treeViewDirectories.Nodes.Clear();
      if (this.observer == null)
      {
        // Observe on the single directories.
        this.observer = this.directories.Subscribe(outputDirectory);
        this.butStop.Enabled = true;
        this.butObserverSingle.Enabled = false;
        this.butObserveBuffered.Enabled = false;
      }
    }

    private void butObserveBuffered_Click(object sender, EventArgs e)
    {
      this.treeViewDirectories.Nodes.Clear();
      if (this.observer == null)
      {
        // observe on the buffered directories.
        this.observer = this.bufferedDirectories.Subscribe(outputDirectories);
        this.butStop.Enabled = true;
        this.butObserverSingle.Enabled = false;
        this.butObserveBuffered.Enabled = false;
      }
    }

    private void outputDirectory(string path)
    {
      // We check to see if the handle is created because when 
      // the form is disposing this may still be trying to observe.
      if (this.treeViewDirectories.IsHandleCreated)
      {
        this.treeViewDirectories.Nodes.Add(path);
      }
    }

    private void outputDirectories(IEnumerable<string> paths)
    {
      // We check to see if the handle is created because when 
      // the form is disposing this may still be trying to observe.
      if (this.treeViewDirectories.IsHandleCreated)
      {
        try
        {
          this.treeViewDirectories.BeginUpdate();
          foreach (var path in paths)
          {
            this.treeViewDirectories.Nodes.Add(path);
          }
        }
        finally
        {
          this.treeViewDirectories.EndUpdate();
        }
      }
    }

    /// <summary>
    /// Gets the enumeratino of all directories and sub directories under the given path.
    /// </summary>
    /// <param name="path">The path to search</param>
    /// <returns>The enumeration of all directories and sub directories.</returns>
    static IEnumerable<string> GetAllDirectories(string path)
    {
      string[] subdirs = null;

      // Some directories may be inaccessable.
      try
      {
        subdirs = Directory.GetDirectories(path);
      }
      catch (IOException)
      {
      }

      if (subdirs != null)
      {
        foreach (var subdir in subdirs)
        {
          yield return subdir;

          foreach (var grandchild in GetAllDirectories(subdir))
          {
            yield return grandchild;
          }
        }
      }
    }
  }
}
