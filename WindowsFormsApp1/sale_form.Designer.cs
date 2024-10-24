namespace WindowsFormsApp1
{
    partial class sale_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saleKey_label = new System.Windows.Forms.Label();
            this.saleKey_textBox = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.buyDate_label = new System.Windows.Forms.Label();
            this.buyDate_textBox = new System.Windows.Forms.TextBox();
            this.buyDetail_label = new System.Windows.Forms.Label();
            this.buyDetail_textBox = new System.Windows.Forms.TextBox();
            this.illustImg_label = new System.Windows.Forms.Label();
            this.buyKey_label = new System.Windows.Forms.Label();
            this.buyKey_textBox = new System.Windows.Forms.TextBox();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.sale_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(599, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 31);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // saleKey_label
            // 
            this.saleKey_label.AutoSize = true;
            this.saleKey_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleKey_label.Location = new System.Drawing.Point(453, 278);
            this.saleKey_label.Name = "saleKey_label";
            this.saleKey_label.Size = new System.Drawing.Size(76, 24);
            this.saleKey_label.TabIndex = 71;
            this.saleKey_label.Text = "판매글 키";
            // 
            // saleKey_textBox
            // 
            this.saleKey_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saleKey_textBox.Location = new System.Drawing.Point(599, 275);
            this.saleKey_textBox.Name = "saleKey_textBox";
            this.saleKey_textBox.Size = new System.Drawing.Size(153, 31);
            this.saleKey_textBox.TabIndex = 70;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(666, 376);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(92, 38);
            this.cancel_btn.TabIndex = 69;
            this.cancel_btn.Text = "돌아가기";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(563, 376);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 38);
            this.search_btn.TabIndex = 68;
            this.search_btn.Text = "조회";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Location = new System.Drawing.Point(666, 322);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 38);
            this.del_btn.TabIndex = 67;
            this.del_btn.Text = "삭제";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(563, 322);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 38);
            this.edit_btn.TabIndex = 66;
            this.edit_btn.Text = "수정";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(460, 322);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 38);
            this.add_btn.TabIndex = 65;
            this.add_btn.Text = "추가";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // buyDate_label
            // 
            this.buyDate_label.AutoSize = true;
            this.buyDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyDate_label.Location = new System.Drawing.Point(453, 215);
            this.buyDate_label.Name = "buyDate_label";
            this.buyDate_label.Size = new System.Drawing.Size(127, 24);
            this.buyDate_label.TabIndex = 64;
            this.buyDate_label.Text = "판매글 등록 날짜";
            // 
            // buyDate_textBox
            // 
            this.buyDate_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buyDate_textBox.Location = new System.Drawing.Point(599, 212);
            this.buyDate_textBox.Name = "buyDate_textBox";
            this.buyDate_textBox.Size = new System.Drawing.Size(153, 31);
            this.buyDate_textBox.TabIndex = 63;
            // 
            // buyDetail_label
            // 
            this.buyDetail_label.AutoSize = true;
            this.buyDetail_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyDetail_label.Location = new System.Drawing.Point(453, 149);
            this.buyDetail_label.Name = "buyDetail_label";
            this.buyDetail_label.Size = new System.Drawing.Size(70, 24);
            this.buyDetail_label.TabIndex = 62;
            this.buyDetail_label.Text = "요청사항";
            // 
            // buyDetail_textBox
            // 
            this.buyDetail_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buyDetail_textBox.Location = new System.Drawing.Point(599, 146);
            this.buyDetail_textBox.Name = "buyDetail_textBox";
            this.buyDetail_textBox.Size = new System.Drawing.Size(153, 31);
            this.buyDetail_textBox.TabIndex = 61;
            // 
            // illustImg_label
            // 
            this.illustImg_label.AutoSize = true;
            this.illustImg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illustImg_label.Location = new System.Drawing.Point(453, 83);
            this.illustImg_label.Name = "illustImg_label";
            this.illustImg_label.Size = new System.Drawing.Size(121, 24);
            this.illustImg_label.TabIndex = 60;
            this.illustImg_label.Text = "일러스트 이미지";
            // 
            // buyKey_label
            // 
            this.buyKey_label.AutoSize = true;
            this.buyKey_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyKey_label.Location = new System.Drawing.Point(453, 17);
            this.buyKey_label.Name = "buyKey_label";
            this.buyKey_label.Size = new System.Drawing.Size(76, 24);
            this.buyKey_label.TabIndex = 59;
            this.buyKey_label.Text = "구매글 키";
            // 
            // buyKey_textBox
            // 
            this.buyKey_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buyKey_textBox.Location = new System.Drawing.Point(599, 14);
            this.buyKey_textBox.Name = "buyKey_textBox";
            this.buyKey_textBox.Size = new System.Drawing.Size(153, 31);
            this.buyKey_textBox.TabIndex = 58;
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DBGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.DBGrid.Location = new System.Drawing.Point(12, 12);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowTemplate.Height = 100;
            this.DBGrid.Size = new System.Drawing.Size(395, 416);
            this.DBGrid.TabIndex = 73;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // sale_btn
            // 
            this.sale_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sale_btn.FlatAppearance.BorderSize = 0;
            this.sale_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sale_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_btn.Location = new System.Drawing.Point(443, 376);
            this.sale_btn.Name = "sale_btn";
            this.sale_btn.Size = new System.Drawing.Size(92, 38);
            this.sale_btn.TabIndex = 74;
            this.sale_btn.Text = "판매 완료";
            this.sale_btn.UseVisualStyleBackColor = false;
            // 
            // sale_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sale_btn);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saleKey_label);
            this.Controls.Add(this.saleKey_textBox);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.buyDate_label);
            this.Controls.Add(this.buyDate_textBox);
            this.Controls.Add(this.buyDetail_label);
            this.Controls.Add(this.buyDetail_textBox);
            this.Controls.Add(this.illustImg_label);
            this.Controls.Add(this.buyKey_label);
            this.Controls.Add(this.buyKey_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "sale_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "판매글 관리";
            this.Load += new System.EventHandler(this.sale_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label saleKey_label;
        private System.Windows.Forms.TextBox saleKey_textBox;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label buyDate_label;
        private System.Windows.Forms.TextBox buyDate_textBox;
        private System.Windows.Forms.Label buyDetail_label;
        private System.Windows.Forms.TextBox buyDetail_textBox;
        private System.Windows.Forms.Label illustImg_label;
        private System.Windows.Forms.Label buyKey_label;
        private System.Windows.Forms.TextBox buyKey_textBox;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button sale_btn;
    }
}