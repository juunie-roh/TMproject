using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarterlyPlan2
{
    public partial class Analysis : MetroForm
    {
        public Analysis()
        {
            InitializeComponent();
        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            pictureBox1.Load(@"C:\Users\김세민\source\repos\QuarterlyPlan2\QuarterlyPlan2\Analysis1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"C:\Users\김세민\source\repos\QuarterlyPlan2\QuarterlyPlan2\Analysis1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"C:\Users\김세민\source\repos\QuarterlyPlan2\QuarterlyPlan2\Analysis2.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"C:\Users\김세민\source\repos\QuarterlyPlan2\QuarterlyPlan2\Analysis3.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"C:\Users\김세민\source\repos\QuarterlyPlan2\QuarterlyPlan2\Analysis4.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"C:\Users\김세민\source\repos\QuarterlyPlan2\QuarterlyPlan2\Analysis5.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
