using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace map_api
{

    public partial class vaccine_map : Form
    {
        private CenterInfo centerInfo;
        public CenterInfo GetCenterInfo
        {
            get { return this.centerInfo; }
            set { this.centerInfo = value; }
        }
        public vaccine_map()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centerInfo = GetCenterInfo;
            try
            {
                string url = "https://map.kakao.com/link/map/"+ centerInfo.centerName + "," + centerInfo.lat + "," + centerInfo.lng;
                this.webBrowser1.Navigate(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
