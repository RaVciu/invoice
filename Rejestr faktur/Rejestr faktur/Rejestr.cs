using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace Rejestr_Faktur
{
    public partial class Rejestr : Telerik.WinControls.UI.RadForm
    {
        public Rejestr()
        {
            InitializeComponent();
        }

        private void Rejestr_Load(object sender, EventArgs e)
        {

        }

        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public void SQL(string command)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(command, connection);
        }

        public void Reload_objectListViewInvoices()
        {
            string command = (@"SELECT com.CompanyName , com.Address, com.City, com.PostalCode, com.Country, com.NIP, com.IBAN, com.BankName, 
                                inv.InvoiceNo, inv.OrderDate, inv.InvoiceDate, inv.PaymentDate, inv.PaymentMethod, inv.CompanyName,
                                inv.NIP, inv.Address, inv.City, inv.PostalCode, inv.Country,
                                invd.ProductName, invd.UnitPrice, invd.Unit, invd.PKWiU, invd.Tax, invd.Quantity, invd.Discount
                                    FROM Invoices as inv
                                    JOIN Company as com ON com.CompanyID = inv.CompanyID
                                    JOIN Customers as cus ON cus.CustomerID = inv.CustomerID
                                    JOIN InvoiceDetails as invd ON invd.InvoiceID = inv.InvoiceID
                                    JOIN Products as prod ON prod.ProductID = invd.ProductID");
        }
    }
}
