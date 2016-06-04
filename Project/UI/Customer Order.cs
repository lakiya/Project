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
    public partial class Customer_Order : Form
    {
        public Customer_Order(int n1)
        {
            InitializeComponent();
			cust_id = n1 - 1;
        }
    DB_Connection dbcon1 = new DB_Connection();
       // string order_id = ;
       // string invoiceH_id 
        int cust_id = 0;
        

        private void New1_Load(object sender, EventArgs e)
        {
            txt_CustID.Text = cust_id.ToString();
            Order_Type_Load();
            Payment_Method_Load();
            txt_increment_ID();
            Add_DataGrid_Columns();
            load_CustomerPayment_Data();
            load_InvoiceHeader_Data();
            load_InvoiceDetail_Data();
//load_InvoiceDetail_Data();
                       
            
        }

         enum OrderType
         {
             Vehicle,VehicleParts
         };

        private void Order_Type_Load()
        {
            cmb_OrderType.DataSource = Enum.GetValues(typeof(OrderType));


        }

        enum PaymentMethod
        {
            Cash, Credit
        };

        private void Payment_Method_Load()
        {
            cmb_PaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethod));
        }

        private void Load_Order_GridData(object sender, EventArgs e)
        {
            if(cmb_OrderType.SelectedItem.ToString()=="Vehicle")
            {
                string query = "select * from Vehicle_Master";
                DataTable dt1 = new DataTable();
                dt1 = dbcon1.data_table(query);
                DGV_Order.DataSource = dt1;
                GB_SalesOrder.Enabled = true;                             

            }

            else if(cmb_OrderType.SelectedItem.ToString()=="VehicleParts")
            {
                string query = "select * from Vehicle_Parts";
                DataTable dt1 = new DataTable();
                dt1 = dbcon1.data_table(query);
                DGV_Order.DataSource = dt1;                
                GB_SalesOrder.Enabled = true;
            }

           
            else
            {
                DGV_Order.DataSource = null;
                GB_SalesOrder.Enabled = false;
                
            }
        }

        private void txt_increment_ID()
        {
            string Query_Order_Inc = "select MAX(Cust_OR_ID) from Customer_Sales_Order";
            //txt_OrID.Text = dbcon1.increment_ID(Query_Order_Inc).ToString();
            int new_ID = dbcon1.increment_ID(Query_Order_Inc);
             txt_OrID.Text = new_ID.ToString();

            string Query_CustPayment_Inc = "select MAX(Cust_Pay_ID) from Customer_Payment";
            int new_pay = dbcon1.increment_ID(Query_CustPayment_Inc);
            txt_CustPaymentID.Text = new_pay.ToString();
           // txt_CustPaymentID.Text = dbcon1.increment_ID(Query_CustPayment_Inc).ToString();

            string Query_InvoiceH_Inc = "select MAX(Invoice_H_ID) from Invoice_Header";
            txt_InvHeaderID.Text = dbcon1.increment_ID(Query_InvoiceH_Inc).ToString();

           
        }

        private void Add_DataGrid_Columns()
        {
            if (DGV_Sales.Columns.Count == 0)
            {
                
                DGV_Sales.Columns.Add("Column1", "Vehicle_ID / Parts_ID");
                DGV_Sales.Columns.Add("Column2", "Model / Description");
                DGV_Sales.Columns.Add("Column3", "Price");
                DGV_Sales.Columns.Add("Column4", "Qty");
                DGV_Sales.Columns.Add("Column5", "Amount");
                
            }

            if(DGV_Sales.Rows.Count==0)
            {
                //DGV_Sales.Rows.Add("sasa","sasas","sasasa","sasasas","sasasasa");
            }
        }

        private void DGV_Order_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                      
            if (cmb_OrderType.SelectedItem.ToString()=="Vehicle")
            {
                string vehicle_id = DGV_Order.CurrentRow.Cells["Vehicle_ID"].Value.ToString();
                string model = DGV_Order.CurrentRow.Cells["Model"].Value.ToString();
                decimal price = Convert.ToDecimal(DGV_Order.CurrentRow.Cells["Price"].Value.ToString());
                string query = "select Vehicle_ID, Model, Price from Vehicle_Master where Vehicle_ID='" + vehicle_id + "'";
                DataTable dt1 = new DataTable();
                dt1 = dbcon1.data_table(query);
                List<object> itemlist = dt1.Rows[0].ItemArray.ToList();
                DGV_Sales.Rows.Add(itemlist[0], itemlist[1], itemlist[2]); 
            }

            else if(cmb_OrderType.SelectedItem.ToString()=="VehicleParts")
            {
                string parts_id = DGV_Order.CurrentRow.Cells["Vehicle_P_ID"].Value.ToString();
                string desc = DGV_Order.CurrentRow.Cells["Description"].Value.ToString();
                decimal price = Convert.ToDecimal(DGV_Order.CurrentRow.Cells["Price"].Value.ToString());
                string query2 = "select Vehicle_P_ID, Description, Price from Vehicle_Parts where Vehicle_P_ID='" + parts_id + "'";
                DataTable dt1 = new DataTable();
                dt1 = dbcon1.data_table(query2);
                List<object> itemlist = dt1.Rows[0].ItemArray.ToList();
                DGV_Sales.Rows.Add(itemlist[0], itemlist[1], itemlist[2]); 
            }

                  
                    
 
           
        }

        private void DGV_Sales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (DGV_Sales.Rows != null)
                {
                    if (DGV_Sales.CurrentRow != null)
                    {
                        
                         DGV_Sales.CurrentRow.Cells["Column5"].Value = Convert.ToDecimal(DGV_Sales.CurrentRow.Cells["Column3"].Value) * Convert.ToDecimal(DGV_Sales.CurrentRow.Cells["Column4"].Value);

                         

                         decimal sum = 0;
                         for (int i = 0; i < DGV_Sales.Rows.Count; ++i)
                         {
                             sum += Convert.ToDecimal(DGV_Sales.Rows[i].Cells["Column5"].Value);

                            
                         }
                         txt_SubTotal.Text = sum.ToString();
                    }                                       
                    
                }
            }

          
        }              
              
             
     
        private void Txt_GST_Change(object sender, EventArgs e)
        {
            int GST = 0;
            decimal sub_tot = Convert.ToDecimal(txt_SubTotal.Text);
            if (!string.IsNullOrEmpty(txt_GST.Text))
            {
                GST = Convert.ToInt32(txt_GST.Text);
            }
             
            decimal tot = sub_tot * GST / 100;
            decimal grand_tot = sub_tot + tot;
            txt_GrandTotal.Text = grand_tot.ToString();
        }

        private void Txt_Cash_Changed(object sender, EventArgs e)
        {
            decimal cash = 0;
            if(!string.IsNullOrEmpty(txt_Cash.Text))
            {
                cash = Convert.ToDecimal(txt_Cash.Text);
            }
            
            decimal Grand_tot = Convert.ToDecimal(txt_GrandTotal.Text);
            decimal change = cash - Grand_tot;
            txt_Change.Text = change.ToString();
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                int line1 = 0;
                int line2 = 0;
                int line3 = 0;
                int line4 = 0;
                string order_id = txt_OrID.Text;
              //  string cust_id = txt_CustID.Text;
                string cust_Pay_id = txt_CustPaymentID.Text;
                string invoiceH_id = txt_InvHeaderID.Text;
                DateTime date = DTP_Order.Value.Date;
                string user_id = txt_UserID.Text;
                string grand_tot = txt_GrandTotal.Text;
                string pay_method = cmb_PaymentMethod.SelectedItem.ToString();
               // int lenght = order_id.Length;
               //  order_id.Substring(2);

                if (DGV_Sales.Rows != null)
                {
                    for (int i = 0; i < DGV_Sales.Rows.Count-1; ++i)
                    {
                       // DGV_InvDetail.CurrentRow.Cells["Item"].Value = DGV_Sales.Rows[i].Cells["Column2"].Value;

                       // string item_code = DGV_Sales.CurrentRow.Cells["Column1"].Value.ToString();
                        string desc = DGV_Sales.Rows[i].Cells["Column2"].Value.ToString();
                        string price = DGV_Sales.Rows[i].Cells["Column3"].Value.ToString();
                        string qty = DGV_Sales.Rows[i].Cells["Column4"].Value.ToString();
                        string amt = DGV_Sales.Rows[i].Cells["Column5"].Value.ToString();

                        string QueryInvoiceDetail = "insert into Invoice_Detail values('" + desc + "','" + price + "','" + qty + "','" + amt + "','" + invoiceH_id + "')";
                        line4 = dbcon1.save_del_update(QueryInvoiceDetail);
                    }
                }
                    
                string QueryCustPayment = "insert into Customer_Payment values('" + cust_Pay_id + "','" + date + "','" + pay_method + "','" + grand_tot + "','" + cust_id + "','" + user_id + "','" + invoiceH_id + "')";
                string QueryInvoiceHeader = "insert into Invoice_Header values('" + invoiceH_id + "','" + date + "','" + grand_tot + "','" + user_id + "','" + order_id + "')";
                string QueryCustOrder = "insert into Customer_Sales_Order values('" + order_id + "','" + date + "','" + cust_id + "','" + user_id + "')";


                line1 = dbcon1.save_del_update(QueryCustPayment);
                line2 = dbcon1.save_del_update(QueryInvoiceHeader);
                line3 = dbcon1.save_del_update(QueryCustOrder);



                //if (DGV_Sales.Rows != null)
                //{
                //    for (int i = 0; i < DGV_Sales.Rows.Count; ++i)
                //    {
                //        string Query_InvDetail_Inc = "select MAX(Invoice_D_ID) from Invoice_Detail";
                //        DGV_InvDetail.CurrentRow.Cells["InvDetail_ID"].Value = dbcon1.increment_ID(Query_InvDetail_Inc).ToString();

                //        DGV_InvDetail.CurrentRow.Cells["Item"].Value = DGV_Sales.CurrentRow.Cells["Column2"].Value;
                //        DGV_InvDetail.CurrentRow.Cells["Unit_Price"].Value = DGV_Sales.CurrentRow.Cells["Column3"].Value;
                //        DGV_InvDetail.CurrentRow.Cells["Qty"].Value = DGV_Sales.CurrentRow.Cells["Column4"].Value;
                //        DGV_InvDetail.CurrentRow.Cells["Amt"].Value = DGV_Sales.CurrentRow.Cells["Column5"].Value;
                //        DGV_InvDetail.CurrentRow.Cells["InvHeader_ID"].Value = invoiceH_id;
                //    }
                //}
 

               if (line1 > 0 && line2 > 0 && line3 > 0 && line4 > 0)

                {
                    load_CustomerPayment_Data();
                    load_InvoiceHeader_Data();
                    load_InvoiceDetail_Data();
                    clearData();
                    txt_increment_ID();
                    MessageBox.Show("Data Inserted");
                } 

                else
                    MessageBox.Show("Data Not Inserted");



              
 

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void load_CustomerPayment_Data()
        {
            
            try
            {
               
                string query1 = "select * from Customer_Payment where Cust_Pay_ID='" + txt_CustPaymentID.Text + "' ";

                DataTable dt1 = new DataTable();                         
                dt1 = dbcon1.data_table(query1);                             
                DGV_CustPayment.DataSource = dt1;
                             

            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        private void load_InvoiceHeader_Data()
        {

            try
            {
                 string query1 = "select * from Invoice_Header where Invoice_H_ID ='" + txt_InvHeaderID.Text + "' ";
                 DataTable dt1 = new DataTable();
                 dt1 = dbcon1.data_table(query1);
                 DGV_InvHeader.DataSource = dt1;
            }

            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        private void load_InvoiceDetail_Data()
        {
            try
            {
                 string query1 = "select * from Invoice_Detail where Invoice_H_ID ='" + txt_InvHeaderID.Text + "' ";
                 DataTable dt1 = new DataTable();
                 dt1 = dbcon1.data_table(query1);
                 DGV_InvDetail.DataSource = dt1;
                

            }


            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        private void clearData()
        {
            DTP_Order.Value = DateTime.Today.Date;                         
            txt_GrandTotal.Text="";
            cmb_PaymentMethod.Text = "";
            DGV_Sales.DataSource = "";
            txt_GST.Text = "";
            txt_Change.Text = "";
            txt_SubTotal.Text = "";
            txt_Cash.Text = "";
            txt_CustID.Text = "";


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int line1 = 0;
            int line2 = 0;
            int line3 = 0;

             DialogResult dr = MessageBox.Show("Do You want to Update ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

             if (dr.ToString() == "Yes")
             {

                 if (DGV_CustPayment.Rows != null)
                 {
                     for (int i = 0; i < DGV_CustPayment.Rows.Count - 1; ++i)
                     {
                         
                         int cust_payment_id = Convert.ToInt32(DGV_CustPayment.Rows[i].Cells["Cust_Pay_ID"].Value.ToString());
                         int cust_id = Convert.ToInt32(DGV_CustPayment.Rows[i].Cells["Customer_ID"].Value.ToString());
                         int invHeader_id = Convert.ToInt32(DGV_CustPayment.Rows[i].Cells["Invoice_H_ID"].Value.ToString());
                         DateTime date_Payment = Convert.ToDateTime(DGV_CustPayment.Rows[i].Cells["Date"].Value.ToString());
                         int user_id = Convert.ToInt32(DGV_CustPayment.Rows[i].Cells["User_ID"].Value.ToString());
                         decimal tot_amt = Convert.ToDecimal(DGV_CustPayment.Rows[i].Cells["Total_Amt"].Value.ToString());
                         string pay_method = DGV_CustPayment.Rows[i].Cells["Payment_Method"].Value.ToString();

                         string query1 = "update Customer_Payment set Date='" + date_Payment + "', Payment_Method='" + pay_method + "', Total_Amt='" + tot_amt + "', Customer_ID='" + cust_id + "', User_ID='" + user_id + "',Invoice_H_ID='" + invHeader_id + "' where Cust_Pay_ID='" + cust_payment_id + "'";
                         line1 = dbcon1.save_del_update(query1);
                     }
                 }


                 if (DGV_InvHeader.Rows != null)
                 {
                     for (int i = 0; i < DGV_InvHeader.Rows.Count - 1; ++i)
                     {


                         int order_id = Convert.ToInt32(DGV_InvHeader.Rows[i].Cells["Sales_OR_ID"].Value.ToString());
                         int invHeader_id = Convert.ToInt32(DGV_InvHeader.Rows[i].Cells["Invoice_H_ID"].Value.ToString());
                         DateTime date = Convert.ToDateTime(DGV_InvHeader.Rows[i].Cells["Date"].Value.ToString());
                         int user_ID = Convert.ToInt32(DGV_InvHeader.Rows[i].Cells["User_ID"].Value.ToString());
                         decimal totAmt = Convert.ToDecimal(DGV_InvHeader.Rows[i].Cells["Total_Amt"].Value.ToString());


                         string query2 = "update Invoice_Header set Date='" + date + "',  Total_Amt='" + totAmt + "',User_ID='" + user_ID + "',Sales_OR_ID = '" + order_id + "' where Invoice_H_ID='" + invHeader_id + "'";
                         line2 = dbcon1.save_del_update(query2);
                     }
                 }


                 if (DGV_InvDetail.Rows != null)
                 {
                     for (int i = 0; i < DGV_InvDetail.Rows.Count - 1; ++i)
                     {


                         int invH_id = Convert.ToInt32(DGV_InvDetail.Rows[i].Cells["Invoice_H_ID"].Value.ToString());
                         int invD_id = Convert.ToInt32(DGV_InvDetail.Rows[i].Cells["Invoice_D_ID"].Value.ToString());
                         int unit_price = Convert.ToInt32(DGV_InvDetail.Rows[i].Cells["Unit_Price"].Value.ToString());
                         decimal Amt = Convert.ToDecimal(DGV_InvDetail.Rows[i].Cells["Amount"].Value.ToString());
                         int qty = Convert.ToInt32(DGV_InvDetail.Rows[i].Cells["Qty"].Value.ToString());
                         string item = DGV_InvDetail.Rows[i].Cells["Item"].Value.ToString();


                         string query3 = "update Invoice_Detail set Item='" + item + "',  Unit_Price='" + unit_price + "',Qty='" + qty + "',Amount = '" + Amt + "', Invoice_H_ID='" + invH_id + "' where Invoice_D_ID='" + invD_id + "'";
                         line3 = dbcon1.save_del_update(query3);
                     }
                 }

                 if (line1 > 0 && line2 > 0 && line3 > 0)
                 {
                     // loadGridData();
                     load_CustomerPayment_Data();
                     load_InvoiceHeader_Data();
                     load_InvoiceDetail_Data();
                     clearData();
                     txt_increment_ID();
                     MessageBox.Show("Data Updated");

                 }

                 else
                     MessageBox.Show("Data Not Updated");
             }

        }

        private void DGV_CustPayment_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cust_payment_id = Convert.ToInt32(DGV_CustPayment.CurrentRow.Cells["Cust_Pay_ID"].Value.ToString());
            int cust_id = Convert.ToInt32(DGV_CustPayment.CurrentRow.Cells["Customer_ID"].Value.ToString());
            int invHeader_id = Convert.ToInt32(DGV_CustPayment.CurrentRow.Cells["Invoice_H_ID"].Value.ToString());
            DateTime date_Payment = Convert.ToDateTime(DGV_CustPayment.CurrentRow.Cells["Date"].Value.ToString());
            int user_id = Convert.ToInt32(DGV_CustPayment.CurrentRow.Cells["User_ID"].Value.ToString());
            decimal tot_amt = Convert.ToDecimal(DGV_CustPayment.CurrentRow.Cells["Total_Amt"].Value.ToString());
            string pay_method = DGV_CustPayment.CurrentRow.Cells["Payment_Method"].Value.ToString();
            
        }

        private void DGV_InvHeader_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int invHeader_id = Convert.ToInt32(DGV_InvHeader.CurrentRow.Cells["Invoice_H_ID"].Value.ToString());

        }

        private void DGV_InvDetail_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int invDetail_id = Convert.ToInt32(DGV_InvDetail.CurrentRow.Cells["Invoice_D_ID"].Value.ToString());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int line1 = 0;
            int line2 = 0;
            int line3 = 0;
            DialogResult dr = MessageBox.Show("Do You want to delete ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr.ToString() == "Yes")
            {
                int invHeader_id = Convert.ToInt32(DGV_InvHeader.CurrentRow.Cells["Invoice_H_ID"].Value.ToString());
                int invDetail_id = Convert.ToInt32(DGV_InvDetail.CurrentRow.Cells["Invoice_D_ID"].Value.ToString());
                int cust_payment_id = Convert.ToInt32(DGV_CustPayment.CurrentRow.Cells["Cust_Pay_ID"].Value.ToString());

                string query1 = "delete from Invoice_Header where Invoice_H_ID='" + invHeader_id + "'";
                string query2 = "delete from Invoice_Detail where Invoice_D_ID='" + invHeader_id + "'";
                string query3 = "delete from Customer_Payment where Cust_Pay_ID='" + cust_payment_id + "'";

                line1 = dbcon1.save_del_update(query1);
                line2 = dbcon1.save_del_update(query2);
                line3 = dbcon1.save_del_update(query3);

                if (line1 > 0 && line2 > 0 && line3 > 0)
                {
                   // loadGridData();
                    load_CustomerPayment_Data();
                    load_InvoiceHeader_Data();
                    load_InvoiceDetail_Data();
                    clearData();
                    txt_increment_ID();
                    MessageBox.Show("Data Deleted");

                }

                else
                    MessageBox.Show("Data Not Deleted");
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Customer_Order_View Order_view1 = new Customer_Order_View();
            Order_view1.Show();
        }
      

        
    }
}


