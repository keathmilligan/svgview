
namespace svgview
{
    partial class SVGView
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
            this.svgImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.svgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // svgImage
            // 
            this.svgImage.BackColor = System.Drawing.Color.Black;
            this.svgImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.svgImage.Location = new System.Drawing.Point(0, 0);
            this.svgImage.Name = "svgImage";
            this.svgImage.Size = new System.Drawing.Size(800, 450);
            this.svgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.svgImage.TabIndex = 0;
            this.svgImage.TabStop = false;
            this.svgImage.Click += new System.EventHandler(this.svgImage_Click);
            this.svgImage.DoubleClick += new System.EventHandler(this.svgImage_DoubleClick);
            // 
            // SVGView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.svgImage);
            this.Name = "SVGView";
            this.Text = "SVGView";
            ((System.ComponentModel.ISupportInitialize)(this.svgImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox svgImage;
    }
}