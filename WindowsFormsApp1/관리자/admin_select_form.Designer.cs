namespace WindowsFormsApp1
{
    partial class admin_select_form
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.유저관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.일러스트관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.돌아가기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("나눔스퀘어 네오 Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.유저관리ToolStripMenuItem,
            this.일러스트관리ToolStripMenuItem,
            this.돌아가기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 유저관리ToolStripMenuItem
            // 
            this.유저관리ToolStripMenuItem.Name = "유저관리ToolStripMenuItem";
            this.유저관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.유저관리ToolStripMenuItem.Text = "유저 관리";
            this.유저관리ToolStripMenuItem.Click += new System.EventHandler(this.유저관리ToolStripMenuItem_Click);
            // 
            // 일러스트관리ToolStripMenuItem
            // 
            this.일러스트관리ToolStripMenuItem.Name = "일러스트관리ToolStripMenuItem";
            this.일러스트관리ToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.일러스트관리ToolStripMenuItem.Text = "일러스트 관리";
            this.일러스트관리ToolStripMenuItem.Click += new System.EventHandler(this.일러스트관리ToolStripMenuItem_Click);
            // 
            // 돌아가기ToolStripMenuItem
            // 
            this.돌아가기ToolStripMenuItem.Name = "돌아가기ToolStripMenuItem";
            this.돌아가기ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.돌아가기ToolStripMenuItem.Text = "돌아가기";
            this.돌아가기ToolStripMenuItem.Click += new System.EventHandler(this.돌아가기ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 489);
            this.panel1.TabIndex = 17;
            // 
            // admin_select_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(974, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "admin_select_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "데이터 관리";
            this.Load += new System.EventHandler(this.admin_select_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 유저관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 일러스트관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 돌아가기ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}