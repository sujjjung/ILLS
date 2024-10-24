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
    public partial class order_manage_form : Form
    {
        string sqlstr;    //쿼리문 저장 변수
        DBClass dbc = new DBClass();  //*****DBClass 객체 생성

        String id = login_form.id;

        public order_manage_form()
        {
            InitializeComponent();
        }

        private void DBGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult rtyes = MessageBox.Show("해당 일러스트를 판매 완료하시겠습니까?", "판매 완료 확인", MessageBoxButtons.YesNo);
            if (rtyes == DialogResult.Yes)
            {
                try
                {
                    dbc.PhoneTable = dbc.DS.Tables["orderTable"];//*
                    DataColumn[] PrimaryKey = new DataColumn[1];
                    PrimaryKey[0] = dbc.PhoneTable.Columns["orderKey"];
                    dbc.PhoneTable.PrimaryKey = PrimaryKey;

                    DataRow currRow = dbc.PhoneTable.Rows.Find(dbc.SelectedRowIndex);

                    currRow.BeginEdit();
                    currRow["finalState"] = 2;
                    currRow.EndEdit();
                    // orderTable finalState -> 거래 완료로 변경
                    DataSet UpdatedSet = dbc.DS.GetChanges(DataRowState.Modified);
                    if (UpdatedSet.HasErrors)
                    {
                        MessageBox.Show("변경된 데이터에 문제가 있습니다.");
                    }
                    else
                    {
                        dbc.DBAdapter.Update(UpdatedSet, "orderTable");
                        dbc.DS.AcceptChanges();
                    }

                    DBGrid.DataSource = dbc.DS.Tables["orderTable"].DefaultView;
                }
                catch (DataException DE)
                {
                    MessageBox.Show(DE.Message);
                }
                catch (Exception DE)
                {
                    MessageBox.Show(DE.Message);
                }
                MessageBox.Show("판매가 완료되었습니다.");
            }
        }
        private void order_manage_form_Load(object sender, EventArgs e)
        {
            try
            {
                // illusttable을 illustNum 으로 참조했는데 그 ownerid 는 우째 가져오나
                // sqlstr = "Select * From orderTable Where ownerid = '" + id + "'";

                // ownerid = '" + id + "' AND 

                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open();//*****
                dbc.DB_Access();//***
                sqlstr = "Select * From orderTable Where finalState = '1'";
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
