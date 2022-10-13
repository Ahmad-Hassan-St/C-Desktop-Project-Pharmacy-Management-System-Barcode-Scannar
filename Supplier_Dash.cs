using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Supplier_Dash : Form
    {
        public Supplier_Dash()
        {
            InitializeComponent();
        }

        private void btnADDsupplier_Click(object sender, EventArgs e)
        {
            AddSupplier AS = new AddSupplier();
            AS.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HOME h = new HOME();
            h.Show();
            this.Hide();
         }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSupplier US = new UpdateSupplier();
            US.Show();
            this.Hide();
        }

        private void BTNDELETESUP_Click(object sender, EventArgs e)
        {
            DeleteSupplier ds = new DeleteSupplier();
            ds.Show();
            this.Hide();
        }

        private void BTNDISPLAsuP_Click(object sender, EventArgs e)
        {
            DisplaySupplier DS = new DisplaySupplier();
            DS.Show();
            this.Hide();

        }
    }
}
