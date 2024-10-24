using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class admin_select_form : Form
    {
        public admin_select_form()
        {
            InitializeComponent();
        }

        private void userEdit_btn_Click(object sender, EventArgs e)
        {
            admin_form admin = new admin_form();
            admin.ShowDialog();
        }

        private void saleEdit_btn_Click(object sender, EventArgs e)
        {
            admin_form2 admin2 = new admin_form2();
            admin2.ShowDialog();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        admin_form child1 = new admin_form();
        admin_form2 child2 = new admin_form2();

        private void 유저관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child2.Hide();
            child1.Show();
        }

        private void 일러스트관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child1.Hide();
            child2.Show();
        }

        private void 돌아가기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admin_select_form_Load(object sender, EventArgs e)
        {
            child1.TopLevel = false;
            child2.TopLevel = false;
            this.Controls.Add(child1);
            this.Controls.Add(child2);

            child1.Parent = this.panel1;
            child2.Parent = this.panel1;

            child1.Text = child2.Text = "";
            child1.ControlBox = child2.ControlBox = false;
        }
    }
}
