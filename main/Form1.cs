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
using System.Drawing.Drawing2D;

namespace main
{

    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            panel5.Width += 3; //길어지는 panel
            if (panel5.Width >= 430)
            {
                timer1.Stop(); 
                this.Size = new Size(430,550);
                panel4.Visible = false; //라인 panel
                panel5.Visible = false; // 길어지는 panel
            }
        }
    }
}
