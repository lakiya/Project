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
    public partial class Vehicle_Parts_Details : Form
    {
        DB_Connection dbcon = new DB_Connection();
        public Vehicle_Parts_Details()
        {
            InitializeComponent();
        }
    private void Vehicle_Parts_Details_Load(object sender, EventArgs e)
        {
            loadGridData();
            txt_increment_ID();
        }

        private void loadGridData()
        {
            try
            {
                string query = "select * from Vehicle_Parts Order by Vehicle_P_ID";
                DataTable dt1 = new DataTable();
                dt1 = dbcon.data_table(query);
                DGV_VehicleParts.DataSource = dt1;

            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        private void txt_increment_ID()
        {
            string Query = "select MAX(Vehicle_P_ID) from Vehicle_Parts";
            int new_ID = dbcon.increment_ID(Query);
            txt_Vp_id.Text = new_ID.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int noline = 0;
                int vp_id = Convert.ToInt32(txt_Vp_id.Text);
                string desc = txt_Desc.Text;
                decimal price = Convert.ToDecimal(txt_Vp_Price.Text);
                              

                bool valid = false;
                valid = validate();
                if (valid == false)
                {
                    MessageBox.Show("Please Insert Data...! ");
                }

                else
                {
                    string query = "insert into Vehicle_Parts values('" + vp_id + "','" + desc + "','" + price + "')";
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

        private void DGV_VehicleParts_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Vp_id.Text = DGV_VehicleParts.CurrentRow.Cells["Vehicle_P_ID"].Value.ToString();
            txt_Desc.Text = DGV_VehicleParts.CurrentRow.Cells["Description"].Value.ToString();
            txt_Vp_Price.Text = DGV_VehicleParts.CurrentRow.Cells["Price"].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                // string id = txt_supId.Text;
                int vp_id = Convert.ToInt32(txt_Vp_id.Text);
                string desc = txt_Desc.Text;
                decimal price = Convert.ToDecimal(txt_Vp_Price.Text);
                

                int line = 0;

                DialogResult dr = MessageBox.Show("Do you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr.ToString() == "Yes")
                {
                    string id = DGV_VehicleParts.CurrentRow.Cells[0].Value.ToString();

                    string query = "update Vehicle_Parts set Description='" + desc + "', Price='" + price + "' where Vehicle_P_ID='" + vp_id + "'";

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
                int vp_id = Convert.ToInt32(DGV_VehicleParts.CurrentRow.Cells[0].Value.ToString());
                string query = "delete from Vehicle_Parts where Vehicle_P_ID='" + vp_id + "'";
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
            txt_Vp_id.Text = "";
            txt_Desc.Text = "";
            txt_Vp_Price.Text = "";
           

        }

        private bool validate()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txt_Desc.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_Vp_Price.Text))
            {
                result = false;
            }

            return result;
        }

    }

  }
  

