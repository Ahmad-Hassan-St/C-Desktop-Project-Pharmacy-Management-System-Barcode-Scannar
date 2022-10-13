using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Final_Project
{
    public partial class GenerateBarCode : Form
    {
        public GenerateBarCode()
        {
            InitializeComponent();
        }

        private void txtSupplierID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNSUpplierDash_Click(object sender, EventArgs e)
        {
            ADDITEM at = new ADDITEM();
            at.Show();
            this.Hide();
        }

        private void btnGenrate_Click(object sender, EventArgs e)
        {
           
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            pictureBox1.Image = writer.Write(txtencode.Text);
        
        }

        private void btnDecod_Click(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode((Bitmap)pictureBox1.Image);
            if (result != null)
                txtDecode.Text = result.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PrintDialog Pd = new PrintDialog();
            PrintDocument PDoc = new PrintDocument();

            PDoc.PrintPage += PDoc_PrintPage;
            Pd.Document = PDoc;
            if (Pd.ShowDialog() == DialogResult.OK)
                PDoc.Print();
        }
        void PDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap btp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(btp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(btp, 0, 0);
            btp.Dispose();
        }
    }
}
