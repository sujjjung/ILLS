using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class admin_form : Form
    {
        string sqlstr;    //쿼리문 저장 변수
        DBClass dbc = new DBClass();
        private void ClearTextBoxes()
        {
            id_textBox.Clear();
            pw_textBox.Clear();
            name_textBox.Clear();
            birth_textBox.Clear();
        }
        public admin_form()
        {
            InitializeComponent();
        }

        private void admin_form_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open();//*****
                dbc.DB_Access();//***

                sqlstr = "select * from userTable";
                dbc.DCom.CommandText = sqlstr;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "userTable");
                dbc.DS.Tables["userTable"].Clear();
                dbc.DA.Fill(dbc.DS, "userTable");
                DBGrid.DataSource = dbc.DS.Tables["userTable"].DefaultView;

                DBGrid.Columns[0].HeaderText = "아이디";
                DBGrid.Columns[1].HeaderText = "비밀번호";
                DBGrid.Columns[2].HeaderText = "이름";
                DBGrid.Columns[3].HeaderText = "생년월일";
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

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DS.Clear();
                dbc.DBAdapter.Fill(dbc.DS, "userTable");
                DBGrid.DataSource = dbc.DS.Tables["userTable"].DefaultView;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable userTable = dbc.DS.Tables["userTable"];

                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > userTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }

                DataRow currRow = userTable.Rows[e.RowIndex];
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

        private void add_btn_Click(object sender, EventArgs e)
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
                DBGrid.DataSource = dbc.DS.Tables["userTable"].DefaultView;
                MessageBox.Show("회원이 추가되었습니다.");
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
        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.PhoneTable = dbc.DS.Tables["userTable"];//*
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.PhoneTable.Columns["id"];
                dbc.PhoneTable.PrimaryKey = PrimaryKey;

                DataRow currRow = dbc.PhoneTable.Rows.Find(dbc.SelectedRowIndex);


                currRow.BeginEdit();
                currRow["id"] = id_textBox.Text;
                currRow["pw"] = pw_textBox.Text;
                currRow["name"] = name_textBox.Text;
                currRow["birth"] = birth_textBox.Text;
                currRow.EndEdit();

                DataSet UpdatedSet = dbc.DS.GetChanges(DataRowState.Modified);
                if (UpdatedSet.HasErrors)
                {
                    MessageBox.Show("변경된 데이터에 문제가 있습니다.");
                }
                else
                {
                    dbc.DBAdapter.Update(UpdatedSet, "userTable");
                    dbc.DS.AcceptChanges();
                }

                DBGrid.DataSource = dbc.DS.Tables["userTable"].DefaultView;

            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
            MessageBox.Show("회원 정보가 수정되었습니다.");
        }

        private void del_btn_Click(object sender, EventArgs e)
        {

            try
            {
                dbc.PhoneTable = dbc.DS.Tables["userTable"];//*
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.PhoneTable.Columns["id"];
                dbc.PhoneTable.PrimaryKey = PrimaryKey;

                DataRow currRow = dbc.PhoneTable.Rows.Find(dbc.SelectedRowIndex);
                currRow.Delete();

                dbc.DBAdapter.Update(dbc.DS.GetChanges(DataRowState.Deleted), "userTable");
                DBGrid.DataSource = dbc.DS.Tables["userTable"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
            MessageBox.Show("회원이 삭제되었습니다.");
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