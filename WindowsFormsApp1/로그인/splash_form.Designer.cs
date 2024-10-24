namespace WindowsFormsApp1
{
    partial class splash_form
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
            this.illust = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.adminMode = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // illust
            // 
            this.illust.AutoSize = true;
            this.illust.Font = new System.Drawing.Font("나눔스퀘어 네오 Heavy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illust.Location = new System.Drawing.Point(266, 37);
            this.illust.Name = "illust";
            this.illust.Size = new System.Drawing.Size(268, 44);
            this.illust.TabIndex = 0;
            this.illust.Text = " 일러스트 거래";
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.signUp.FlatAppearance.BorderSize = 0;
            this.signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUp.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.signUp.Location = new System.Drawing.Point(557, 185);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(188, 81);
            this.signUp.TabIndex = 8;
            this.signUp.Text = "회원가입";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login.Location = new System.Drawing.Point(305, 185);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(188, 81);
            this.login.TabIndex = 7;
            this.login.Text = "로그인";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // adminMode
            // 
            this.adminMode.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.adminMode.FlatAppearance.BorderSize = 0;
            this.adminMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminMode.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.adminMode.Location = new System.Drawing.Point(53, 185);
            this.adminMode.Name = "adminMode";
            this.adminMode.Size = new System.Drawing.Size(188, 81);
            this.adminMode.TabIndex = 9;
            this.adminMode.Text = "관리 모드";
            this.adminMode.UseVisualStyleBackColor = false;
            this.adminMode.Click += new System.EventHandler(this.adminMode_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancel_btn.Location = new System.Drawing.Point(645, 21);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(131, 32);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Text = "프로그램 종료";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // splash_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.adminMode);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.login);
            this.Controls.Add(this.illust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "splash_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "일러스트 거래";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label illust;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button adminMode;
        private System.Windows.Forms.Button cancel_btn;
    }
}

