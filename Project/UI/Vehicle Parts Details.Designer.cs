namespace Project.UI
{
    partial class Vehicle_Parts_Details
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
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_chassyNo = new System.Windows.Forms.TextBox();
            this.txt_Vp_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vid = new System.Windows.Forms.TextBox();
            this.DGV_VehicleParts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_Vp_Price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VehicleParts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 119);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 17);
            this.label18.TabIndex = 125;
            this.label18.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 126;
            this.label3.Text = "Brand";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 17);
            this.label17.TabIndex = 123;
            this.label17.Text = "Description";
            // 
            // txt_Desc
            // 
            this.txt_Desc.Location = new System.Drawing.Point(162, 73);
            this.txt_Desc.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(157, 24);
            this.txt_Desc.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 124;
            this.label2.Text = "Chassy No";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 17);
            this.label16.TabIndex = 119;
            this.label16.Text = "Vehicle Parts ID";
            // 
            // txt_chassyNo
            // 
            this.txt_chassyNo.Location = new System.Drawing.Point(162, 73);
            this.txt_chassyNo.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_chassyNo.Name = "txt_chassyNo";
            this.txt_chassyNo.Size = new System.Drawing.Size(157, 24);
            this.txt_chassyNo.TabIndex = 122;
            // 
            // txt_Vp_id
            // 
            this.txt_Vp_id.Location = new System.Drawing.Point(162, 33);
            this.txt_Vp_id.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_Vp_id.Name = "txt_Vp_id";
            this.txt_Vp_id.Size = new System.Drawing.Size(157, 24);
            this.txt_Vp_id.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 120;
            this.label1.Text = "Vehicle ID";
            // 
            // txt_vid
            // 
            this.txt_vid.Location = new System.Drawing.Point(162, 33);
            this.txt_vid.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_vid.Name = "txt_vid";
            this.txt_vid.Size = new System.Drawing.Size(157, 24);
            this.txt_vid.TabIndex = 118;
            // 
            // DGV_VehicleParts
            // 
            this.DGV_VehicleParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VehicleParts.Location = new System.Drawing.Point(357, 33);
            this.DGV_VehicleParts.Name = "DGV_VehicleParts";
            this.DGV_VehicleParts.Size = new System.Drawing.Size(301, 150);
            this.DGV_VehicleParts.TabIndex = 129;
            this.DGV_VehicleParts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_VehicleParts_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_view);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Location = new System.Drawing.Point(60, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(164, 378);
            this.groupBox2.TabIndex = 130;
            this.groupBox2.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(27, 297);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(118, 51);
            this.btn_clear.TabIndex = 64;
            this.btn_clear.Text = "&Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(27, 232);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(118, 51);
            this.btn_delete.TabIndex = 63;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(27, 166);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(118, 51);
            this.btn_update.TabIndex = 62;
            this.btn_update.Text = "&Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(27, 101);
            this.btn_view.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(118, 51);
            this.btn_view.TabIndex = 61;
            this.btn_view.Text = "&View";
            this.btn_view.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(27, 37);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 51);
            this.btn_save.TabIndex = 60;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_Vp_Price
            // 
            this.txt_Vp_Price.Location = new System.Drawing.Point(162, 116);
            this.txt_Vp_Price.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_Vp_Price.Name = "txt_Vp_Price";
            this.txt_Vp_Price.Size = new System.Drawing.Size(157, 24);
            this.txt_Vp_Price.TabIndex = 122;
            // 
            // Vehicle_Parts_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(684, 564);
            this.Controls.Add(this.txt_Vp_Price);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DGV_VehicleParts);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_chassyNo);
            this.Controls.Add(this.txt_Vp_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_vid);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Vehicle_Parts_Details";
            this.Text = "Vehicle_Parts_Details";
            this.Load += new System.EventHandler(this.Vehicle_Parts_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VehicleParts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_chassyNo;
        private System.Windows.Forms.TextBox txt_Vp_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_vid;
        private System.Windows.Forms.DataGridView DGV_VehicleParts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_Vp_Price;
    }
}