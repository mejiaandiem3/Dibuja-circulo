using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23Febrero21
{
    public partial class Form1 : Form
    {
        private Graphics papel;

        private void SetParameters() 
        {
            trcBrVertical.Minimum = 0;
            trcBrVertical.Maximum = pictureBox1.Height;

            trcBrHorizontal.Minimum = 0;
            trcBrHorizontal.Maximum = pictureBox1.Width;

            trcBrVerticalY.Minimum = 0;
            trcBrVerticalY.Maximum = pictureBox1.Height;

            trcBrHorizontalX.Minimum = 0;
            trcBrHorizontalX.Maximum = pictureBox1.Width;


            lblTrackVertical.Text = Convert.ToString(trcBrVertical.Value);
            lblTrackHorizontal.Text = Convert.ToString(trcBrHorizontal.Value);

        }

        public Form1()
        {
            InitializeComponent();
            papel = pictureBox1.CreateGraphics();
            SetParameters();
            
            
        }

        private void trcBrHorizontal_Scroll(object sender, EventArgs e)
        {
            lblTrackHorizontal.Text = Convert.ToString(trcBrHorizontal.Value);
            SolidBrush brocha = new SolidBrush(Color.Aquamarine);
            papel.Clear(Color.White);
            papel.FillEllipse(brocha, 0, 0, trcBrHorizontal.Value, trcBrVertical.Value);
        }

        private void trcBrVertical_Scroll(object sender, EventArgs e)
        {
            lblTrackVertical.Text = Convert.ToString(trcBrVertical.Value);
            SolidBrush brocha = new SolidBrush(Color.Aquamarine);
            papel.Clear(Color.White);
            papel.FillEllipse(brocha,0,0,trcBrHorizontal.Value, trcBrVertical.Value);
        }

        private void trcBrVerticalY_Scroll(object sender, EventArgs e)
        {
            lblTrackVerticalY.Text = Convert.ToString(trcBrVerticalY.Value);
            SolidBrush brocha = new SolidBrush(Color.Aquamarine);
            papel.Clear(Color.White);
            papel.FillEllipse(brocha, trcBrHorizontalX.Value, trcBrVerticalY.Value, trcBrHorizontal.Value, trcBrVertical.Value);
        }

        private void trcBrHorizontalX_Scroll(object sender, EventArgs e)
        {
            lblTrackHorizontalX.Text = Convert.ToString(trcBrHorizontalX.Value);
            SolidBrush brocha = new SolidBrush(Color.Aquamarine);
            papel.Clear(Color.White);
            papel.FillEllipse(brocha, trcBrHorizontalX.Value, trcBrVerticalY.Value, trcBrHorizontal.Value, trcBrVertical.Value);
        }
    }
}
