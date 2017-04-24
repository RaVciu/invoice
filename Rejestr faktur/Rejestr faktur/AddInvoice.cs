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
    public partial class AddInvoice : Telerik.WinControls.UI.RadForm
    {
        public AddInvoice()
        {
            InitializeComponent();
            Generator.GenerateColumns(objectListViewInvoiceDetails, typeof(InvoiceDetails), true);
            Generator.GenerateColumns(objectListViewTaxList, typeof(TaxList), true);

        }

        List<TaxList> TaxL = new List<TaxList>();
        private void AddInvoice_Load(object sender, EventArgs e)
        {
            decimal GrossSum = 0;
            try
            {
                foreach (InvoiceDetails obj in objectListViewInvoiceDetails.Objects)
                {
                    GrossSum += obj.GrossValue;
                }
            }
            catch { }
            radLabelGrossSum.Text = GrossSum.ToString();

        }

        

        public string ProductName, PKWiU, Unit;
        public int ProductID, Tax, Quantity;
        
        public decimal NetUnitPrice, GrossUnitPrice, Discount, NetValue, GrossValue, TaxValue;
        

        private void radButtonAddInvoiceDetail_Click(object sender, EventArgs e)
        {
            AddInvoiceDetails AddInvD = new AddInvoiceDetails();
            AddInvD.Owner = this;
            AddInvD.Show();

            
        }
        




    }
}
