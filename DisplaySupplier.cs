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
    public partial class DisplaySupplier : Form
    {
        public DisplaySupplier()
        {
            InitializeComponent();
        }

        private void BTNSUpplierDash_Click(object sender, EventArgs e)
        {
            Supplier_Dash SD = new Supplier_Dash();
            SD.Show();
            this.Hide();
        }

        private void BTNSEARCHSUP_Click(object sender, EventArgs e)
        {
            string query = "";
            Supplier sp = new Supplier();
            if (txtSearchIdSupp.Text == "")
            {

            }
            else
                sp.sid = int.Parse(txtSearchIdSupp.Text);

            query = "Select * from Supplier_t where SupplierID=" + sp.sid + ";";

            DAL.SupplierDataGrid(dataGridView1, sp, query, "Supplier_t");
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            Supplier sp = new Supplier();
            string  query = "Select * from Supplier_t ;";
            DAL.SupplierDataGrid(dataGridView1, sp, query,"Supplier_t");
        }
    }
}
