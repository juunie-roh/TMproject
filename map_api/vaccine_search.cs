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
using System.Collections;

namespace map_api
{
    public partial class vaccine_search : MetroForm
    {
        public ArrayList list;
        public CenterInfo centerInfo;
        public vaccine_search()
        {
            InitializeComponent();

            center_listbox.Items.Clear();
            center_info.Clear();
            center_listbox.Items.Add("시/도 를 선택해주세요.");
        }

        private void vaccine_search_Load(object sender, EventArgs e)
        {
            // 폼 로드 시 예방 접종 센터 리스트 불러오기
            list = new ArrayList();
            Get_vaccine_info.get_vaccin_list();
            list = Get_vaccine_info.arrayList;
        }

        private void sido_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sigungu_combobox.Items.Clear();
            sigungu_combobox.Enabled = true;
            center_listbox.Items.Clear();
            foreach (CenterInfo ci in list) // listbox에 아이템 추가, 시/군/구 아이템 추가
            {
                if (ci.sido == sido_combobox.SelectedItem.ToString())
                {
                    center_listbox.Items.Add(ci.centerName + '(' + ci.zipCode + ')');
                    if (sigungu_combobox.Items.Contains(ci.sigungu)) continue; // 시군구 중복 있으면 스킵
                    else sigungu_combobox.Items.Add(ci.sigungu);
                }
            }
        }

        private void sigungu_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            center_listbox.Items.Clear();
            foreach (CenterInfo ci in list) // listbox 아이템 검색 범위 축소.
            {
                if (ci.sido == sido_combobox.SelectedItem.ToString() && ci.sigungu == sigungu_combobox.SelectedItem.ToString())
                    center_listbox.Items.Add(ci.centerName + '(' + ci.zipCode + ')');
            }
            if (center_listbox.Items.Count == 0)
                center_listbox.Items.Add("검색 결과가 없습니다.");
            // list에 있는 시군구만 item으로 추가하기 때문에 검색 결과가 없는 경우는 없음.
        }

        private void center_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            center_info.Clear();
            foreach (CenterInfo ci in list)
            {
                if (center_listbox.SelectedItem.ToString() == ci.centerName + '(' + ci.zipCode + ')')
                {
                    center_info.AppendText("센터 이름: " + ci.centerName + "\r\n");
                    center_info.AppendText("주소: " + ci.address + "\r\n");
                    center_info.AppendText("우편 번호: " + ci.zipCode + "\t센터 유형: " + ci.centerType + "\r\n");
                    center_info.AppendText("운영 기관: " + ci.org + "\r\n\r\n");
                    centerInfo = ci;
                }
            }
        }

        private void open_map_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["vaccine_map"];
            if (form != null)
                form.Close();
            vaccine_map map = new vaccine_map();
            map.Owner = this;
            map.GetCenterInfo = centerInfo;
            map.ShowDialog();
            map.BringToFront();
        }
    }
}
