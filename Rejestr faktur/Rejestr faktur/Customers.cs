using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.SqlClient;
using System.Configuration;
using BrightIdeasSoftware;

namespace Rejestr_Faktur
{
    public partial class Customers : Telerik.WinControls.UI.RadForm
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            Reload_objectListViewCustomers();
        }
        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public void Reload_objectListViewCustomers()
        {
            string InvoiceQuery = (@"SELECT CompanyName, ContactName, NIP, Address, City, PostalCode, Country, IBAN,
                                            PhoneNumber, Email, WWW
                                    FROM Customers");

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(InvoiceQuery, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            List<Customer> listOfCustomers = new List<Customer>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listOfCustomers.Add(new Customer(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(),
                                    row[8].ToString(), row[9].ToString(), row[10].ToString()));
            }
            Generator.GenerateColumns(objectListViewCustomers, typeof(Customer), true);
            objectListViewCustomers.SetObjects(listOfCustomers);

        }


    }
}
