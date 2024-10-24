namespace WindowsFormsApp1
{
    partial class main_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.illust_label = new System.Windows.Forms.Label();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.saleUserName_textBox = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.buylist_btn = new System.Windows.Forms.Button();
            this.print_id = new System.Windows.Forms.TextBox();
            this.illust_upload_btn = new System.Windows.Forms.Button();
            this.illust_manage_btn = new System.Windows.Forms.Button();
            this.order_manage_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.a_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // illust_label
            // 
            this.illust_label.AutoSize = true;
            this.illust_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Heavy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.illust_label.Location = new System.Drawing.Point(264, 22);
            this.illust_label.Name = "illust_label";
            this.illust_label.Size = new System.Drawing.Size(267, 44);
            this.illust_label.TabIndex = 1;
            this.illust_label.Text = " 일러스트 거래";
            // 
            // DBGrid
            // 
            this.DBGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DBGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DBGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DBGrid.Location = new System.Drawing.Point(12, 163);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowTemplate.Height = 100;
            this.DBGrid.Size = new System.Drawing.Size(776, 275);
            this.DBGrid.TabIndex = 2;
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(684, 13);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(104, 32);
            this.cancel_btn.TabIndex = 10;
            this.cancel_btn.Text = "로그아웃";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // saleUserName_textBox
            // 
            this.saleUserName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saleUserName_textBox.Location = new System.Drawing.Point(24, 103);
            this.saleUserName_textBox.Multiline = true;
            this.saleUserName_textBox.Name = "saleUserName_textBox";
            this.saleUserName_textBox.Size = new System.Drawing.Size(167, 44);
            this.saleUserName_textBox.TabIndex = 11;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_btn.Location = new System.Drawing.Point(197, 103);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(167, 44);
            this.search_btn.TabIndex = 12;
            this.search_btn.Text = "판매자 검색";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // buylist_btn
            // 
            this.buylist_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buylist_btn.FlatAppearance.BorderSize = 0;
            this.buylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buylist_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buylist_btn.Location = new System.Drawing.Point(574, 13);
            this.buylist_btn.Name = "buylist_btn";
            this.buylist_btn.Size = new System.Drawing.Size(104, 32);
            this.buylist_btn.TabIndex = 13;
            this.buylist_btn.Text = "구매내역";
            this.buylist_btn.UseVisualStyleBackColor = false;
            this.buylist_btn.Click += new System.EventHandler(this.buylist_btn_Click);
            // 
            // print_id
            // 
            this.print_id.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.print_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.print_id.Font = new System.Drawing.Font("나눔스퀘어 네오 Heavy", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.print_id.Location = new System.Drawing.Point(683, 51);
            this.print_id.Name = "print_id";
            this.print_id.ReadOnly = true;
            this.print_id.Size = new System.Drawing.Size(100, 18);
            this.print_id.TabIndex = 14;
            // 
            // illust_upload_btn
            // 
            this.illust_upload_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.illust_upload_btn.FlatAppearance.BorderSize = 0;
            this.illust_upload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.illust_upload_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.illust_upload_btn.Location = new System.Drawing.Point(405, 103);
            this.illust_upload_btn.Name = "illust_upload_btn";
            this.illust_upload_btn.Size = new System.Drawing.Size(133, 32);
            this.illust_upload_btn.TabIndex = 15;
            this.illust_upload_btn.Text = "일러스트 등록";
            this.illust_upload_btn.UseVisualStyleBackColor = false;
            this.illust_upload_btn.Click += new System.EventHandler(this.illust_upload_btn_Click);
            // 
            // illust_manage_btn
            // 
            this.illust_manage_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.illust_manage_btn.FlatAppearance.BorderSize = 0;
            this.illust_manage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.illust_manage_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.illust_manage_btn.Location = new System.Drawing.Point(544, 103);
            this.illust_manage_btn.Name = "illust_manage_btn";
            this.illust_manage_btn.Size = new System.Drawing.Size(132, 32);
            this.illust_manage_btn.TabIndex = 16;
            this.illust_manage_btn.Text = "일러스트 관리";
            this.illust_manage_btn.UseVisualStyleBackColor = false;
            this.illust_manage_btn.Click += new System.EventHandler(this.illust_manage_btn_Click);
            // 
            // order_manage_btn
            // 
            this.order_manage_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.order_manage_btn.FlatAppearance.BorderSize = 0;
            this.order_manage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_manage_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_manage_btn.Location = new System.Drawing.Point(684, 103);
            this.order_manage_btn.Name = "order_manage_btn";
            this.order_manage_btn.Size = new System.Drawing.Size(99, 32);
            this.order_manage_btn.TabIndex = 17;
            this.order_manage_btn.Text = "주문 관리";
            this.order_manage_btn.UseVisualStyleBackColor = false;
            this.order_manage_btn.Click += new System.EventHandler(this.order_manage_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(490, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "일러스트 행 더블클릭 시 구매가 가능합니다";
            // 
            // a_btn
            // 
            this.a_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.a_btn.FlatAppearance.BorderSize = 0;
            this.a_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.a_btn.Location = new System.Drawing.Point(34, 25);
            this.a_btn.Name = "a_btn";
            this.a_btn.Size = new System.Drawing.Size(167, 44);
            this.a_btn.TabIndex = 19;
            this.a_btn.Text = "조회";
            this.a_btn.UseVisualStyleBackColor = false;
            this.a_btn.Click += new System.EventHandler(this.a_btn_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.a_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.order_manage_btn);
            this.Controls.Add(this.illust_manage_btn);
            this.Controls.Add(this.illust_upload_btn);
            this.Controls.Add(this.print_id);
            this.Controls.Add(this.buylist_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.saleUserName_textBox);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.illust_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "메인 거래 폼";
            this.Load += new System.EventHandler(this.main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label illust_label;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.TextBox saleUserName_textBox;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button buylist_btn;
        private System.Windows.Forms.TextBox print_id;
        private System.Windows.Forms.Button illust_upload_btn;
        private System.Windows.Forms.Button illust_manage_btn;
        private System.Windows.Forms.Button order_manage_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button a_btn;
    }
}