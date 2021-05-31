
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
            this.center_info = new System.Windows.Forms.TextBox();
            this.open_map = new System.Windows.Forms.Button();
            this.return_menu = new System.Windows.Forms.Button();
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
            this.sido_combobox.Location = new System.Drawing.Point(373, 97);
            this.sido_combobox.Name = "sido_combobox";
            this.sido_combobox.Size = new System.Drawing.Size(160, 23);
            this.sido_combobox.TabIndex = 0;
            this.sido_combobox.SelectedIndexChanged += new System.EventHandler(this.sido_combobox_SelectedIndexChanged);
            // 
            // sigungu_combobox
            // 
            this.sigungu_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sigungu_combobox.Enabled = false;
            this.sigungu_combobox.FormattingEnabled = true;
            this.sigungu_combobox.Location = new System.Drawing.Point(627, 97);
            this.sigungu_combobox.Name = "sigungu_combobox";
            this.sigungu_combobox.Size = new System.Drawing.Size(150, 23);
            this.sigungu_combobox.TabIndex = 1;
            this.sigungu_combobox.SelectedIndexChanged += new System.EventHandler(this.sigungu_combobox_SelectedIndexChanged);
            // 
            // center_listbox
            // 
            this.center_listbox.FormattingEnabled = true;
            this.center_listbox.ItemHeight = 15;
            this.center_listbox.Location = new System.Drawing.Point(23, 93);
            this.center_listbox.Name = "center_listbox";
            this.center_listbox.Size = new System.Drawing.Size(268, 334);
            this.center_listbox.TabIndex = 2;
            this.center_listbox.SelectedIndexChanged += new System.EventHandler(this.center_listbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "시/도 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "시/군/구 : ";
            // 
            // center_info
            // 
            this.center_info.Location = new System.Drawing.Point(312, 126);
            this.center_info.Multiline = true;
            this.center_info.Name = "center_info";
            this.center_info.ReadOnly = true;
            this.center_info.Size = new System.Drawing.Size(465, 260);
            this.center_info.TabIndex = 5;
            // 
            // open_map
            // 
            this.open_map.Location = new System.Drawing.Point(312, 392);
            this.open_map.Name = "open_map";
            this.open_map.Size = new System.Drawing.Size(107, 35);
            this.open_map.TabIndex = 6;
            this.open_map.Text = "지도 보기";
            this.open_map.UseVisualStyleBackColor = true;
            this.open_map.Click += new System.EventHandler(this.open_map_Click);
            // 
            // return_menu
            // 
            this.return_menu.Location = new System.Drawing.Point(680, 392);
            this.return_menu.Name = "return_menu";
            this.return_menu.Size = new System.Drawing.Size(97, 35);
            this.return_menu.TabIndex = 7;
            this.return_menu.Text = "돌아가기";
            this.return_menu.UseVisualStyleBackColor = true;
            // 
            // vaccine_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.return_menu);
            this.Controls.Add(this.open_map);
            this.Controls.Add(this.center_info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.center_listbox);
            this.Controls.Add(this.sigungu_combobox);
            this.Controls.Add(this.sido_combobox);
            this.Name = "vaccine_search";
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
        private System.Windows.Forms.TextBox center_info;
        private System.Windows.Forms.Button open_map;
        private System.Windows.Forms.Button return_menu;
    }
}