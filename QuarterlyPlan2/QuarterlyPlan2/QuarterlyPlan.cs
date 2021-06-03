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
    public partial class main : MetroForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            Order f1 = new Order();
            DialogResult dResult = f1.ShowDialog();
        }

        private void planbtn_Click(object sender, EventArgs e)
        {
            Plan f2 = new Plan();
            DialogResult dResult = f2.ShowDialog();
        }

        private void analbtn_Click(object sender, EventArgs e)
        {
            Analysis f3 = new Analysis();
            DialogResult dResult = f3.ShowDialog();
        }

        private void videobtn_Click(object sender, EventArgs e)
        {
            Vedio f4 = new Vedio();
            DialogResult dResult = f4.ShowDialog();
        }
    }
}
