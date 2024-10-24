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
    public partial class splash_form : Form
    {
        public splash_form()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            login_form login= new login_form();
            login.ShowDialog();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            signUp_form signUp = new signUp_form();
            signUp.Show();
        }

        private void adminMode_Click(object sender, EventArgs e)
        {
            admin_pw_form admin_pw = new admin_pw_form();
            admin_pw.ShowDialog();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
