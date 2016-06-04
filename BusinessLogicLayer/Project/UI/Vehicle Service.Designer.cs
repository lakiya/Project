namespace Project.UI
{
    partial class Vehicle_Service
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
            this.txtbox_service_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_closeservice = new System.Windows.Forms.Button();
            this.btn_savesarvice = new System.Windows.Forms.Button();
            this.dtp_vs_servicedate = new System.Windows.Forms.DateTimePicker();
            this.txtbox_parts_name = new System.Windows.Forms.TextBox();
            this.txtbox_vs_milestone = new System.Windows.Forms.TextBox();
            this.txtbox_vs_descrip = new System.Windows.Forms.TextBox();
            this.txtbox_vs_servicetype = new System.Windows.Forms.TextBox();
            this.txtbox_vs_cusname = new System.Windows.Forms.TextBox();
            this.txtbox_vs_regno = new System.Windows.Forms.TextBox();
            this.txtbox_vs_vid = new System.Windows.Forms.TextBox();
            this.cb_add_parts = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_v_id = new System.Windows.Forms.RadioButton();
            this.rb_reg_no = new System.Windows.Forms.RadioButton();
            this.btn_viewservice = new System.Windows.Forms.Button();
            this.dgv_vs_view = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vs_view)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_service_id
            // 
            this.txtbox_service_id.Location = new System.Drawing.Point(190, 133);
            this.txtbox_service_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_service_id.Multiline = true;
            this.txtbox_service_id.Name = "txtbox_service_id";
            this.txtbox_service_id.Size = new System.Drawing.Size(233, 25);
            this.txtbox_service_id.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Service ID";
            // 
            // btn_closeservice
            // 
            this.btn_closeservice.Location = new System.Drawing.Point(540, 137);
            this.btn_closeservice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_closeservice.Name = "btn_closeservice";
            this.btn_closeservice.Size = new System.Drawing.Size(87, 30);
            this.btn_closeservice.TabIndex = 41;
            this.btn_closeservice.Text = "Close";
            this.btn_closeservice.UseVisualStyleBackColor = true;
            // 
            // btn_savesarvice
            // 
            this.btn_savesarvice.Location = new System.Drawing.Point(540, 97);
            this.btn_savesarvice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_savesarvice.Name = "btn_savesarvice";
            this.btn_savesarvice.Size = new System.Drawing.Size(87, 30);
            this.btn_savesarvice.TabIndex = 40;
            this.btn_savesarvice.Text = "Save";
            this.btn_savesarvice.UseVisualStyleBackColor = true;
            this.btn_savesarvice.Click += new System.EventHandler(this.btn_savesarvice_Click);
            // 
            // dtp_vs_servicedate
            // 
            this.dtp_vs_servicedate.Location = new System.Drawing.Point(190, 200);
            this.dtp_vs_servicedate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_vs_servicedate.Name = "dtp_vs_servicedate";
            this.dtp_vs_servicedate.Size = new System.Drawing.Size(233, 24);
            this.dtp_vs_servicedate.TabIndex = 39;
            // 
            // txtbox_parts_name
            // 
            this.txtbox_parts_name.Location = new System.Drawing.Point(190, 336);
            this.txtbox_parts_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_parts_name.Multiline = true;
            this.txtbox_parts_name.Name = "txtbox_parts_name";
            this.txtbox_parts_name.Size = new System.Drawing.Size(233, 25);
            this.txtbox_parts_name.TabIndex = 38;
            this.txtbox_parts_name.Text = "parts_name";
            // 
            // txtbox_vs_milestone
            // 
            this.txtbox_vs_milestone.Location = new System.Drawing.Point(190, 302);
            this.txtbox_vs_milestone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_vs_milestone.Multiline = true;
            this.txtbox_vs_milestone.Name = "txtbox_vs_milestone";
            this.txtbox_vs_milestone.Size = new System.Drawing.Size(233, 25);
            this.txtbox_vs_milestone.TabIndex = 37;
            // 
            // txtbox_vs_descrip
            // 
            this.txtbox_vs_descrip.Location = new System.Drawing.Point(190, 268);
            this.txtbox_vs_descrip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_vs_descrip.Multiline = true;
            this.txtbox_vs_descrip.Name = "txtbox_vs_descrip";
            this.txtbox_vs_descrip.Size = new System.Drawing.Size(233, 25);
            this.txtbox_vs_descrip.TabIndex = 36;
            // 
            // txtbox_vs_servicetype
            // 
            this.txtbox_vs_servicetype.Location = new System.Drawing.Point(190, 234);
            this.txtbox_vs_servicetype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_vs_servicetype.Multiline = true;
            this.txtbox_vs_servicetype.Name = "txtbox_vs_servicetype";
            this.txtbox_vs_servicetype.Size = new System.Drawing.Size(233, 25);
            this.txtbox_vs_servicetype.TabIndex = 35;
            // 
            // txtbox_vs_cusname
            // 
            this.txtbox_vs_cusname.Location = new System.Drawing.Point(190, 166);
            this.txtbox_vs_cusname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_vs_cusname.Multiline = true;
            this.txtbox_vs_cusname.Name = "txtbox_vs_cusname";
            this.txtbox_vs_cusname.Size = new System.Drawing.Size(233, 25);
            this.txtbox_vs_cusname.TabIndex = 34;
            // 
            // txtbox_vs_regno
            // 
            this.txtbox_vs_regno.Location = new System.Drawing.Point(178, 45);
            this.txtbox_vs_regno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_vs_regno.Multiline = true;
            this.txtbox_vs_regno.Name = "txtbox_vs_regno";
            this.txtbox_vs_regno.Size = new System.Drawing.Size(245, 25);
            this.txtbox_vs_regno.TabIndex = 33;
            // 
            // txtbox_vs_vid
            // 
            this.txtbox_vs_vid.Location = new System.Drawing.Point(178, 12);
            this.txtbox_vs_vid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_vs_vid.Multiline = true;
            this.txtbox_vs_vid.Name = "txtbox_vs_vid";
            this.txtbox_vs_vid.Size = new System.Drawing.Size(245, 25);
            this.txtbox_vs_vid.TabIndex = 32;
            // 
            // cb_add_parts
            // 
            this.cb_add_parts.AutoSize = true;
            this.cb_add_parts.Location = new System.Drawing.Point(36, 340);
            this.cb_add_parts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_add_parts.Name = "cb_add_parts";
            this.cb_add_parts.Size = new System.Drawing.Size(81, 21);
            this.cb_add_parts.TabIndex = 31;
            this.cb_add_parts.Text = "Add Parts";
            this.cb_add_parts.UseVisualStyleBackColor = true;
            this.cb_add_parts.CheckedChanged += new System.EventHandler(this.cb_add_parts_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Milestone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Service Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Service Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Registration Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Vehicle ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_v_id);
            this.groupBox1.Controls.Add(this.rb_reg_no);
            this.groupBox1.Controls.Add(this.btn_viewservice);
            this.groupBox1.Location = new System.Drawing.Point(649, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 200);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rb_v_id
            // 
            this.rb_v_id.AutoSize = true;
            this.rb_v_id.Location = new System.Drawing.Point(43, 32);
            this.rb_v_id.Name = "rb_v_id";
            this.rb_v_id.Size = new System.Drawing.Size(82, 21);
            this.rb_v_id.TabIndex = 24;
            this.rb_v_id.TabStop = true;
            this.rb_v_id.Text = "Vehicle ID";
            this.rb_v_id.UseVisualStyleBackColor = true;
            // 
            // rb_reg_no
            // 
            this.rb_reg_no.AutoSize = true;
            this.rb_reg_no.Location = new System.Drawing.Point(204, 32);
            this.rb_reg_no.Name = "rb_reg_no";
            this.rb_reg_no.Size = new System.Drawing.Size(112, 21);
            this.rb_reg_no.TabIndex = 25;
            this.rb_reg_no.TabStop = true;
            this.rb_reg_no.Text = "Registration No";
            this.rb_reg_no.UseVisualStyleBackColor = true;
            // 
            // btn_viewservice
            // 
            this.btn_viewservice.Location = new System.Drawing.Point(125, 85);
            this.btn_viewservice.Name = "btn_viewservice";
            this.btn_viewservice.Size = new System.Drawing.Size(75, 23);
            this.btn_viewservice.TabIndex = 18;
            this.btn_viewservice.Text = "View";
            this.btn_viewservice.UseVisualStyleBackColor = true;
            this.btn_viewservice.Click += new System.EventHandler(this.btn_viewservice_Click);
            // 
            // dgv_vs_view
            // 
            this.dgv_vs_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vs_view.Location = new System.Drawing.Point(36, 391);
            this.dgv_vs_view.Name = "dgv_vs_view";
            this.dgv_vs_view.Size = new System.Drawing.Size(927, 212);
            this.dgv_vs_view.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbox_vs_vid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtbox_vs_regno);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 92);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // Vehicle_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 615);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_vs_view);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbox_service_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_closeservice);
            this.Controls.Add(this.btn_savesarvice);
            this.Controls.Add(this.dtp_vs_servicedate);
            this.Controls.Add(this.txtbox_parts_name);
            this.Controls.Add(this.txtbox_vs_milestone);
            this.Controls.Add(this.txtbox_vs_descrip);
            this.Controls.Add(this.txtbox_vs_servicetype);
            this.Controls.Add(this.txtbox_vs_cusname);
            this.Controls.Add(this.cb_add_parts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Vehicle_Service";
            this.Text = "Vehicle_Service";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vs_view)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_service_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_closeservice;
        private System.Windows.Forms.Button btn_savesarvice;
        private System.Windows.Forms.DateTimePicker dtp_vs_servicedate;
        private System.Windows.Forms.TextBox txtbox_parts_name;
        private System.Windows.Forms.TextBox txtbox_vs_milestone;
        private System.Windows.Forms.TextBox txtbox_vs_descrip;
        private System.Windows.Forms.TextBox txtbox_vs_servicetype;
        private System.Windows.Forms.TextBox txtbox_vs_cusname;
        private System.Windows.Forms.TextBox txtbox_vs_regno;
        private System.Windows.Forms.TextBox txtbox_vs_vid;
        private System.Windows.Forms.CheckBox cb_add_parts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_v_id;
        private System.Windows.Forms.RadioButton rb_reg_no;
        private System.Windows.Forms.Button btn_viewservice;
        private System.Windows.Forms.DataGridView dgv_vs_view;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}