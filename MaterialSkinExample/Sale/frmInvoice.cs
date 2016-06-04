using BusinessEntities;
using BusinessLogicLayer;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkinExample.Sale
{
    public partial class frmInvoice : MaterialForm
    {
        classbll ObjC = new classbll();
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            DataSet DS = ObjC.getData();
            MessageBox.Show(DS.Tables[0].Rows[0]["A"].ToString());
        }
    }
}
