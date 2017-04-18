using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejestr_Faktur
{
    class Invoice
    {
        public Invoice(string comCompanyName, string IssuedBy, string comAddress, string comCity, string comPostalCode, string comCountry, string comNIP, string comIBAN, string comBankName,
                       string cusCompanyName, string cusNIP, string cusAddress, string cusCity, string cusPostalCode, string cusCountry, string InvoiceNo, string OrderDate,
                       string InvoiceDate, string PaymentDate, string PaymentMethod, decimal Sum)
        {
            this.comCompanyName = comCompanyName;
            this.IssuedBy = IssuedBy;
            this.comAddress = comAddress;
            this.comCity = comCity;
            this.comPostalCode = comPostalCode;
            this.comCountry = comCountry;
            this.comNIP = comNIP;
            this.comIBAN = comIBAN;
            this.comBankName = comBankName;
            this.cusCompanyName = cusCompanyName;
            this.cusNIP = cusNIP;
            this.cusAddress = cusAddress;
            this.cusCity = cusCity;
            this.cusPostalCode = cusPostalCode;
            this.cusCountry = cusCountry;
            this.InvoiceNo = InvoiceNo;
            this.OrderDate = OrderDate;
            this.InvoiceDate = InvoiceDate;
            this.PaymentDate = PaymentDate;
            this.PaymentMethod = PaymentMethod;
            //this.ProductName = ProductName;
            //this.UnitPrice = UnitPrice;
            //this.Unit = Unit;
            //this.PKWiU = PKWiU;
            //this.Tax = Tax;
            //this.Quantity = Quantity;
            //this.Discount = Discount;
            this.Sum = Sum;
        }

        public string comCompanyName { get; set; }
        public string IssuedBy { get; set; }
        public string comAddress { get; set; }
        public string comCity { get; set; }
        public string comPostalCode { get; set; }
        public string comCountry { get; set; }
        public string comNIP { get; set; }
        public string comIBAN { get; set; }
        public string comBankName { get; set; }
        public string cusCompanyName { get; set; }
        public string cusNIP { get; set; }
        public string cusAddress { get; set; }
        public string cusCity { get; set; }
        public string cusPostalCode { get; set; }
        public string cusCountry { get; set; }
        public string InvoiceNo { get; set; }
        public string OrderDate { get; set; }
        public string InvoiceDate { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        //public string ProductName { get; set; }
        //public double UnitPrice { get; set; }
        //public string Unit { get; set; }
        //public string PKWiU { get; set; }
        //public double Tax { get; set; }
        //public int Quantity { get; set; }
        //public double Discount { get; set; }
        public decimal Sum { get; set; }
    }
}
