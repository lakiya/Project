using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Projecct22012016.DB_connection
{
    public class DB
    {
        public string dataSource, userName, password, initcat, auth;

        public string constring;
        public SqlConnection con = null;
        public SqlCommand com = null;

        public DB()
        {
            
            constring = "Data Source=DESKTOP-K5E147C;Initial Catalog=Projecct22012016;Integrated Security=True";
            con = new SqlConnection(constring);

        }
        
        public SqlDataReader data_reader(string query)
        {
            SqlDataReader dr;
            con.Open();
            com = new SqlCommand(query, con);
            dr = com.ExecuteReader();
            com.Dispose();
            con.Close();
            return dr;
        }
        public DataTable selecting_date(string Query)
        {
            DataTable dt = new DataTable();
            con.Open();
            com = new SqlCommand(Query, con);
            dt.Load(com.ExecuteReader());
            com.Dispose();
            con.Close();
            return dt;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        public int save_del_update(string query)
        {
            con.Open();
            int line = 0;
            com = new SqlCommand(query, con);
            line = com.ExecuteNonQuery();
            com.Dispose();
            con.Close();
            return line;
        }
        public DataTable data_table(string Query)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(Query,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

    }
}
