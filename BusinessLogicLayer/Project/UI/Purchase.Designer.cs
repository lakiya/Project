namespace Project.UI
{
    partial class Purchase
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
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Sup_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pur_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP_Purchase = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.GB_SalesOrder = new System.Windows.Forms.GroupBox();
            this.btn_Vpur_delete = new System.Windows.Forms.Button();
            this.btn_Vpur_update = new System.Windows.Forms.Button();
            this.btn_VPur_save = new System.Windows.Forms.Button();
            this.btn_Vforward = new System.Windows.Forms.Button();
            this.cmb_pur_brand = new System.Windows.Forms.ComboBox();
            this.DTP_VehiclePur_find = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pur_capacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pur_fuel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_pur_Vqty = new System.Windows.Forms.TextBox();
            this.txt_pur_year = new System.Windows.Forms.TextBox();
            this.cmb_pur_color = new System.Windows.Forms.ComboBox();
            this.cmb_brand = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_pur_model = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_chassyNo = new System.Windows.Forms.TextBox();
            this.DGV_Vehicle_Purchase = new System.Windows.Forms.DataGridView();
            this.cmb_supCompany = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_VPpur_delete = new System.Windows.Forms.Button();
            this.btn_VPpur_update = new System.Windows.Forms.Button();
            this.btn_VPpur_save = new System.Windows.Forms.Button();
            this.btn_VPpur_Forward = new System.Windows.Forms.Button();
            this.DTP_PartsPurchase_find = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_Parts_Purchase = new System.Windows.Forms.DataGridView();
            this.txt_VPpur_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_VPpur_qty = new System.Windows.Forms.TextBox();
            this.GB_SalesOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Vehicle_Purchase)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Parts_Purchase)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(567, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 142;
            this.label11.Text = "Supplier ID";
            // 
            // txt_Sup_id
            // 
            this.txt_Sup_id.Location = new System.Drawing.Point(775, 28);
            this.txt_Sup_id.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txt_Sup_id.Name = "txt_Sup_id";
            this.txt_Sup_id.ReadOnly = true;
            this.txt_Sup_id.Size = new System.Drawing.Size(118, 24);
            this.txt_Sup_id.TabIndex = 141;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 140;
            this.label9.Text = "Purchase ID";
            // 
            // txt_pur_id
            // 
            this.txt_pur_id.Location = new System.Drawing.Point(120, 28);
            this.txt_pur_id.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txt_pur_id.Name = "txt_pur_id";
            this.txt_pur_id.ReadOnly = true;
            this.txt_pur_id.Size = new System.Drawing.Size(118, 24);
            this.txt_pur_id.TabIndex = 139;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 138;
            this.label5.Text = "Date";
            // 
            // DTP_Purchase
            // 
            this.DTP_Purchase.CustomFormat = "";
            this.DTP_Purchase.Location = new System.Drawing.Point(357, 28);
            this.DTP_Purchase.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DTP_Purchase.Name = "DTP_Purchase";
            this.DTP_Purchase.Size = new System.Drawing.Size(118, 24);
            this.DTP_Purchase.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(964, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 136;
            this.label3.Text = "User ID";
            // 
            // txt_UserID
            // 
            this.txt_UserID.Location = new System.Drawing.Point(1028, 28);
            this.txt_UserID.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.ReadOnly = true;
            this.txt_UserID.Size = new System.Drawing.Size(118, 24);
            this.txt_UserID.TabIndex = 135;
            // 
            // GB_SalesOrder
            // 
            this.GB_SalesOrder.Controls.Add(this.btn_Vpur_delete);
            this.GB_SalesOrder.Controls.Add(this.btn_Vpur_update);
            this.GB_SalesOrder.Controls.Add(this.btn_VPur_save);
            this.GB_SalesOrder.Controls.Add(this.btn_Vforward);
            this.GB_SalesOrder.Controls.Add(this.cmb_pur_brand);
            this.GB_SalesOrder.Controls.Add(this.DTP_VehiclePur_find);
            this.GB_SalesOrder.Controls.Add(this.label7);
            this.GB_SalesOrder.Controls.Add(this.txt_pur_capacity);
            this.GB_SalesOrder.Controls.Add(this.label6);
            this.GB_SalesOrder.Controls.Add(this.txt_pur_fuel);
            this.GB_SalesOrder.Controls.Add(this.label13);
            this.GB_SalesOrder.Controls.Add(this.label8);
            this.GB_SalesOrder.Controls.Add(this.txt_pur_Vqty);
            this.GB_SalesOrder.Controls.Add(this.txt_pur_year);
            this.GB_SalesOrder.Controls.Add(this.cmb_pur_color);
            this.GB_SalesOrder.Controls.Add(this.cmb_brand);
            this.GB_SalesOrder.Controls.Add(this.label18);
            this.GB_SalesOrder.Controls.Add(this.label1);
            this.GB_SalesOrder.Controls.Add(this.label17);
            this.GB_SalesOrder.Controls.Add(this.txt_pur_model);
            this.GB_SalesOrder.Controls.Add(this.label16);
            this.GB_SalesOrder.Controls.Add(this.txt_chassyNo);
            this.GB_SalesOrder.Controls.Add(this.DGV_Vehicle_Purchase);
            this.GB_SalesOrder.Enabled = false;
            this.GB_SalesOrder.Location = new System.Drawing.Point(24, 82);
            this.GB_SalesOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GB_SalesOrder.Name = "GB_SalesOrder";
            this.GB_SalesOrder.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GB_SalesOrder.Size = new System.Drawing.Size(1122, 309);
            this.GB_SalesOrder.TabIndex = 143;
            this.GB_SalesOrder.TabStop = false;
            this.GB_SalesOrder.Text = "Vehicle Purchase";
            // 
            // btn_Vpur_delete
            // 
            this.btn_Vpur_delete.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vpur_delete.Location = new System.Drawing.Point(376, 195);
            this.btn_Vpur_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Vpur_delete.Name = "btn_Vpur_delete";
            this.btn_Vpur_delete.Size = new System.Drawing.Size(89, 36);
            this.btn_Vpur_delete.TabIndex = 150;
            this.btn_Vpur_delete.Text = "&Delete";
            this.btn_Vpur_delete.UseVisualStyleBackColor = true;
            // 
            // btn_Vpur_update
            // 
            this.btn_Vpur_update.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vpur_update.Location = new System.Drawing.Point(376, 149);
            this.btn_Vpur_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Vpur_update.Name = "btn_Vpur_update";
            this.btn_Vpur_update.Size = new System.Drawing.Size(89, 36);
            this.btn_Vpur_update.TabIndex = 149;
            this.btn_Vpur_update.Text = "&Update";
            this.btn_Vpur_update.UseVisualStyleBackColor = true;
            // 
            // btn_VPur_save
            // 
            this.btn_VPur_save.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VPur_save.Location = new System.Drawing.Point(376, 105);
            this.btn_VPur_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_VPur_save.Name = "btn_VPur_save";
            this.btn_VPur_save.Size = new System.Drawing.Size(89, 36);
            this.btn_VPur_save.TabIndex = 148;
            this.btn_VPur_save.Text = "&Save";
            this.btn_VPur_save.UseVisualStyleBackColor = true;
            // 
            // btn_Vforward
            // 
            this.btn_Vforward.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vforward.Location = new System.Drawing.Point(376, 61);
            this.btn_Vforward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Vforward.Name = "btn_Vforward";
            this.btn_Vforward.Size = new System.Drawing.Size(89, 36);
            this.btn_Vforward.TabIndex = 147;
            this.btn_Vforward.Text = ">>";
            this.btn_Vforward.UseVisualStyleBackColor = true;
            this.btn_Vforward.Click += new System.EventHandler(this.btn_Vforward_Click);
            // 
            // cmb_pur_brand
            // 
            this.cmb_pur_brand.FormattingEnabled = true;
            this.cmb_pur_brand.Location = new System.Drawing.Point(159, 27);
            this.cmb_pur_brand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_pur_brand.Name = "cmb_pur_brand";
            this.cmb_pur_brand.Size = new System.Drawing.Size(157, 25);
            this.cmb_pur_brand.TabIndex = 146;
            // 
            // DTP_VehiclePur_find
            // 
            this.DTP_VehiclePur_find.CustomFormat = "";
            this.DTP_VehiclePur_find.Location = new System.Drawing.Point(883, 24);
            this.DTP_VehiclePur_find.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DTP_VehiclePur_find.Name = "DTP_VehiclePur_find";
            this.DTP_VehiclePur_find.Size = new System.Drawing.Size(222, 24);
            this.DTP_VehiclePur_find.TabIndex = 144;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 134;
            this.label7.Text = "Engine Capacity";
            // 
            // txt_pur_capacity
            // 
            this.txt_pur_capacity.Location = new System.Drawing.Point(159, 202);
            this.txt_pur_capacity.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_pur_capacity.Name = "txt_pur_capacity";
            this.txt_pur_capacity.Size = new System.Drawing.Size(157, 24);
            this.txt_pur_capacity.TabIndex = 133;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 132;
            this.label6.Text = "Fuel";
            // 
            // txt_pur_fuel
            // 
            this.txt_pur_fuel.Location = new System.Drawing.Point(159, 167);
            this.txt_pur_fuel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_pur_fuel.Name = "txt_pur_fuel";
            this.txt_pur_fuel.Size = new System.Drawing.Size(157, 24);
            this.txt_pur_fuel.TabIndex = 131;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 17);
            this.label13.TabIndex = 145;
            this.label13.Text = "Qty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 130;
            this.label8.Text = "Year";
            // 
            // txt_pur_Vqty
            // 
            this.txt_pur_Vqty.Location = new System.Drawing.Point(159, 235);
            this.txt_pur_Vqty.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_pur_Vqty.Name = "txt_pur_Vqty";
            this.txt_pur_Vqty.Size = new System.Drawing.Size(157, 24);
            this.txt_pur_Vqty.TabIndex = 144;
            // 
            // txt_pur_year
            // 
            this.txt_pur_year.Location = new System.Drawing.Point(159, 130);
            this.txt_pur_year.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_pur_year.Name = "txt_pur_year";
            this.txt_pur_year.Size = new System.Drawing.Size(157, 24);
            this.txt_pur_year.TabIndex = 129;
            // 
            // cmb_pur_color
            // 
            this.cmb_pur_color.FormattingEnabled = true;
            this.cmb_pur_color.Location = new System.Drawing.Point(159, 95);
            this.cmb_pur_color.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_pur_color.Name = "cmb_pur_color";
            this.cmb_pur_color.Size = new System.Drawing.Size(157, 25);
            this.cmb_pur_color.TabIndex = 127;
            // 
            // cmb_brand
            // 
            this.cmb_brand.FormattingEnabled = true;
            this.cmb_brand.Location = new System.Drawing.Point(159, 95);
            this.cmb_brand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_brand.Name = "cmb_brand";
            this.cmb_brand.Size = new System.Drawing.Size(157, 25);
            this.cmb_brand.TabIndex = 128;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 17);
            this.label18.TabIndex = 125;
            this.label18.Text = "Colour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 126;
            this.label1.Text = "Brand";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 17);
            this.label17.TabIndex = 123;
            this.label17.Text = "Model";
            // 
            // txt_pur_model
            // 
            this.txt_pur_model.Location = new System.Drawing.Point(159, 61);
            this.txt_pur_model.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_pur_model.Name = "txt_pur_model";
            this.txt_pur_model.Size = new System.Drawing.Size(157, 24);
            this.txt_pur_model.TabIndex = 121;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 17);
            this.label16.TabIndex = 119;
            this.label16.Text = "Brand";
            // 
            // txt_chassyNo
            // 
            this.txt_chassyNo.Location = new System.Drawing.Point(159, 61);
            this.txt_chassyNo.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_chassyNo.Name = "txt_chassyNo";
            this.txt_chassyNo.Size = new System.Drawing.Size(157, 24);
            this.txt_chassyNo.TabIndex = 122;
            // 
            // DGV_Vehicle_Purchase
            // 
            this.DGV_Vehicle_Purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Vehicle_Purchase.Location = new System.Drawing.Point(528, 58);
            this.DGV_Vehicle_Purchase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_Vehicle_Purchase.Name = "DGV_Vehicle_Purchase";
            this.DGV_Vehicle_Purchase.Size = new System.Drawing.Size(577, 226);
            this.DGV_Vehicle_Purchase.TabIndex = 43;
            // 
            // cmb_supCompany
            // 
            this.cmb_supCompany.FormattingEnabled = true;
            this.cmb_supCompany.Location = new System.Drawing.Point(644, 28);
            this.cmb_supCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_supCompany.Name = "cmb_supCompany";
            this.cmb_supCompany.Size = new System.Drawing.Size(118, 25);
            this.cmb_supCompany.TabIndex = 146;
            this.cmb_supCompany.SelectionChangeCommitted += new System.EventHandler(this.SupplierID_Select);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_VPpur_delete);
            this.groupBox1.Controls.Add(this.btn_VPpur_update);
            this.groupBox1.Controls.Add(this.btn_VPpur_save);
            this.groupBox1.Controls.Add(this.btn_VPpur_Forward);
            this.groupBox1.Controls.Add(this.DTP_PartsPurchase_find);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DGV_Parts_Purchase);
            this.groupBox1.Controls.Add(this.txt_VPpur_desc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_VPpur_qty);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(24, 429);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1122, 209);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Parts Purchase";
            // 
            // btn_VPpur_delete
            // 
            this.btn_VPpur_delete.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VPpur_delete.Location = new System.Drawing.Point(376, 159);
            this.btn_VPpur_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_VPpur_delete.Name = "btn_VPpur_delete";
            this.btn_VPpur_delete.Size = new System.Drawing.Size(89, 36);
            this.btn_VPpur_delete.TabIndex = 154;
            this.btn_VPpur_delete.Text = "&Delete";
            this.btn_VPpur_delete.UseVisualStyleBackColor = true;
            // 
            // btn_VPpur_update
            // 
            this.btn_VPpur_update.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VPpur_update.Location = new System.Drawing.Point(376, 113);
            this.btn_VPpur_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_VPpur_update.Name = "btn_VPpur_update";
            this.btn_VPpur_update.Size = new System.Drawing.Size(89, 36);
            this.btn_VPpur_update.TabIndex = 153;
            this.btn_VPpur_update.Text = "&Update";
            this.btn_VPpur_update.UseVisualStyleBackColor = true;
            // 
            // btn_VPpur_save
            // 
            this.btn_VPpur_save.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VPpur_save.Location = new System.Drawing.Point(376, 69);
            this.btn_VPpur_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_VPpur_save.Name = "btn_VPpur_save";
            this.btn_VPpur_save.Size = new System.Drawing.Size(89, 36);
            this.btn_VPpur_save.TabIndex = 152;
            this.btn_VPpur_save.Text = "&Save";
            this.btn_VPpur_save.UseVisualStyleBackColor = true;
            // 
            // btn_VPpur_Forward
            // 
            this.btn_VPpur_Forward.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VPpur_Forward.Location = new System.Drawing.Point(376, 25);
            this.btn_VPpur_Forward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_VPpur_Forward.Name = "btn_VPpur_Forward";
            this.btn_VPpur_Forward.Size = new System.Drawing.Size(89, 36);
            this.btn_VPpur_Forward.TabIndex = 151;
            this.btn_VPpur_Forward.Text = ">>";
            this.btn_VPpur_Forward.UseVisualStyleBackColor = true;
            // 
            // DTP_PartsPurchase_find
            // 
            this.DTP_PartsPurchase_find.CustomFormat = "";
            this.DTP_PartsPurchase_find.Location = new System.Drawing.Point(883, 25);
            this.DTP_PartsPurchase_find.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DTP_PartsPurchase_find.Name = "DTP_PartsPurchase_find";
            this.DTP_PartsPurchase_find.Size = new System.Drawing.Size(222, 24);
            this.DTP_PartsPurchase_find.TabIndex = 147;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 148;
            this.label2.Text = "Description";
            // 
            // DGV_Parts_Purchase
            // 
            this.DGV_Parts_Purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Parts_Purchase.Location = new System.Drawing.Point(528, 58);
            this.DGV_Parts_Purchase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_Parts_Purchase.Name = "DGV_Parts_Purchase";
            this.DGV_Parts_Purchase.Size = new System.Drawing.Size(577, 134);
            this.DGV_Parts_Purchase.TabIndex = 43;
            // 
            // txt_VPpur_desc
            // 
            this.txt_VPpur_desc.Location = new System.Drawing.Point(159, 58);
            this.txt_VPpur_desc.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_VPpur_desc.Name = "txt_VPpur_desc";
            this.txt_VPpur_desc.Size = new System.Drawing.Size(157, 24);
            this.txt_VPpur_desc.TabIndex = 147;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 150;
            this.label4.Text = "Qty";
            // 
            // txt_VPpur_qty
            // 
            this.txt_VPpur_qty.Location = new System.Drawing.Point(159, 91);
            this.txt_VPpur_qty.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_VPpur_qty.Name = "txt_VPpur_qty";
            this.txt_VPpur_qty.Size = new System.Drawing.Size(157, 24);
            this.txt_VPpur_qty.TabIndex = 149;
            // 
            // Vehicle_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1181, 669);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_supCompany);
            this.Controls.Add(this.GB_SalesOrder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_Sup_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_pur_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTP_Purchase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_UserID);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Vehicle_Purchase";
            this.Text = "Vehicle & Parts Purchase";
            this.Load += new System.EventHandler(this.Vehicle_Purchase_Load);
            this.GB_SalesOrder.ResumeLayout(false);
            this.GB_SalesOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Vehicle_Purchase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Parts_Purchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Sup_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_pur_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTP_Purchase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.GroupBox GB_SalesOrder;
        private System.Windows.Forms.DataGridView DGV_Vehicle_Purchase;
        private System.Windows.Forms.ComboBox cmb_pur_color;
        private System.Windows.Forms.ComboBox cmb_brand;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_pur_model;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_chassyNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_pur_capacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pur_fuel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_pur_year;
        private System.Windows.Forms.DateTimePicker DTP_VehiclePur_find;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_pur_Vqty;
        private System.Windows.Forms.ComboBox cmb_supCompany;
        private System.Windows.Forms.ComboBox cmb_pur_brand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_Parts_Purchase;
        private System.Windows.Forms.TextBox txt_VPpur_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_VPpur_qty;
        private System.Windows.Forms.DateTimePicker DTP_PartsPurchase_find;
        internal System.Windows.Forms.Button btn_Vpur_delete;
        internal System.Windows.Forms.Button btn_Vpur_update;
        internal System.Windows.Forms.Button btn_VPur_save;
        internal System.Windows.Forms.Button btn_Vforward;
        internal System.Windows.Forms.Button btn_VPpur_delete;
        internal System.Windows.Forms.Button btn_VPpur_update;
        internal System.Windows.Forms.Button btn_VPpur_save;
        internal System.Windows.Forms.Button btn_VPpur_Forward;
    }
}