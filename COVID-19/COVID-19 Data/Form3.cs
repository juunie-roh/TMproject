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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //하이퍼링크 안보이게 설정
            linkLabel1.Visible = false;
            //리스트 박스 초기화 및 아이템 생성
            listBox1.Items.Clear();
            listBox1.Items.Add("백신 접종 설명");
            listBox1.Items.Add("인터넷 사전예약 설명");
            listBox1.Items.Add("백신 접종 현황");
            listBox1.Items.Add("백신 종류");
            //listBox1.Items.Add("백신 접종 계획");
            //가장 첫항목이 선택되게 나오게 하기
            listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0://인데스에 따른 변화 감지
                    textBox1.Text = "백신 접종 설명 내용";//텍스트 박스 내용 설정
                    textBox1.Visible = true;//텍스트 박스 드러나게
                    pictureBox1.Visible = true;//이미지 박스 드러나게
                    //pictureBox1.Load("image5.png");//이미지 설정         
                    linkLabel1.Visible = false;//하이퍼링크 안보이게 설정
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 1://인데스에 따른 변화 감지
                    textBox1.Text = "인터넷 사전예약 설명 내용";//텍스트 박스 내용 설정
                    textBox1.Visible = true;//텍스트 박스 드러나게
                    pictureBox1.Visible = true;//이미지 박스 드러나게
                    //pictureBox1.Load("image6.png");//이미지 설정
                    linkLabel1.Visible = false;//하이퍼링크 안보이게 설정
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                    
                case 2://인덱스가 3번 일때 추가 이벤트 설정
                    textBox1.Visible = false;//텍스트 박스 사라지게
                    pictureBox1.Visible = false;//이미지 박스 사라지게
                    linkLabel1.Visible = true;//하이퍼링크 보이게 설정
                    linkLabel1.Text = "현황을 보려면 클릭하세요!";//하이퍼 링크 텍스트 설정
                    break;

                case 3://인데스에 따른 변화 감지
                    textBox1.Text = "백신 종류 내용";//텍스트 박스 내용 설정
                    textBox1.Visible = true;//텍스트 박스 드러나게
                    pictureBox1.Visible = true;//이미지 박스 드러나게
                    //pictureBox1.Load("image7.png");//이미지 설정
                    linkLabel1.Visible = false;//하이퍼링크 안보이게 설정
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                /*case 4://인데스에 따른 변화 감지
                    textBox1.Text = "백신 접종 계획 내용";//텍스트 박스 내용 설정
                    textBox1.Visible = true;//텍스트 박스 드러나게
                    pictureBox1.Visible = true;//이미지 박스 드러나게
                    pictureBox1.Load("image8.png");//이미지 설정
                    linkLabel1.Visible = false;//하이퍼링크 안보이게 설정
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;*/
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //네이버창 띄우기
            System.Diagnostics.Process.Start("https://ncv.kdca.go.kr/mainStatus.es?mid=a11702000000");
        }
    }
}
