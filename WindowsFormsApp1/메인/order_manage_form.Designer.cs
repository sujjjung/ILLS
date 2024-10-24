namespace WindowsFormsApp1
{
    partial class order_manage_form
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
            this.add_ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DBGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.DBGrid.Location = new System.Drawing.Point(12, 74);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowTemplate.Height = 100;
            this.DBGrid.Size = new System.Drawing.Size(776, 364);
            this.DBGrid.TabIndex = 15;
            this.DBGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellDoubleClick);
            // 
            // add_
            // 
            this.add_.AutoSize = true;
            this.add_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_.Location = new System.Drawing.Point(12, 20);
            this.add_.Name = "add_";
            this.add_.Size = new System.Drawing.Size(106, 31);
            this.add_.TabIndex = 37;
            this.add_.Text = "주문 관리";
            // 
            // order_manage_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_);
            this.Controls.Add(this.DBGrid);
            this.Name = "order_manage_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "order_manage_form";
            this.Load += new System.EventHandler(this.order_manage_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Label add_;
    }
}