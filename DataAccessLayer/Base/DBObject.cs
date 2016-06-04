using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Configuration;
using DataAccess.Base;
using System.Windows.Forms;

namespace DataAccessLayer.Base
{
    public abstract class DBObject
    {

        public string path = AppDomain.CurrentDomain.BaseDirectory;

        protected static SqlConnection Connection;
        private static SqlTransaction sqlTran;

        DataSet sqlDataSet;
        SqlDataAdapter sqlDataAdapter;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        SqlBulkCopy sqlBulkCopy;

        static OleDbConnection oleConnection;
        OleDbCommand oleCommand;
        OleDbDataReader oleDataReader;

        public DBObject()
        {
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(path + "ConnectionString.xml");

            //XmlNodeList conStr = xmlDoc.GetElementsByTagName("ConnectionString");
            //string c = conStr[0].InnerText;

            //int indexOfPass = (c.IndexOf("password=") + 9);
            //string encPass = c.Substring(indexOfPass).ToString();
            //int indexOfEnd = encPass.IndexOf(";");
            //encPass = encPass.Substring(0,indexOfEnd);
            //string decPass = new Security().Decrypt(encPass);
            //c = c.Substring(0, indexOfPass) + decPass + c.Substring(indexOfPass + indexOfEnd);
            string c = ConfigurationManager.ConnectionStrings["ConnectionStringKey"].ToString();
            if (Connection ==null)
            {
                Connection = new SqlConnection(c);
            }
            string olePath = "Provider=Microsoft.ACE.OLEDB.12.0;Date Source="+path+"DocNumber.accdb;Persist Security Info=False";

            if (oleConnection == null)
            {
                oleConnection = new OleDbConnection(olePath);
            }   

        }

        protected SqlConnection getConnection()
        {
            return Connection;
        }

        public int OpenConnection()
        {
            try
            {
                if (Connection.State != ConnectionState.Open)
                    Connection.Open();
                return 1;
            }
            catch (SqlException)
            {
                //frmSettings f = new frmSettings();
                //f.ShowDialog();
                //// obUi.MessageBoxError("Cannot Find Server");
                return 0;
            }
        }

        public void CloseConnection()
        {
            if (sqlTran == null)
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }

        }


        //*****************************************************************************************************//
        protected void beginTransaction()
        {
            OpenConnection();
            sqlTran = Connection.BeginTransaction();
        }

        protected void commitTransaction()
        {
            sqlTran.Commit();
            sqlTran = null;
            CloseConnection();
        }

        protected void rollbackTrancsaction()
        {
            sqlTran.Rollback();
            sqlTran = null;
            CloseConnection();
        }


        //*****************************************************************************************************//

        /// <summary>
        /// Private routine allowed only by this base class, it automates the task
        /// of building a SqlCommand object designed to obtain a return value from
        /// the stored procedure.
        /// </summary>
        /// <param name="storedProcName">Name of the stored procedure in the DB, eg. sp_DoTask</param>
        /// <param name="parameters">Array of IDataParameter objects containing parameters to the stored proc</param>
        /// <returns>Newly instantiated SqlCommand instance</returns>
        protected SqlCommand BuildIntCommand(string storedProcName, IDataParameter[] parameters)
        {

            sqlCommand = BuildQueryCommand(storedProcName, parameters);

            sqlCommand.Parameters.Add(new SqlParameter("ReturnValue",
                SqlDbType.Int,
                4,
                ParameterDirection.ReturnValue,
                false, /* is nullable */
                0, /* byte precision */
                0, /* byte scale */
                string.Empty,
                DataRowVersion.Default,
                null));

            return sqlCommand;
        }

