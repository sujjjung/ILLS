namespace WindowsFormsApp1
{
    partial class signUp_form
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
            this.signUp_btn = new System.Windows.Forms.Button();
            this.birth_label = new System.Windows.Forms.Label();
            this.birth_textBox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.pw_label = new System.Windows.Forms.Label();
            this.pw_textBox = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.signUp = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.visible_pw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // signUp_btn
            // 
            this.signUp_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.signUp_btn.FlatAppearance.BorderSize = 0;
            this.signUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUp_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.signUp_btn.Location = new System.Drawing.Point(54, 335);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Size = new System.Drawing.Size(130, 45);
            this.signUp_btn.TabIndex = 29;
            this.signUp_btn.Text = "가입하기";
            this.signUp_btn.UseVisualStyleBackColor = false;
            this.signUp_btn.Click += new System.EventHandler(this.signUp_btn_Click);
            // 
            // birth_label
            // 
            this.birth_label.AutoSize = true;
            this.birth_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.birth_label.Location = new System.Drawing.Point(74, 273);
            this.birth_label.Name = "birth_label";
            this.birth_label.Size = new System.Drawing.Size(82, 21);
            this.birth_label.TabIndex = 28;
            this.birth_label.Text = "생년월일";
            // 
            // birth_textBox
            // 
            this.birth_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.birth_textBox.Location = new System.Drawing.Point(180, 268);
            this.birth_textBox.Name = "birth_textBox";
            this.birth_textBox.Size = new System.Drawing.Size(153, 31);
            this.birth_textBox.TabIndex = 27;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_label.Location = new System.Drawing.Point(74, 212);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(46, 21);
            this.name_label.TabIndex = 26;
            this.name_label.Text = "이름";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_textBox.Location = new System.Drawing.Point(180, 207);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(153, 31);
            this.name_textBox.TabIndex = 25;
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw_label.Location = new System.Drawing.Point(74, 151);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(82, 21);
            this.pw_label.TabIndex = 24;
            this.pw_label.Text = "비밀번호";
            // 
            // pw_textBox
            // 
            this.pw_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw_textBox.Location = new System.Drawing.Point(180, 146);
            this.pw_textBox.Name = "pw_textBox";
            this.pw_textBox.PasswordChar = '*';
            this.pw_textBox.Size = new System.Drawing.Size(153, 31);
            this.pw_textBox.TabIndex = 23;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_label.Location = new System.Drawing.Point(74, 90);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(64, 21);
            this.id_label.TabIndex = 22;
            this.id_label.Text = "아이디";
            // 
            // id_textBox
            // 
            this.id_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_textBox.Location = new System.Drawing.Point(180, 85);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(153, 31);
            this.id_textBox.TabIndex = 21;
            // 
            // signUp
            // 
            this.signUp.AutoSize = true;
            this.signUp.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.signUp.Location = new System.Drawing.Point(30, 27);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(117, 30);
            this.signUp.TabIndex = 20;
            this.signUp.Text = "회원가입";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancel_btn.Location = new System.Drawing.Point(212, 335);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(130, 45);
            this.cancel_btn.TabIndex = 42;
            this.cancel_btn.Text = "돌아가기";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // visible_pw
            // 
            this.visible_pw.AutoSize = true;
            this.visible_pw.Font = new System.Drawing.Font("나눔스퀘어 네오 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visible_pw.Location = new System.Drawing.Point(180, 183);
            this.visible_pw.Name = "visible_pw";
            this.visible_pw.Size = new System.Drawing.Size(89, 18);
            this.visible_pw.TabIndex = 43;
            this.visible_pw.Text = "암호 보이기";
            this.visible_pw.UseVisualStyleBackColor = true;
            this.visible_pw.CheckedChanged += new System.EventHandler(this.visible_pw_CheckedChanged);
            // 
            // signUp_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(406, 411);
            this.Controls.Add(this.visible_pw);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.signUp_btn);
            this.Controls.Add(this.birth_label);
            this.Controls.Add(this.birth_textBox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.pw_label);
            this.Controls.Add(this.pw_textBox);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.signUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "signUp_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원가입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUp_btn;
        private System.Windows.Forms.Label birth_label;
        private System.Windows.Forms.TextBox birth_textBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label pw_label;
        private System.Windows.Forms.TextBox pw_textBox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label signUp;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.CheckBox visible_pw;
    }
}