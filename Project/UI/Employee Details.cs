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
    public partial class Employee_Details : Form
    {
	DB_Connection dbcon = new DB_Connection();
        public Employee_Details()
        {
            InitializeComponent();
        }
    private void Employee_Details_Load(object sender, EventArgs e)
        {
            loadGridData();
            txt_increment_ID();
            Designation_Load();
            Gender_Load();


        }

        private void loadGridData()
        {
            try
            {
                string query = "select * from Staff_Master Order by Employee_ID";
                DataTable dt1 = new DataTable();
                dt1 = dbcon.data_table(query);
                DGV_Employee.DataSource = dt1;

            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        private void txt_increment_ID()
        {
            string Query = "select MAX(Employee_ID) from Staff_Master";
            int new_ID = dbcon.increment_ID(Query);
            txt_emp_id.Text = new_ID.ToString();
        }

        enum Designation
        {
            Manager, Cashier,Salesman
        };

        private void Designation_Load()
        {
            cmb_designation.DataSource = Enum.GetValues(typeof(Designation));


        }


        enum Gender
        {
            F, M
        };

        private void Gender_Load()
        {
            cmb_gender.DataSource = Enum.GetValues(typeof(Gender));


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int noline = 0;
                string id = txt_emp_id.Text;
                string fname = txt_emp_Fname.Text;
                string lname = txt_emp_Lname.Text;                               
                string addNo = txt_emp_AddNo.Text;
                string addStreet = txt_emp_AddStreet.Text;
                string addCity = txt_emp_AddCity.Text;
                string nic = txt_emp_nic.Text;
                DateTime dob = DTP_dob.Value.Date;
                DateTime doj = DTP_doj.Value.Date;
                string desig = cmb_designation.SelectedItem.ToString();
                string gender = cmb_gender.SelectedItem.ToString();
                // string c1 = txt_Contact1.Text;
                //  string c2 = txt_contact2.Text;

                bool valid = false;
                valid = validate();
                if (valid == false)
                {
                    MessageBox.Show("Please Insert Data...! ");
                }

                else
                {
                    string query = "insert into Staff_Master values('" + id + "','" + fname + "','" + lname + "','" + addNo + "','" + addStreet + "','" + addCity + "','" + nic + "','" + dob + "','" + doj + "','" + desig + "','"+gender+"')";
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

        private void DGV_Employee_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_emp_id.Text = DGV_Employee.CurrentRow.Cells["Employee_ID"].Value.ToString();
            txt_emp_Fname.Text = DGV_Employee.CurrentRow.Cells["Employee_Fname"].Value.ToString();
            txt_emp_Lname.Text = DGV_Employee.CurrentRow.Cells["Employee_Lname"].Value.ToString();
            txt_emp_AddNo.Text = DGV_Employee.CurrentRow.Cells["Emp_AddNo"].Value.ToString();
            txt_emp_AddStreet.Text = DGV_Employee.CurrentRow.Cells["Emp_AddStreet"].Value.ToString();
            txt_emp_AddCity.Text = DGV_Employee.CurrentRow.Cells["Emp_AddCity"].Value.ToString();
            txt_emp_nic.Text = DGV_Employee.CurrentRow.Cells["Employee_NIC"].Value.ToString();
            DTP_dob.Value = Convert.ToDateTime(DGV_Employee.CurrentRow.Cells["Employee_DOB"].Value.ToString());
            DTP_doj.Value = Convert.ToDateTime(DGV_Employee.CurrentRow.Cells["Employee_DOJ"].Value.ToString());
            cmb_designation.Text = DGV_Employee.CurrentRow.Cells["Employee_Designation"].Value.ToString();
            cmb_gender.Text = DGV_Employee.CurrentRow.Cells["Gender"].Value.ToString();
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                
                string fname = txt_emp_Fname.Text;
                string lname = txt_emp_Lname.Text;               
                string addNo = txt_emp_AddNo.Text;
                string addStreet = txt_emp_AddStreet.Text;
                string addCity = txt_emp_AddCity.Text;
                string nic = txt_emp_nic.Text;
                DateTime dob = DTP_dob.Value.Date;
                DateTime doj = DTP_doj.Value.Date;
                string desig = cmb_designation.SelectedText;
                string gender = cmb_gender.SelectedText;
                //   string c1 = txt_Contact1.Text;
                //  string c2 = txt_contact2.Text;

                int line = 0;

                DialogResult dr = MessageBox.Show("Do you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr.ToString() == "Yes")
                {
                    string id = DGV_Employee.CurrentRow.Cells[0].Value.ToString();

                    string query = "update Staff_Master set Employee_Fname='" + fname + "', Employee_Lname='" + lname + "',Emp_AddNo='" + addNo + "',Emp_AddStreet='" + addStreet + "',Emp_AddCity='" + addCity + "',Employee_NIC='" + nic + "',Employee_DOB='" + dob + "',Employee_DOJ ='" + doj + "',Employee_Designation='" + desig + "',Gender='" + gender + "' where Employee_ID='" + id + "'";

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
                string emp_id = DGV_Employee.CurrentRow.Cells[0].Value.ToString();
                string query = "delete from Staff_Master where Employee_ID='" + emp_id + "'";
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
            txt_emp_id.Text = "";
            txt_emp_Fname.Text = "";
            txt_emp_Lname.Text = "";
            txt_emp_AddNo.Text = "";
            txt_emp_AddStreet.Text = "";
            txt_emp_AddCity.Text = "";
            txt_emp_nic.Text = "";
            DTP_dob.Value = DateTime.Today.Date;
            cmb_designation.Text = "";
            DTP_doj.Value = DateTime.Today.Date;
            cmb_gender.Text = "";


        }

     

        private bool validate()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txt_emp_Fname.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_emp_Lname.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_emp_AddNo.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_emp_AddStreet.Text))
            {
                result = false;
            }


            if (string.IsNullOrEmpty(txt_emp_AddCity.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_emp_nic.Text))
            {
                result = false;
            }

                     

            return result;

        }

    }
}


