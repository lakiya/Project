using BusinessLogicLayer.Main;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkinExample.Main
{
    public partial class frmLogIn : MaterialForm
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        LogInBLL logInObj = new LogInBLL();

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text)) { lblMessage.Text = "Username and Password Fields are Required"; return; }
            ValidateUser();
        }
        
        private void ValidateUser()
        {
            if(logInObj.ValidateUsers(txtUsername.Text.ToLower(), txtPassword.Text))
            {
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Username or Password Incorrect";
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
