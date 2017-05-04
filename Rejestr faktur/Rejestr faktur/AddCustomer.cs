using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Rejestr_Faktur
{
    public partial class AddCustomer_cs : Telerik.WinControls.UI.RadForm
    {
        public AddCustomer_cs()
        {
            InitializeComponent();
        }

        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private void radButtonAdd_Click(object sender, EventArgs e)
        {
            try
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
                string AddCustomerQuery = "INSERT INTO Customers VALUES('" + CompanyName + "', '" + ContactName + "', '" + NIP + "', '" + Address + "', '" + City + "', '" + PostalCode + "', '" + IBAN + "', '" + PhoneNumber + "', '" + Email + "', '" + WWW + "')";
                SqlCommand command = new SqlCommand(AddCustomerQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();

                this.Close();
            }
            catch { MessageBox.Show("Niepoprawny format danych bądź występują puste pola"); }


        }

        private void radButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomer_cs_Load(object sender, EventArgs e)
        {

        }
    }
}
