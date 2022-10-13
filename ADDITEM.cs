using AForge.Video.DirectShow;
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
using System.Data;
using ZXing;

namespace Final_Project
{
    public partial class ADDITEM : Form
    {
        public ADDITEM()
        {
            InitializeComponent();
            fillCmbo();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Item it = new Item();
            it.Barcode = txtbarcode.Text;
            it.itemName = txtItemName.Text; 
            it.Description = txtdescription.Text;
            it.price = Convert.ToInt32(txtprice.Value);
            it.noofbox = Convert.ToInt32(txtQty.Value);
            it.Sid = int.Parse(cmbsupplierID.Text);
            DAL.additemData(it);

            txtbarcode.Text = "";
            txtItemName.Text = "";
            txtdescription.Text = "";
            txtprice.Text = "";
            txtQty.Text = "";
            cmbsupplierID.Text = "";
            

        }

        private void BTNSUpplierDash_Click(object sender, EventArgs e)
        {
            Itemmaster im = new Itemmaster();
            im.Show();
            this.Hide();
        }

        #region
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;


        private void ADDITEM_Load(object sender, EventArgs e)
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
                txtbarcode.Invoke(new MethodInvoker(delegate ()
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
        void fillCmbo() {
           
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
                        cmbsupplierID.Items.Add(dr["SupplierID"].ToString());

                    }
                   // cmbsupplierID.Text = dr["SupplierID"].ToString();
                }
            }
            catch (Exception)
            {
                
                //throw;
            }
            
        }

        private void cmbsupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
           // fillCmbo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateBarCode gc = new GenerateBarCode();
            gc.Show();
            this.Hide();
        }
    }
}
