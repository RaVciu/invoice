﻿using BrightIdeasSoftware;

namespace Rejestr_Faktur
{
    class TaxList
    {
        public TaxList(string TaxName, string Tax,decimal NetValue, decimal TaxValue, decimal GrossValue)
        {
            this.TaxName = TaxName;
            this.Tax = Tax;
            this.NetValue = NetValue;
            this.TaxValue = TaxValue;
            this.GrossValue = GrossValue;
        }

        [OLVColumn("Stawka VAT [%]", Width = 100, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public string TaxName { get; set; }

        [OLVColumn("Wart. netto [zł]", Width = 100, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal NetValue { get; set; }

        [OLVColumn("Wart. VAT [zł]", Width = 100, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal TaxValue { get; set; }

        [OLVColumn("Wart. brutto [zł]", Width = 100, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal GrossValue { get; set; }

        [OLVColumn ("VAT %", IsVisible = true)]
        public string Tax { get; set; }
    }
}
