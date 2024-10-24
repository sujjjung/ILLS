using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class sale_form : Form
    {
        string sqlstr;    //쿼리문 저장 변수
        DBClass dbc = new DBClass();  //*****DBClass 객체 생성

        public static byte[] ImageToByteArray(Image image) //이미지를 바이트배열 변환
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void ClearTextBoxes()
        {
            buyKey_textBox.Clear();
            buyDetail_textBox.Clear();
            buyDate_textBox.Clear();
            saleKey_textBox.Clear();
        }

        public sale_form()
        {
            InitializeComponent();
        }
        private void sale_form_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open();//*****
                dbc.DB_Access();//***
                dbc.DS.Clear();

                sqlstr = "select * from saleRequest";
                dbc.DCom.CommandText = sqlstr;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "saleRequest");
                dbc.DS.Tables["saleRequest"].Clear();
                dbc.DA.Fill(dbc.DS, "saleRequest");
                DBGrid.DataSource = dbc.DS.Tables["saleRequest"].DefaultView;
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
                dbc.DBAdapter.Fill(dbc.DS, "saleRequest");
                DBGrid.DataSource = dbc.DS.Tables["saleRequest"].DefaultView;
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
        private void DBGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable saleRequest= dbc.DS.Tables["saleRequest"];
                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > saleRequest.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }

                DataRow currRow = saleRequest.Rows[e.RowIndex];
                buyKey_textBox.Text = currRow["buyKey"].ToString();
                // 일러스트 이미지
                buyDetail_textBox.Text = currRow["buyDetail"].ToString();
                buyDate_textBox.Text = currRow["buyDate"].ToString();
                buyKey_textBox.Text = currRow["saleKey"].ToString();

                dbc.SelectedRowIndex = Convert.ToInt32(currRow["buyKey"]);
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
        public void GetImageColumn()

        {

            //이미지 컬럼 객체 생성

            DataGridViewImageColumn img = new DataGridViewImageColumn();



            //리소스에 저장되어 있는 Image 넣기

            Image _image = pictureBox1.Image;

            img.Image = _image;



            //image 컬럼 추가

            //DBGrid.Columns.Add(img);

            img.HeaderText = "ImageColumn";

            img.Name = "img";

        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.PhoneTable = dbc.DS.Tables["saleRequest"];//*
                DataRow newRow = dbc.PhoneTable.NewRow();
                newRow["buyKey"] = Convert.ToInt32(buyKey_textBox.Text);
                // newRow["illustImg"] = ImageToByteArray(pictureBox1.Image);
                newRow["buyDetail"] = buyDetail_textBox.Text;
                newRow["buyDate"] = buyDate_textBox.Text;
                newRow["saleKey"] = saleKey_textBox.Text;

                dbc.PhoneTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "saleRequest");
                dbc.DS.AcceptChanges();//*
                ClearTextBoxes();  //*
                DBGrid.DataSource = dbc.DS.Tables["saleRequest"].DefaultView;
                MessageBox.Show("게시글이 추가되었습니다.");
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
                dbc.PhoneTable = dbc.DS.Tables["saleRequest"];//*
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.PhoneTable.Columns["saleRequest"];
                dbc.PhoneTable.PrimaryKey = PrimaryKey;

                DataRow currRow = dbc.PhoneTable.Rows.Find(dbc.SelectedRowIndex);


                currRow.BeginEdit();
                currRow["buyKey"] = buyKey_textBox.Text;
                currRow["buyDetail"] = buyDetail_textBox.Text;
                currRow["buyDate"] = buyDate_textBox.Text;
                currRow["saleKey"] = saleKey_textBox.Text;
                currRow.EndEdit();

                DataSet UpdatedSet = dbc.DS.GetChanges(DataRowState.Modified);
                if (UpdatedSet.HasErrors)
                {
                    MessageBox.Show("변경된 데이터에 문제가 있습니다.");
                }
                else
                {
                    dbc.DBAdapter.Update(UpdatedSet, "saleRequest");
                    dbc.DS.AcceptChanges();
                    MessageBox.Show("게시글 정보가 수정되었습니다.");
                }

                DBGrid.DataSource = dbc.DS.Tables["saleRequest"].DefaultView;

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

        private void del_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.PhoneTable = dbc.DS.Tables["saleRequest"];//*
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.PhoneTable.Columns["buyKey"];
                dbc.PhoneTable.PrimaryKey = PrimaryKey;

                DataRow currRow = dbc.PhoneTable.Rows.Find(dbc.SelectedRowIndex);
                currRow.Delete();

                dbc.DBAdapter.Update(dbc.DS.GetChanges(DataRowState.Deleted), "saleRequest");
                DBGrid.DataSource = dbc.DS.Tables["saleRequest"].DefaultView;
                MessageBox.Show("게시글이 삭제되었습니다.");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty; //이미지를 담기위한 지역변수

            OpenFileDialog dialog = new OpenFileDialog(); //이미지 선택을 위한 다이얼로그
            dialog.InitialDirectory = @"D:\"; //다이얼로그 초기위치

            if (dialog.ShowDialog() == DialogResult.OK)

            {

                image_file = dialog.FileName;

            }

            else if (dialog.ShowDialog() == DialogResult.Cancel)

            {

                return;

            }

            pictureBox1.Image = Image.FromFile(image_file); //Image에 사용자가 설정한 img 넣음
        }

        private void DBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
