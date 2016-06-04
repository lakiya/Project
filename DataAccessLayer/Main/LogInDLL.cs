using DataAccessLayer.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Main
{
    public class LogInDLL : DBObject
    {
        public bool ValidateUsers(string UserName, string Password)
        {
            try
            {
                SqlParameter[] para =
                    {
                        new SqlParameter("@Username", UserName),
                        new SqlParameter("@Password", Password)
                    };

                return CheckExistance("ValidateUser", para);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
