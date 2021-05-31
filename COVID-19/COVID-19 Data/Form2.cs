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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //리스트 박스 초기화 및 아이템 생성
            listBox1.Items.Clear();
            listBox1.Items.Add("비인두도말 pcr");
            listBox1.Items.Add("타액 pcr");
            listBox1.Items.Add("신속 항원 검사");
            listBox1.Items.Add("자가 진단 키트");
            //가장 첫항목이 선택되게 나오게 하기

            listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0://인데스에 따른 변화 감지
                    textBox1.Text = "비인두도말 PCR검사는 표준검사법으로 주로 시행하는 검사이다.\r\n\r\n먼저 검사소에 방문해 문진표를 작성한다. 그 후에 검체 채취소에서 코와 목에 긴 면봉을 넣어 분비물을 채취한다.\r\n\r\n검사 결과는 빠르면 당일 밤, 보통은 다음 날 결과가 나온다.";//텍스트 박스 내용 설정
                    pictureBox1.Load("pcr1.jpg");//이미지 설정
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 1://인데스에 따른 변화 감지
                    textBox1.Text = "타액 PCR검사는 기존 PCR검사에서 비인두 검체 대신 침을 이용하는 점만 다르다.\r\n\r\n채취에 드는 노력과 시간이 줄어드는 장점이 있지만, 비인두도말 PCR검사보다 민감도가 떨어진다.\r\n\r\n보통 24시간 이내에 검사 결과가 나온다.";//텍스트 박스 내용 설정
                    pictureBox1.Load("pcr2.png");//이미지 설정
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 2://인데스에 따른 변화 감지
                    textBox1.Text = "신속 항원 검사는 항원 진단 키트를 이용한다.\r\n\r\n검체 채취는 검사소에서 비인두도말 PCR방법과 동일한 방법으로 채취한다.\r\n\r\n검사결과는 15~30분 이내에 결과창에 선 형식으로 나타나며, C와T줄이 모두 표시되면 양성이다. 정확성이 떨어지는 편이라 양성이 나오면 비인두도말 PCR 검사를 다시 시행해야한다. ";//텍스트 박스 내용 설정
                    pictureBox1.Load("test3.jpg");//이미지 설정
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 3://인데스에 따른 변화 감지
                    textBox1.Text = "자가 진단 키트는 약국과 온라인 쇼핑몰에서 판매한다.\r\n\r\n면봉을 콧속에 넣는 방식이지만 비인두도말 방식보다는 좀 더 앞쪽에서 검체를 채취한다.\r\n\r\n검사결과까지는 약 15분 정도가 소요되며, 정확도가 떨어져 코로나 방역체계를 혼란을 초래할 수도 있다는 전문가들의 우려가 있다.";//텍스트 박스 내용 설정
                    pictureBox1.Load("test4.jpg");//이미지 설정
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }
    }
}
