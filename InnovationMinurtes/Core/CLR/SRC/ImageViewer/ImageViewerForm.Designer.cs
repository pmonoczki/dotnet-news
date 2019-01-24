namespace ImageViewer
{
  partial class ImageViewerForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.textImagesPath = new System.Windows.Forms.TextBox();
      this.butFindImages = new System.Windows.Forms.Button();
      this.listViewThumbnails = new System.Windows.Forms.ListView();
      this.imageList = new System.Windows.Forms.ImageList(this.components);
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.pictureCurrent = new System.Windows.Forms.PictureBox();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureCurrent)).BeginInit();
      this.SuspendLayout();
      // 
      // textImagesPath
      // 
      this.textImagesPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.textImagesPath.Location = new System.Drawing.Point(12, 12);
      this.textImagesPath.Name = "textImagesPath";
      this.textImagesPath.Size = new System.Drawing.Size(507, 20);
      this.textImagesPath.TabIndex = 0;
      this.textImagesPath.Text = "c:\\home\\phillip\\photos";
      // 
      // butFindImages
      // 
      this.butFindImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.butFindImages.Location = new System.Drawing.Point(525, 10);
      this.butFindImages.Name = "butFindImages";
      this.butFindImages.Size = new System.Drawing.Size(75, 23);
      this.butFindImages.TabIndex = 1;
      this.butFindImages.Text = "Show Images";
      this.butFindImages.UseVisualStyleBackColor = true;
      this.butFindImages.Click += new System.EventHandler(this.butFindImages_Click);
      // 
      // listViewThumbnails
      // 
      this.listViewThumbnails.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listViewThumbnails.LargeImageList = this.imageList;
      this.listViewThumbnails.Location = new System.Drawing.Point(0, 0);
      this.listViewThumbnails.Name = "listViewThumbnails";
      this.listViewThumbnails.Size = new System.Drawing.Size(196, 291);
      this.listViewThumbnails.TabIndex = 2;
      this.listViewThumbnails.UseCompatibleStateImageBehavior = false;
      // 
      // imageList
      // 
      this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
      this.imageList.ImageSize = new System.Drawing.Size(64, 64);
      this.imageList.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer1.Location = new System.Drawing.Point(12, 38);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.listViewThumbnails);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.pictureCurrent);
      this.splitContainer1.Size = new System.Drawing.Size(588, 291);
      this.splitContainer1.SplitterDistance = 196;
      this.splitContainer1.TabIndex = 3;
      // 
      // pictureCurrent
      // 
      this.pictureCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureCurrent.Location = new System.Drawing.Point(0, 0);
      this.pictureCurrent.Name = "pictureCurrent";
      this.pictureCurrent.Size = new System.Drawing.Size(388, 291);
      this.pictureCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureCurrent.TabIndex = 0;
      this.pictureCurrent.TabStop = false;
      // 
      // ImageViewerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(612, 341);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.butFindImages);
      this.Controls.Add(this.textImagesPath);
      this.Name = "ImageViewerForm";
      this.Text = "Image Viewer";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureCurrent)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textImagesPath;
    private System.Windows.Forms.Button butFindImages;
    private System.Windows.Forms.ListView listViewThumbnails;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.PictureBox pictureCurrent;
    private System.Windows.Forms.ImageList imageList;
  }
}

