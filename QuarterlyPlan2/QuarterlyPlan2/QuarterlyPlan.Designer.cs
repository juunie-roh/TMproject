
namespace QuarterlyPlan2
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderbtn = new System.Windows.Forms.Button();
            this.planbtn = new System.Windows.Forms.Button();
            this.analbtn = new System.Windows.Forms.Button();
            this.videobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderbtn
            // 
            this.orderbtn.BackColor = System.Drawing.Color.LightBlue;
            this.orderbtn.FlatAppearance.BorderSize = 0;
            this.orderbtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderbtn.Location = new System.Drawing.Point(35, 95);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(322, 57);
            this.orderbtn.TabIndex = 0;
            this.orderbtn.Text = "분기별 접종 순서";
            this.orderbtn.UseVisualStyleBackColor = false;
            this.orderbtn.Click += new System.EventHandler(this.orderbtn_Click);
            // 
            // planbtn
            // 
            this.planbtn.BackColor = System.Drawing.Color.LightBlue;
            this.planbtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.planbtn.Location = new System.Drawing.Point(35, 164);
            this.planbtn.Name = "planbtn";
            this.planbtn.Size = new System.Drawing.Size(322, 57);
            this.planbtn.TabIndex = 1;
            this.planbtn.Text = "5월 이후 추진 계획";
            this.planbtn.UseVisualStyleBackColor = false;
            this.planbtn.Click += new System.EventHandler(this.planbtn_Click);
            // 
            // analbtn
            // 
            this.analbtn.BackColor = System.Drawing.Color.LightBlue;
            this.analbtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.analbtn.Location = new System.Drawing.Point(35, 231);
            this.analbtn.Name = "analbtn";
            this.analbtn.Size = new System.Drawing.Size(322, 57);
            this.analbtn.TabIndex = 2;
            this.analbtn.Text = "1분기 예방접종 분석";
            this.analbtn.UseVisualStyleBackColor = false;
            this.analbtn.Click += new System.EventHandler(this.analbtn_Click);
            // 
            // videobtn
            // 
            this.videobtn.BackColor = System.Drawing.Color.LightBlue;
            this.videobtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.videobtn.Location = new System.Drawing.Point(35, 299);
            this.videobtn.Name = "videobtn";
            this.videobtn.Size = new System.Drawing.Size(322, 57);
            this.videobtn.TabIndex = 3;
            this.videobtn.Text = "예방접종 참조영상";
            this.videobtn.UseVisualStyleBackColor = false;
            this.videobtn.Click += new System.EventHandler(this.videobtn_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 397);
            this.Controls.Add(this.videobtn);
            this.Controls.Add(this.analbtn);
            this.Controls.Add(this.planbtn);
            this.Controls.Add(this.orderbtn);
            this.Name = "main";
            this.Text = "QurterlyPlan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button orderbtn;
        private System.Windows.Forms.Button planbtn;
        private System.Windows.Forms.Button analbtn;
        private System.Windows.Forms.Button videobtn;
    }
}

