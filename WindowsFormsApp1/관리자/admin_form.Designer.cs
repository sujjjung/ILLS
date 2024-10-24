
namespace WindowsFormsApp1
{
    partial class admin_form
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
            this.birth_label = new System.Windows.Forms.Label();
            this.birth_textBox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.pw_label = new System.Windows.Forms.Label();
            this.pw_textBox = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.visible_pw = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔스퀘어 네오 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DBGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.DBGrid.Location = new System.Drawing.Point(12, 12);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.Size = new System.Drawing.Size(395, 416);
            this.DBGrid.TabIndex = 0;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // birth_label
            // 
            this.birth_label.AutoSize = true;
            this.birth_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_label.Location = new System.Drawing.Point(531, 256);
            this.birth_label.Name = "birth_label";
            this.birth_label.Size = new System.Drawing.Size(82, 21);
            this.birth_label.TabIndex = 36;
            this.birth_label.Text = "생년월일";
            // 
            // birth_textBox
            // 
            this.birth_textBox.Font = new System.Drawing.Font("나눔스퀘어 네오 Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.birth_textBox.Location = new System.Drawing.Point(677, 253);
            this.birth_textBox.Name = "birth_textBox";
            this.birth_textBox.Size = new System.Drawing.Size(153, 31);
            this.birth_textBox.TabIndex = 35;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(531, 190);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(46, 21);
            this.name_label.TabIndex = 34;
            this.name_label.Text = "이름";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("나눔스퀘어 네오 Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_textBox.Location = new System.Drawing.Point(677, 187);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(153, 31);
            this.name_textBox.TabIndex = 33;
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_label.Location = new System.Drawing.Point(531, 124);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(82, 21);
            this.pw_label.TabIndex = 32;
            this.pw_label.Text = "비밀번호";
            // 
            // pw_textBox
            // 
            this.pw_textBox.Font = new System.Drawing.Font("나눔스퀘어 네오 Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw_textBox.Location = new System.Drawing.Point(677, 121);
            this.pw_textBox.Name = "pw_textBox";
            this.pw_textBox.PasswordChar = '*';
            this.pw_textBox.Size = new System.Drawing.Size(153, 31);
            this.pw_textBox.TabIndex = 31;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(531, 58);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(64, 21);
            this.id_label.TabIndex = 30;
            this.id_label.Text = "아이디";
            // 
            // id_textBox
            // 
            this.id_textBox.Font = new System.Drawing.Font("나눔스퀘어 네오 Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_textBox.Location = new System.Drawing.Point(677, 55);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(153, 31);
            this.id_textBox.TabIndex = 29;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(520, 324);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 38);
            this.add_btn.TabIndex = 37;
            this.add_btn.Text = "추가";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(611, 324);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 38);
            this.edit_btn.TabIndex = 38;
            this.edit_btn.Text = "수정";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Location = new System.Drawing.Point(695, 324);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 38);
            this.del_btn.TabIndex = 39;
            this.del_btn.Text = "삭제";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(776, 324);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 38);
            this.search_btn.TabIndex = 40;
            this.search_btn.Text = "조회";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(759, 373);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(92, 38);
            this.cancel_btn.TabIndex = 41;
            this.cancel_btn.Text = "돌아가기";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // visible_pw
            // 
            this.visible_pw.AutoSize = true;
            this.visible_pw.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.visible_pw.Location = new System.Drawing.Point(677, 158);
            this.visible_pw.Name = "visible_pw";
            this.visible_pw.Size = new System.Drawing.Size(89, 18);
            this.visible_pw.TabIndex = 42;
            this.visible_pw.Text = "암호 보이기";
            this.visible_pw.UseVisualStyleBackColor = true;
            this.visible_pw.CheckedChanged += new System.EventHandler(this.visible_pw_CheckedChanged);
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.visible_pw);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.birth_label);
            this.Controls.Add(this.birth_textBox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.pw_label);
            this.Controls.Add(this.pw_textBox);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.DBGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "admin_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "유저 관리";
            this.Load += new System.EventHandler(this.admin_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Label birth_label;
        private System.Windows.Forms.TextBox birth_textBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label pw_label;
        private System.Windows.Forms.TextBox pw_textBox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.CheckBox visible_pw;
    }
}