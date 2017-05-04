using System;
using System.Windows.Forms;
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

        private void AddProduct_Load(object sender, EventArgs e)
        {
            
        }

          string ProductName, PKWiU, Unit;
          string NetUnitPrice, GrossUnitPrice;
          string Tax, TaxName;
        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private void radButtonAdd_Click(object sender, EventArgs e)
        {
  
            
            ProductName = radTextBoxProductName.Text;
            NetUnitPrice = (radTextBoxNetUnitPrice.Text).Replace(",", ".");
            GrossUnitPrice = (radTextBoxGrossUnitPrice.Text).Replace(",", ".");
            PKWiU = radTextBoxPKWiU.Text;
            Unit = radTextBoxUnit.Text;
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                string AddProductQuery = "INSERT INTO Products VALUES ('" + ProductName + "', " + NetUnitPrice + "," + GrossUnitPrice + " ,'" + PKWiU + "', '" + Unit + "', " + Tax + ")";
                SqlCommand command = new SqlCommand(AddProductQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
            catch { MessageBox.Show("Niepoprawny format danych bądź występują puste pola"); }
        }

        private void radButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool GrossUnitValue = false;
        bool NetUnitValue = false;

        private void radTextBoxNetUnitPrice_Enter(object sender, EventArgs e)
        {
            this.NetUnitValue = true;
            radTextBoxNetUnitPrice_TextChanged(sender, e);
        }


        private void radTextBoxGrossUnitPrice_Enter(object sender, EventArgs e)
        {
            this.GrossUnitValue = true;
            radTextBoxGrossUnitPrice_TextChanged(sender, e);
        }

        private void radTextBoxNetUnitPrice_Leave(object sender, EventArgs e)
        {
            this.NetUnitValue = false;
        }

        private void radTextBoxGrossUnitPrice_Leave(object sender, EventArgs e)
        {
            this.GrossUnitValue = false;
        }

        private void radTextBoxNetUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (this.NetUnitValue == true)
            {
                try
                {
                    decimal tax = 1 + Decimal.Parse(Tax) / 100;
                    radTextBoxGrossUnitPrice.Text = Math.Round(Decimal.Multiply(Decimal.Parse(radTextBoxNetUnitPrice.Text), tax), 2).ToString();
                }
                catch { radTextBoxGrossUnitPrice.Text = ""; }
            }
        }


        private void radTextBoxGrossUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (this.GrossUnitValue == true)
            {
                try
                {
                    decimal tax = 1 + Decimal.Parse(Tax) / 100;
                    radTextBoxNetUnitPrice.Text = Math.Round(Decimal.Divide(Decimal.Parse(radTextBoxGrossUnitPrice.Text), tax), 2).ToString();
                }
                catch { radTextBoxNetUnitPrice.Text = ""; }
            }
        }

        private void comboBoxTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tax;
            if (int.TryParse(comboBoxTax.SelectedItem.ToString(), out tax))
            {
                Tax = tax.ToString();
                TaxName = Tax;
            }
            else { Tax = "0"; TaxName = comboBoxTax.SelectedItem.ToString(); }
        }
    }
}
