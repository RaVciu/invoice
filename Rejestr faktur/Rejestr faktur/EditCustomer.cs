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

namespace Rejestr_Faktur
{
    public partial class EditCustomer : Telerik.WinControls.UI.RadForm
    {
        public EditCustomer()
        {
            InitializeComponent();
        }
        public string CompanyName, ContactName, NIP, Address, City, PostalCode, IBAN, PhoneNumber, Email, WWW;
        public int CustomerID;

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            radTextBoxCompanyName.Text = CompanyName;
            radTextBoxContactName.Text = ContactName;
            radTextBoxNIP.Text = NIP;
            radTextBoxAddress.Text = Address;
            radTextBoxCity.Text = City;
            radTextBoxPostalCode.Text = PostalCode;
            radTextBoxIBAN.Text = IBAN;
            radTextBoxPhoneNumber.Text = PhoneNumber;
            radTextBoxEmail.Text = Email;
            radTextBoxWWW.Text = WWW;
        }

        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private void radButtonEdit_Click(object sender, EventArgs e)
        {
            string CompanyName, ContactName, NIP, Address, City, PostalCode, IBAN, PhoneNumber, Email, WWW;
            CompanyName = radTextBoxCompanyName.Text;
            ContactName = radTextBoxContactName.Text;
            NIP = radTextBoxNIP.Text;
            Address = radTextBoxAddress.Text;
            City = radTextBoxCity.Text;
            PostalCode = radTextBoxPostalCode.Text;
            IBAN = radTextBoxIBAN.Text;
            PhoneNumber = radTextBoxPhoneNumber.Text;
            Email = radTextBoxEmail.Text;
            WWW = radTextBoxWWW.Text;

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string EditCustomerQuery = "UPDATE Customers SET CompanyName = '" + CompanyName + "', ContactName = '" + ContactName + "',NIP = '" + NIP + "',Address = '" + Address + "',City = '" + City + "',PostalCode = '" + PostalCode + "',IBAN = '" + IBAN + "',PhoneNumber = '" + PhoneNumber + "',Email = '" + Email + "',WWW = '" + WWW + "' WHERE CustomerID = '"+this.CustomerID+"'";
            SqlCommand command = new SqlCommand(EditCustomerQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }
    }
}
