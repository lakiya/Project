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
    public partial class Vehicle_Service : Form
    {
	DB_Connection db1 = new DB_Connection();
        public Vehicle_Service()
        {
            InitializeComponent();
        }
    private void cb_add_parts_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_add_parts.Checked) txtbox_parts_name.Show();
        }

        private void btn_savesarvice_Click(object sender, EventArgs e)
        {
            try
            {
                string service_id = txtbox_service_id.Text;
                string vehicle_id = txtbox_vs_vid.Text;
                string registration = txtbox_vs_regno.Text;
                string customer_name = txtbox_vs_cusname.Text;
                DateTime service_date = Convert.ToDateTime(dtp_vs_servicedate.Value);
                string service_type = txtbox_vs_servicetype.Text;
                string description = txtbox_vs_descrip.Text;
                int milestone = Convert.ToInt32(txtbox_vs_milestone.Text);
                string add_parts = txtbox_parts_name.Text;

                string query = "insert into service_table values('" + service_id + "','" + vehicle_id + "','" + registration + "','" + customer_name + "','" + service_date + "','" + service_type + "','" + description + "','" + milestone + "','" + add_parts + "')";

                int line = db1.save_del_update(query);
                if (line > 0)
                {
                   // cleardata();
                    MessageBox.Show("Success!");
                }
                else MessageBox.Show("Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_viewservice_Click(object sender, EventArgs e)
        {
            string query = "";
            if (txtbox_vs_regno.Text.Length > 0 || txtbox_vs_vid.Text.Length > 0)
            {
                if (rb_reg_no.Checked)
                {
                    query = "select * from service_table where registration_no like '%" + txtbox_vs_regno.Text + "%'";
                }
                else if (rb_v_id.Checked)
                {
                    query = "select * from service_table where vehicle_id like '%" + txtbox_vs_vid.Text + "%'";
                }
            }
            else query = "select * from service_table";

            loadgriddata(query);
            
           
            DataTable dt1 = new DataTable();
            dt1 = db1.data_table(query);
            dgv_vs_view.DataSource = dt1;

        }
        private void loadgriddata(string query)
        {
            try
            {
                query = "";
                DataTable dt = new DataTable();
                dt = db1.data_table(query);
                dgv_vs_view.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Vehicle_Service_Load(object sender, EventArgs e)
        {

        }
    }
}
