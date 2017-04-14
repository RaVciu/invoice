using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Customers
    {

        public Customers(string CompanyName, string ContactName, string Address, string City, string Country)
        {
            this.CompanyName = CompanyName;
            this.ContactName = ContactName;
            this.Address = Address;
            this.City = City;
            this.Country = Country;
        }


        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }


    }
}
