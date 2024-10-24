namespace WindowsFormsApp1
{
    partial class buyRequest_form
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
            this.buyDetail_label = new System.Windows.Forms.Label();
            this.buyDetail_textBox = new System.Windows.Forms.TextBox();
            this.buyPrice_textBox = new System.Windows.Forms.TextBox();
            this.buyPrice_label = new System.Windows.Forms.Label();
            this.saleUserName_textBox = new System.Windows.Forms.TextBox();
            this.saleUserName_label = new System.Windows.Forms.Label();
            this.buyRequest_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orderKey_textBox = new System.Windows.Forms.TextBox();
            this.finalState_textBox = new System.Windows.Forms.TextBox();
            this.illustNum_textBox = new System.Windows.Forms.TextBox();
            this.buyerId_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buyDetail_label
            // 
            this.buyDetail_label.AutoSize = true;
            this.buyDetail_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyDetail_label.Location = new System.Drawing.Point(36, 192);
            this.buyDetail_label.Name = "buyDetail_label";
            this.buyDetail_label.Size = new System.Drawing.Size(118, 21);
            this.buyDetail_label.TabIndex = 33;
            this.buyDetail_label.Text = "구매요청사항";
            // 
            // buyDetail_textBox
            // 
            this.buyDetail_textBox.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyDetail_textBox.Location = new System.Drawing.Point(211, 185);
            this.buyDetail_textBox.Name = "buyDetail_textBox";
            this.buyDetail_textBox.Size = new System.Drawing.Size(153, 31);
            this.buyDetail_textBox.TabIndex = 34;
            // 
            // buyPrice_textBox
            // 
            this.buyPrice_textBox.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPrice_textBox.Location = new System.Drawing.Point(211, 136);
            this.buyPrice_textBox.Name = "buyPrice_textBox";
            this.buyPrice_textBox.Size = new System.Drawing.Size(153, 31);
            this.buyPrice_textBox.TabIndex = 36;
            // 
            // buyPrice_label
            // 
            this.buyPrice_label.AutoSize = true;
            this.buyPrice_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPrice_label.Location = new System.Drawing.Point(36, 142);
            this.buyPrice_label.Name = "buyPrice_label";
            this.buyPrice_label.Size = new System.Drawing.Size(87, 21);
            this.buyPrice_label.TabIndex = 35;
            this.buyPrice_label.Text = "구매 가격";
            // 
            // saleUserName_textBox
            // 
            this.saleUserName_textBox.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleUserName_textBox.Location = new System.Drawing.Point(211, 37);
            this.saleUserName_textBox.Name = "saleUserName_textBox";
            this.saleUserName_textBox.Size = new System.Drawing.Size(153, 31);
            this.saleUserName_textBox.TabIndex = 38;
            // 
            // saleUserName_label
            // 
            this.saleUserName_label.AutoSize = true;
            this.saleUserName_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleUserName_label.Location = new System.Drawing.Point(36, 42);
            this.saleUserName_label.Name = "saleUserName_label";
            this.saleUserName_label.Size = new System.Drawing.Size(105, 21);
            this.saleUserName_label.TabIndex = 37;
            this.saleUserName_label.Text = "판매자 이름";
            // 
            // buyRequest_btn
            // 
            this.buyRequest_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buyRequest_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buyRequest_btn.FlatAppearance.BorderSize = 0;
            this.buyRequest_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyRequest_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyRequest_btn.Location = new System.Drawing.Point(285, 266);
            this.buyRequest_btn.Name = "buyRequest_btn";
            this.buyRequest_btn.Size = new System.Drawing.Size(145, 44);
            this.buyRequest_btn.TabIndex = 39;
            this.buyRequest_btn.Text = "구매 신청";
            this.buyRequest_btn.UseVisualStyleBackColor = false;
            this.buyRequest_btn.Click += new System.EventHandler(this.buyRequest_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancel_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(121, 266);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(145, 44);
            this.cancel_btn.TabIndex = 40;
            this.cancel_btn.Text = "돌아가기";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "일러스트 이미지";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(211, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 32);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // orderKey_textBox
            // 
            this.orderKey_textBox.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderKey_textBox.Location = new System.Drawing.Point(142, 273);
            this.orderKey_textBox.Name = "orderKey_textBox";
            this.orderKey_textBox.Size = new System.Drawing.Size(20, 31);
            this.orderKey_textBox.TabIndex = 43;
            // 
            // finalState_textBox
            // 
            this.finalState_textBox.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalState_textBox.Location = new System.Drawing.Point(168, 273);
            this.finalState_textBox.Name = "finalState_textBox";
            this.finalState_textBox.Size = new System.Drawing.Size(20, 31);
            this.finalState_textBox.TabIndex = 44;
            // 
            // illustNum_textBox
            // 
            this.illustNum_textBox.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illustNum_textBox.Location = new System.Drawing.Point(194, 273);
            this.illustNum_textBox.Name = "illustNum_textBox";
            this.illustNum_textBox.Size = new System.Drawing.Size(21, 31);
            this.illustNum_textBox.TabIndex = 45;
            // 
            // buyerId_textBox
            // 
            this.buyerId_textBox.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerId_textBox.Location = new System.Drawing.Point(223, 273);
            this.buyerId_textBox.Name = "buyerId_textBox";
            this.buyerId_textBox.Size = new System.Drawing.Size(20, 31);
            this.buyerId_textBox.TabIndex = 46;
            // 
            // buyRequest_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 336);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.buyerId_textBox);
            this.Controls.Add(this.illustNum_textBox);
            this.Controls.Add(this.finalState_textBox);
            this.Controls.Add(this.orderKey_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buyRequest_btn);
            this.Controls.Add(this.saleUserName_textBox);
            this.Controls.Add(this.saleUserName_label);
            this.Controls.Add(this.buyPrice_textBox);
            this.Controls.Add(this.buyPrice_label);
            this.Controls.Add(this.buyDetail_textBox);
            this.Controls.Add(this.buyDetail_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "buyRequest_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "구매 신청";
            this.Load += new System.EventHandler(this.buyRequest_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buyDetail_label;
        private System.Windows.Forms.TextBox buyDetail_textBox;
        private System.Windows.Forms.TextBox buyPrice_textBox;
        private System.Windows.Forms.Label buyPrice_label;
        private System.Windows.Forms.TextBox saleUserName_textBox;
        private System.Windows.Forms.Label saleUserName_label;
        private System.Windows.Forms.Button buyRequest_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox orderKey_textBox;
        private System.Windows.Forms.TextBox finalState_textBox;
        private System.Windows.Forms.TextBox illustNum_textBox;
        private System.Windows.Forms.TextBox buyerId_textBox;
    }
}