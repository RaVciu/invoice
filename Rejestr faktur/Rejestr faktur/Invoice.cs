

namespace Rejestr_Faktur
{
    class Invoice
    {
        public Invoice(string comCompanyName, string IssuedBy, string comAddress, string comCity, string comPostalCode, string comNIP, string comIBAN, string comBankName,
                       string cusCompanyName, string cusNIP, string cusAddress, string cusCity, string cusPostalCode, string InvoiceNo, string OrderDate,
                       string InvoiceDate, string PaymentDate, string PaymentMethod, decimal Sum, int InvoiceID)
        {
            this.comCompanyName = comCompanyName;
            this.IssuedBy = IssuedBy;
            this.comAddress = comAddress;
            this.comCity = comCity;
            this.comPostalCode = comPostalCode;
            this.comNIP = comNIP;
            this.comIBAN = comIBAN;
            this.comBankName = comBankName;
            this.cusCompanyName = cusCompanyName;
            this.cusNIP = cusNIP;
            this.cusAddress = cusAddress;
            this.cusCity = cusCity;
            this.cusPostalCode = cusPostalCode;
            this.InvoiceNo = InvoiceNo;
            this.OrderDate = OrderDate;
            this.InvoiceDate = InvoiceDate;
            this.PaymentDate = PaymentDate;
            this.PaymentMethod = PaymentMethod;
            this.Sum = Sum;
            this.InvoiceID = InvoiceID;
        }


        public string comCompanyName { get; set; }
        public string IssuedBy { get; set; }
        public string comAddress { get; set; }
        public string comCity { get; set; }
        public string comPostalCode { get; set; }
        public string comNIP { get; set; }
        public string comIBAN { get; set; }
        public string comBankName { get; set; }
        public string cusCompanyName { get; set; }
        public string cusNIP { get; set; }
        public string cusAddress { get; set; }
        public string cusCity { get; set; }
        public string cusPostalCode { get; set; }
        public string InvoiceNo { get; set; }
        public string OrderDate { get; set; }
        public string InvoiceDate { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Sum { get; set; }
        public int InvoiceID { get; set; }
    }
}
