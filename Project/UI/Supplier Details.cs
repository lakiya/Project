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
    public partial class Supplier_Details : Form
    {
	DB_Connection dbcon = new DB_Connection();
        public Supplier_Details()
        {
            InitializeComponent();
        }
    private void Form1_Load(object sender, EventArgs e)
        {

            loadGridData();
            txt_increment_ID();

         //   int increment;
        }

        private void loadGridData()
        {
            try
            {
                string query = "select * from Supplier_Master Order by Supplier_ID";
                DataTable dt1 = new DataTable();
                dt1 = dbcon.data_table(query);
                dataGridView1.DataSource = dt1;

            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        private void txt_increment_ID()
        {
            string Query = "select MAX(Supplier_ID) from Supplier_Master";
            int new_ID = dbcon.increment_ID(Query);
            txt_supId.Text = new_ID.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int noline = 0;
                string id = txt_supId.Text;
                string fname = txt_supFname.Text;
                string lname = txt_supLname.Text;
                string cname = txt_CompName.Text;
                string BRId = txt_BusRegId.Text;
                string email = txt_supEmail.Text;
                string addNo = txt_AddNo.Text;
                string addStreet = txt_AddStreet.Text;
                string addCity = txt_AddCity.Text;
                DateTime doReg = DTP_DOR.Value.Date;
                // string c1 = txt_Contact1.Text;
                //  string c2 = txt_contact2.Text;

                bool valid = false;
                 valid = validate();
                if(valid == false)
                {
                    MessageBox.Show("Please Insert Data...! ");
                }

                else
                {
                    string query = "insert into Supplier_Master values('" + id + "','" + fname + "','" + lname + "','" + cname + "','" + BRId + "','" + email + "','" + addNo + "','" + addStreet + "','" + addCity + "','" + doReg + "')";
                    //string query = "insert into Supplier_Master (Supplier_ID,Supplier_Fname,Supplier_Lname, Company_Name, Business_Reg_ID, Supplier_Email, Sup_AddNo, Sup_AddStreet, Sup_AddCity, Sup_Reg_Date) OUTPUT Inserted.Supplier_ID values('" + id + "','" + fname + "','" + lname + "','" + cname + "','" + BRId + "','" + email + "','" + addNo + "','" + addStreet + "','" + addCity + "','" + doReg + "')";

                    noline = dbcon.save_del_update(query);
                    
                    if (noline > 0)
                    {
                        loadGridData();
                        clearData();
                        txt_increment_ID();
                        MessageBox.Show("Data Inserted");
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

        private void GridDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_supId.Text = dataGridView1.CurrentRow.Cells["Supplier_ID"].Value.ToString();
            txt_supFname.Text = dataGridView1.CurrentRow.Cells["Supplier_Fname"].Value.ToString();
            txt_supLname.Text = dataGridView1.CurrentRow.Cells["Supplier_Lname"].Value.ToString();
            txt_CompName.Text = dataGridView1.CurrentRow.Cells["Company_Name"].Value.ToString();
            txt_BusRegId.Text = dataGridView1.CurrentRow.Cells["Business_Reg_ID"].Value.ToString();
            txt_supEmail.Text = dataGridView1.CurrentRow.Cells["Supplier_Email"].Value.ToString();
            txt_AddNo.Text = dataGridView1.CurrentRow.Cells["Sup_AddNo"].Value.ToString();
            txt_AddStreet.Text = dataGridView1.CurrentRow.Cells["Sup_AddStreet"].Value.ToString();
            txt_AddCity.Text = dataGridView1.CurrentRow.Cells["Sup_AddCity"].Value.ToString();
            DTP_DOR.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Sup_Reg_Date"].Value.ToString());
            //txt_Contact1.Text = dataGridView1.CurrentRow.Cells["Supplier_ID"].Value.ToString();
            //txt_contact2.Text = dataGridView1.CurrentRow.Cells["Supplier_ID"].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                // string id = txt_supId.Text;
                string fname = txt_supFname.Text;
                string lname = txt_supLname.Text;
                string cname = txt_CompName.Text;
                string BRId = txt_BusRegId.Text;
                string email = txt_supEmail.Text;
                string addNo = txt_AddNo.Text;
                string addStreet = txt_AddStreet.Text;
                string addCity = txt_AddCity.Text;
                DateTime doReg = DTP_DOR.Value.Date;
                //   string c1 = txt_Contact1.Text;
                //  string c2 = txt_contact2.Text;

                int line = 0;

                DialogResult dr = MessageBox.Show("Do you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr.ToString() == "Yes")
                {
                    string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    string query = "update Supplier_Master set Supplier_Fname='" + fname + "', Supplier_Lname='" + lname + "',Company_Name='" + cname + "', Business_Reg_ID='" + BRId + "',Supplier_Email='" + email + "',Sup_AddNo='" + addNo + "',Sup_AddStreet='" + addStreet + "',Sup_AddCity='" + addCity + "',Sup_Reg_Date='" + doReg + "' where Supplier_ID='" + id + "'";

                    line = dbcon.save_del_update(query);

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
                string sup_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string query = "delete from Supplier_Master where Supplier_ID='" + sup_id + "'";
                line = dbcon.save_del_update(query);

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
            txt_supId.Text = "";
            txt_supFname.Text = "";
            txt_supLname.Text = "";
            txt_CompName.Text = "";
            txt_BusRegId.Text = "";
            txt_supEmail.Text = "";
            txt_AddNo.Text = "";
            txt_AddStreet.Text = "";
            txt_AddCity.Text = "";
            DTP_DOR.Value = DateTime.Today.Date;


        }

        private void btn_view_Click(object sender, EventArgs e)
        {

        }



        private bool validate()
        {
            bool result = true;

            if(string.IsNullOrEmpty(txt_supFname.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_supLname.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_CompName.Text))
            {
                result = false;
            }

             if (string.IsNullOrEmpty(txt_BusRegId.Text))
            {
                result = false;
            }


            if (string.IsNullOrEmpty(txt_supEmail.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_AddNo.Text))
            {
                result = false;
            }

             if (string.IsNullOrEmpty(txt_AddStreet.Text))
            {
                result = false;
            }


            if (string.IsNullOrEmpty(txt_AddCity.Text))
            {
                result = false;
            }

            //if (DTP_DOR.is)
            //{
            //    result = false;
            //}

            return result;

        }


         
            

    }
}


