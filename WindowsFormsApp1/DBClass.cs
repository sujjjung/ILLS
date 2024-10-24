﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;//ADO.Net 개체 참조
using System.Data;  //DataSet 개체 참조
using System.Windows.Forms; //MessageBox 개체 참조

namespace WindowsFormsApp1
{
    public class DBClass //DBClass 정의 시작
    {
        private String ret;
        private String sql;
        

        private int selectedRowIndex;//수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다.
        private int selectedKeyValue; // 수정, 삭제할 때 필요한 레코드의 키값을 보관할 필드

        OracleDataAdapter dBAdapter; // Data Provider인 DBAdapter 입니다.

        OracleConnection con;
        OracleCommand dcom;
        OracleDataAdapter da; // Data Provider인 DBAdapter 입니다.

        DataSet dS;// DataSet 객체입니다.
        OracleDataReader dr; //DataReader 객체입니다.
        OracleCommandBuilder myCommandBuilder; // 추가, 수정, 삭제시에 필요한 명령문을 자동으로 작성해주는 객체
        DataTable phoneTable;// DataTable 객체입니다. 

        public String Ret { get { return ret; } set { ret = value; } }
        public String SQL { get { return sql; } set { sql = value; } }


        public int SelectedRowIndex { get { return selectedRowIndex; } set { selectedRowIndex = value; } }
        public int SelectedKeyValue { get { return selectedKeyValue; } set { selectedKeyValue = value; } }

        public OracleDataAdapter DBAdapter { get { return dBAdapter; } set { dBAdapter = value; } }
        public OracleConnection Con { get { return con; } set { con = value; } }
        public OracleCommand DCom { get { return dcom; } set { dcom = value; } }
        public OracleDataAdapter DA { get { return da; } set { da = value; } }
        public OracleDataReader DR { get { return dr; } set { dr = value; } }
        public DataSet DS { get { return dS; } set { dS = value; } }
        public OracleCommandBuilder MyCommandBuilder { get { return myCommandBuilder; } set { myCommandBuilder = value; } }
        public DataTable PhoneTable { get { return phoneTable; } set { phoneTable = value; } }

        public void DB_Open()
        {
            try
            {
                string connectionString = "User Id=sujung; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                string commandString = "select * from userTable";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DA = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DA);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public void DB_Access()
        {
            try
            {
                string My_con = "User Id=sujung; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                Con = new OracleConnection();
                Con.ConnectionString = My_con;
                DCom = new OracleCommand();
                DCom.Connection = Con;
                Con.Open();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public void DB_ObjCreate()
        {
            PhoneTable = new DataTable();
        }
    } //DBClass 정의 끝
}
