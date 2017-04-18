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
            this.label1 = new System.Windows.Forms.Label();
            this.labelGrossValue = new System.Windows.Forms.Label();
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
            this.objectListViewInvoices.FullRowSelect = true;
            this.objectListViewInvoices.Location = new System.Drawing.Point(370, 59);
            this.objectListViewInvoices.Name = "objectListViewInvoices";
            this.objectListViewInvoices.ShowGroups = false;
            this.objectListViewInvoices.Size = new System.Drawing.Size(998, 551);
            this.objectListViewInvoices.TabIndex = 0;
            this.objectListViewInvoices.UseCompatibleStateImageBehavior = false;
            this.objectListViewInvoices.View = System.Windows.Forms.View.Details;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.AspectName = "InvoiceNo";
            this.InvoiceNo.Text = "Numer faktury";
            this.InvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InvoiceNo.Width = 100;
            // 
            // comCity
            // 
            this.comCity.AspectName = "comCity";
            this.comCity.Text = "Miejsce wystawienia";
            this.comCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comCity.Width = 115;
            // 
            // IssuedBy
            // 
            this.IssuedBy.AspectName = "IssuedBy";
            this.IssuedBy.Text = "Wystawiono przez";
            this.IssuedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IssuedBy.Width = 110;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.AspectName = "InvoiceDate";
            this.InvoiceDate.Text = "Data wystawienia";
            this.InvoiceDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InvoiceDate.Width = 100;
            // 
            // OrderDate
            // 
            this.OrderDate.AspectName = "OrderDate";
            this.OrderDate.Text = "Data sprzedaży";
            this.OrderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrderDate.Width = 100;
            // 
            // cusCompanyName
            // 
            this.cusCompanyName.AspectName = "cusCompanyName";
            this.cusCompanyName.Text = "Nazwa klienta";
            this.cusCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cusCompanyName.Width = 100;
            // 
            // cusNIP
            // 
            this.cusNIP.AspectName = "cusNIP";
            this.cusNIP.Text = "NIP klienta";
            this.cusNIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cusNIP.Width = 100;
            // 
            // cusAddress
            // 
            this.cusAddress.AspectName = "cusAddress";
            this.cusAddress.Text = "Adres klienta";
            this.cusAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cusAddress.Width = 120;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AspectName = "PaymentMethod";
            this.PaymentMethod.Text = "Forma Płatności";
            this.PaymentMethod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PaymentMethod.Width = 90;
            // 
            // Sum
            // 
            this.Sum.AspectName = "Sum";
            this.Sum.Text = "Do zapłaty [zł]";
            this.Sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sum.Width = 90;
            // 
            // cusCity
            // 
            this.cusCity.AspectName = "cusCity";
            this.cusCity.Text = "Miasto klienta";
            this.cusCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cusCity.Width = 90;
            // 
            // cusPostalCode
            // 
            this.cusPostalCode.AspectName = "cusPostalCode";
            this.cusPostalCode.Text = "Kod klienta";
            this.cusPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cusPostalCode.Width = 90;
            // 
            // cusCountry
            // 
            this.cusCountry.AspectName = "cusCountry";
            this.cusCountry.Text = "Kraj klienta";
            this.cusCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cusCountry.Width = 90;
            // 
            // PaymentDate
            // 
            this.PaymentDate.AspectName = "PaymentDate";
            this.PaymentDate.Text = "Termin płatności";
            this.PaymentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PaymentDate.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(1075, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wartość faktur brutto [zł]:";
            // 
            // labelGrossValue
            // 
            this.labelGrossValue.AutoSize = true;
            this.labelGrossValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelGrossValue.Location = new System.Drawing.Point(1247, 623);
            this.labelGrossValue.Name = "labelGrossValue";
            this.labelGrossValue.Size = new System.Drawing.Size(45, 19);
            this.labelGrossValue.TabIndex = 2;
            this.labelGrossValue.Text = "label2";
            // 
            // Rejestr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 651);
            this.Controls.Add(this.labelGrossValue);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGrossValue;
    }
}