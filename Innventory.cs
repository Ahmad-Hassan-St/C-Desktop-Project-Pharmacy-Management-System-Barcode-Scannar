using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Innventory
    {
        public string  barcode { get; set; }
        public string  itemName { get; set; }
        public string  Description { get; set; }
        public int SalePrice  { get; set; }
        public int PurchasePrice { get; set; }
        public int NoofBoxes { get; set; }
        public DateTime  expiryDate { get; set; }
    }
}
