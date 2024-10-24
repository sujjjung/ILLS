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
    public partial class admin_pw_form : Form
    {
        public admin_pw_form()
        {
            InitializeComponent();
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "1234")
            {
                MessageBox.Show("관리자 모드를 실행합니다");
                textBox1.Text = "";
                textBox1.Focus();
                admin_select_form admin_select = new admin_select_form();
                admin_select.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("잘못된 암호입니다.");
                textBox1.Text = "1234";
                textBox1.Focus();
                this.Close();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void visible_pw_CheckedChanged(object sender, EventArgs e)
        {
            if (visible_pw.Checked == true)
            {
                textBox1.PasswordChar = default(char);
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }
    }
}
