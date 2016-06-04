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
    public partial class Purchase : Form
    {
        DB_Connection dbcon3 = new DB_Connection();
        public Purchase()
        {
            InitializeComponent();
        }
    private void Vehicle_Purchase_Load(object sender, EventArgs e)
        {
            txt_increment_ID();
            Binding_SupplierCompany();
            Vehicle_Brand_Load();
            Vehicle_Colour_Load();

        }


        private void txt_increment_ID()
        {
            string Query = "select MAX(Purchase_ID) from Purchase_Order_Request";
            int new_ID = dbcon3.increment_ID(Query);
            txt_pur_id.Text = new_ID.ToString();
            
        }


        private void Binding_SupplierCompany()
        {
            string query = "select distinct (Company_Name) from Supplier_Master ";                       
            DataTable dt1 = new DataTable();
            dt1 = dbcon3.data_table(query);
            cmb_supCompany.DataSource = dt1;
            cmb_supCompany.DisplayMember = "Company_Name";
            cmb_supCompany.ValueMember = "Supplier_ID";


        }

        enum brand
        {
            Toyota, Mitsubishi, Nissan
        };

        private void Vehicle_Brand_Load()
        {
            cmb_pur_brand.DataSource = Enum.GetValues(typeof(brand));
        }


        enum colour
        {
            White, Black, Dark_Blue, Sky_Blue, Red 
        };


         private void Vehicle_Colour_Load()
        {
            cmb_pur_color.DataSource = Enum.GetValues(typeof(colour));
        }

         private void SupplierID_Select(object sender, EventArgs e)
         {
             string companyName = cmb_supCompany.SelectedItem.ToString();
             string query = "select Supplier_ID where Company_Name='" + companyName + "'";
             
         }

         private void btn_Vforward_Click(object sender, EventArgs e)
         {
             //int pur_id = Convert.ToInt32(txt_pur_id.Text);
             //DateTime date = DTP_Purchase.Value.Date;
             //string brand = cmb_brand.SelectedItem.ToString();
             //string model = txt_pur_model.Text;
             //string color = cmb_pur_color.SelectedItem.ToString();
             //string year = txt_pur_year.Text;
             //string fuel = txt_pur_fuel.Text;
             //int capacity = Convert.ToInt32(txt_pur_capacity.Text);
             //int qty = Convert.ToInt32(txt_pur_Vqty.Text);

             //string query = "insert into Purchase_Order_Request values('"+pur_id+"','"+date+"','"++"','"+txt_UserID.Text+"')";

         }

        
    }
}


