using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrightIdeasSoftware;

namespace Rejestr_Faktur
{
    class TaxRegister_Class
    {

        public TaxRegister_Class(int _Ordinal, string _InvoiceNo, string _InvoiceDate, string _OrderDate, string _cusNIP, string _cusCompanyName, string _cusFullAddress, decimal _GrossValue,
                                 decimal _NetValue23, decimal _TaxValue23, decimal _NetValue8, decimal _TaxValue8, decimal _NetValue5, decimal _TaxValue5, decimal _NetValue0, decimal _NetValueZW,
                                 decimal _NetValueOO, decimal _NetValueNP, decimal _TaxValue)
        {
            Ordinal = _Ordinal;
            InvoiceNo = _InvoiceNo;
            InvoiceDate = _InvoiceDate;
            OrderDate = _OrderDate;
            cusNIP = _cusNIP;
            cusCompanyName = _cusCompanyName;
            cusFullAddress = _cusFullAddress;
            GrossValue = _GrossValue;
            NetValue23 = _NetValue23;
            TaxValue23 = _TaxValue23;
            NetValue8 = _NetValue8;
            TaxValue8 = _TaxValue8;
            NetValue5 = _NetValue5;
            TaxValue5 = _TaxValue5;
            NetValue0 = _NetValue0;
            NetValueZW = _NetValueZW;
            NetValueOO = _NetValueOO;
            NetValueNP = _NetValueNP;
            TaxValue = _TaxValue;
    }

        [OLVColumn ("Lp.", Width = 30)]
        public int Ordinal { get; set; }

        [OLVColumn("Numer dokumentu", Width = 100)]
        public string InvoiceNo { get; set; }

        [OLVColumn("Data wystawienia", Width = 100)]
        public string InvoiceDate { get; set; }

        [OLVColumn("Data sprzedaży", Width = 100)]
        public string OrderDate { get; set; }

        [OLVColumn("NIP kontrahenta", Width = 100, TextAlign = System.Windows.Forms.HorizontalAlignment.Center)]
        public string cusNIP { get; set; }

        [OLVColumn("Nazwa kontrahenta", Width = 100, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public string cusCompanyName { get; set; }

        [OLVColumn("Adres kontrahenta", Width = 100)]
        public string cusFullAddress { get; set; }

        [OLVColumn("Brutto", Width = 80, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal GrossValue { get; set; }

        [OLVColumn("Netto 23%", Width = 80, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal NetValue23 { get; set; }

        [OLVColumn("VAT 23%", Width = 80, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal TaxValue23 { get; set; }

        [OLVColumn("Netto 8/7[%]", Width = 80, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal NetValue8 { get; set; }

        [OLVColumn("VAT 8/7[%]", Width = 80, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal TaxValue8 { get; set; }

        [OLVColumn("Netto 5[%]", Width = 80, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal NetValue5 { get; set; }

        [OLVColumn("VAT 5[%]", Width = 80, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal TaxValue5 { get; set; }

        [OLVColumn("Stawka 0%", Width = 80, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal NetValue0 { get; set; }

        [OLVColumn("Sprzedaż zwolniona", Width = 80, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal NetValueZW { get; set; }

        [OLVColumn("Odwrotne obciążenie", Width = 80, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal NetValueOO { get; set; }

        [OLVColumn("Niepodlegające opodatkowaniu", Width = 80, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal NetValueNP { get; set; }

        [OLVColumn("Suma VAT", Width = 80, TextAlign = System.Windows.Forms.HorizontalAlignment.Right)]
        public decimal TaxValue { get; set; }




    }
}
