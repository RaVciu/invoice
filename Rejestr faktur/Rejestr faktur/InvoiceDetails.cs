using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrightIdeasSoftware;

namespace Rejestr_Faktur
{
    class InvoiceDetails
    {


        public InvoiceDetails(int Ordinal, int InvoiceID, int ProductID, string ProductName, decimal NetUnitPrice, decimal GrossUnitPrice, string PKWiU, string Unit, string Tax, int Quantity, decimal Discount, decimal NetValue, decimal GrossValue)
        {
            this.Ordinal = Ordinal;
            this.InvoiceID = InvoiceID;
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.NetUnitPrice = NetUnitPrice;
            this.GrossUnitPrice = GrossUnitPrice;
            this.PKWiU = PKWiU;
            this.Tax = Tax;
            this.Unit = Unit;
            this.Quantity = Quantity;
            this.Discount = Discount;
            this.NetValue = NetValue;
            this.GrossValue = GrossValue;
        }

        public InvoiceDetails(int Ordinal, int ProductID, string ProductName, decimal NetUnitPrice, decimal GrossUnitPrice, string PKWiU, string Unit, string Tax, int Quantity, decimal Discount, decimal NetValue, decimal GrossValue)
        {
            this.Ordinal = Ordinal;
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.NetUnitPrice = NetUnitPrice;
            this.GrossUnitPrice = GrossUnitPrice;
            this.PKWiU = PKWiU;
            this.Tax = Tax;
            this.Unit = Unit;
            this.Quantity = Quantity;
            this.Discount = Discount;
            this.NetValue = NetValue;
            this.GrossValue = GrossValue;
        }
        [OLVColumn("Lp", Width = 30, TextAlign = System.Windows.Forms.HorizontalAlignment.Center)]
        public int Ordinal { get; set; }

        [OLVColumn (IsVisible = false)]
        public int InvoiceID { get; set; }

        [OLVColumn(IsVisible = false)]
        public int ProductID { get; set; }

        [OLVColumn("Nazwa produktu", Width = 120, TextAlign = System.Windows.Forms.HorizontalAlignment.Center)]
        public string ProductName { get; set; }

        [OLVColumn("Cena netto [zł]", Width = 90, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal NetUnitPrice { get; set; }

        [OLVColumn("Cena brutto [zł]", Width = 90, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal GrossUnitPrice { get; set; }

        [OLVColumn("PKWiU", Width = 40, TextAlign = System.Windows.Forms.HorizontalAlignment.Center)]
        public string PKWiU { get; set; }

        [OLVColumn("Jednostka", Width = 60, TextAlign = System.Windows.Forms.HorizontalAlignment.Center)]
        public string Unit { get; set; }

        [OLVColumn("VAT", Width = 40, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public string Tax { get; set; }

        [OLVColumn("Ilość", Width = 40, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public int Quantity { get; set; }

        [OLVColumn("Rabat", Width = 50, TextAlign = System.Windows.Forms.HorizontalAlignment.Right, AspectToStringFormat = "{0:0,0}")]
        public decimal Discount { get; set; }

        [OLVColumn("Wart. netto [zł]", Width = 100, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal NetValue { get; set; }

        [OLVColumn("Wart. brutto [zł]", Width = 100, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal GrossValue { get; set; }
    }
}
