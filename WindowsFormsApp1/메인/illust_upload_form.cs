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
    public partial class illust_upload_form : Form

    {
        public static int illust_number;

        String owner_id = login_form.id;

        string sqlstr;    //쿼리문 저장 변수
        DBClass dbc = new DBClass();

        private void ClearTextBoxes()
        {
            illustNum_textBox.Clear();
            price_textBox.Clear();
            sellerid_textBox.Clear();
        }

        public illust_upload_form()
        {
            InitializeComponent();
        }

        private void illust_upload_form_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open();//*****
                dbc.DB_Access();//***
                dbc.DS.Clear();

                sqlstr = "select * from illustTable";
                dbc.DCom.CommandText = sqlstr;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "illustTable");
                dbc.DS.Tables["illustTable"].Clear();
                dbc.DA.Fill(dbc.DS, "illustTable");

                illustNum_textBox.Text = illust_number.ToString();
                sellerid_textBox.Text = owner_id;
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
        public static byte[] ImageToByteArray(Image image) //이미지를 바이트배열 변환
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
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

        /*
        private int INSERTRow()//사용자 함수 정의
        {
            string strqry = "INSERT INTO illustTable VALUES (:illustNum, :illustImg, :price, :ownerid)";
            OracleCommand OraCmd = new OracleCommand(strqry, dbc.Con);

            OraCmd.Parameters.Add("illustNum", OracleDbType.Int32).Value = illust_number;
            OraCmd.Parameters.Add("illustImg", OracleDbType.Blob).Value = pictureBox1;
            OraCmd.Parameters.Add("price", OracleDbType.Varchar2, 50).Value = price_textBox.Text.Trim();
            OraCmd.Parameters.Add("ownerid", OracleDbType.Varchar2, 50).Value = owner_id;

            return OraCmd.ExecuteNonQuery(); //추가되는 행수 반환
        }
        */
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.PhoneTable = dbc.DS.Tables["illustTable"];//*
                DataRow newRow = dbc.PhoneTable.NewRow();
                newRow["illustNum"] = Convert.ToInt32(illustNum_textBox.Text);
                illust_number++;
                newRow["illustImg"] = ImageToByteArray(pictureBox1.Image);
                newRow["price"] = price_textBox.Text;
                newRow["ownerid"] = sellerid_textBox.Text;

                dbc.PhoneTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "illustTable");
                dbc.DS.AcceptChanges();//*
                ClearTextBoxes();  //*
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
            /*
            try
            {
                dbc.PhoneTable = dbc.DS.Tables["illustTable"];
                DataRow newRow = dbc.PhoneTable.NewRow();
                newRow["illustnum"] = illust_number;
                illust_number++;
                newRow["illustImg"] = ImageToByteArray(pictureBox1.Image);
                newRow["price"] = Convert.ToInt32(price_textBox.Text);
                newRow["ownerid"] = ownerid;

                dbc.PhoneTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "illustTable");
                dbc.DS.AcceptChanges();//*
                ClearTextBoxes();  //*
                DBGrid.DataSource = dbc.DS.Tables["illustTable"].DefaultView;
                
                if (INSERTRow() > 0)
                {
                    MessageBox.Show("정상적으로 데이터 행이 추가됨.");
                }
                else MessageBox.Show("데이터 행이 추가되지 않음!");
                this.Close();
                
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
            */
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox1.Image = Image.FromFile(image_file); //Image에 사용자가 설정한 img 넣음
        }
    }
}
