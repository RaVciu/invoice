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
    public partial class AddInvoiceCustomer : Telerik.WinControls.UI.RadForm
    {
        public AddInvoiceCustomer()
        {
            InitializeComponent();
        }

        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private void Reload_objectListViewCustomers()
        {
            string InvoiceQuery = (@"SELECT CompanyName, ContactName, NIP, Address, City, PostalCode, IBAN,
                                            PhoneNumber, Email, WWW, CustomerID
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
                                    row[8].ToString(), row[9].ToString(), Int16.Parse(row[10].ToString())));
            }
            Generator.GenerateColumns(objectListViewCustomers, typeof(Customer), true);
            objectListViewCustomers.SetObjects(listOfCustomers);

        }

        private void radTextBoxSearchCustomers_TextChanged(object sender, EventArgs e)
        {
            objectListViewCustomers.ModelFilter = TextMatchFilter.Contains(objectListViewCustomers, radTextBoxSearchCustomers.Text);
        }

        private void objectListViewCustomers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            radButtonSelect_Click(sender, e);
        }

        private void AddInvoiceCustomer_Load(object sender, EventArgs e)
        {
            Reload_objectListViewCustomers();
        }

        string cusCompanyName, cusNIP, cusAddress, cusCity, cusPostalCode;
        int cusCustomerID;
        private void radButtonSelect_Click(object sender, EventArgs e)
        {
            var olvcust = ((Customer)objectListViewCustomers.SelectedObject);
            cusCompanyName = olvcust.CompanyName;
            cusAddress = olvcust.Address;
            cusCity = olvcust.City;
            cusNIP = olvcust.NIP;
            cusPostalCode = olvcust.PostalCode;
            cusCustomerID = olvcust.CustomerID;

            var owner = ((AddInvoice)this.Owner);
            owner.radRichTextEditor_cusCompanyName.Text = this.cusCompanyName;
            owner.radTextBox_cusAddress.Text = this.cusAddress;
            owner.radTextBox_cusCity.Text = this.cusCity;
            owner.radTextBox_cusPostalCode.Text = this.cusPostalCode;
            owner.radTextBox_cusNIP.Text = this.cusNIP;
            owner.labelCustomerID.Text = cusCustomerID.ToString();
            this.Close();
        }
    }
}
