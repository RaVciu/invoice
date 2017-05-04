using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Rejestr_Faktur
{
    public partial class EditProduct : Telerik.WinControls.UI.RadForm
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        public string ProductName, PKWiU, Unit, NetUnitPrice, GrossUnitPrice, Tax, TaxName;

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

        private void radButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int ProductID;

        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private void radButtonEdit_Click(object sender, EventArgs e)
        {
            ProductName = radTextBoxProductName.Text;
            NetUnitPrice = radTextBoxNetUnitPrice.Text.Replace(",", ".");
            GrossUnitPrice = radTextBoxGrossUnitPrice.Text.Replace(",", ".");
            PKWiU = radTextBoxPKWiU.Text;
            Unit = radTextBoxUnit.Text;

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                string EditProductQuery = "UPDATE Products SET ProductName = '" + ProductName + "', NetUnitPrice = " + NetUnitPrice + ", GrossUnitPrice = " + GrossUnitPrice + " ,PKWiU = '" + PKWiU + "', Unit = '" + Unit + "', Tax = '" + Tax + "' WHERE ProductID = '" + ProductID + "'";
                SqlCommand cmd = new SqlCommand(EditProductQuery, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
            catch { MessageBox.Show("Niepoprawny format danych bądź występują puste pola"); }
        }



        private void EditProduct_Load(object sender, EventArgs e)
        {
            radTextBoxProductName.Text = ProductName;
            radTextBoxNetUnitPrice.Text = NetUnitPrice.ToString();
            radTextBoxGrossUnitPrice.Text = GrossUnitPrice.ToString();
            radTextBoxPKWiU.Text = PKWiU;
            radTextBoxUnit.Text = Unit;
            comboBoxTax.Text = Tax.ToString();
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

    }
}
