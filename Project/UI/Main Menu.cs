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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }
		private void Main_Menu_Load(object sender, EventArgs e)
        {
            ToolTip tt1 = new ToolTip();
            tt1.SetToolTip(btn_add_vehicle, "Add New vehicle");

            ToolTip tt2 = new ToolTip();
            tt2.SetToolTip(btn_customer, "Customer Details");

            ToolTip tt3 = new ToolTip();
            tt3.SetToolTip(btn_employee, "Employee Details");

            ToolTip tt4 = new ToolTip();
            tt4.SetToolTip(btn_purchase, "Purchase Details");

            ToolTip tt5 = new ToolTip();
            tt5.SetToolTip(btn_reports, "View Reports");

            ToolTip tt6 = new ToolTip();
            tt6.SetToolTip(btn_sales, "Sales Details");

            ToolTip tt7 = new ToolTip();
            tt7.SetToolTip(btn_service, "Vehicle Service Details");

            ToolTip tt8 = new ToolTip();
            tt8.SetToolTip(btn_supplier, "Supplier Details");

            ToolTip tt9 = new ToolTip();
            tt9.SetToolTip(btn_view_vehicles, "View Vehicles");
        }

        private void btn_add_vehicle_Click(object sender, EventArgs e)
        {
            Vehicle_Details add_vehicle = new Vehicle_Details();
            add_vehicle.Show();
            Hide();

        }
    }
}
