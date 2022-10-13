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
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            Supplier_Dash Sd = new Supplier_Dash();
            Sd.Show();
            this.Hide();
        }

        private void btnitem_Click(object sender, EventArgs e)
        {
            Itemmaster im = new Itemmaster();
            im.Show();
            this.Hide();
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            PurchaseItem pi = new PurchaseItem();
            pi.Show();
            this.Hide();
        }

        private void btnsale_Click(object sender, EventArgs e)
        {
            SaleItem SI = new SaleItem();
            SI.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory I = new Inventory();
            I.Show();
            this.Hide();
        }
    }
}
