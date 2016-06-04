namespace Project.UI
{
    partial class Employee_Details
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.DTP_doj = new System.Windows.Forms.DateTimePicker();
            this.DGV_Employee = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_emp_contact = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_emp_nic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_emp_AddCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_emp_AddStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_emp_AddNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_emp_Lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_emp_Fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_emp_id = new System.Windows.Forms.TextBox();
            this.DTP_dob = new System.Windows.Forms.DateTimePicker();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.cmb_designation = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_view);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Location = new System.Drawing.Point(390, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(141, 289);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(23, 228);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(101, 39);
            this.btn_clear.TabIndex = 64;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(23, 178);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(101, 39);
            this.btn_delete.TabIndex = 63;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(23, 128);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(101, 39);
            this.btn_update.TabIndex = 62;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(23, 78);
            this.btn_view.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(101, 39);
            this.btn_view.TabIndex = 61;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(23, 29);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 39);
            this.btn_save.TabIndex = 60;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // DTP_doj
            // 
            this.DTP_doj.Location = new System.Drawing.Point(174, 387);
            this.DTP_doj.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DTP_doj.Name = "DTP_doj";
            this.DTP_doj.Size = new System.Drawing.Size(135, 24);
            this.DTP_doj.TabIndex = 86;
            // 
            // DGV_Employee
            // 
            this.DGV_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Employee.Location = new System.Drawing.Point(566, 32);
            this.DGV_Employee.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DGV_Employee.Name = "DGV_Employee";
            this.DGV_Employee.Size = new System.Drawing.Size(667, 453);
            this.DGV_Employee.TabIndex = 85;
            this.DGV_Employee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Employee_DoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 526);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 84;
            this.label12.Text = "Contact No1";
            // 
            // txt_emp_contact
            // 
            this.txt_emp_contact.Location = new System.Drawing.Point(174, 521);
            this.txt_emp_contact.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_emp_contact.Name = "txt_emp_contact";
            this.txt_emp_contact.Size = new System.Drawing.Size(135, 24);
            this.txt_emp_contact.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 482);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 82;
            this.label11.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 80;
            this.label10.Text = "Designation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 79;
            this.label9.Text = "DOJ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 77;
            this.label8.Text = "DOB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 75;
            this.label7.Text = "NIC";
            // 
            // txt_emp_nic
            // 
            this.txt_emp_nic.Location = new System.Drawing.Point(174, 299);
            this.txt_emp_nic.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_emp_nic.Name = "txt_emp_nic";
            this.txt_emp_nic.Size = new System.Drawing.Size(135, 24);
            this.txt_emp_nic.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 73;
            this.label6.Text = "Address_City";
            // 
            // txt_emp_AddCity
            // 
            this.txt_emp_AddCity.Location = new System.Drawing.Point(174, 254);
            this.txt_emp_AddCity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_emp_AddCity.Name = "txt_emp_AddCity";
            this.txt_emp_AddCity.Size = new System.Drawing.Size(135, 24);
            this.txt_emp_AddCity.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Address_Street";
            // 
            // txt_emp_AddStreet
            // 
            this.txt_emp_AddStreet.Location = new System.Drawing.Point(174, 210);
            this.txt_emp_AddStreet.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_emp_AddStreet.Name = "txt_emp_AddStreet";
            this.txt_emp_AddStreet.Size = new System.Drawing.Size(135, 24);
            this.txt_emp_AddStreet.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "Address_No";
            // 
            // txt_emp_AddNo
            // 
            this.txt_emp_AddNo.Location = new System.Drawing.Point(174, 165);
            this.txt_emp_AddNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_emp_AddNo.Name = "txt_emp_AddNo";
            this.txt_emp_AddNo.Size = new System.Drawing.Size(135, 24);
            this.txt_emp_AddNo.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Last Name";
            // 
            // txt_emp_Lname
            // 
            this.txt_emp_Lname.Location = new System.Drawing.Point(174, 121);
            this.txt_emp_Lname.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_emp_Lname.Name = "txt_emp_Lname";
            this.txt_emp_Lname.Size = new System.Drawing.Size(135, 24);
            this.txt_emp_Lname.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "First Name";
            // 
            // txt_emp_Fname
            // 
            this.txt_emp_Fname.Location = new System.Drawing.Point(174, 76);
            this.txt_emp_Fname.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_emp_Fname.Name = "txt_emp_Fname";
            this.txt_emp_Fname.Size = new System.Drawing.Size(135, 24);
            this.txt_emp_Fname.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Employee ID";
            // 
            // txt_emp_id
            // 
            this.txt_emp_id.Location = new System.Drawing.Point(174, 32);
            this.txt_emp_id.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_emp_id.Name = "txt_emp_id";
            this.txt_emp_id.Size = new System.Drawing.Size(135, 24);
            this.txt_emp_id.TabIndex = 62;
            // 
            // DTP_dob
            // 
            this.DTP_dob.Location = new System.Drawing.Point(174, 342);
            this.DTP_dob.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DTP_dob.Name = "DTP_dob";
            this.DTP_dob.Size = new System.Drawing.Size(135, 24);
            this.DTP_dob.TabIndex = 88;
            // 
            // cmb_gender
            // 
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Location = new System.Drawing.Point(174, 479);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(135, 25);
            this.cmb_gender.TabIndex = 89;
            // 
            // cmb_designation
            // 
            this.cmb_designation.FormattingEnabled = true;
            this.cmb_designation.Location = new System.Drawing.Point(174, 434);
            this.cmb_designation.Name = "cmb_designation";
            this.cmb_designation.Size = new System.Drawing.Size(135, 25);
            this.cmb_designation.TabIndex = 90;
            // 
            // Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1263, 741);
            this.Controls.Add(this.cmb_designation);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.DTP_dob);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DTP_doj);
            this.Controls.Add(this.DGV_Employee);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_emp_contact);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_emp_nic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_emp_AddCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_emp_AddStreet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_emp_AddNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_emp_Lname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_emp_Fname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_emp_id);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Employee_Details";
            this.Text = "Employee_Details";
            this.Load += new System.EventHandler(this.Employee_Details_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker DTP_doj;
        private System.Windows.Forms.DataGridView DGV_Employee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_emp_contact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_emp_nic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_emp_AddCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_emp_AddStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_emp_AddNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_emp_Lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_emp_Fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_emp_id;
        private System.Windows.Forms.DateTimePicker DTP_dob;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.ComboBox cmb_designation;
    }
}