using DBConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UI
{
    public partial class Customer_Order_View : Form
    {
        public Customer_Order_View()
        {
            InitializeComponent();
        }
		DB_Connection dbcon = new DB_Connection();
    private void Customer_Order_View_Load(object sender, EventArgs e)
        {
            View_load();
        }

        enum Select_View
        {
             Customer_Payment, Customer_Invoice
        };

        private void View_load()
        {
            cmb_View.DataSource = Enum.GetValues(typeof(Select_View));
        }

        private void Order_Invoice_Payment_load(object sender, EventArgs e)
        {
            //if (cmb_View.SelectedItem.ToString() == "Customer_Order")
            //{
            //    string query = "select * from Vehicle_Master";
            //    DataTable dt1 = new DataTable();
            //    dt1 = dbcon.data_table(query);
            //    DGV_Order_Payment_Invoice.DataSource = dt1;
               
            //}

             if (cmb_View.SelectedItem.ToString() == "Customer_Payment")
            {
                 
                string query = "select * from Customer_Payment";
                DataTable dt1 = new DataTable();
                dt1 = dbcon.data_table(query);
                DGV_Order_Payment_Invoice.DataSource = dt1;
                
            }

            else if (cmb_View.SelectedItem.ToString() == "Customer_Invoice")
            {
                string query = "select * from Invoice_Detail";
                DataTable dt1 = new DataTable();
                dt1 = dbcon.data_table(query);
                DGV_Order_Payment_Invoice.DataSource = dt1;
                

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DGV_Order_Payment_Invoice.DataSource = "";
        }

       
    }


}
