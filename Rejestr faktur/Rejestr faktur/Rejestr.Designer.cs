namespace Rejestr_Faktur
{
    partial class Rejestr
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
            this.objectListViewInvoices = new BrightIdeasSoftware.ObjectListView();
            this.InvoiceNo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.comCity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.IssuedBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InvoiceDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OrderDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cusCompanyName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cusNIP = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cusAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PaymentMethod = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Sum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cusCity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cusPostalCode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cusCountry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PaymentDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListViewInvoices
            // 
            this.objectListViewInvoices.AllColumns.Add(this.InvoiceNo);
            this.objectListViewInvoices.AllColumns.Add(this.comCity);
            this.objectListViewInvoices.AllColumns.Add(this.IssuedBy);
            this.objectListViewInvoices.AllColumns.Add(this.InvoiceDate);
            this.objectListViewInvoices.AllColumns.Add(this.OrderDate);
            this.objectListViewInvoices.AllColumns.Add(this.cusCompanyName);
            this.objectListViewInvoices.AllColumns.Add(this.cusNIP);
            this.objectListViewInvoices.AllColumns.Add(this.cusAddress);
            this.objectListViewInvoices.AllColumns.Add(this.cusPostalCode);
            this.objectListViewInvoices.AllColumns.Add(this.cusCity);
            this.objectListViewInvoices.AllColumns.Add(this.cusCountry);
            this.objectListViewInvoices.AllColumns.Add(this.PaymentMethod);
            this.objectListViewInvoices.AllColumns.Add(this.PaymentDate);
            this.objectListViewInvoices.AllColumns.Add(this.Sum);
            this.objectListViewInvoices.CellEditUseWholeCell = false;
            this.objectListViewInvoices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InvoiceNo,
            this.comCity,
            this.IssuedBy,
            this.InvoiceDate,
            this.OrderDate,
            this.cusCompanyName,
            this.cusNIP,
            this.cusAddress,
            this.cusPostalCode,
            this.cusCity,
            this.cusCountry,
            this.PaymentMethod,
            this.PaymentDate,
            this.Sum});
            this.objectListViewInvoices.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewInvoices.Location = new System.Drawing.Point(364, 61);
            this.objectListViewInvoices.Name = "objectListViewInvoices";
            this.objectListViewInvoices.Size = new System.Drawing.Size(998, 551);
            this.objectListViewInvoices.TabIndex = 0;
            this.objectListViewInvoices.UseCompatibleStateImageBehavior = false;
            this.objectListViewInvoices.View = System.Windows.Forms.View.Details;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.AspectName = "InvoiceNo";
            this.InvoiceNo.Text = "Numer faktury";
            this.InvoiceNo.Width = 91;
            // 
            // comCity
            // 
            this.comCity.AspectName = "comCity";
            this.comCity.Text = "Miejsce wystawienia";
            this.comCity.Width = 111;
            // 
            // IssuedBy
            // 
            this.IssuedBy.AspectName = "IssuedBy";
            this.IssuedBy.Text = "Wystawiono przez";
            this.IssuedBy.Width = 102;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.AspectName = "InvoiceDate";
            this.InvoiceDate.Text = "Data wystawienia";
            // 
            // OrderDate
            // 
            this.OrderDate.AspectName = "OrderDate";
            this.OrderDate.Text = "Data sprzedaży";
            // 
            // cusCompanyName
            // 
            this.cusCompanyName.AspectName = "cusCompanyName";
            this.cusCompanyName.Text = "Nazwa klienta";
            // 
            // cusNIP
            // 
            this.cusNIP.AspectName = "cusNIP";
            this.cusNIP.Text = "NIP klienta";
            // 
            // cusAddress
            // 
            this.cusAddress.AspectName = "cusAddress";
            this.cusAddress.Text = "Adres klienta";
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AspectName = "PaymentMethod";
            this.PaymentMethod.Text = "Forma Płatności";
            // 
            // Sum
            // 
            this.Sum.AspectName = "Sum";
            this.Sum.Text = "Do zapłaty";
            // 
            // cusCity
            // 
            this.cusCity.AspectName = "cusCity";
            this.cusCity.Text = "Miasto klienta";
            // 
            // cusPostalCode
            // 
            this.cusPostalCode.AspectName = "cusPostalCode";
            this.cusPostalCode.Text = "Kod klienta";
            // 
            // cusCountry
            // 
            this.cusCountry.AspectName = "cusCountry";
            this.cusCountry.Text = "Kraj klienta";
            // 
            // PaymentDate
            // 
            this.PaymentDate.AspectName = "PaymentDate";
            this.PaymentDate.DisplayIndex = 13;
            this.PaymentDate.Text = "Termin płatności";
            // 
            // Rejestr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 651);
            this.Controls.Add(this.objectListViewInvoices);
            this.Name = "Rejestr";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Rejestr faktur";
            this.Load += new System.EventHandler(this.Rejestr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListViewInvoices;
        private BrightIdeasSoftware.OLVColumn InvoiceNo;
        private BrightIdeasSoftware.OLVColumn comCity;
        private BrightIdeasSoftware.OLVColumn IssuedBy;
        private BrightIdeasSoftware.OLVColumn InvoiceDate;
        private BrightIdeasSoftware.OLVColumn OrderDate;
        private BrightIdeasSoftware.OLVColumn cusCompanyName;
        private BrightIdeasSoftware.OLVColumn cusNIP;
        private BrightIdeasSoftware.OLVColumn cusAddress;
        private BrightIdeasSoftware.OLVColumn PaymentMethod;
        private BrightIdeasSoftware.OLVColumn Sum;
        private BrightIdeasSoftware.OLVColumn cusCity;
        private BrightIdeasSoftware.OLVColumn cusPostalCode;
        private BrightIdeasSoftware.OLVColumn cusCountry;
        private BrightIdeasSoftware.OLVColumn PaymentDate;
    }
}