        /// <summary>
        /// Builds a SqlCommand designed to return a SqlDataReader, and not
        /// an actual integer value.
        /// </summary>
        /// <param name="storedProcName">Name of the stored procedure</param>
        /// <param name="parameters">Array of IDataParameter objects</param>
        /// <returns></returns>
        protected SqlCommand BuildQueryCommand(string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command;

            if (sqlTran != null)
            {
                command = new SqlCommand(storedProcName, Connection, sqlTran);
            }
            else
            {
                command = new SqlCommand(storedProcName, Connection);
            }

            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }
            return command;
        }
        protected SqlCommand BuildQueryCommandTransaction(string storedProcName, IDataParameter[] parameters, SqlTransaction transaction)
        {
            SqlCommand command = new SqlCommand(storedProcName, Connection);
            command.Transaction = transaction;// Assign Transaction to Command
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }
            return command;
        }

        //*** Run Procedure Functions **************************************************************************************************//
        /// <summary>
        /// Runs a stored procedure, can only be called by those classes deriving
        /// from this base. It returns an integer indicating the return value of the
        /// stored procedure, and also returns the value of the RowsAffected aspect
        /// of the stored procedure that is returned by the ExecuteNonQuery method.
        /// </summary>
        /// <param name="storedProcName">Name of the stored procedure</param>
        /// <param name="parameters">Array of IDataParameter objects</param>
        /// <param name="rowsAffected">Number of rows affected by the stored procedure.</param>
        /// <returns>An integer indicating return value of the stored procedure</returns>
        protected int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)
        {
            int result;

            OpenConnection();
            SqlCommand command = BuildIntCommand(storedProcName, parameters);
            rowsAffected = command.ExecuteNonQuery();
            result = (int)command.Parameters["ReturnValue"].Value;

            CloseConnection();

            //return result;
            return rowsAffected;
        }

        protected DataSet RunProcedure(string storedProcName)
        {
            OpenConnection();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = BuildQueryCommand(storedProcName, new IDataParameter[] { });
            sqlDA.Fill(dataSet);
            CloseConnection();

            return dataSet;
        }

        protected DataSet RunProcedure(string storedProcName, string tableName)
        {
            OpenConnection();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = BuildQueryCommand(storedProcName, new IDataParameter[] { });
            sqlDA.Fill(dataSet, tableName);
            CloseConnection();

            return dataSet;
        }
        protected SqlDataReader ReadProcedure(string storedProcName, IDataParameter[] parameters)
        {
            SqlDataReader returnReader;

            OpenConnection();

            SqlCommand command = BuildQueryCommand(storedProcName, parameters);
            command.CommandType = CommandType.StoredProcedure;

            returnReader = command.ExecuteReader();
            //Connection.Close();
            //CloseConnection();
            return returnReader;
        }
        protected DataSet RunProcedure(string storedProcName, IDataParameter[] parameters)
        {
            int i = OpenConnection();
            DataSet dataSet = new DataSet();
            if (i == 0)
                return dataSet;

            SqlDataAdapter sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = BuildQueryCommand(storedProcName, parameters);
            sqlDA.Fill(dataSet);
            CloseConnection();

            return dataSet;
        }

        /// <summary>
        /// Creates a DataSet by running the stored procedure and placing the results
        /// of the query/proc into the given tablename.
        /// </summary>
        /// <param name="storedProcName"></param>
        /// <param name="parameters"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        /// -------------------------------------------------------------------------------------------------------------------------
        protected DataSet RunProcedureTransaction(string storedProcName, IDataParameter[] parameters, string tableName, SqlTransaction trans)
        {
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            if (trans != null)
            {
                sqlDA.SelectCommand = BuildQueryCommandTransaction(storedProcName, parameters, trans);
            }
            else
            {
                sqlDA.SelectCommand = BuildQueryCommand(storedProcName, parameters);
            }
            sqlDA.Fill(dataSet, tableName);
            //Connection.Close();

            return dataSet;
        }
        protected DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            OpenConnection();
            //if (Connection.State != ConnectionState.Open)


            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = BuildQueryCommand(storedProcName, parameters);
            sqlDA.Fill(dataSet, tableName);
            CloseConnection();
            return dataSet;
        }
        protected int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected, SqlTransaction sqlTrans)
        {
            try
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }
                SqlCommand command = BuildQueryCommandTransaction(storedProcName, parameters, sqlTrans);
                command.Transaction = sqlTrans;
                rowsAffected = command.ExecuteNonQuery();
                return rowsAffected;
            }

            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Will run a stored procedure, can only be called by those classes deriving
        /// from this base. It returns a SqlDataReader containing the result of the stored
        /// procedure.
        /// </summary>
        /// <param name="storedProcName">Name of the stored procedure</param>
        /// <param name="parameters">Array of parameters to be passed to the procedure</param>
        /// <returns>A newly instantiated SqlDataReader object</returns>
        protected SqlDataReader RunProcedure1(string storedProcName, IDataParameter[] parameters)
        {
            SqlDataReader returnReader;
            OpenConnection();
            SqlCommand command = BuildQueryCommand(storedProcName, parameters);
            command.CommandType = CommandType.StoredProcedure;

            returnReader = command.ExecuteReader();
            //Connection.Close();

            return returnReader;
        }

        protected string singleDataReadThroughSp(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            OpenConnection();

            SqlCommand sqlCmd = BuildIntCommand(storedProcName, parameters);
            sqlDataReader = sqlCmd.ExecuteReader();
            string strValue;

            if (sqlDataReader.Read())
            {
                strValue = sqlDataReader.GetValue(0).ToString();
                sqlDataReader.Close();
                CloseConnection();

                return strValue;
            }
            else
            {
                sqlDataReader.Close();
                return null;
            }
        }
        protected bool CheckExistance(string storedProcName, IDataParameter[] parameters)
        {

            sqlDataReader = ReadProcedure(storedProcName, parameters);
            OpenConnection();
            if (sqlDataReader.Read())
            {
                sqlDataReader.Close();
                return true;
            }
            sqlDataReader.Close();
            CloseConnection();
            return false;
        }



        //**** Run SQL Command - Functions *************************************************************************************************//

        protected int RunSqlCommand(string sqlQuery)
        {
            int rowsAffected = 0;
            //int result;
            SqlCommand com = new SqlCommand(sqlQuery);

            if (Connection.State == ConnectionState.Closed)
                OpenConnection();

            com.Connection = this.getConnection();
            if (sqlTran != null)
                com.Transaction = sqlTran;

            rowsAffected = com.ExecuteNonQuery();
            //result = (int)sqlCommand.Parameters["ReturnValue"].Value;

            CloseConnection();

            //return result;
            return rowsAffected;
        }

        protected DataSet RunSqlCommandWithOutTableName(string sqlQuery)
        {
            SqlCommand com = new SqlCommand(sqlQuery);

            if (Connection.State == ConnectionState.Closed)
                OpenConnection();

            com.Connection = this.getConnection();
            if (sqlTran != null)
                com.Transaction = sqlTran;

            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = com;
            sqlDA.Fill(dataSet);
            CloseConnection();
            return dataSet;
        }

        protected DataSet RunSqlCommand(string sqlQuery, string tableName)
        {
            if (Connection.State == ConnectionState.Closed)
                OpenConnection();

            SqlCommand com = new SqlCommand(sqlQuery);
            com.Connection = this.getConnection();
            if (sqlTran != null)
                com.Transaction = sqlTran;

            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = com;
            sqlDA.Fill(dataSet, tableName);
            CloseConnection();
            return dataSet;
        }



        //**** Run OLEDB Command - Functions *************************************************************************************************//

        protected int RunOleDbCommand(OleDbCommand OleDbCommand)
        {
            if (!(oleConnection.State == ConnectionState.Open))
            {
                oleConnection.Open();
            }
            OleDbCommand.Connection = oleConnection;
            int RowsAff = OleDbCommand.ExecuteNonQuery();
            oleConnection.Close();
            return RowsAff;
        }

        protected DataSet RunOleDbCommand(OleDbCommand OleDbCommand, string tableName)
        {
            if (!(oleConnection.State == ConnectionState.Open))
            {
                oleConnection.Open();
            }
            OleDbCommand.Connection = oleConnection;
            DataSet dataSet = new DataSet();
            OleDbDataAdapter oleDbDA = new OleDbDataAdapter();
            oleDbDA.SelectCommand = OleDbCommand;
            oleDbDA.Fill(dataSet, tableName);
            oleConnection.Close();
            return dataSet;
        }

        protected int executeNonQueryToAccDb(string strInsertQuery)
        {
            if (!(oleConnection.State == ConnectionState.Open))
            {
                oleConnection.Open();
            }
            oleCommand = new OleDbCommand();
            oleCommand.Connection = oleConnection;
            oleCommand.CommandText = strInsertQuery;
            int rowsAff = oleCommand.ExecuteNonQuery();
            return rowsAff;
        }

        protected string retreiveSingleValueFromTempDb(string strSelectQuery)
        {
            if (!(oleConnection.State == ConnectionState.Open))
            {
                oleConnection.Open();
            }

            oleCommand = new OleDbCommand(strSelectQuery, oleConnection);
            oleDataReader = oleCommand.ExecuteReader();
            string strValue;

            if (oleDataReader.Read())
            {
                strValue = oleDataReader.GetValue(0).ToString();
                oleDataReader.Close();
                Connection.Close();
                return strValue;
            }
            else
            {
                return null;
            }
        }


        //*****************************************************************************************************//


        protected string singleDataRead(string sqlStr)
        {
            OpenConnection();
            sqlCommand = new SqlCommand(sqlStr, Connection);
            sqlDataReader = sqlCommand.ExecuteReader();
            string strValue;

            if (sqlDataReader.Read())
            {
                strValue = sqlDataReader.GetValue(0).ToString();
                sqlDataReader.Close();
                CloseConnection();
                return strValue;
            }
            else
            {
                return null;
            }
            Connection.Close();
        }

        /// <summary>
        /// Reading a Last (single) value from a DataSet  
        /// </summary>
        /// <param name="DataSet">DataSet Name</param>
        /// <param name="ColumnName">Column Name of DataSet</param>
        /// <returns>Last Value of specified Column</returns>
        public string singleDataReadInDataSet(DataSet DataSet, string ColumnName)
        {
            string retValue = "";
            foreach (DataRow dr in DataSet.Tables[0].Rows)
            {
                retValue = dr[ColumnName].ToString();
            }
            return retValue;
        }

        public DataSet getDataSet(string strSqlCmd)
        {
            sqlDataAdapter = new SqlDataAdapter(strSqlCmd, Connection);
            sqlDataSet = new DataSet();
            sqlDataAdapter.Fill(sqlDataSet);
            return sqlDataSet;
        }

        protected void InsertdataBulk(string tblName, DataTable dt)
        {
            sqlBulkCopy = new SqlBulkCopy(Connection);
            sqlBulkCopy.DestinationTableName = tblName;
            sqlBulkCopy.WriteToServer(dt);

        }

        protected void FillCombo(string sqlstr, ComboBox cmb, bool cmbOption)
        {
            int a = 0;
            int b = 0;
            string c = "";

            DataSet d = this.getDataSet(sqlstr);

            b = this.getDataSet(sqlstr).Tables[0].Rows.Count;

            if (cmbOption)
            {
                cmb.Items.Add("--SELECT--");
            }

            cmb.Items.Clear();

            for (a = 0; a < b; a++)
            {
                //c = cmb.GetItemText(d.Tables(0).Rows(a).Item(0))
                //c = d.Tables[0].Rows[a].Item;
                //c = d.Tables[0].Rows[a][0].ToString();
                c = d.Tables[0].Rows[a][0].ToString();
                cmb.Items.Add(c);
            }
            try
            {
                cmb.SelectedIndex = 0;
            }
            catch (Exception)
            { }
        }
        //============================================================================
        //public void ExcelToDb(string browseFile)
        //{
        //    try
        //    {
        //        string excelConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + browseFile + "';Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";



        //        // Create Connection to Excel Workbook

        //        using (OleDbConnection connection = new OleDbConnection(excelConnectionString))
        //        {

        //            OleDbCommand command = new OleDbCommand("Select * FROM [Sheet1$]", connection);



        //            connection.Open();
        //            Connection.Open();
        //            // OpenConnection();

        //            // Create DbDataReader to Data Worksheet

        //            using (DbDataReader dr = command.ExecuteReader())
        //            {

        //                // SQL Server Connection String

        //                //   string sqlConnectionString = "Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=TestDb;Integrated Security=True";



        //                // Bulk Copy to SQL Server

        //                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(Connection))
        //                {
        //                    bulkCopy.ColumnMappings.Add("Dept", "Dept");
        //                    bulkCopy.ColumnMappings.Add("UserID", "UserID");
        //                    bulkCopy.ColumnMappings.Add("Name", "EmpName");
        //                    bulkCopy.ColumnMappings.Add("Date", "Date");
        //                    bulkCopy.ColumnMappings.Add("Time", "Time");
        //                    bulkCopy.ColumnMappings.Add("AttType", "InOut");
        //                    bulkCopy.DestinationTableName = "Attendance";

        //                    bulkCopy.WriteToServer(dr);

        //                }
        //                connection.Close();
        //            }

        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }

        //}
        //public void AccessToMs()
        //{
        //    string connectionString = SystemInfo.AccessConString;
        //    //const string connectionStringDest = "YOUR SQL SERVER CONNECTION STRING";
        //    using (var sourceConnection =
        //          new OleDbConnection(connectionString))
        //    {
        //        sourceConnection.Open();

        //        var commandSourceData = new OleDbCommand(
        //            "Select * from ras_AttRecord", sourceConnection);
        //        var reader =
        //            commandSourceData.ExecuteReader();

        //        //using (var destinationConnection =
        //        //           new SqlConnection(connectionStringDest))
        //        //{
        //        Connection.Open();

        //        using (var bulkCopy =
        //                   new SqlBulkCopy(Connection))
        //        {
        //            bulkCopy.DestinationTableName =
        //                "ras_AttRecord";

        //            try
        //            {
        //                bulkCopy.WriteToServer(reader);
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //            finally
        //            {
        //                reader.Close();
        //            }
        //        }
        //        // }
        //    }
        //}
        //*****************************************************************************************************//                      
        //Added by kalana.
        public string RunSPWithOutParameter(string storedProcName, IDataParameter[] parameters, string OutParaName)
        {
            //int scope = 0;
            string status = null;
            SqlParameter statusParam = new SqlParameter();
            //SqlParameter identityParam = new SqlParameter();
            sqlCommand = BuildQueryCommand(storedProcName, parameters);
            //identityParam = sqlCommand.Parameters.Add("@scopeId", SqlDbType.Int, 4);
            statusParam = sqlCommand.Parameters.Add(OutParaName, SqlDbType.VarChar, 100);
            //identityParam.Direction = ParameterDirection.ReturnValue;
            statusParam.Direction = ParameterDirection.Output;
            OpenConnection();
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
            //scope = Int32.Parse(identityParam.Value.ToString());
            status = statusParam.Value.ToString();
            sqlCommand.Dispose();
            return status;
        }

        //Thilina Added From PELa ERP
        public DataSet GetDataSet(SqlCommand SqlCmd, string TableName)
        {
            OpenConnection();
            DataSet SqlDS = new DataSet();
            try
            {
                SqlCmd.Connection = Connection;
                SqlDataAdapter Sqldap = new SqlDataAdapter(SqlCmd);
                Sqldap.Fill(SqlDS, TableName);
                return SqlDS;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                CloseConnection();
            }
        }

        //Originally Coded By kalana For PELa ERP - Added To This By Thilina
        public string getSingleDataThroughSP(string storedProcName, SqlParameter[] parameter)
        {

            if (!(Connection.State == ConnectionState.Open))
            {
                Connection.Open();
            }
            SqlCommand sqlCmd = BuildQueryCommand(storedProcName, parameter);
            String value = sqlCmd.ExecuteScalar().ToString();
            if (!(Connection.State == ConnectionState.Closed))
            {
                Connection.Close();
            }
            return value;

        }


    }
}
