namespace Directories
{
  partial class DirectoriesForm
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
      this.butObserverSingle = new System.Windows.Forms.Button();
      this.treeViewDirectories = new System.Windows.Forms.TreeView();
      this.butObserveBuffered = new System.Windows.Forms.Button();
      this.butStop = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // butObserverSingle
      // 
      this.butObserverSingle.Location = new System.Drawing.Point(12, 12);
      this.butObserverSingle.Name = "butObserverSingle";
      this.butObserverSingle.Size = new System.Drawing.Size(113, 23);
      this.butObserverSingle.TabIndex = 0;
      this.butObserverSingle.Text = "Get Directories";
      this.butObserverSingle.UseVisualStyleBackColor = true;
      this.butObserverSingle.Click += new System.EventHandler(this.butObserverSingle_Click);
      // 
      // treeViewDirectories
      // 
      this.treeViewDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.treeViewDirectories.Location = new System.Drawing.Point(12, 78);
      this.treeViewDirectories.Name = "treeViewDirectories";
      this.treeViewDirectories.Size = new System.Drawing.Size(260, 168);
      this.treeViewDirectories.TabIndex = 1;
      // 
      // butObserveBuffered
      // 
      this.butObserveBuffered.Location = new System.Drawing.Point(131, 12);
      this.butObserveBuffered.Name = "butObserveBuffered";
      this.butObserveBuffered.Size = new System.Drawing.Size(141, 23);
      this.butObserveBuffered.TabIndex = 0;
      this.butObserveBuffered.Text = "Get Directories (buffered)";
      this.butObserveBuffered.UseVisualStyleBackColor = true;
      this.butObserveBuffered.Click += new System.EventHandler(this.butObserveBuffered_Click);
      // 
      // butStop
      // 
      this.butStop.Location = new System.Drawing.Point(13, 42);
      this.butStop.Name = "butStop";
      this.butStop.Size = new System.Drawing.Size(75, 23);
      this.butStop.TabIndex = 2;
      this.butStop.Text = "Stop";
      this.butStop.UseVisualStyleBackColor = true;
      this.butStop.Click += new System.EventHandler(this.butStop_Click);
      // 
      // DirectoriesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 258);
      this.Controls.Add(this.butStop);
      this.Controls.Add(this.treeViewDirectories);
      this.Controls.Add(this.butObserveBuffered);
      this.Controls.Add(this.butObserverSingle);
      this.Name = "DirectoriesForm";
      this.Text = "Directories Example";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button butObserverSingle;
    private System.Windows.Forms.TreeView treeViewDirectories;
    private System.Windows.Forms.Button butObserveBuffered;
    private System.Windows.Forms.Button butStop;
  }
}

