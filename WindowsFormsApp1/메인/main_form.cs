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
    public partial class main_form : Form
    {
        string sqlstr;    //쿼리문 저장 변수
        DBClass dbc = new DBClass();  //*****DBClass 객체 생성

        private int SelectedRowIndex;
        OracleDataAdapter DBAdapter; // Data Provider인 DBAdapter 입니다.
        DataSet DS; // DataSet 객체입니다.
        OracleCommandBuilder myCommandBuilder;
        DataTable phoneTable;

        String buyerid = login_form.id;
        public static string illustNum;
        public static string price;
        public static string ownerid;

        public main_form()
        {
            InitializeComponent();
        }
        private void main_form_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open();//*****
                dbc.DB_Access();//***

                sqlstr = "select * from illustTable";
                dbc.DCom.CommandText = sqlstr;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "illustTable");
                dbc.DS.Tables["illustTable"].Clear();
                dbc.DA.Fill(dbc.DS, "illustTable");
                DBGrid.DataSource = dbc.DS.Tables["illustTable"].DefaultView;

                DBGrid.Columns[0].HeaderText = "일러스트 키";
                DBGrid.Columns[1].HeaderText = "일러스트";
                DBGrid.Columns[2].HeaderText = "가격";
                DBGrid.Columns[3].HeaderText = "판매자 아이디";

                print_id.Text = buyerid + " 님";
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
        public void list_search(String find, String sort)
        {
            sqlstr = "Select * From illustTable Where ownerid = '" + find + "'";
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "illustTable");
            dbc.DS.Tables["illustTable"].Clear();
            dbc.DA.Fill(dbc.DS, "illustTable");
            DBGrid.DataSource = dbc.DS.Tables["illustTable"].DefaultView;
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            String find = saleUserName_textBox.Text;
            if (saleUserName_textBox.Text.Trim() == "")
                MessageBox.Show("검색 미입력");
            else
                list_search(saleUserName_textBox.Text.Trim(), "");
        }
        /*
        public void list_search(String Find, String Sort)  // 검색과 정렬에 해당하는 SQL 작성 
        {
            if (Find == "" && Sort == "")  //기본
            {
                sqlstr = "Select * From saleTable ORDER BY id ASC";
            }
            else if (Find != "")  //검색
            {
                sqlstr = "Select * From saleTable Where id Like '%" + Find + "%'";
            }
        }
        */

        private void buylist_btn_Click(object sender, EventArgs e)
        {
            buylist_form buylist = new buylist_form();
            buylist.ShowDialog();
        }
        private void DBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable saletable = dbc.DS.Tables["illustTable"];
                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > saletable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                // 데이터가 없는 경우 return
                if (this.DBGrid.RowCount == 0)
                    return;

                // 현재 Row를 가져온다.
                DataGridViewRow dgvr = DBGrid.CurrentRow;

                // 선택한 Row의 데이터를 가져온다.
                DataRow row = (dgvr.DataBoundItem as DataRowView).Row;

                // TextBox에 그리드 데이터를 넣는다.
                illustNum = row["illustNum"].ToString();

                // 이미지 추가
                price = row["price"].ToString();
                ownerid = row["ownerid"].ToString();

                buyRequest_form buyRequest = new buyRequest_form();
                buyRequest.ShowDialog();
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
        private void illust_upload_btn_Click(object sender, EventArgs e)
        {
            illust_upload_form add_illust = new illust_upload_form();
            add_illust.ShowDialog();
        }

        private void illust_manage_btn_Click(object sender, EventArgs e)
        {
            illust_manage_form illust_Manage = new illust_manage_form();
            illust_Manage.ShowDialog();
        }

        private void order_manage_btn_Click(object sender, EventArgs e)
        {
            order_manage_form order_Manage = new order_manage_form();
            order_Manage.ShowDialog();
        }

        private void a_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DS.Clear();
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "illustTable");
                dbc.DS.Tables["illustTable"].Clear();
                dbc.DA.Fill(dbc.DS, "illustTable");
                DBGrid.DataSource = dbc.DS.Tables["illustTable"].DefaultView;
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
    }
}