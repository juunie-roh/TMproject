using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            webBrowser1.Visible = true;
            webBrowser2.Visible = false;
            webBrowser3.Visible = false;
            webBrowser4.Visible = false;
            webBrowser5.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            webBrowser1.Visible = false;
            webBrowser2.Visible = true;
            webBrowser3.Visible = false;
            webBrowser4.Visible = false;
            webBrowser5.Visible = false;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.Window.ScrollTo(0, 550);
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser2.Document.Window.ScrollTo(50, 850);
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser3.Document.Window.ScrollTo(0, 1225);
        }

        private void webBrowser4_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser4.Document.Window.ScrollTo(0, 700);
        }

        private void webBrowser5_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser5.Document.Window.ScrollTo(0, 1080);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            webBrowser1.Visible = false;
            webBrowser2.Visible = false;
            webBrowser3.Visible = true;
            webBrowser4.Visible = false;
            webBrowser5.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            webBrowser1.Visible = false;
            webBrowser2.Visible = false;
            webBrowser3.Visible = false;
            webBrowser4.Visible = true;
            webBrowser5.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            webBrowser1.Visible = false;
            webBrowser2.Visible = false;
            webBrowser3.Visible = false;
            webBrowser4.Visible = false;
            webBrowser5.Visible = true;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Process.Start("http://ncov.mohw.go.kr/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.mohw.go.kr/react/index.jsp");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://search.naver.com/search.naver?where=nexearch&query=%EC%BD%94%EB%A1%9C%EB%82%9819+%EC%84%A0%EB%B3%84%EC%A7%84%EB%A3%8C%EC%86%8C&sm=tab_etc");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://search.naver.com/search.naver?where=nexearch&query=%EC%BD%94%EB%A1%9C%EB%82%9819%EC%98%88%EB%B0%A9%EC%A0%91%EC%A2%85%EC%84%BC%ED%84%B0&sm=tab_etc");
        }
    }
}
