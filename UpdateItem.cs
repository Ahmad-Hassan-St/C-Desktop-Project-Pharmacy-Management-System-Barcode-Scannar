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
using AForge.Video.DirectShow;
using ZXing;

namespace Final_Project
{
    public partial class UpdateItem : Form
    {
        public UpdateItem()
        {
            InitializeComponent();
            fillCmbo();
        }

        private void BTNSUpplierDash_Click(object sender, EventArgs e)
        {
            Itemmaster im = new Itemmaster();
            im.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Item it = new Item();
            
            
            it.Barcode = txtSearchId.Text;
            it.itemName =txtitemName.Text;
            it.Description = txtdescription.Text;
            it.price = Convert.ToInt32(txtprice.Value);
            it.noofbox = Convert.ToInt32(txtQty.Value);
            it.Sid = int.Parse(cmbsupplierId.Text);
            string query = "update Item_t set itemName='" + it.itemName + "',descriptionn='" + it.Description + "',price='" + it.price + "',noofboxes='" + it.noofbox + "'where barcode='" + it.Barcode + "';";
            DAL.UpdateSupplierData(query);

            txtitemName.Text = "";
            txtdescription.Text = "";
            txtprice.Value = 0;
            txtQty.Value = 0;
            cmbsupplierId.Text = "";
            
        }

        private void txtSearchId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = DAL.Getconnection();

            if (txtSearchId.Text == "")
            {

            }
            else
            {
                string id = txtSearchId.Text;

                string query = "select * from Item_t where barcode='" + id + "';";
                SqlDataReader reader = DAL.Datafromdatabase(query);

                while (reader.Read())
                {
                   txtitemName.Text = reader["itemName"].ToString();
                     txtdescription.Text = reader["descriptionn"].ToString();
                   txtprice.Text = reader["price"].ToString();
                   txtQty.Text = reader["noofboxes"].ToString();
                   cmbsupplierId.Text = reader["supplierId"].ToString();
                }
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


        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        
        private void UpdateItem_Load(object sender, EventArgs e)
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
                txtSearchId.Invoke(new MethodInvoker(delegate()
                {
                    txtSearchId.Text = result.ToString();
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
        void fillCmbo()
        {

            try
            {
                SqlConnection con = DAL.Getconnection();
                string selectQuery = "SELECT SupplierID FROM Supplier_t";
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                //cmd.Parameters.AddWithValue("@SupplierName", SupplierName);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        cmbsupplierId.Items.Add(dr["SupplierID"].ToString());

                    }
                    // cmbsupplierID.Text = dr["SupplierID"].ToString();
                }
            }
            catch (Exception)
            {

                //throw;
            }

        }

        private void cmbsupplierId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
