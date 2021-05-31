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

namespace COVID_19_Data
{
    public partial class Form1 : MetroForm
    {

        public Form1()
        {
            InitializeComponent();
            //AutoScrollMinSize = new Size(int.MaxValue, int.MaxValue); //스크롤제거
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Popup;
            button1.FlatAppearance.BorderSize = 0;
            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Popup;
            button2.FlatAppearance.BorderSize = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 객체 생성
            Form2 fr2 = new Form2();
            //새로운 폼 보여주기
            fr2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form3 객체 생성
            Form3 fr3 = new Form3();
            //새로운 폼 보여주기
            fr3.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
