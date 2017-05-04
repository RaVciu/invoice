using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Rejestr_Faktur
{
    public partial class PrintInvoice : Telerik.WinControls.UI.RadForm
    {
        public PrintInvoice()
        {
            InitializeComponent();
        }
        public int InvoiceID;
        private void PrintInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RejestrDataSet.Customers' table. You can move, or remove it, as needed.
            this.CustomersTableAdapter.Fill(this.RejestrDataSet.Customers);
            // TODO: This line of code loads data into the 'RejestrDataSet.Company' table. You can move, or remove it, as needed.
            this.CompanyTableAdapter.Fill(this.RejestrDataSet.Company);
            // TODO: This line of code loads data into the 'RejestrDataSet.InvoiceDetails' table. You can move, or remove it, as needed.
            this.InvoiceDetailsTableAdapter.Fill(this.RejestrDataSet.InvoiceDetails);
            // TODO: This line of code loads data into the 'RejestrDataSet.Invoices' table. You can move, or remove it, as needed.
            this.InvoicesTableAdapter.Fill(this.RejestrDataSet.Invoices);
            // TODO: This line of code loads data into the 'RejestrDataSet.TaxDetails' table. You can move, or remove it, as needed.
            this.TaxDetailsTableAdapter.Fill(this.RejestrDataSet.TaxDetails);
            this.reportViewer1.RefreshReport();

            try
            {
                this.InvoiceDetailsTableAdapter.FillBy(this.RejestrDataSet.InvoiceDetails, ((int)(System.Convert.ChangeType(InvoiceID, typeof(int)))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                this.InvoicesTableAdapter.FillBy(this.RejestrDataSet.Invoices, ((int)(System.Convert.ChangeType(InvoiceID, typeof(int)))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                this.TaxDetailsTableAdapter.FillBy(this.RejestrDataSet.TaxDetails, new System.Nullable<int>(((int)(System.Convert.ChangeType(InvoiceID, typeof(int))))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            var pageSettings = new System.Drawing.Printing.PageSettings();
            pageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);

            this.reportViewer1.SetPageSettings(pageSettings);
        }


    }
}
