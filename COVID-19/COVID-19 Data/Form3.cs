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
    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();
            //하이퍼링크 안보이게 설정
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            //리스트 박스 초기화 및 아이템 생성
            listBox1.Items.Clear();
            listBox1.Items.Add("백신 접종 설명");
            listBox1.Items.Add("접종 사전예약 설명");
            listBox1.Items.Add("시도별 백신 접종 현황");
            listBox1.Items.Add("백신 종류");
            //listBox1.Items.Add("백신 접종 계획");
            //가장 첫항목이 선택되게 나오게 하기
            listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0://인덱스에 따른 변화 감지
                    textBox1.Text = "백신 접종은 전 국민을 대상으로 접종할 예정이지만, 접종 순서 및 공급 상황등에 따라 접종 우선순서 및 일정은 상시 변경될 수 있습니다.\r\n\r\n(백신접종 분기별 계획 메뉴를 참고)";//텍스트 박스 내용 설정
                    textBox1.Visible = true;//텍스트 박스 드러나게
                    pictureBox1.Visible = true;//이미지 박스 드러나게
                    pictureBox1.Load("vaccine.jpg");//이미지 설정         
                    linkLabel1.Visible = false;//하이퍼링크 안보이게 설정
                    linkLabel2.Visible = false;

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 1://인덱스에 따른 변화 감지
                    textBox1.Text = "\r\n인터넷으로 사전예약하는 경우에는 위의 링크를 클릭해서 진행하면됩니다. 본인이 예약이 어려운 경우에는 대리인분께서 대리예약도 진행할 수 있습니다.\r\n\r\n온라인 예약이 어려우면 1339로 전화하여 예약하거나, 동주민센터에 방문하여 온라인 본인 예약도움을 받을 수 있습니다.\r\n(신분증, 본인명의 휴대전화 지참)";//텍스트 박스 내용 설정
                    textBox1.Visible = true;//텍스트 박스 드러나게
                    pictureBox1.Visible = true;//이미지 박스 드러나게
                    pictureBox1.Load("vaccine.jpg");//이미지 설정         

                    linkLabel1.Visible = false;//하이퍼링크 안보이게 설정
                    linkLabel2.Visible = true;
                    linkLabel2.Text = "사전예약 사이트 방문하기 링크";//하이퍼 링크 텍스트 설정

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                    
                case 2://인덱스가 3번 일때 추가 이벤트 설정
                    textBox1.Visible = false;//텍스트 박스 사라지게

                    pictureBox1.Visible = true;//이미지 박스 사라지게
                    pictureBox1.Load("vaccine.jpg");//이미지 설정         

                    linkLabel1.Visible = true;//하이퍼링크 보이게 설정
                    linkLabel2.Visible = false;
                    linkLabel1.Text = "백신 접종 현황을 보려면 링크를 클릭하세요!";//하이퍼 링크 텍스트 설정
                    break;

                case 3://인덱스에 따른 변화 감지
                    textBox1.Text = "현재 국내에는 화이자와 아스트라 제네카 백신이 들어와있습니다. 그리고 모더나 백신과 얀센 백신은 아직 국내허가 전인 상황입니다.\r\n\r\n화이자 백신은 초저온 보관을 해야하는 주의사항에 유의해야합니다.";
                    //텍스트 박스 내용 설정
                    textBox1.Visible = true;//텍스트 박스 드러나게
                    pictureBox1.Visible = true;//이미지 박스 드러나게
                    pictureBox1.Load("vaccine.jpg");//이미지 설정         

                    linkLabel1.Visible = false;//하이퍼링크 안보이게 설정
                    linkLabel2.Visible = false;
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
            //접종현황링크 띄우기
            System.Diagnostics.Process.Start("https://ncv.kdca.go.kr/mainStatus.es?mid=a11702000000");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("https://ncvr.kdca.go.kr/cobk/index.html");
        }
    }
}
