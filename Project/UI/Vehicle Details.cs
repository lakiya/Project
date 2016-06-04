using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBConnection;
//using Projecct22012016.DB_connection;
namespace Project
{
    public partial class Vehicle_Details : Form
    {
        DB_Connection dbcon = new DB_Connection();
        //DB db = new DB();
        public Vehicle_Details()
        {
            InitializeComponent();
        }
		
		private void Vehicle_Details_Load(object sender, EventArgs e)
        {
            loadGridData();
            txt_increment_ID();
            Brand_load();
            Coulur_load();
        }


        private void loadGridData()
        {
            try
            {
                string query = "select * from Vehicle_Master";
                DataTable dt1 = new DataTable();
                dt1 = dbcon.data_table(query);
                DGV_Vehicle.DataSource = dt1;

            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }


        private void txt_increment_ID()
        {
            string Query = "select MAX(Vehicle_ID) from Vehicle_Master";
            int new_ID = dbcon.increment_ID(Query);
            txt_vid.Text = new_ID.ToString();
        }


        enum Brand
        {
            Nissan, Toyota, Mitsubishi
        };

        private void Brand_load()
        {
            cmb_brand.DataSource = Enum.GetValues(typeof(Brand));


        }


        enum Colour
        {
            Red, White, Black, Dark_Blue, Sky_Blue
        };

        private void Coulur_load()
        {
            cmb_colour.DataSource = Enum.GetValues(typeof(Colour));


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int noline = 0;
                string id = txt_vid.Text;
                string chassyNo = txt_chassyNo.Text;
                string brand = cmb_brand.SelectedText;
                string colour = cmb_colour.SelectedText;
                string year = txt_year.Text;
                string model = txt_model.Text;
                string fuel = txt_fuel.Text;
                int capacity = Convert.ToInt32(txt_capacity.Text);
                int cylinders = Convert.ToInt32(txt_cylinders.Text);
                decimal pur_price = Convert.ToDecimal(txt_pur_price.Text);
                decimal sales_price = Convert.ToDecimal(txt_sales_price.Text);
                DateTime reg_date = DTP_reg_date.Value.Date;
                DateTime expire_date = DTP_expire_date.Value.Date;
                int seats = Convert.ToInt32(txt_seats.Text);
                string status = txt_status.Text;
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
                    string query = "insert into Vehicle_Master values('" + id + "','" + chassyNo + "','" + brand + "','" + colour + "','" + year + "','" + model + "','" + fuel + "','" + capacity + "','" + cylinders + "','" + pur_price + "','" + sales_price + "','" + reg_date + "','" + expire_date + "','" + seats + "','" + status + "')";
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

        private void DGV_Vehicle_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_vid.Text = DGV_Vehicle.CurrentRow.Cells["Vehicle_ID"].Value.ToString();
            txt_chassyNo.Text = DGV_Vehicle.CurrentRow.Cells["Chassy_No"].Value.ToString();
            cmb_brand.SelectedText = DGV_Vehicle.CurrentRow.Cells["Brand"].Value.ToString();
            cmb_colour.SelectedText = DGV_Vehicle.CurrentRow.Cells["Color"].Value.ToString();
            txt_year.Text = DGV_Vehicle.CurrentRow.Cells["Year"].Value.ToString();
            txt_model.Text = DGV_Vehicle.CurrentRow.Cells["Model"].Value.ToString();
            txt_fuel.Text = DGV_Vehicle.CurrentRow.Cells["Fuel"].Value.ToString();
            txt_capacity.Text = DGV_Vehicle.CurrentRow.Cells["Engine_Capacity"].Value.ToString();
            txt_cylinders.Text = DGV_Vehicle.CurrentRow.Cells["Cylinders"].Value.ToString();
            txt_pur_price.Text = DGV_Vehicle.CurrentRow.Cells["Value"].Value.ToString();
            txt_sales_price.Text = DGV_Vehicle.CurrentRow.Cells["Price"].Value.ToString();
            DTP_reg_date.Value = Convert.ToDateTime(DGV_Vehicle.CurrentRow.Cells["Reg_Date"].Value.ToString());
            DTP_expire_date.Value = Convert.ToDateTime(DGV_Vehicle.CurrentRow.Cells["Reg_Expire_Date"].Value.ToString());
            txt_seats.Text = DGV_Vehicle.CurrentRow.Cells["No.OfSeats"].Value.ToString();
            txt_status.Text = DGV_Vehicle.CurrentRow.Cells["Status"].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txt_vid.Text;
                string chassyNo = txt_chassyNo.Text;
                string brand = cmb_brand.SelectedText;
                string colour = cmb_colour.SelectedText;
                string year = txt_year.Text;
                string model = txt_model.Text;
                string fuel = txt_fuel.Text;
                int capacity = Convert.ToInt32(txt_capacity.Text);
                int cylinders = Convert.ToInt32(txt_cylinders.Text);
                decimal pur_price = Convert.ToDecimal(txt_pur_price.Text);
                decimal sales_price = Convert.ToDecimal(txt_sales_price.Text);
                DateTime reg_date = DTP_reg_date.Value.Date;
                DateTime expire_date = DTP_expire_date.Value.Date;
                int seats = Convert.ToInt32(txt_seats.Text);
                string status = txt_status.Text;

                int line = 0;

                DialogResult dr = MessageBox.Show("Do you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr.ToString() == "Yes")
                {
                    id = DGV_Vehicle.CurrentRow.Cells[0].Value.ToString();

                    string query = "update Vehicle_Master set Chassy_No='" + chassyNo + "', Brand='" + brand + "',Color='" + colour + "', Year='" + year + "',Model='" + model + "',Fuel='" + fuel + "',Engine_Capacity='" + capacity + "',Cylinders='" + cylinders + "',Value='" + pur_price + "',Price='" + sales_price + "', Reg_Date='" + reg_date + "',Reg_Expire_Date='" + expire_date + "',No.Of_Seats='" + seats + "',Status='" + status + "' where Vehicle_ID='" + id + "'";

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
                string v_id = DGV_Vehicle.CurrentRow.Cells[0].Value.ToString();
                string query = "delete from Vehicle_Master where Vehicle_ID='" + v_id + "'";
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
            txt_vid.Text = "";
            txt_chassyNo.Text = "";
            cmb_brand.Text = "";
            cmb_colour.Text = "";
            txt_year.Text = "";
            txt_model.Text = "";
            txt_fuel.Text = "";
            txt_capacity.Text = "";
            txt_cylinders.Text = "";
            txt_pur_price.Text = "";
            txt_sales_price.Text = "";
            DTP_reg_date.Value = DateTime.Today.Date;
            DTP_expire_date.Value = DateTime.Today.Date;
            txt_seats.Text = "";
            txt_status.Text = "Not Sold";

        }

        private bool validate()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txt_chassyNo.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_year.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_model.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_fuel.Text))
            {
                result = false;
            }


            if (string.IsNullOrEmpty(txt_capacity.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_cylinders.Text))
            {
                result = false;
            }

            if (string.IsNullOrEmpty(txt_pur_price.Text))
            {
                result = false;
            }


            if (string.IsNullOrEmpty(txt_sales_price.Text))
            {
                result = false;
            }


            if (string.IsNullOrEmpty(txt_status.Text))
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
 
    

