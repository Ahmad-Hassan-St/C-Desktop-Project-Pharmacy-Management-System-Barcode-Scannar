using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_Project
{
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void BTNSUpplierDash_Click(object sender, EventArgs e)
        {
            Supplier_Dash SD = new Supplier_Dash();
            SD.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //SqlConnection con = DAL.Getconnection();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = DAL.Getconnection();
            Supplier sd = new Supplier();
            sd.sname = txtSupplierName.Text;
            sd.saddress = txtAddress.Text;
            sd.cellNo = mtxtcell.Text;
            sd.company = txtCompany.Text;

            DAL.AddsuplierData(sd);

            txtCompany.Text = "";
        
            txtAddress.Text = "";
            mtxtcell.Text = "";
            txtSupplierName.Text = "";
        
        }
    }
}
