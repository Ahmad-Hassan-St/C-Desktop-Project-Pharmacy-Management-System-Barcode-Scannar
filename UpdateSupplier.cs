using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class UpdateSupplier : Form
    {
        public UpdateSupplier()
        {
            InitializeComponent();
        }

        private void BTNSUpplierDash_Click(object sender, EventArgs e)
        {
            Supplier_Dash SD = new Supplier_Dash();
            SD.Show();
            this.Hide();
        }

        private void txtSearchIdSupp_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = DAL.Getconnection();

            if (txtSearchIdSupp.Text == "")
            {

            }
            else
            {
                int id = int.Parse(txtSearchIdSupp.Text);

                string query = "select * from Supplier_t where SupplierID='" + id + "';";

                SqlDataReader reader = DAL.Datafromdatabase(query);

                while (reader.Read())
                {
                    txtSupplierName.Text = reader["SupplierName"].ToString();
                    txtAddress.Text = reader["Saddress"].ToString();
                    txtCompany.Text = reader["Company"].ToString();
                    mtxtcell.Text = reader["Cell"].ToString();
                }
            }
        }

        private void BTNuPDATEsUPPLIER_Click(object sender, EventArgs e)
        {
            Supplier sp = new Supplier();
            sp.sid =int.Parse( txtSearchIdSupp.Text);
            sp.sname = txtSupplierName.Text;
            sp.saddress = txtAddress.Text;
            sp.cellNo = mtxtcell.Text;
            sp.company = txtCompany.Text;

            string query = "update Supplier_t set Saddress='" + sp.saddress + "',Company='" + sp.company + "',SupplierName='" + sp.sname + "',Cell='" + sp.cellNo + "'where SupplierID=" + sp.sid + ";";

            DAL.UpdateSupplierData(query);


            txtSearchIdSupp.Text = "";
            txtSupplierName.Text = "";
            txtAddress.Text = "";
            mtxtcell.Text = "";
            txtCompany.Text = "";


        }
    }
}
