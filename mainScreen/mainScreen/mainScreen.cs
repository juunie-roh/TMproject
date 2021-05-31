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

namespace mainScreen
{

    public partial class mainScreen : MetroForm
    {
        public mainScreen()
        {
            InitializeComponent();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            panel7.Width += 3; //길어지는 panel
            if (panel7.Width >= 440)
            {
                timer1.Stop();
                this.Size = new Size(390, 500);
                panel6.Visible = false; //라인 panel
                panel7.Visible = false; // 길어지는 panel
            }
        }
    }
}