
namespace map_api
{
    partial class vaccine_search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sido_combobox = new System.Windows.Forms.ComboBox();
            this.sigungu_combobox = new System.Windows.Forms.ComboBox();
            this.center_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.center_name = new System.Windows.Forms.TextBox();
            this.open_map = new System.Windows.Forms.Button();
            this.return_menu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.center_addr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.center_zip = new System.Windows.Forms.TextBox();
            this.center_type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.center_org = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sido_combobox
            // 
            this.sido_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sido_combobox.FormattingEnabled = true;
            this.sido_combobox.Items.AddRange(new object[] {
            "서울특별시",
            "부산광역시",
            "대구광역시",
            "인천광역시",
            "광주광역시",
            "대전광역시",
            "울산광역시",
            "세종특별자치시",
            "경기도",
            "강원도",
            "충청북도",
            "충청남도",
            "전라북도",
            "전라남도",
            "경상북도",
            "경상남도",
            "제주특별자치도"});
            this.sido_combobox.Location = new System.Drawing.Point(337, 71);
            this.sido_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sido_combobox.Name = "sido_combobox";
            this.sido_combobox.Size = new System.Drawing.Size(129, 20);
            this.sido_combobox.TabIndex = 0;
            this.sido_combobox.SelectedIndexChanged += new System.EventHandler(this.sido_combobox_SelectedIndexChanged);
            // 
            // sigungu_combobox
            // 
            this.sigungu_combobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sigungu_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sigungu_combobox.Enabled = false;
            this.sigungu_combobox.FormattingEnabled = true;
            this.sigungu_combobox.Location = new System.Drawing.Point(543, 71);
            this.sigungu_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sigungu_combobox.Name = "sigungu_combobox";
            this.sigungu_combobox.Size = new System.Drawing.Size(136, 20);
            this.sigungu_combobox.TabIndex = 1;
            this.sigungu_combobox.SelectedIndexChanged += new System.EventHandler(this.sigungu_combobox_SelectedIndexChanged);
            // 
            // center_listbox
            // 
            this.center_listbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.center_listbox.FormattingEnabled = true;
            this.center_listbox.ItemHeight = 12;
            this.center_listbox.Location = new System.Drawing.Point(23, 71);
            this.center_listbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.center_listbox.Name = "center_listbox";
            this.center_listbox.Size = new System.Drawing.Size(233, 244);
            this.center_listbox.TabIndex = 2;
            this.center_listbox.SelectedIndexChanged += new System.EventHandler(this.center_listbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "시/도 : ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "시/군/구 : ";
            // 
            // center_name
            // 
            this.center_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.center_name.Location = new System.Drawing.Point(337, 95);
            this.center_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.center_name.Name = "center_name";
            this.center_name.ReadOnly = true;
            this.center_name.Size = new System.Drawing.Size(342, 21);
            this.center_name.TabIndex = 5;
            // 
            // open_map
            // 
            this.open_map.Location = new System.Drawing.Point(273, 314);
            this.open_map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.open_map.Name = "open_map";
            this.open_map.Size = new System.Drawing.Size(94, 28);
            this.open_map.TabIndex = 6;
            this.open_map.Text = "지도 보기";
            this.open_map.UseVisualStyleBackColor = true;
            this.open_map.Click += new System.EventHandler(this.open_map_Click);
            // 
            // return_menu
            // 
            this.return_menu.Location = new System.Drawing.Point(595, 314);
            this.return_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.return_menu.Name = "return_menu";
            this.return_menu.Size = new System.Drawing.Size(85, 28);
            this.return_menu.TabIndex = 7;
            this.return_menu.Text = "돌아가기";
            this.return_menu.UseVisualStyleBackColor = true;
            this.return_menu.Click += new System.EventHandler(this.return_menu_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "센터 이름 : ";
            // 
            // center_addr
            // 
            this.center_addr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.center_addr.Location = new System.Drawing.Point(337, 120);
            this.center_addr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.center_addr.Name = "center_addr";
            this.center_addr.ReadOnly = true;
            this.center_addr.Size = new System.Drawing.Size(342, 21);
            this.center_addr.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "센터 주소 : ";
            // 
            // center_zip
            // 
            this.center_zip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.center_zip.Location = new System.Drawing.Point(337, 145);
            this.center_zip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.center_zip.Name = "center_zip";
            this.center_zip.ReadOnly = true;
            this.center_zip.Size = new System.Drawing.Size(129, 21);
            this.center_zip.TabIndex = 11;
            // 
            // center_type
            // 
            this.center_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.center_type.Location = new System.Drawing.Point(543, 145);
            this.center_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.center_type.Name = "center_type";
            this.center_type.ReadOnly = true;
            this.center_type.Size = new System.Drawing.Size(136, 21);
            this.center_type.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "우편 번호 : ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "센터 유형 : ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "운영 기관 :";
            // 
            // center_org
            // 
            this.center_org.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.center_org.Location = new System.Drawing.Point(337, 170);
            this.center_org.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.center_org.Name = "center_org";
            this.center_org.ReadOnly = true;
            this.center_org.Size = new System.Drawing.Size(342, 21);
            this.center_org.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "해당 지역 센터 수 :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "개";
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(136, 317);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(11, 12);
            this.result.TabIndex = 19;
            this.result.Text = "0";
            // 
            // vaccine_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.center_org);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.center_type);
            this.Controls.Add(this.center_zip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.center_addr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.return_menu);
            this.Controls.Add(this.open_map);
            this.Controls.Add(this.center_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.center_listbox);
            this.Controls.Add(this.sigungu_combobox);
            this.Controls.Add(this.sido_combobox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "vaccine_search";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.Text = "백신 예방 접종 센터";
            this.Load += new System.EventHandler(this.vaccine_search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sido_combobox;
        private System.Windows.Forms.ComboBox sigungu_combobox;
        private System.Windows.Forms.ListBox center_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox center_name;
        private System.Windows.Forms.Button open_map;
        private System.Windows.Forms.Button return_menu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox center_addr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox center_zip;
        private System.Windows.Forms.TextBox center_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox center_org;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label result;
    }
}