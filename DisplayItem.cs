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
using ZXing;

namespace Final_Project
{
    public partial class DisplayItem : Form
    {
        public DisplayItem()
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

        }
        #region
        private void DisplayItem_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                comboCamera.Items.Add(device.Name);
            comboCamera.SelectedIndex = 0;
        }

        private void comboCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
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
                txtSearchIdSupp.Invoke(new MethodInvoker(delegate()
                {
                    txtSearchIdSupp.Text = result.ToString();
                }));
            }

            pictureBox1.Image = bitmap;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void txtSearchIdSupp_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            Item it = new Item();
            if (txtSearchIdSupp.Text == "")
            {

            }
            else
                it.Barcode = txtSearchIdSupp.Text;

            query = "Select * from Item_t where Barcode='"+ it.Barcode + "';";

            DAL.SupplierDataGrid(dataGridView1, it, query, "Item_t");
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {

           string  query = "Select * from Item_t ;";

            DAL.SupplierDataGrid(dataGridView1, "", query, "Item_t");
        }

    }
}
