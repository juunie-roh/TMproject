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
    public partial class Vedio : MetroForm
    {
        public Vedio()
        {
            InitializeComponent();
        }

        private void Vedio_Load(object sender, EventArgs e)
        {
            try
            {
                string url = "http://www.kdca.go.kr/gallery.es?mid=a20503030300&bid=0004&b_list=9&act=view&list_no=144956&nPage=1&vlist_no_npage=2&keyField=&keyWord=&orderby=";
                //string url = "file:///C:/Users/%EA%B9%80%EC%84%B8%EB%AF%BC/source/repos/QuarterlyPlan2/QuarterlyPlan2/vedio.html";
                this.webBrowser1.Navigate(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
