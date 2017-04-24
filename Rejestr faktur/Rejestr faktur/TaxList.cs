using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrightIdeasSoftware;

namespace Rejestr_Faktur
{
    class TaxList
    {
        public TaxList(int Tax, decimal NetValue, decimal TaxValue, decimal GrossValue)
        {
            this.Tax = Tax;
            this.NetValue = NetValue;
            this.TaxValue = TaxValue;
            this.GrossValue = GrossValue;
        }

        [OLVColumn("Stawka VAT [%]", Width = 100, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public int Tax { get; set; }

        [OLVColumn("Wart. netto [zł]", Width = 100, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal NetValue { get; set; }

        [OLVColumn("Wart. VAT [zł]", Width = 100, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal TaxValue { get; set; }

        [OLVColumn("Wart. brutto [zł]", Width = 100, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal GrossValue { get; set; }
    }
}
