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
using BrightIdeasSoftware;

namespace Rejestr_Faktur
{
    public partial class Register : Telerik.WinControls.UI.RadForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Rejestr_Load(object sender, EventArgs e)
        {
            Reload_objectListViewInvoices();
            radButtonPrint.Enabled = false;
            radButtonDeleteInvoice.Enabled = false;
        }

            
        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public void Reload_objectListViewInvoices()
        {
            string InvoiceQuery = (@"SELECT com.CompanyName, inv.IssuedBy, com.Address, com.City, com.PostalCode, com.NIP, com.IBAN, com.BankName, 
                                inv.CompanyName, inv.NIP, inv.Address, inv.City, inv.PostalCode, inv.InvoiceNo, inv.OrderDate, inv.InvoiceDate, inv.PaymentDate, inv.PaymentMethod,  inv.Sum, inv.InvoiceID
                                    FROM Invoices as inv
                                    JOIN Company as com ON com.CompanyID = inv.CompanyID");

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(InvoiceQuery, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            List<Invoice> listOfInvoices = new List<Invoice>();

            decimal GrossValue = 0;

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                DateTime OrderDate = DateTime.Parse(row[14].ToString());
                DateTime InvoiceDate = DateTime.Parse(row[15].ToString());
                DateTime PaymentDate = DateTime.Parse(row[16].ToString());

                decimal Sum = Decimal.Round(Decimal.Parse(row[18].ToString()), 2);
                GrossValue += Sum;

                listOfInvoices.Add(new Invoice(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(),
                                     row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString(), row[11].ToString(), row[12].ToString(), row[13].ToString(),
                                     OrderDate.ToString("dd.MM.yyyy"), InvoiceDate.ToString("dd.MM.yyyy"), PaymentDate.ToString("dd.MM.yyyy"), row[17].ToString(), Sum, int.Parse(row[19].ToString())));
            }
            objectListViewInvoices.SetObjects(listOfInvoices);
            labelGrossValue.Text = GrossValue.ToString();

           
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            objectListViewInvoices.ModelFilter = TextMatchFilter.Contains(objectListViewInvoices, textBoxSearch.Text);
        }

        private void radButtonCustomers_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void radButtonProducts_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void radButtonAddInvoice_Click(object sender, EventArgs e)
        {
            AddInvoice AddInv = new AddInvoice();
            AddInv.Show();
        }

        private void objectListViewInvoices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                EditInvoice editinv = new EditInvoice();
                editinv.InvoiceID = ((Invoice)objectListViewInvoices.SelectedObject).InvoiceID;
                editinv.Show();
            }
            catch { }
        }

        private void radButtonPrint_Click(object sender, EventArgs e)
        {
            PrintInvoice print = new PrintInvoice();
            print.InvoiceID = ((Invoice)objectListViewInvoices.SelectedObject).InvoiceID;
            print.Show();
        }

        private void objectListViewInvoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectListViewInvoices.SelectedObjects.Count > 0)
            {
                radButtonPrint.Enabled = true;
                radButtonDeleteInvoice.Enabled = true;
            }
            else
            {
                radButtonPrint.Enabled = false;
                radButtonDeleteInvoice.Enabled = false;
            }
        }

        private void radButtonDeleteInvoice_Click(object sender, EventArgs e)
        {
            int InvoiceID = ((Invoice)objectListViewInvoices.SelectedObject).InvoiceID;
            string QueryDeleteInvoiceDetails = "DELETE FROM InvoiceDetails WHERE InvoiceID = " + InvoiceID + "";
            string QueryDeleteTaxDetails = "DELETE FROM TaxDetails WHERE InvoiceID = " + InvoiceID + "";
            string QueryDeleteInvoice = "DELETE FROM Invoices WHERE InvoiceID = " + InvoiceID + "";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmdDeleteInvD = new SqlCommand(QueryDeleteInvoiceDetails, connection);
            SqlCommand cmdDeleteTaxD = new SqlCommand(QueryDeleteTaxDetails, connection);
            SqlCommand cmdDeleteInv = new SqlCommand(QueryDeleteInvoice, connection);
            connection.Open();
            cmdDeleteInvD.ExecuteNonQuery();
            cmdDeleteTaxD.ExecuteNonQuery();
            cmdDeleteInv.ExecuteNonQuery();
            connection.Close();
            Reload_objectListViewInvoices();
        }

        private void radButtonTaxRegister_Click(object sender, EventArgs e)
        {
            TaxRegister TaxR = new TaxRegister();
            TaxR.Owner = this;
            TaxR.Show();
        }
    }
}
