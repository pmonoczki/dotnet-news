namespace DrawingApplication
{
  partial class DrawingForm
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
      this.drawingCanvas1 = new DrawingApplication.DrawingCanvas();
      this.SuspendLayout();
      // 
      // drawingCanvas1
      // 
      this.drawingCanvas1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.drawingCanvas1.Location = new System.Drawing.Point(0, 0);
      this.drawingCanvas1.Name = "drawingCanvas1";
      this.drawingCanvas1.Size = new System.Drawing.Size(284, 258);
      this.drawingCanvas1.TabIndex = 0;
      // 
      // DrawingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 258);
      this.Controls.Add(this.drawingCanvas1);
      this.Name = "DrawingForm";
      this.Text = "Draw Some Lines!";
      this.ResumeLayout(false);

    }

    #endregion

    private DrawingCanvas drawingCanvas1;
  }
}

