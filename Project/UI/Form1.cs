using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string userName, password;
                if (string.IsNullOrWhiteSpace(txt_un.Text)) Error_UN.SetError(txt_un, "User Name is Empty...!");
                else
                {
                    Error_UN.Clear();
                     userName = txt_un.Text;
                }
                if (string.IsNullOrWhiteSpace(txt_pw.Text)) Error_PW.SetError(txt_pw, "Password is Empty....!");
                else
                {
                    Error_PW.Clear();
                    password = txt_pw.Text;
                    //if(password == "111")
                    //{
                        Main_Menu mm = new Main_Menu();
                        mm.Show();
                        Hide();
                    //}
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
