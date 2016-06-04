namespace Project.UI
{
    partial class Customer_Order_View
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
            this.DGV_Order_Payment_Invoice = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_View = new System.Windows.Forms.ComboBox();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Order_Payment_Invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Order_Payment_Invoice
            // 
            this.DGV_Order_Payment_Invoice.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_Order_Payment_Invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Order_Payment_Invoice.Location = new System.Drawing.Point(48, 77);
            this.DGV_Order_Payment_Invoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_Order_Payment_Invoice.Name = "DGV_Order_Payment_Invoice";
            this.DGV_Order_Payment_Invoice.Size = new System.Drawing.Size(871, 562);
            this.DGV_Order_Payment_Invoice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "[ Customer Order / Invoice / Customer Payment ]";
            // 
            // cmb_View
            // 
            this.cmb_View.FormattingEnabled = true;
            this.cmb_View.Location = new System.Drawing.Point(329, 33);
            this.cmb_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_View.Name = "cmb_View";
            this.cmb_View.Size = new System.Drawing.Size(158, 25);
            this.cmb_View.TabIndex = 2;
            this.cmb_View.SelectionChangeCommitted += new System.EventHandler(this.Order_Invoice_Payment_load);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(798, 33);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(90, 29);
            this.btn_exit.TabIndex = 109;
            this.btn_exit.Text = "&Clear";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Customer_Order_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(985, 679);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.cmb_View);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Order_Payment_Invoice);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Customer_Order_View";
            this.Text = "Customer_Order_View";
            this.Load += new System.EventHandler(this.Customer_Order_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Order_Payment_Invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Order_Payment_Invoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_View;
        internal System.Windows.Forms.Button btn_exit;
    }
}