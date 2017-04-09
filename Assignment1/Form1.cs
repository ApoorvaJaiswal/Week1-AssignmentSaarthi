using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;

namespace Assignment1
{
	public partial class Form1 : Form
	{
        Bitmap orgImg, newImg;
		public Form1()
		{
			InitializeComponent();
		}

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            var result = od.ShowDialog();
            if(result == DialogResult.OK)
            {
                orgImg = new Bitmap(od.FileName);
                pictureBox1.Image = orgImg;

            }
                
        }

        private void blackNWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Threshold gb = new Threshold();
            newImg = gb.Apply(newImg);
            pictureBox3.Image = newImg;
        }

        private void greyScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayscaleBT709 gb = new GrayscaleBT709();
            newImg = gb.Apply(orgImg);
            pictureBox2.Image = newImg;
        }

        private void edgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CannyEdgeDetector gb = new CannyEdgeDetector();
            newImg = gb.Apply(newImg);
            pictureBox4.Image = newImg;
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GaussianBlur gb = new GaussianBlur();
            newImg = gb.Apply(orgImg);
            pictureBox6.Image = newImg;
        }

        private void hueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HueModifier gb = new HueModifier();
            newImg = gb.Apply(orgImg);
            pictureBox5.Image = newImg;
        }
    }
}
