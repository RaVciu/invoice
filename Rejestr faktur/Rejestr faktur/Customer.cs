using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrightIdeasSoftware;

namespace Rejestr_Faktur
{
    class Customer
    {
        public  Customer(string CompanyName, string ContactName, string NIP, string Address, string City, string PostalCode,
                         string IBAN, string PhoneNumber, string Email, string WWW)
        {
            this.CompanyName = CompanyName;
            this.ContactName = ContactName;
            this.NIP = NIP;
            this.Address = Address;
            this.City = City;
            this.PostalCode = PostalCode;
            this.IBAN = IBAN;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.WWW = WWW;
        }

        [OLVColumn ("Nazwa", Width = 100)]
        public string CompanyName { get; set; }

        [OLVColumn("Osoba kontaktowa", Width = 130)]
        public string ContactName { get; set; }

        [OLVColumn(Width = 80)]
        public string NIP { get; set; }

        [OLVColumn("Adres", Width = 120)]
        public string Address { get; set; }

        [OLVColumn("Miasto", Width = 80)]
        public string City { get; set; }

        [OLVColumn("Kod", Width = 70)]
        public string PostalCode { get; set; }

        [OLVColumn("Nr konta bankowego", Width = 80)]
        public string IBAN { get; set; }

        [OLVColumn("Telefon", Width = 80)]
        public string PhoneNumber { get; set; }

        [OLVColumn(Width = 100)]
        public string Email { get; set; }

        [OLVColumn(Width = 100)]
        public string WWW { get; set; }
    }
}
