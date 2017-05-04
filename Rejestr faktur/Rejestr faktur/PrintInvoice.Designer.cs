namespace Rejestr_Faktur
{
    partial class PrintInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RejestrDataSet = new Rejestr_Faktur.RejestrDataSet();
            this.CompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InvoiceDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InvoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaxDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomersTableAdapter = new Rejestr_Faktur.RejestrDataSetTableAdapters.CustomersTableAdapter();
            this.CompanyTableAdapter = new Rejestr_Faktur.RejestrDataSetTableAdapters.CompanyTableAdapter();
            this.InvoiceDetailsTableAdapter = new Rejestr_Faktur.RejestrDataSetTableAdapters.InvoiceDetailsTableAdapter();
            this.InvoicesTableAdapter = new Rejestr_Faktur.RejestrDataSetTableAdapters.InvoicesTableAdapter();
            this.TaxDetailsTableAdapter = new Rejestr_Faktur.RejestrDataSetTableAdapters.TaxDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RejestrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsCustomers";
            reportDataSource1.Value = this.CustomersBindingSource;
            reportDataSource2.Name = "dsCompany";
            reportDataSource2.Value = this.CompanyBindingSource;
            reportDataSource3.Name = "dsInvoiceDetails";
            reportDataSource3.Value = this.InvoiceDetailsBindingSource;
            reportDataSource4.Name = "dsInvoices";
            reportDataSource4.Value = this.InvoicesBindingSource;
            reportDataSource5.Name = "dsTaxDetails";
            reportDataSource5.Value = this.TaxDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rejestr_Faktur.InvoiceReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(847, 489);
            this.reportViewer1.TabIndex = 0;
            // 
            // CustomersBindingSource
            // 
            this.CustomersBindingSource.DataMember = "Customers";
            this.CustomersBindingSource.DataSource = this.RejestrDataSet;
            // 
            // RejestrDataSet
            // 
            this.RejestrDataSet.DataSetName = "RejestrDataSet";
            this.RejestrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CompanyBindingSource
            // 
            this.CompanyBindingSource.DataMember = "Company";
            this.CompanyBindingSource.DataSource = this.RejestrDataSet;
            // 
            // InvoiceDetailsBindingSource
            // 
            this.InvoiceDetailsBindingSource.DataMember = "InvoiceDetails";
            this.InvoiceDetailsBindingSource.DataSource = this.RejestrDataSet;
            // 
            // InvoicesBindingSource
            // 
            this.InvoicesBindingSource.DataMember = "Invoices";
            this.InvoicesBindingSource.DataSource = this.RejestrDataSet;
            // 
            // TaxDetailsBindingSource
            // 
            this.TaxDetailsBindingSource.DataMember = "TaxDetails";
            this.TaxDetailsBindingSource.DataSource = this.RejestrDataSet;
            // 
            // CustomersTableAdapter
            // 
            this.CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // CompanyTableAdapter
            // 
            this.CompanyTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceDetailsTableAdapter
            // 
            this.InvoiceDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // InvoicesTableAdapter
            // 
            this.InvoicesTableAdapter.ClearBeforeFill = true;
            // 
            // TaxDetailsTableAdapter
            // 
            this.TaxDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // PrintInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 489);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintInvoice";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Drukuj fakturę";
            this.Load += new System.EventHandler(this.PrintInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RejestrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private RejestrDataSet RejestrDataSet;
        private System.Windows.Forms.BindingSource CompanyBindingSource;
        private System.Windows.Forms.BindingSource InvoiceDetailsBindingSource;
        private System.Windows.Forms.BindingSource InvoicesBindingSource;
        private System.Windows.Forms.BindingSource TaxDetailsBindingSource;
        private RejestrDataSetTableAdapters.CustomersTableAdapter CustomersTableAdapter;
        private RejestrDataSetTableAdapters.CompanyTableAdapter CompanyTableAdapter;
        private RejestrDataSetTableAdapters.InvoiceDetailsTableAdapter InvoiceDetailsTableAdapter;
        private RejestrDataSetTableAdapters.InvoicesTableAdapter InvoicesTableAdapter;
        private RejestrDataSetTableAdapters.TaxDetailsTableAdapter TaxDetailsTableAdapter;
    }
}
