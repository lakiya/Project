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
    public partial class Customer_Details : Form
    {
        public Customer_Details()
        {
            InitializeComponent();
        }
    DB_Connection dbcon2 = new DB_Connection();
        private void New_Customer_Load(object sender, EventArgs e)
        {
            loadGridData();
            txt_increment_ID();
        }

        private void loadGridData()
        {
            try
            {
                string query = "select * from Customer_Master Order by Customer_ID";
                DataTable dt1 = new DataTable();
                dt1 = dbcon2.data_table(query);
                DGV_Customer.DataSource = dt1;

            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        private void txt_increment_ID()
        {
            string Query = "select MAX(Customer_ID) from Customer_Master";
            int new_ID = dbcon2.increment_ID(Query);
            txt_cust_id.Text = new_ID.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int noline = 0;
                int id = Convert.ToInt32(txt_cust_id.Text);
                string fname = txt_cust_Fname.Text;
                string lname = txt_cust_Lname.Text;
                string email = txt_cust_Email.Text;
                string addNo = txt_cust_AddNo.Text;
                string addStreet = txt_cust_AddStreet.Text;
                string addCity = txt_cust_AddCity.Text;
                string nic = txt_cust_NIC.Text;
                // string c1 = txt_cust_Contact1.Text;
                //  string c2 = txt_cust_Contact2.Text;

                bool valid = false;
                valid = validate();
                if (valid == false)
                {
                    MessageBox.Show("Please Insert Data...! ");
                }

                else
                {
                    string query = "insert into Customer_Master values('" + id + "','" + fname + "','" + lname + "','" + addNo + "','" + addStreet + "','" + addCity + "','" + nic + "','" + email + "')";
                    //string query = "insert into Supplier_Master (Supplier_ID,Supplier_Fname,Supplier_Lname, Company_Name, Business_Reg_ID, Supplier_Email, Sup_AddNo, Sup_AddStreet, Sup_AddCity, Sup_Reg_Date) OUTPUT Inserted.Supplier_ID values('" + id + "','" + fname + "','" + lname + "','" + cname + "','" + BRId + "','" + email + "','" + addNo + "','" + addStreet + "','" + addCity + "','" + doReg + "')";

                    noline = dbcon2.save_del_update(query);

                    if (noline > 0)
                    {
                        loadGridData();
                        clearData();
                        txt_increment_ID();
                        MessageBox.Show("Data Inserted");

                        int cust_id = Convert.ToInt32(txt_cust_id.Text);
                        Customer_Order n1 = new Customer_Order(cust_id);
                        n1.Show();
                      
                    }

                    else
                        MessageBox.Show("Data Not Inserted");

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void DGV_Customer_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cust_Fname.Text = DGV_Customer.CurrentRow.Cells["Customer_ID"].Value.ToString();
            txt_cust_Fname.Text = DGV_Customer.CurrentRow.Cells["Customer_Fname"].Value.ToString();
            txt_cust_Lname.Text = DGV_Customer.CurrentRow.Cells["Customer_Lname"].Value.ToString();
            txt_cust_AddNo.Text = DGV_Customer.CurrentRow.Cells["Cust_AddNo"].Value.ToString();
            txt_cust_AddStreet.Text = DGV_Customer.CurrentRow.Cells["Cust_AddStreet"].Value.ToString();
            txt_cust_AddCity.Text = DGV_Customer.CurrentRow.Cells["Cust_AddCity"].Value.ToString();
            txt_cust_NIC.Text = DGV_Customer.CurrentRow.Cells["Customer_NIC"].Value.ToString();
            txt_cust_Email.Text = DGV_Customer.CurrentRow.Cells["Customer_Email"].Value.ToString();
            
            //txt_Contact1.Text = dataGridView1.CurrentRow.Cells["Supplier_ID"].Value.ToString();
            //txt_contact2.Text = dataGridView1.CurrentRow.Cells["Supplier_ID"].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                
                int id = Convert.ToInt32(txt_cust_id.Text);
                string fname = txt_cust_Fname.Text;
                string lname = txt_cust_Lname.Text;
                string email = txt_cust_Email.Text;
                string addNo = txt_cust_AddNo.Text;
                string addStreet = txt_cust_AddStreet.Text;
                string addCity = txt_cust_AddCity.Text;
                string nic = txt_cust_NIC.Text;
                // string c1 = txt_cust_Contact1.Text;
                //  string c2 = txt_cust_Contact2.Text;

                int line = 0;

                DialogResult dr = MessageBox.Show("Do you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr.ToString() == "Yes")
                {
                     id = Convert.ToInt32(DGV_Customer.CurrentRow.Cells[0].Value.ToString());

                     string query = "update Customer_Master set Customer_Fname='" + fname + "', Customer_Lname='" + lname + "',Cust_AddNo='" + addNo + "', Cust_AddStreet='" + addStreet + "',Cust_AddCity='" + addCity + "',Customer_NIC='" + nic + "',Customer_Email='" + email + "' where Supplier_ID='" + id + "'";

                    line = dbcon2.save_del_update(query);

                    if (line > 0)
                    {
                        loadGridData();
                        clearData();
                        txt_increment_ID();
                        MessageBox.Show("Data Updated");

                    }

                    else
                        MessageBox.Show("Data Not Updated");

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int line = 0;
            DialogResult dr = MessageBox.Show("Do You want to delete ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr.ToString() == "Yes")
            {
                string id = DGV_Customer.CurrentRow.Cells[0].Value.ToString();
                string query = "delete from Customer_Master where Customer_ID='" + id + "'";
                line = dbcon2.save_del_update(query);

                if (line > 0)
                {
                    loadGridData();
                    clearData();
                    txt_increment_ID();
                    MessageBox.Show("Data Deleted");

                }

                else
                    MessageBox.Show("Data Not Deleted");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearData();
            txt_increment_ID();
        }

        private void clearData()
        {
            txt_cust_id.Text = "";
            txt_cust_Fname.Text = "";
            txt_cust_Lname.Text = "";
            txt_cust_AddNo.Text = "";
            txt_cust_AddStreet.Text = "";
            txt_cust_AddCity.Text = "";
            txt_cust_Email.Text = "";
            txt_cust_NIC.Text = "";
           // txt_cust_Contact1.Text ="";
           // txt_cust_Contact2.Text ="";


        }


        private bool validate()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txt_cust_Fname.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_cust_Lname.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_cust_AddNo.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_cust_AddStreet.Text))
            {
                result = false;
            }


            if (string.IsNullOrEmpty(txt_cust_AddCity.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_cust_Email.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_cust_NIC.Text))
            {
                result = false;
            }
         

            return result;

        }
    }
}


 

