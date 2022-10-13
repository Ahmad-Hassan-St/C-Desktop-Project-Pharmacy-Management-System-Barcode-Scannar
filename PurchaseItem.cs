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
    public partial class PurchaseItem : Form
    {
        public PurchaseItem()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string query = "Select * from purchase_T ;";

            DAL.SupplierDataGrid(dataGridView1, "", query, "purchase_T");
        }

        private void BTNSUpplierDash_Click(object sender, EventArgs e)
        {
            HOME h = new HOME();
            h.Show();
            this.Hide();

        }
        #region
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void PurchaseItem_Load(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
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

        #endregion
        string itemName = "";
        string pPrice = "";
        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = DAL.Getconnection();

            if (txtbarcode.Text == "")
            {

            }
            else
            {
                string id = txtbarcode.Text;

                string query = "select * from Item_t where barcode='" + id + "';";
                SqlDataReader reader = DAL.Datafromdatabase(query);

                while (reader.Read())
                {

                    txtItemName.Text = reader["itemName"].ToString();

                    lblPrice.Text = reader["price"].ToString();
                    lblqty.Text = reader["noofboxes"].ToString();

                    txtSupplierID.Text = reader["supplierId"].ToString();
                    itemName = txtItemName.Text;
                }

                string qry = "select * from inventory where barcode='" + id + "';";

                SqlDataReader rd = DAL.Datafromdatabase(qry);

                while (rd.Read())
                {
                    lblboxes.Text = rd["noofboxes"].ToString();
                    pPrice = rd["PurchasePrice"].ToString();

                }

            }
        }

        private void txtcarton_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection connection = DAL.Getconnection();



            string id = txtbarcode.Text;
            int carton = Convert.ToInt32(txtcarton.Value);

            string query = "select " + carton + "*noofboxes As Boxes," + carton + "*Price  as CPrice from Item_t where barcode='" + id + "';";
            SqlDataReader reader = DAL.Datafromdatabase(query);

            while (reader.Read())
            {

                lblPrice.Text = reader["CPrice"].ToString();
                lblqty.Text = reader["Boxes"].ToString();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Purchase p = new Purchase();
            p.barcode = txtbarcode.Text;
            p.sid = int.Parse(txtSupplierID.Text);
            p.noBox = int.Parse(lblqty.Text);
            p.PurchasePrice = int.Parse(lblPrice.Text);
            p.carton = Convert.ToInt32(txtcarton.Value);
            p.date = Convert.ToDateTime(sysDate.Text);

            p.ExpiryDate = Convert.ToDateTime(ExpiryDate.Text);

            DAL.addPurchaseItem(p);

            //------------------INVENTORY ------------------

            Innventory inv = new Innventory();
            inv.barcode = txtbarcode.Text;
            inv.itemName = txtItemName.Text;
            inv.NoofBoxes = int.Parse(lblqty.Text);
            inv.PurchasePrice = int.Parse(lblPrice.Text);
            inv.expiryDate = Convert.ToDateTime(ExpiryDate.Text);


            //   ---------------------------------
            string query = "select barcode from inventory;";
            SqlDataReader reader = DAL.Datafromdatabase(query);
            string barcode = "";

            // MessageBox.Show("???");
            while (reader.Read())
            {
                if (txtbarcode.Text != reader["barcode"].ToString())
                {
                    inv.SalePrice = Convert.ToInt32(inv.PurchasePrice * 0.1);
                    DAL.AddandUpdateInventory(inv);
                    break;
                }
                else
                {
                    int pp = int.Parse(pPrice) + inv.PurchasePrice;
                    inv.PurchasePrice = pp;
                    double profit = int.Parse(pPrice) + inv.PurchasePrice * 0.1;

                    int pa = Convert.ToInt32(profit);
                    int sale_price = inv.PurchasePrice + pa; // +(inv.PurchasePrice * 0.1);
                    inv.SalePrice = sale_price;

                    int a = int.Parse(lblqty.Text);
                    int bo = int.Parse(lblboxes.Text);
                    int abok = bo + inv.NoofBoxes;
                    inv.NoofBoxes = abok;
                    //------------------
                    //-------------------------
                    string que = "update Inventory set ItemName ='" + inv.itemName + "',SalePrice='" + inv.SalePrice + "',PurchasePrice='" + inv.PurchasePrice + "',NoofBoxes='" + inv.NoofBoxes + "' where Barcode='" + inv.barcode + "';";
                    DAL.UpdateInventory(que);
                    //MessageBox.Show("!!!");
                    

                    //MessageBox.Show("Add update");
                }
            }


        }
    }
}
