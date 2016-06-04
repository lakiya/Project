using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Class
{
    class DB_Connection
    {
        public string DataSource, UserName, Password, Initcat, Auth;

        public string constring;
        public SqlConnection con = null;
        public SqlCommand com = null;

        public DB_Connection()
        {
            get_Server_Info();

        }

        public void get_Server_Info()
        {
            try
            {
                DataSource = "";
                UserName = "";
                Password = "";
                Initcat = "";
                Auth = "";

                DataSource = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "\\Server.txt", Encoding.UTF8).ToString().Trim();
                UserName = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "\\UserName.sys", Encoding.UTF8).ToString().Trim();
                Password = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "\\Password.sys", Encoding.UTF8).ToString().Trim();
                Initcat = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "\\Initcat.sys", Encoding.UTF8).ToString().Trim();
                Auth = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "\\Auth.sys", Encoding.UTF8).ToString().Trim();

                Connection_Sql();

            }

            catch (Exception e)
            {

                throw e;
                //   return e.ToString();


            }
        }


        public void Connection_Sql()
        {
            if (Auth == "sql")

                constring = "Data Source='" + DataSource + "';Initial Catalog='" + Initcat + "';User Name='" + UserName + "';password = '" + Password + "';Integrated Security=True";

            else
                constring = "Data Source='" + DataSource + "';Initial Catalog='" + Initcat + "';Integrated Security=True";


            con = new SqlConnection(constring);

        }

        public void open()
        {
            con.Open();
        }


        public void close()
        {
            con.Close();

        }

        public SqlDataReader data_reader(string query)
        {
            SqlDataReader dr;
            open();
            com = new SqlCommand(query, con);
            dr = com.ExecuteReader();
            com.Dispose();
            close();
            return dr;

        }

        public int save_del_update(string query)
        {
            open();
            int line = 0;
            com = new SqlCommand(query, con);
            line = com.ExecuteNonQuery();
            com.Dispose();
            close();
            return line;

        }

        public int increment_ID(string Query)
        {
            int increment = 0;
            open();
            com = new SqlCommand(Query, con);
            com.CommandType = CommandType.Text;

            try
            {
                increment = Convert.ToInt32(com.ExecuteScalar());
                increment = increment + 1;
                return increment;
            }

            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                close();
            }
        }

        public DataTable data_table(string query)
        {
            open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            close();
            return dt;

        }




    }
}


