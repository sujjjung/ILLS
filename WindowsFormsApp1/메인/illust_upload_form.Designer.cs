
namespace WindowsFormsApp1
{
    partial class illust_upload_form
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
            this.add_btn = new System.Windows.Forms.Button();
            this.price_label = new System.Windows.Forms.Label();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.img_text = new System.Windows.Forms.Label();
            this.add_ = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sellerid_textBox = new System.Windows.Forms.TextBox();
            this.illustNum_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(69, 238);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(132, 42);
            this.add_btn.TabIndex = 41;
            this.add_btn.Text = "등록하기";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.Location = new System.Drawing.Point(94, 176);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(40, 24);
            this.price_label.TabIndex = 40;
            this.price_label.Text = "가격";
            // 
            // price_textBox
            // 
            this.price_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price_textBox.Location = new System.Drawing.Point(231, 179);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(153, 31);
            this.price_textBox.TabIndex = 39;
            // 
            // img_text
            // 
            this.img_text.AutoSize = true;
            this.img_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.img_text.Location = new System.Drawing.Point(65, 108);
            this.img_text.Name = "img_text";
            this.img_text.Size = new System.Drawing.Size(91, 24);
            this.img_text.TabIndex = 38;
            this.img_text.Text = "이미지 등록";
            // 
            // add_
            // 
            this.add_.AutoSize = true;
            this.add_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_.Location = new System.Drawing.Point(26, 29);
            this.add_.Name = "add_";
            this.add_.Size = new System.Drawing.Size(148, 31);
            this.add_.TabIndex = 36;
            this.add_.Text = "일러스트 등록";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancel_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(252, 239);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(132, 42);
            this.cancel_btn.TabIndex = 42;
            this.cancel_btn.Text = "돌아가기";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(231, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 92);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // sellerid_textBox
            // 
            this.sellerid_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sellerid_textBox.Location = new System.Drawing.Point(161, 243);
            this.sellerid_textBox.Name = "sellerid_textBox";
            this.sellerid_textBox.Size = new System.Drawing.Size(37, 31);
            this.sellerid_textBox.TabIndex = 59;
            // 
            // illustNum_textBox
            // 
            this.illustNum_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.illustNum_textBox.Location = new System.Drawing.Point(96, 243);
            this.illustNum_textBox.Name = "illustNum_textBox";
            this.illustNum_textBox.Size = new System.Drawing.Size(39, 31);
            this.illustNum_textBox.TabIndex = 57;
            // 
            // illust_upload_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(463, 333);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.sellerid_textBox);
            this.Controls.Add(this.illustNum_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.price_textBox);
            this.Controls.Add(this.img_text);
            this.Controls.Add(this.add_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "illust_upload_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "일러스트 등록";
            this.Load += new System.EventHandler(this.illust_upload_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.Label img_text;
        private System.Windows.Forms.Label add_;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox sellerid_textBox;
        private System.Windows.Forms.TextBox illustNum_textBox;
    }
}