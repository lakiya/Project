namespace Project
{
    partial class Main_Menu
    {
        //// <summary>
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
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_service = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_supplier = new System.Windows.Forms.Button();
            this.btn_view_vehicles = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.btn_add_vehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_employee
            // 
            this.btn_employee.BackgroundImage = global::Project.Properties.Resources.salesman__4_;
            this.btn_employee.Location = new System.Drawing.Point(748, 437);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(128, 113);
            this.btn_employee.TabIndex = 8;
            this.btn_employee.UseVisualStyleBackColor = true;
            // 
            // btn_purchase
            // 
            this.btn_purchase.BackgroundImage = global::Project.Properties.Resources._1453827746_BT_c3tool;
            this.btn_purchase.Location = new System.Drawing.Point(614, 437);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(128, 113);
            this.btn_purchase.TabIndex = 7;
            this.btn_purchase.UseVisualStyleBackColor = true;
            // 
            // btn_reports
            // 
            this.btn_reports.BackgroundImage = global::Project.Properties.Resources._1453673395_chart;
            this.btn_reports.Location = new System.Drawing.Point(480, 437);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(128, 113);
            this.btn_reports.TabIndex = 6;
            this.btn_reports.UseVisualStyleBackColor = true;
            // 
            // btn_service
            // 
            this.btn_service.BackgroundImage = global::Project.Properties.Resources.vehicle18;
            this.btn_service.Location = new System.Drawing.Point(748, 318);
            this.btn_service.Name = "btn_service";
            this.btn_service.Size = new System.Drawing.Size(128, 113);
            this.btn_service.TabIndex = 5;
            this.btn_service.UseVisualStyleBackColor = true;
            // 
            // btn_customer
            // 
            this.btn_customer.BackgroundImage = global::Project.Properties.Resources.Office_Customer_Male_Light_icon1;
            this.btn_customer.Location = new System.Drawing.Point(748, 199);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(128, 113);
            this.btn_customer.TabIndex = 4;
            this.btn_customer.UseVisualStyleBackColor = true;
            // 
            // btn_supplier
            // 
            this.btn_supplier.BackgroundImage = global::Project.Properties.Resources.Office_Customer_Male_Light_icon1;
            this.btn_supplier.Location = new System.Drawing.Point(614, 318);
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.Size = new System.Drawing.Size(128, 113);
            this.btn_supplier.TabIndex = 3;
            this.btn_supplier.UseVisualStyleBackColor = true;
            // 
            // btn_view_vehicles
            // 
            this.btn_view_vehicles.BackgroundImage = global::Project.Properties.Resources.dollar_sign4;
            this.btn_view_vehicles.Location = new System.Drawing.Point(614, 199);
            this.btn_view_vehicles.Name = "btn_view_vehicles";
            this.btn_view_vehicles.Size = new System.Drawing.Size(128, 113);
            this.btn_view_vehicles.TabIndex = 2;
            this.btn_view_vehicles.UseVisualStyleBackColor = true;
            // 
            // btn_sales
            // 
            this.btn_sales.BackgroundImage = global::Project.Properties.Resources.dollar_sign4;
            this.btn_sales.Location = new System.Drawing.Point(480, 318);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(128, 113);
            this.btn_sales.TabIndex = 1;
            this.btn_sales.UseVisualStyleBackColor = true;
            // 
            // btn_add_vehicle
            // 
            this.btn_add_vehicle.BackgroundImage = global::Project.Properties.Resources.sedan3;
            this.btn_add_vehicle.Location = new System.Drawing.Point(480, 199);
            this.btn_add_vehicle.Name = "btn_add_vehicle";
            this.btn_add_vehicle.Size = new System.Drawing.Size(128, 113);
            this.btn_add_vehicle.TabIndex = 0;
            this.btn_add_vehicle.UseVisualStyleBackColor = true;
            this.btn_add_vehicle.Click += new System.EventHandler(this.btn_add_vehicle_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.btn_reports);
            this.Controls.Add(this.btn_service);
            this.Controls.Add(this.btn_customer);
            this.Controls.Add(this.btn_supplier);
            this.Controls.Add(this.btn_view_vehicles);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.btn_add_vehicle);
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_vehicle;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Button btn_view_vehicles;
        private System.Windows.Forms.Button btn_supplier;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_service;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Button btn_employee;
    }
}