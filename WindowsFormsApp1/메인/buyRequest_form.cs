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
    public partial class buyRequest_form : Form
    {
        string sqlstr;    //쿼리문 저장 변수
        main_form _parent;
        DBClass dbc = new DBClass();

        String illustNum = main_form.illustNum;
        String saleUserName = main_form.ownerid;
        String buyPrice = main_form.price;

        String buyerid = login_form.id;
        int orderKey = 0;

        DataRow currRow1; //DS의 현재 행 저장 변수 
        DataRow currRow2; //DS의 현재 행 저장 변수 
        private void ClearTextBoxes()
        {
            saleUserName_textBox.Clear();
            buyPrice_textBox.Clear();
            buyDetail_textBox.Clear();
        }
        public buyRequest_form()
        {   //main_form parent
            InitializeComponent();
            //_parent = parent;
        }
        private void buyRequest_form_Load(object sender, EventArgs e)
        {

            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//***
            dbc.DS.Clear();

            sqlstr = "select * from orderTable";
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "orderTable");
            dbc.DS.Tables["orderTable"].Clear();
            dbc.DA.Fill(dbc.DS, "orderTable");

            orderKey_textBox.Text = orderKey.ToString();
            finalState_textBox.Text = "1";
            buyerId_textBox.Text = buyerid;

            illustNum_textBox.Text = illustNum;
            saleUserName_textBox.Text = saleUserName;
            buyPrice_textBox.Text = buyPrice;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buyRequest_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.PhoneTable = dbc.DS.Tables["orderTable"];//*
                DataRow newRow = dbc.PhoneTable.NewRow();
                newRow["orderKey"] = Convert.ToInt32(orderKey_textBox.Text);
                newRow["orderDetail"] = buyDetail_textBox.Text;
                newRow["finalState"] = Convert.ToInt32(finalState_textBox.Text);
                newRow["illustNum"] = Convert.ToInt32(illustNum_textBox.Text);
                newRow["buyerid"] = buyerId_textBox.Text;

                dbc.PhoneTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "orderTable");
                dbc.DS.AcceptChanges();//*
                ClearTextBoxes();  //*

                MessageBox.Show("구매 신청이 완료됐습니다.");
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
            this.Close();
        }
    }
}
