using DataAccessLayer.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Main
{
    public class LogInBLL
    {

        LogInDLL logInObj = new LogInDLL();

        public bool ValidateUsers(string UserName, string Password)
        {
            try
            {
                return logInObj.ValidateUsers(UserName, Password);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
