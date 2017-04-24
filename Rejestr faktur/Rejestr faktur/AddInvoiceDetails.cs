using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using BrightIdeasSoftware;
using System.Data.SqlClient;

namespace Rejestr_Faktur
{
    public partial class AddInvoiceDetails : Telerik.WinControls.UI.RadForm
    {
        public AddInvoiceDetails()
        {
            InitializeComponent();
        }

        private void radButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string ProductName, PKWiU, Unit;
        public int ProductID, Tax, Quantity;
        public decimal NetUnitPrice, GrossUnitPrice, Discount, NetValue, GrossValue;
        private void radButtonAdd_Click(object sender, EventArgs e)
        {
            ProductName = radTextBoxProductName.Text;
            PKWiU = radTextBoxPKWiU.Text;
            Unit = radTextBoxUnit.Text;
            Tax = Int16.Parse(radTextBoxTax.Text);
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
            int Ordinal = ((AddInvoice)this.Owner).objectListViewInvoiceDetails.GetItemCount() + 1;
            if (labelProductID.Text != "")
            {
                ProductID = Int16.Parse(labelProductID.Text);
            }

            var owner = ((AddInvoice)this.Owner);
            owner.objectListViewInvoiceDetails.AddObject(new InvoiceDetails(Ordinal, ProductID, ProductName, NetUnitPrice, GrossUnitPrice, PKWiU, Unit, Tax, Quantity, Discount, NetValue, GrossValue));
            owner.NetValue = NetValue;
            owner.GrossValue = GrossValue;
            owner.TaxValue = GrossValue - NetValue;
            owner.Tax = Tax;
            owner.objectListViewTaxList.AddObject(new TaxList(Tax, NetValue, GrossValue - NetValue, GrossValue));
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
                    decimal tax = 1 + Decimal.Parse(radTextBoxTax.Text) / 100;
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
                    decimal tax = 1 + Decimal.Parse(radTextBoxTax.Text) / 100;
                    radTextBoxNetUnitPrice.Text = Math.Round(Decimal.Divide(Decimal.Parse(radTextBoxGrossUnitPrice.Text), tax), 2).ToString();
                }
                catch { radTextBoxNetUnitPrice.Text = ""; }
            }
        }

        private void AddInvoiceDetails_Load(object sender, EventArgs e)
        {
            radTextBoxTax.Text = "23";
        }
    }
}
