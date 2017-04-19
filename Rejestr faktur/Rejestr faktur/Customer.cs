using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejestr_Faktur
{
    class Customer
    {
        public  Customer(string CompanyName, string ContactName, string NIP, string Address, string City, string PostalCode,
                         string Country, string IBAN, string PhoneNumber, string Email, string WWW)
        {
            this.CompanyName = CompanyName;
            this.ContactName = ContactName;
            this.NIP = NIP;
            this.Address = Address;
            this.City = City;
            this.PostalCode = PostalCode;
            this.Country = Country;
            this.IBAN = IBAN;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.WWW = WWW;
        }

        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string NIP { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string IBAN { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string WWW { get; set; }
    }
}
