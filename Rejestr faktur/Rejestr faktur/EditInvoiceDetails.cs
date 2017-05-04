using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Rejestr_Faktur
{
    public partial class EditInvoiceDetails : Telerik.WinControls.UI.RadForm
    {
        public EditInvoiceDetails()
        {
            InitializeComponent();
        }

        private void radButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string ProductName, PKWiU, Unit, Tax, TaxName, ProductID;
        public int Quantity, SelectedObjectIndex, Old_Ordinal;
        public decimal NetUnitPrice, GrossUnitPrice, Discount, NetValue, GrossValue;
        List<InvoiceDetails> ObjectToInsert = new List<InvoiceDetails>();
        private void radButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                ProductName = radTextBoxProductName.Text;
                PKWiU = radTextBoxPKWiU.Text;
                Unit = radTextBoxUnit.Text;

                Quantity = Int16.Parse(radTextBoxQuantity.Text);
                NetUnitPrice = Convert.ToDecimal(radTextBoxNetUnitPrice.Text);
                GrossUnitPrice = Decimal.Parse(radTextBoxGrossUnitPrice.Text);
                if (radTextBoxDiscount.Text != "")
                {
                    Discount = Decimal.Parse(radTextBoxDiscount.Text);
                }
                else { Discount = 0; }
                decimal DiscountMultiplier = 1 - Discount / 100;
                GrossValue = Decimal.Round(Decimal.Multiply(Decimal.Multiply(GrossUnitPrice, Quantity), DiscountMultiplier), 2);
                NetValue = Decimal.Round(Decimal.Multiply(Decimal.Multiply(NetUnitPrice, Quantity), DiscountMultiplier), 2);
                if (labelProductID.Text != "")
                {
                    ProductID = labelProductID.Text;
                }
                else { ProductID = ""; }

            try
            {
                var owner = ((AddInvoice)this.Owner);
                if (owner != null)
                {
                    ObjectToInsert.Add(new InvoiceDetails(Old_Ordinal, ProductID, ProductName, NetUnitPrice, GrossUnitPrice, PKWiU, Unit, TaxName, Quantity, Discount, NetValue, GrossValue));
                    owner.objectListViewInvoiceDetails.SelectedIndex = SelectedObjectIndex;
                    owner.objectListViewInvoiceDetails.RemoveObject(owner.objectListViewInvoiceDetails.SelectedObject);
                    owner.objectListViewInvoiceDetails.InsertObjects(SelectedObjectIndex, ObjectToInsert);
                    owner.NetValue = NetValue;
                    owner.GrossValue = GrossValue;
                    owner.TaxValue = GrossValue - NetValue;
                    owner.Tax = Tax;
                }
            }
            catch { }

            try
            {
                var owner2 = ((EditInvoice)this.Owner);
                if (owner2 != null)
                {
                    ObjectToInsert.Add(new InvoiceDetails(Old_Ordinal, ProductID, ProductName, NetUnitPrice, GrossUnitPrice, PKWiU, Unit, TaxName, Quantity, Discount, NetValue, GrossValue));
                    owner2.objectListViewInvoiceDetails.SelectedIndex = SelectedObjectIndex;
                    owner2.objectListViewInvoiceDetails.RemoveObject(owner2.objectListViewInvoiceDetails.SelectedObject);
                    owner2.objectListViewInvoiceDetails.InsertObjects(SelectedObjectIndex, ObjectToInsert);
                    owner2.NetValue = NetValue;
                    owner2.GrossValue = GrossValue;
                    owner2.TaxValue = GrossValue - NetValue;
                    owner2.Tax = Tax;
                }
            }
            catch { }
            this.Close();
            }
            catch { MessageBox.Show("Niepoprawny format danych bądź występują puste pola"); }

        }

        bool GrossUnitValue = false;

        private void radButtonAddFromList_Click(object sender, EventArgs e)
        {
            AddInvoiceProdukt AddProduct = new AddInvoiceProdukt();
            AddProduct.Owner = this;
            AddProduct.Show();

        }

        private void comboBoxTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tax;
            if (int.TryParse(comboBoxTax.SelectedItem.ToString(), out tax))
            {
                Tax = tax.ToString();
                TaxName = Tax;
                NetUnitValue = true;
                radTextBoxNetUnitPrice_TextChanged(sender, e);
                NetUnitValue = false;

            }
            else
            {
                Tax = "0";
                TaxName = comboBoxTax.SelectedItem.ToString();
                NetUnitValue = true;
                radTextBoxNetUnitPrice_TextChanged(sender, e);
                NetUnitValue = false;
            }
        }

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

        private void EditInvoiceDetails_Load(object sender, EventArgs e)
        {
            comboBoxTax.Text = "23";
        }
    }
}
