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
    public partial class AddProduct : Telerik.WinControls.UI.RadForm
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private void radButtonAdd_Click(object sender, EventArgs e)
        {
            string ProductName, PKWiU, Unit;
            string NetUnitPrice, GrossUnitPrice;
            int Tax;

            ProductName = radTextBoxProductName.Text;
            NetUnitPrice = radTextBoxNetUnitPrice.Text;
            GrossUnitPrice = radTextBoxGrossUnitPrice.Text;
            PKWiU = radTextBoxPKWiU.Text;
            Unit = radTextBoxUnit.Text;
            Tax = Int16.Parse(radTextBoxTax.Text);

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string AddProductQuery = "INSERT INTO Products VALUES ('"+ProductName+"', "+NetUnitPrice+","+GrossUnitPrice+" ,'"+PKWiU+"', '"+Unit+"', "+Tax+")";
            SqlCommand command = new SqlCommand(AddProductQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }

        private void radButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radTextBoxNetUnitPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                radTextBoxGrossUnitPrice.Text = (Decimal.Parse(radTextBoxNetUnitPrice.Text) * (1 + ((Decimal.Parse(radTextBoxTax.Text)) / 100))).ToString();
            }

            catch
            {
                if(radTextBoxNetUnitPrice.Text == "")
                {
                    radTextBoxGrossUnitPrice.Text = "";
                }
            }
        }

        private void radTextBoxGrossUnitPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                radTextBoxNetUnitPrice.Text = (Decimal.Parse(radTextBoxGrossUnitPrice.Text) / (1 + ((Decimal.Parse(radTextBoxTax.Text)) / 100))).ToString();
            }

            catch
            {
                if(radTextBoxGrossUnitPrice.Text == "")
                {
                    radTextBoxNetUnitPrice.Text = "";
                }
            }
        }
    }
}
