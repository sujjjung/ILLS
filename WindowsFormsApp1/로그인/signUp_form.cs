using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class signUp_form : Form
    {
        private void ClearTextBoxes()
        {
            id_textBox.Clear();
            pw_textBox.Clear();
            name_textBox.Clear();
            birth_textBox.Clear();
        }

        DBClass dbc = new DBClass();

        public signUp_form()
        {
            InitializeComponent();
            dbc.DB_ObjCreate();
            dbc.DB_Open();
            dbc.DS.Clear();
            dbc.DBAdapter.Fill(dbc.DS, "userTable");
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.PhoneTable = dbc.DS.Tables["userTable"];//*
                DataRow newRow = dbc.PhoneTable.NewRow();
                newRow["id"] = id_textBox.Text;
                newRow["pw"] = pw_textBox.Text;
                newRow["name"] = name_textBox.Text;
                newRow["birth"] = birth_textBox.Text;


                dbc.PhoneTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "userTable");
                dbc.DS.AcceptChanges();//*
                ClearTextBoxes();  //*

                MessageBox.Show("회원가입이 완료되었습니다");
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
                MessageBox.Show("회원가입이 완료되지 않았습니다");
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
                MessageBox.Show("회원가입이 완료되지 않았습니다");
            }
            this.Close();
        }

        private void DBGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable phoneTable = dbc.DS.Tables["userTable"];

                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > phoneTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }

                DataRow currRow = phoneTable.Rows[e.RowIndex];
                id_textBox.Text = currRow["id"].ToString();
                pw_textBox.Text = currRow["pw"].ToString();
                name_textBox.Text = currRow["name"].ToString();
                birth_textBox.Text = currRow["birth"].ToString();

                dbc.SelectedRowIndex = Convert.ToInt32(currRow["id"]);
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
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
                pw_textBox.PasswordChar = default(char);
            }
            else
            {
                pw_textBox.PasswordChar = '*';
            }
        }
    }
}
