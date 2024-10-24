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
    public partial class login_form : Form
    {
        string sqlstr;
        
        public static String id = null;
        
        private void ClearTextBoxes()
        {
            id_textBox.Clear();
            pw_textBox.Clear();
        }

        DBClass dbc = new DBClass();  //*****DBClass 객체 생성 
        
        public login_form()
        {
            InitializeComponent();
            dbc.DB_ObjCreate();
            dbc.DB_Open();
            dbc.DS.Clear();
            dbc.DB_Access();
            dbc.DBAdapter.Fill(dbc.DS, "userTable");
        }
        public void login_btn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text.Trim() == "")
            {
                MessageBox.Show("아이디를 입력하세요");
                id_textBox.Text = "";
                id_textBox.Focus();
            }
            else
            {
                dbc.DS.Tables["userTable"].Clear();
                sqlstr = "Select * From userTable Where id = '" + id_textBox.Text + "'";
                dbc.DCom.CommandText = sqlstr;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "userTable");
                dbc.DS.Tables["userTable"].Clear();
                dbc.DA.Fill(dbc.DS, "userTable");
                if (dbc.DS.Tables["userTable"].Rows.Count == 0)
                {
                    MessageBox.Show("없는 아이디입니다.");
                    id_textBox.Text = "";
                    id_textBox.Focus();
                }
                else
                {
                    if (pw_textBox.Text.Trim() == "")
                    {
                        MessageBox.Show("비밀번호를 입력하세요");
                        pw_textBox.Text = "";
                        pw_textBox.Focus();
                    }
                    else
                    {
                        // 비밀번호 확인
                        // 아이디 저장 -> 마이페이지, 판매글 등록 시 아이디 같이 등록
                        // 로그아웃시 아이디 삭제, 메인화면으로 돌아감

                        /*
                        dbc.DS.Tables["userTable"].Clear();
                        sqlstr = "Select * From userTable Where pw = '" + id_textBox.Text + "'";
                        dbc.DCom.CommandText = sqlstr;
                        dbc.DA.SelectCommand = dbc.DCom;
                        dbc.DA.Fill(dbc.DS, "userTable");
                        dbc.DS.Tables["userTable"].Clear();
                        dbc.DA.Fill(dbc.DS, "userTable");
                        if (dbc.DS.Tables["userTable"].Rows.Count == 0)
                        {
                            MessageBox.Show("비밀번호 오류");
                            pw_textBox.Text = "";
                            pw_textBox.Focus();
                        }
                        else
                        {
                            MessageBox.Show("로그인 성공");
                            main_form main = new main_form();
                            main.ShowDialog();
                            this.Close();
                        }
                        */
                        id = id_textBox.Text;
                        main_form main = new main_form();
                        main.ShowDialog();
                        this.Close();
                    }
                }
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