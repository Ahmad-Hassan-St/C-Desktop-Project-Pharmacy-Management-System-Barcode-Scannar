using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Purchase
    {
        public string barcode { get; set; }
        public int  sid { get; set; }
        public int noBox { get; set; }
        public int carton { get; set; }
        public int PurchasePrice { get; set; }
        public DateTime date { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
