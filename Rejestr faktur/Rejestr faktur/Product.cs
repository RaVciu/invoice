using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrightIdeasSoftware;

namespace Rejestr_Faktur
{
    class Product
    {

        public Product(string ProductName, decimal UnitPrice, string PKWiU, string Unit, int Tax, int ProductID)
        {
            this.ProductName = ProductName;
            this.UnitPrice = UnitPrice;
            this.PKWiU = PKWiU;
            this.Unit = Unit;
            this.Tax = Tax;
            this.ProductID = ProductID;
        }

        [OLVColumn ("Nazwa", Width = 100)]
        public string ProductName { get; set; }

        [OLVColumn("Cena", Width = 80, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal UnitPrice { get; set; }

        [OLVColumn("PKWIU", Width = 60, TextAlign = System.Windows.Forms.HorizontalAlignment.Center)]
        public string PKWiU { get; set; }

        [OLVColumn("Jednostka", Width = 60, TextAlign = System.Windows.Forms.HorizontalAlignment.Center)]
        public string Unit { get; set; }

        [OLVColumn("VAT", Width = 30, TextAlign = System.Windows.Forms.HorizontalAlignment.Center)]
        public int Tax { get; set; }

        [OLVColumn (IsVisible = false)]
        public int ProductID { get; set; }
    }
}
