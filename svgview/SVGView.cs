using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svg;

namespace svgview
{
    public partial class SVGView : Form
    {
        private string svgFilename;

        public SVGView(string svgFilename)
        {
            this.svgFilename = svgFilename;
            InitializeComponent();
            RenderSvg();
        }

        private void RenderSvg()
        {
            svgImage.Image?.Dispose();
            var dir = Directory.GetCurrentDirectory();
            var svgDoc = SvgDocument.Open<SvgDocument>(svgFilename, null);
            svgImage.Image = svgDoc.Draw();
        }

        private void svgImage_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                //this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.TopMost = false;
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void svgImage_Click(object sender, EventArgs e)
        {
            RenderSvg();
        }
    }
}
