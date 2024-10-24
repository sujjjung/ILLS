namespace WindowsFormsApp1
{
    partial class admin_form2
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
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.price_label = new System.Windows.Forms.Label();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.illustImg_label = new System.Windows.Forms.Label();
            this.illustNum_label = new System.Windows.Forms.Label();
            this.illustNum_textBox = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.sellerid_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.DBGrid.Size = new System.Drawing.Size(571, 416);
            this.DBGrid.TabIndex = 1;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(840, 390);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(92, 38);
            this.cancel_btn.TabIndex = 54;
            this.cancel_btn.Text = "돌아가기";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(695, 340);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 38);
            this.search_btn.TabIndex = 53;
            this.search_btn.Text = "조회";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Location = new System.Drawing.Point(857, 340);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 38);
            this.del_btn.TabIndex = 52;
            this.del_btn.Text = "삭제";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(776, 340);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 38);
            this.edit_btn.TabIndex = 51;
            this.edit_btn.Text = "수정";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(614, 340);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 38);
            this.add_btn.TabIndex = 50;
            this.add_btn.Text = "추가";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.Location = new System.Drawing.Point(610, 196);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(46, 21);
            this.price_label.TabIndex = 47;
            this.price_label.Text = "가격";
            // 
            // price_textBox
            // 
            this.price_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price_textBox.Location = new System.Drawing.Point(773, 189);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(159, 31);
            this.price_textBox.TabIndex = 46;
            // 
            // illustImg_label
            // 
            this.illustImg_label.AutoSize = true;
            this.illustImg_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illustImg_label.Location = new System.Drawing.Point(610, 115);
            this.illustImg_label.Name = "illustImg_label";
            this.illustImg_label.Size = new System.Drawing.Size(141, 21);
            this.illustImg_label.TabIndex = 45;
            this.illustImg_label.Text = "일러스트 이미지";
            // 
            // illustNum_label
            // 
            this.illustNum_label.AutoSize = true;
            this.illustNum_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illustNum_label.Location = new System.Drawing.Point(610, 34);
            this.illustNum_label.Name = "illustNum_label";
            this.illustNum_label.Size = new System.Drawing.Size(105, 21);
            this.illustNum_label.TabIndex = 43;
            this.illustNum_label.Text = "일러스트 키";
            // 
            // illustNum_textBox
            // 
            this.illustNum_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.illustNum_textBox.Location = new System.Drawing.Point(773, 27);
            this.illustNum_textBox.Name = "illustNum_textBox";
            this.illustNum_textBox.Size = new System.Drawing.Size(159, 31);
            this.illustNum_textBox.TabIndex = 42;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(610, 277);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(146, 21);
            this.id_label.TabIndex = 56;
            this.id_label.Text = "판매 유저 아이디";
            // 
            // sellerid_textBox
            // 
            this.sellerid_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sellerid_textBox.Location = new System.Drawing.Point(773, 270);
            this.sellerid_textBox.Name = "sellerid_textBox";
            this.sellerid_textBox.Size = new System.Drawing.Size(159, 31);
            this.sellerid_textBox.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(773, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 31);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // admin_form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.sellerid_textBox);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.price_textBox);
            this.Controls.Add(this.illustImg_label);
            this.Controls.Add(this.illustNum_label);
            this.Controls.Add(this.illustNum_textBox);
            this.Controls.Add(this.DBGrid);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "admin_form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "일러스트 관리";
            this.Load += new System.EventHandler(this.admin_form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.Label illustImg_label;
        private System.Windows.Forms.Label illustNum_label;
        private System.Windows.Forms.TextBox illustNum_textBox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox sellerid_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}