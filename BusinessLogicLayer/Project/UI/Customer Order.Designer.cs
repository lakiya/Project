namespace Project.UI
{
    partial class Customer_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Order = new System.Windows.Forms.DataGridView();
            this.cmb_OrderType = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGV_InvDetail = new System.Windows.Forms.DataGridView();
            this.DGV_InvHeader = new System.Windows.Forms.DataGridView();
            this.DGV_CustPayment = new System.Windows.Forms.DataGridView();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_InvHeaderID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CustPaymentID = new System.Windows.Forms.TextBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.cmb_PaymentMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Change = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txt_Cash = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Label29 = new System.Windows.Forms.Label();
            this.txt_GST = new System.Windows.Forms.TextBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.txt_GrandTotal = new System.Windows.Forms.TextBox();
            this.payment = new System.Windows.Forms.Label();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.GB_SalesOrder = new System.Windows.Forms.GroupBox();
            this.DGV_Sales = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP_Order = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CustID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_OrID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Order)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InvHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CustPayment)).BeginInit();
            this.Panel6.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.GB_SalesOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Order
            // 
            this.DGV_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Order.Location = new System.Drawing.Point(24, 64);
            this.DGV_Order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_Order.Name = "DGV_Order";
            this.DGV_Order.Size = new System.Drawing.Size(1196, 719);
            this.DGV_Order.TabIndex = 0;
            this.DGV_Order.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Order_CellDoubleClick);
            // 
            // cmb_OrderType
            // 
            this.cmb_OrderType.FormattingEnabled = true;
            this.cmb_OrderType.Location = new System.Drawing.Point(87, 29);
            this.cmb_OrderType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_OrderType.Name = "cmb_OrderType";
            this.cmb_OrderType.Size = new System.Drawing.Size(140, 25);
            this.cmb_OrderType.TabIndex = 2;
            this.cmb_OrderType.SelectionChangeCommitted += new System.EventHandler(this.Load_Order_GridData);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2240, 1340);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmb_OrderType);
            this.tabPage1.Controls.Add(this.DGV_Order);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(2232, 1310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vehicles/ VehicleParts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order Type";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGV_InvDetail);
            this.tabPage2.Controls.Add(this.DGV_InvHeader);
            this.tabPage2.Controls.Add(this.DGV_CustPayment);
            this.tabPage2.Controls.Add(this.Panel6);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txt_InvHeaderID);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txt_CustPaymentID);
            this.tabPage2.Controls.Add(this.Panel3);
            this.tabPage2.Controls.Add(this.Panel5);
            this.tabPage2.Controls.Add(this.GB_SalesOrder);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.DTP_Order);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txt_UserID);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txt_CustID);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_OrID);
            this.tabPage2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(2232, 1310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer Order";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // DGV_InvDetail
            // 
            this.DGV_InvDetail.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_InvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_InvDetail.Location = new System.Drawing.Point(804, 464);
            this.DGV_InvDetail.Name = "DGV_InvDetail";
            this.DGV_InvDetail.Size = new System.Drawing.Size(522, 150);
            this.DGV_InvDetail.TabIndex = 138;
            this.DGV_InvDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_InvDetail_DoubleClick);
            // 
            // DGV_InvHeader
            // 
            this.DGV_InvHeader.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_InvHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_InvHeader.Location = new System.Drawing.Point(804, 294);
            this.DGV_InvHeader.Name = "DGV_InvHeader";
            this.DGV_InvHeader.Size = new System.Drawing.Size(522, 150);
            this.DGV_InvHeader.TabIndex = 137;
            this.DGV_InvHeader.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_InvHeader_DoubleClick);
            // 
            // DGV_CustPayment
            // 
            this.DGV_CustPayment.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_CustPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CustPayment.Location = new System.Drawing.Point(804, 127);
            this.DGV_CustPayment.Name = "DGV_CustPayment";
            this.DGV_CustPayment.Size = new System.Drawing.Size(522, 150);
            this.DGV_CustPayment.TabIndex = 136;
            this.DGV_CustPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CustPayment_DoubleClick);
            // 
            // Panel6
            // 
            this.Panel6.BackColor = System.Drawing.Color.Transparent;
            this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.btn_view);
            this.Panel6.Controls.Add(this.btn_exit);
            this.Panel6.Controls.Add(this.btn_Save);
            this.Panel6.Controls.Add(this.btn_update);
            this.Panel6.Controls.Add(this.btn_delete);
            this.Panel6.Location = new System.Drawing.Point(428, 383);
            this.Panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(123, 231);
            this.Panel6.TabIndex = 135;
            // 
            // btn_view
            // 
            this.btn_view.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(18, 138);
            this.btn_view.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(89, 36);
            this.btn_view.TabIndex = 109;
            this.btn_view.Text = "&View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(18, 182);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(89, 36);
            this.btn_exit.TabIndex = 108;
            this.btn_exit.Text = "&Clear";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(16, 10);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 36);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "&Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(18, 53);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(89, 36);
            this.btn_update.TabIndex = 51;
            this.btn_update.Text = "&Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(18, 95);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 36);
            this.btn_delete.TabIndex = 52;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(336, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 134;
            this.label11.Text = "Invoice ID";
            // 
            // txt_InvHeaderID
            // 
            this.txt_InvHeaderID.Location = new System.Drawing.Point(418, 76);
            this.txt_InvHeaderID.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txt_InvHeaderID.Name = "txt_InvHeaderID";
            this.txt_InvHeaderID.Size = new System.Drawing.Size(118, 24);
            this.txt_InvHeaderID.TabIndex = 133;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 132;
            this.label9.Text = "Customer Payment ID";
            // 
            // txt_CustPaymentID
            // 
            this.txt_CustPaymentID.Location = new System.Drawing.Point(418, 25);
            this.txt_CustPaymentID.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txt_CustPaymentID.Name = "txt_CustPaymentID";
            this.txt_CustPaymentID.Size = new System.Drawing.Size(118, 24);
            this.txt_CustPaymentID.TabIndex = 131;
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.cmb_PaymentMethod);
            this.Panel3.Controls.Add(this.label6);
            this.Panel3.Controls.Add(this.txt_Change);
            this.Panel3.Controls.Add(this.Label16);
            this.Panel3.Controls.Add(this.txt_Cash);
            this.Panel3.Controls.Add(this.label8);
            this.Panel3.Location = new System.Drawing.Point(19, 529);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(321, 121);
            this.Panel3.TabIndex = 130;
            // 
            // cmb_PaymentMethod
            // 
            this.cmb_PaymentMethod.FormattingEnabled = true;
            this.cmb_PaymentMethod.Location = new System.Drawing.Point(130, 12);
            this.cmb_PaymentMethod.Name = "cmb_PaymentMethod";
            this.cmb_PaymentMethod.Size = new System.Drawing.Size(110, 25);
            this.cmb_PaymentMethod.TabIndex = 138;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 92;
            this.label6.Text = "Payment Method";
            // 
            // txt_Change
            // 
            this.txt_Change.Location = new System.Drawing.Point(130, 80);
            this.txt_Change.Name = "txt_Change";
            this.txt_Change.Size = new System.Drawing.Size(110, 24);
            this.txt_Change.TabIndex = 1;
            this.txt_Change.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(19, 83);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(50, 17);
            this.Label16.TabIndex = 90;
            this.Label16.Text = "Change";
            // 
            // txt_Cash
            // 
            this.txt_Cash.Location = new System.Drawing.Point(130, 46);
            this.txt_Cash.Name = "txt_Cash";
            this.txt_Cash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Cash.Size = new System.Drawing.Size(110, 24);
            this.txt_Cash.TabIndex = 0;
            this.txt_Cash.TextChanged += new System.EventHandler(this.Txt_Cash_Changed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 77;
            this.label8.Text = "Cash";
            // 
            // Panel5
            // 
            this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.Label29);
            this.Panel5.Controls.Add(this.txt_GST);
            this.Panel5.Controls.Add(this.Label28);
            this.Panel5.Controls.Add(this.txt_GrandTotal);
            this.Panel5.Controls.Add(this.payment);
            this.Panel5.Controls.Add(this.txt_SubTotal);
            this.Panel5.Controls.Add(this.Label37);
            this.Panel5.Location = new System.Drawing.Point(19, 383);
            this.Panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(321, 131);
            this.Panel5.TabIndex = 119;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label29.Location = new System.Drawing.Point(180, 56);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(19, 17);
            this.Label29.TabIndex = 98;
            this.Label29.Text = "%";
            // 
            // txt_GST
            // 
            this.txt_GST.Location = new System.Drawing.Point(130, 52);
            this.txt_GST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_GST.Name = "txt_GST";
            this.txt_GST.Size = new System.Drawing.Size(42, 24);
            this.txt_GST.TabIndex = 97;
            this.txt_GST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_GST.TextChanged += new System.EventHandler(this.Txt_GST_Change);
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label28.Location = new System.Drawing.Point(22, 55);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(34, 17);
            this.Label28.TabIndex = 96;
            this.Label28.Text = "GST";
            // 
            // txt_GrandTotal
            // 
            this.txt_GrandTotal.Location = new System.Drawing.Point(130, 90);
            this.txt_GrandTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_GrandTotal.Name = "txt_GrandTotal";
            this.txt_GrandTotal.Size = new System.Drawing.Size(110, 24);
            this.txt_GrandTotal.TabIndex = 3;
            this.txt_GrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(22, 93);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(75, 17);
            this.payment.TabIndex = 95;
            this.payment.Text = "Grand Total";
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.Location = new System.Drawing.Point(130, 17);
            this.txt_SubTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.Size = new System.Drawing.Size(110, 24);
            this.txt_SubTotal.TabIndex = 0;
            this.txt_SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label37.Location = new System.Drawing.Point(22, 20);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(61, 17);
            this.Label37.TabIndex = 77;
            this.Label37.Text = "Sub Total";
            // 
            // GB_SalesOrder
            // 
            this.GB_SalesOrder.Controls.Add(this.DGV_Sales);
            this.GB_SalesOrder.Enabled = false;
            this.GB_SalesOrder.Location = new System.Drawing.Point(19, 130);
            this.GB_SalesOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GB_SalesOrder.Name = "GB_SalesOrder";
            this.GB_SalesOrder.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GB_SalesOrder.Size = new System.Drawing.Size(624, 209);
            this.GB_SalesOrder.TabIndex = 47;
            this.GB_SalesOrder.TabStop = false;
            this.GB_SalesOrder.Text = "Sales Order";
            // 
            // DGV_Sales
            // 
            this.DGV_Sales.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Sales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DGV_Sales.Location = new System.Drawing.Point(22, 43);
            this.DGV_Sales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_Sales.Name = "DGV_Sales";
            this.DGV_Sales.Size = new System.Drawing.Size(577, 134);
            this.DGV_Sales.TabIndex = 43;
            this.DGV_Sales.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Sales_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "    Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Description/Model";
            this.Column2.Name = "Column2";
            this.Column2.Width = 134;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "    Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Weight/Qty";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "    Amount";
            this.Column5.Name = "Column5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Date";
            // 
            // DTP_Order
            // 
            this.DTP_Order.CustomFormat = "";
            this.DTP_Order.Location = new System.Drawing.Point(681, 25);
            this.DTP_Order.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DTP_Order.Name = "DTP_Order";
            this.DTP_Order.Size = new System.Drawing.Size(118, 24);
            this.DTP_Order.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "User ID";
            // 
            // txt_UserID
            // 
            this.txt_UserID.Location = new System.Drawing.Point(681, 76);
            this.txt_UserID.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(118, 24);
            this.txt_UserID.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Customer ID";
            // 
            // txt_CustID
            // 
            this.txt_CustID.Location = new System.Drawing.Point(125, 76);
            this.txt_CustID.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txt_CustID.Name = "txt_CustID";
            this.txt_CustID.Size = new System.Drawing.Size(109, 24);
            this.txt_CustID.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Sales Order ID";
            // 
            // txt_OrID
            // 
            this.txt_OrID.Location = new System.Drawing.Point(125, 25);
            this.txt_OrID.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txt_OrID.Name = "txt_OrID";
            this.txt_OrID.Size = new System.Drawing.Size(109, 24);
            this.txt_OrID.TabIndex = 39;
            // 
            // Customer_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Customer_Order";
            this.Text = "Customer Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.New1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Order)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InvHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CustPayment)).EndInit();
            this.Panel6.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.GB_SalesOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Order;
        private System.Windows.Forms.ComboBox cmb_OrderType;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CustID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_OrID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTP_Order;
        private System.Windows.Forms.GroupBox GB_SalesOrder;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView DGV_Sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.TextBox txt_GST;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.TextBox txt_GrandTotal;
        internal System.Windows.Forms.Label payment;
        internal System.Windows.Forms.TextBox txt_SubTotal;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.TextBox txt_Change;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txt_Cash;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_InvHeaderID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_CustPaymentID;
        internal System.Windows.Forms.Panel Panel6;
        internal System.Windows.Forms.Button btn_view;
        internal System.Windows.Forms.Button btn_exit;
        internal System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView DGV_CustPayment;
        private System.Windows.Forms.DataGridView DGV_InvHeader;
        private System.Windows.Forms.ComboBox cmb_PaymentMethod;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGV_InvDetail;
    }
}