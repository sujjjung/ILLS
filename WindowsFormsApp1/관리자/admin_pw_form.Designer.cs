namespace WindowsFormsApp1
{
    partial class admin_pw_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enter_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.visible_pw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "관리자 암호를 입력하세요";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("나눔스퀘어 네오 Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(56, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(147, 31);
            this.textBox1.TabIndex = 1;
            // 
            // enter_btn
            // 
            this.enter_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.enter_btn.FlatAppearance.BorderSize = 0;
            this.enter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_btn.Location = new System.Drawing.Point(16, 155);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(98, 32);
            this.enter_btn.TabIndex = 30;
            this.enter_btn.Text = "확인";
            this.enter_btn.UseVisualStyleBackColor = false;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(154, 155);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(98, 32);
            this.cancel_btn.TabIndex = 31;
            this.cancel_btn.Text = "취소";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // visible_pw
            // 
            this.visible_pw.AutoSize = true;
            this.visible_pw.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.visible_pw.Location = new System.Drawing.Point(86, 115);
            this.visible_pw.Name = "visible_pw";
            this.visible_pw.Size = new System.Drawing.Size(89, 18);
            this.visible_pw.TabIndex = 32;
            this.visible_pw.Text = "암호 보이기";
            this.visible_pw.UseVisualStyleBackColor = true;
            this.visible_pw.CheckedChanged += new System.EventHandler(this.visible_pw_CheckedChanged);
            // 
            // admin_pw_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(265, 199);
            this.Controls.Add(this.visible_pw);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_pw_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "관리자 암호 입력";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.CheckBox visible_pw;
    }
}