using ADOX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Microsoft ADO Ext. 2.8 for DDL and Security

namespace AccessHelper
{
    public class Access_Operation
    {
        public static ADOX.Catalog catalog;
        public static System.Data.OleDb.OleDbConnection Conn;
        public static System.Data.OleDb.OleDbDataReader odrReader;
        public static System.Data.OleDb.OleDbCommand cmd;
        public static System.Data.OleDb.OleDbDataAdapter adapter;
        

        public static void Access_Open(string filePath, string grouppassword = null, string DatabasePassword = null)
        {

            catalog = new ADOX.Catalog();
            string conStr =@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + @";Password=" + grouppassword + @";Jet OLEDB:Database Password=" + DatabasePassword + ";Jet OLEDB:Engine Type=5";
            if (!File.Exists(filePath))  
            {
                try
                {
                    catalog.Create(conStr);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            Conn = new System.Data.OleDb.OleDbConnection(conStr);
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
            cmd = new OleDbCommand();
        }



        public static void Access_Close()
        {
            System.GC.Collect();  
            catalog.ActiveConnection = null;
            if (Conn.State == ConnectionState.Open)
                Conn.Close();
            Conn.Dispose();
        }

        /// <param name="TableName">TableName</param>
        /// <param name="FieldName">FieldName</param>
        /// <returns></returns>
        public static List<string> GetTableFieldValueList(string TableName, string FieldName)
        {
            List<string> list = new List<string>();
            try
            {
                string Constr = "SELECT " + FieldName + " FROM " + TableName + "";
                using (cmd = new OleDbCommand(Constr, Conn))
                {
                    odrReader = cmd.ExecuteReader();
                    while (odrReader.Read())  
                    {
                        list.Add(odrReader.GetValue(odrReader.GetOrdinal(FieldName)).ToString()); 
                    }
                }
                return list;
            }
            catch (Exception e)
            { throw e; }
        }



        /// <param name="TableName"></param>TableName</param>
        /// <param name="RowId"></param>The row number of the cell to be selected
        /// <param name="ColumnId"></param>The column number of the cell to be selected
        /// <returns></returns>
        public static string GetCellValue(string TableName, int RowId, int ColumnId, string SortTab="")
        {
            try
            {
                string CellValueStr = "";
                string Constr = "SELECT * FROM [" + TableName + "]";
                if (SortTab != "") { Constr = "select * from " + TableName + " order by [" + SortTab + "] asc"; }
                else { Constr = "select * from " + TableName; }
                using (cmd = new OleDbCommand(Constr, Conn))
                {
                    odrReader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(odrReader); 
                    CellValueStr = dt.Rows[RowId - 1][ColumnId - 1].ToString();  
                    odrReader.Close();  
                    return CellValueStr;
                }                
            }
            catch (Exception e)
            { throw e; }
        }



        /// <param name="Constr"></param>SQL commands for selecting data
        /// <param name="ColumnId"></param>The column number of the cell to be extracted in the selected row of data
        /// <returns></returns>
        public static string GetCellValuebySql(string Constr, int ColumnId)
        {
            try
            {
                string CellValueStr = "";
                using (cmd = new OleDbCommand(Constr, Conn))  
                {
                    odrReader = cmd.ExecuteReader();
                    odrReader.Read();
                    CellValueStr = odrReader[ColumnId - 1].ToString();  
                    return CellValueStr;
                }
            }
            catch 
            {
                return "";
            }
        }


        /// <param name="TableName">TableName</param>
        /// <param name="dgv">datagridview</param>
        /// <returns></returns>
        public static void TransferAccessToDataGridView(string TableName, DataGridView dgv,string ColTab="",string SortTab="")
        {
            string sqlstr = null;
            if (ColTab != "" && SortTab != "") { sqlstr = "select " + ColTab + " from " + TableName + " order by " + SortTab + " ASC"; }
            else if (ColTab != "" && SortTab == "") { sqlstr = "select " + ColTab + " from " + TableName; }
            else if (ColTab == "" && SortTab == "") { sqlstr = "select * from [" + TableName + "] "; }
            cmd = new OleDbCommand(sqlstr, Conn);
            adapter = new OleDbDataAdapter(cmd);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }



        /// <param name="strSql">sql</param>
        /// <returns></returns>
        public static void ExcuteSql(string strSql)
        {
            try
            {
                using (cmd = new OleDbCommand(strSql, Conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (System.Exception e)
            {
                //Console.WriteLine(e.ToString());  
                MessageBox.Show(e.Message);
            }
        }


        


    }

}