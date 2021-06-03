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
    public partial class Order : MetroForm
    {
        public Order()
        {
            InitializeComponent();
        }
        private void Order_Load(object sender, EventArgs e)
        {
            textBox1.Text = "- 요양병원ㆍ요양시설입원ㆍ입소자, 종사자";
            StringBuilder sb=new StringBuilder();
            sb.AppendLine("- 코로나19 환자를 치료하는 기관 종사자");
            //sb.AppendLine("");
            sb.AppendLine("- 고위험 의료기관 종사자");
            //sb.AppendLine("");
            sb.AppendLine("- 1차 대응요원(역학조사ㆍ구급대 등");
            textBox2.Text = sb.ToString();
            textBox3.Text = "- 정신요양ㆍ재활시설등 입소자ㆍ종사자";


            StringBuilder sb2 = new StringBuilder();
            sb2.AppendLine("- 노인재가복지시설 이용자ㆍ종사자");
            //sb.AppendLine("");
            sb2.AppendLine("- 65세 이상(고령자부터 순차 접종)");
            textBox4.Text = sb2.ToString();
            textBox5.Text = "- 의료기관 및 약국 종사자(보건 의료인)";
            textBox6.Text = "- 장애인ㆍ노숙인 등 시설 입소자ㆍ종사자";

            StringBuilder sb3 = new StringBuilder();
            sb3.AppendLine("- 성인 만성질환자");
            //sb.AppendLine("");
            sb3.AppendLine("- 성인 50~64세");
            textBox7.Text = sb3.ToString();
            textBox8.Text = "- 군인,경찰,소방 및 사회 기반시설 종사자";
            StringBuilder sb4 = new StringBuilder();
            sb4.AppendLine("- 소아,청소년 교육,보육시설 종사자");
            //sb.AppendLine("");
            sb4.AppendLine("- 성인 19~49세");
            textBox9.Text = sb4.ToString();

            textBox10.Text="- 2차 접종자, 미접종자 또는 재접종자 (항체유지기간 고려)";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.seoul.go.kr/coronaV/coronaStatus.do?menu_code=41");
        }
    }
}
