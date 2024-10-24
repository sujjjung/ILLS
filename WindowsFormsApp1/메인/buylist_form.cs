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
    public partial class buylist_form : Form
    {
        string sqlstr;    //쿼리문 저장 변수
        DBClass dbc = new DBClass();  //*****DBClass 객체 생성

        String id = login_form.id;

        public buylist_form()
        {
            InitializeComponent();
        }
        private void buylist_form_Load(object sender, EventArgs e)
        {
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//***

            sqlstr = "Select * From orderTable Where buyerid = '" + id + "' AND finalState = '1'"; 
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "orderTable");
            dbc.DS.Tables["orderTable"].Clear();
            dbc.DA.Fill(dbc.DS, "orderTable");
            DBGrid.DataSource = dbc.DS.Tables["orderTable"].DefaultView;

            DBGrid.Columns[0].HeaderText = "주문 키";
            DBGrid.Columns[1].HeaderText = "주문 요청사항";
            DBGrid.Columns[2].HeaderText = "주문 상태";
            DBGrid.Columns[3].HeaderText = "일러스트 키";
            DBGrid.Columns[4].HeaderText = "구매자 아이디";
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
