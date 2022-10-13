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
    public partial class Itemmaster : Form
    {
        public Itemmaster()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HOME h = new HOME();
            h.Show();
            this.Hide();
        }

        private void btnADDITEM_Click(object sender, EventArgs e)
        {
            ADDITEM at = new ADDITEM();
            at.Show();
            this.Hide();
        }

        private void BTNDELETEITEM_Click(object sender, EventArgs e)
        {
            DeleteItem dt = new DeleteItem();
            dt.Show();
            this.Hide();
        }

        private void btnUpdateITEM_Click(object sender, EventArgs e)
        {
            UpdateItem ut = new UpdateItem();
            ut.Show();
            this.Hide();
        }

        private void BTNDISPLAsuP_Click(object sender, EventArgs e)
        {
            DisplayItem dt = new DisplayItem();
            dt.Show();
            this.Hide();
        }
    }
}
