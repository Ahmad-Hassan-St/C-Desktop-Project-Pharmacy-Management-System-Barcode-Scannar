using AForge.Video.DirectShow;
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
using ZXing;

namespace Final_Project
{
    public partial class SaleItem : Form
    {
        public SaleItem()
        {
            InitializeComponent();
            //lblboxes.Text = "0";
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            Billitem BI = new Billitem();
            BI.Show();
            this.Hide();

        }

        private void BTNSUpplierDash_Click(object sender, EventArgs e)
        {

            HOME h = new HOME();
            h.Show();
            this.Hide();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;


        private void SaleItem_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                comboCamera.Items.Add(device.Name);
            comboCamera.SelectedIndex = 0;
        }

        private void btnConnectCamera_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txtbarcode.Invoke(new MethodInvoker(delegate()
                {
                    txtbarcode.Text = result.ToString();
                }));
            }

            pictureBox1.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void comboCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Sale sl = new Sale();
            sl.Barcode = txtbarcode.Text;
            sl.CustomerName = txtCustomerName.Text;
            sl.NoBoxes = Convert.ToInt32(txtQty.Value);
            sl.SDate = Convert.ToDateTime(sysDate.Text);
            double a = Convert.ToDouble(lblPrice.Text);
            sl.SalePrice = Convert.ToInt16(a);
            DAL.addSale(sl);
            #region
            //-----------------Inventory--------------------

            Innventory inv = new Innventory();
            inv.barcode = txtbarcode.Text;
            int saleqty = Convert.ToInt32(txtQty.Value);
            inv.NoofBoxes = Convert.ToInt32(lblboxes.Text) - saleqty;

                    string que = "update Inventory set NoofBoxes='" + inv.NoofBoxes + "'where Barcode='" + inv.barcode + "';";
                    DAL.UpdateInventory(que);
             
#endregion

            
        }


        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = DAL.Getconnection();

            if (txtbarcode.Text == "")
            {
                
            }
            else
            {
                string id = txtbarcode.Text;

                string query = "select * from inventory where barcode='" + id + "';";
                
                SqlDataReader reader = DAL.Datafromdatabase(query);

                while (reader.Read())
                {

                    txtitemName.Text = reader["itemName"].ToString();
                    lblPrice.Text = reader["SalePrice"].ToString();
                    txtQty.Text = reader["noofboxes"].ToString();
                    lblboxes.Text = reader["noofboxes"].ToString();

                }
                string qry = "select * from inventory where barcode='" + id + "';";

                

            }
        }

        private void txtQty_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection connection = DAL.Getconnection();



            string id = txtbarcode.Text;
            int carton = Convert.ToInt32(txtQty.Value);


            string query = "select " + carton + "*noofboxes As Boxes," + carton + "*SalePrice  as CPrice from inventory where barcode='" + id + "';";
            SqlDataReader reader = DAL.Datafromdatabase(query);

            while (reader.Read())
            {

                lblPrice.Text = reader["CPrice"].ToString();
              
            }
            if (Convert.ToInt32(lblboxes.Text) < Convert.ToInt32(txtQty.Value))
            {
                lblcheck.Text = "Not in Inventory";

            }
            else
            {
                lblcheck.Text = "*";
            }
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string query = "Select * from Sale_t ;";

            DAL.SupplierDataGrid(dataGridView1, "", query, "Sale_t");
       
        }
    }
}
