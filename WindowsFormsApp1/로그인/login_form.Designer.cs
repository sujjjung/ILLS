namespace WindowsFormsApp1
{
    partial class login_form
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
            this.login_btn = new System.Windows.Forms.Button();
            this.pw_label = new System.Windows.Forms.Label();
            this.pw_textBox = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.visible_pw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login_btn.Location = new System.Drawing.Point(37, 228);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(134, 46);
            this.login_btn.TabIndex = 35;
            this.login_btn.Text = "로그인하기";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw_label.Location = new System.Drawing.Point(53, 154);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(82, 21);
            this.pw_label.TabIndex = 34;
            this.pw_label.Text = "비밀번호";
            // 
            // pw_textBox
            // 
            this.pw_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw_textBox.Location = new System.Drawing.Point(171, 147);
            this.pw_textBox.Name = "pw_textBox";
            this.pw_textBox.PasswordChar = '*';
            this.pw_textBox.Size = new System.Drawing.Size(153, 31);
            this.pw_textBox.TabIndex = 33;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_label.Location = new System.Drawing.Point(71, 97);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(64, 21);
            this.id_label.TabIndex = 32;
            this.id_label.Text = "아이디";
            // 
            // id_textBox
            // 
            this.id_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_textBox.Location = new System.Drawing.Point(171, 90);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(153, 31);
            this.id_textBox.TabIndex = 31;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login_label.Location = new System.Drawing.Point(32, 36);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(81, 26);
            this.login_label.TabIndex = 30;
            this.login_label.Text = "로그인";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancel_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancel_btn.Location = new System.Drawing.Point(190, 228);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(134, 46);
            this.cancel_btn.TabIndex = 36;
            this.cancel_btn.Text = "돌아가기";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // visible_pw
            // 
            this.visible_pw.AutoSize = true;
            this.visible_pw.Font = new System.Drawing.Font("나눔스퀘어 네오 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visible_pw.Location = new System.Drawing.Point(171, 187);
            this.visible_pw.Name = "visible_pw";
            this.visible_pw.Size = new System.Drawing.Size(89, 18);
            this.visible_pw.TabIndex = 44;
            this.visible_pw.Text = "암호 보이기";
            this.visible_pw.UseVisualStyleBackColor = true;
            this.visible_pw.CheckedChanged += new System.EventHandler(this.visible_pw_CheckedChanged);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(380, 297);
            this.Controls.Add(this.visible_pw);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pw_label);
            this.Controls.Add(this.pw_textBox);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.login_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label pw_label;
        private System.Windows.Forms.TextBox pw_textBox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.CheckBox visible_pw;
    }
}