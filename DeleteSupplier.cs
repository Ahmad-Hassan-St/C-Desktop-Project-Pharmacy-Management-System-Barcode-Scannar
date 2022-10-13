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
    public partial class DeleteSupplier : Form
    {
        public DeleteSupplier()
        {
            InitializeComponent();
        }

        private void BTNSUpplierDash_Click(object sender, EventArgs e)
        {
            Supplier_Dash SD = new Supplier_Dash();
            SD.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchIdSupp_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            Supplier sp = new Supplier();
            if (txtSearchIdSup.Text=="")
            {
                
            }
            else
             sp.sid = int.Parse(txtSearchIdSup.Text);

            query = "Select * from Supplier_t where SupplierID="+sp.sid+";";

            DAL.SupplierDataGrid(dataGridView1, sp, query, "Supplier_t");
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            Supplier sp = new Supplier();
            sp.sid = int.Parse(txtSearchIdSup.Text);
            string query = "Delete From Supplier_t where  SupplierID=" + sp.sid + "";

            DAL.DeleteSupplierData(query);

            txtSearchIdSup.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteSupplier_Load(object sender, EventArgs e)
        {

        }
    }
}
