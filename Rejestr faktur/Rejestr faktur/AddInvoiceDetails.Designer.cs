namespace Rejestr_Faktur
{
    partial class AddInvoiceDetails
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
            this.radButtonCancel = new Telerik.WinControls.UI.RadButton();
            this.radButtonAdd = new Telerik.WinControls.UI.RadButton();
            this.radGroupBoxCustomerDetails = new Telerik.WinControls.UI.RadGroupBox();
            this.radButtonAddFromList = new Telerik.WinControls.UI.RadButton();
            this.radLabelUnit = new Telerik.WinControls.UI.RadLabel();
            this.radLabelPKWiU = new Telerik.WinControls.UI.RadLabel();
            this.radLabelProductName = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxProductName = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBoxPKWiU = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBoxUnit = new Telerik.WinControls.UI.RadTextBox();
            this.radLabelGrossUnitPrice = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxGrossUnitPrice = new Telerik.WinControls.UI.RadTextBox();
            this.radLabelTax = new Telerik.WinControls.UI.RadLabel();
            this.radLabelNetUnitPrice = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxNetUnitPrice = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.comboBoxTax = new System.Windows.Forms.ComboBox();
            this.radTextBoxDiscount = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxQuantity = new Telerik.WinControls.UI.RadTextBox();
            this.labelProductID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxCustomerDetails)).BeginInit();
            this.radGroupBoxCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddFromList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPKWiU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxPKWiU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelGrossUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxGrossUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelNetUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxNetUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButtonCancel
            // 
            this.radButtonCancel.Location = new System.Drawing.Point(232, 326);
            this.radButtonCancel.Name = "radButtonCancel";
            this.radButtonCancel.Size = new System.Drawing.Size(110, 24);
            this.radButtonCancel.TabIndex = 10;
            this.radButtonCancel.Text = "Anuluj";
            this.radButtonCancel.Click += new System.EventHandler(this.radButtonCancel_Click);
            // 
            // radButtonAdd
            // 
            this.radButtonAdd.Location = new System.Drawing.Point(114, 326);
            this.radButtonAdd.Name = "radButtonAdd";
            this.radButtonAdd.Size = new System.Drawing.Size(110, 24);
            this.radButtonAdd.TabIndex = 9;
            this.radButtonAdd.Text = "Dodaj";
            this.radButtonAdd.Click += new System.EventHandler(this.radButtonAdd_Click);
            // 
            // radGroupBoxCustomerDetails
            // 
            this.radGroupBoxCustomerDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxCustomerDetails.Controls.Add(this.radButtonAddFromList);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radLabelUnit);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radLabelPKWiU);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radLabelProductName);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radTextBoxProductName);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radTextBoxPKWiU);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radTextBoxUnit);
            this.radGroupBoxCustomerDetails.HeaderText = "Dane produktu";
            this.radGroupBoxCustomerDetails.Location = new System.Drawing.Point(12, 12);
            this.radGroupBoxCustomerDetails.Name = "radGroupBoxCustomerDetails";
            this.radGroupBoxCustomerDetails.Size = new System.Drawing.Size(415, 123);
            this.radGroupBoxCustomerDetails.TabIndex = 12;
            this.radGroupBoxCustomerDetails.Text = "Dane produktu";
            // 
            // radButtonAddFromList
            // 
            this.radButtonAddFromList.Location = new System.Drawing.Point(20, 29);
            this.radButtonAddFromList.Name = "radButtonAddFromList";
            this.radButtonAddFromList.Size = new System.Drawing.Size(87, 69);
            this.radButtonAddFromList.TabIndex = 0;
            this.radButtonAddFromList.Text = "Dodaj z listy";
            this.radButtonAddFromList.Click += new System.EventHandler(this.radButtonAddFromList_Click);
            // 
            // radLabelUnit
            // 
            this.radLabelUnit.Location = new System.Drawing.Point(113, 79);
            this.radLabelUnit.Name = "radLabelUnit";
            this.radLabelUnit.Size = new System.Drawing.Size(56, 18);
            this.radLabelUnit.TabIndex = 5;
            this.radLabelUnit.Text = "Jednostka";
            // 
            // radLabelPKWiU
            // 
            this.radLabelPKWiU.Location = new System.Drawing.Point(128, 53);
            this.radLabelPKWiU.Name = "radLabelPKWiU";
            this.radLabelPKWiU.Size = new System.Drawing.Size(40, 18);
            this.radLabelPKWiU.TabIndex = 6;
            this.radLabelPKWiU.Text = "PKWiU";
            // 
            // radLabelProductName
            // 
            this.radLabelProductName.Location = new System.Drawing.Point(129, 29);
            this.radLabelProductName.Name = "radLabelProductName";
            this.radLabelProductName.Size = new System.Drawing.Size(39, 18);
            this.radLabelProductName.TabIndex = 4;
            this.radLabelProductName.Text = "Nazwa";
            // 
            // radTextBoxProductName
            // 
            this.radTextBoxProductName.Location = new System.Drawing.Point(174, 28);
            this.radTextBoxProductName.Name = "radTextBoxProductName";
            this.radTextBoxProductName.Size = new System.Drawing.Size(212, 20);
            this.radTextBoxProductName.TabIndex = 1;
            // 
            // radTextBoxPKWiU
            // 
            this.radTextBoxPKWiU.Location = new System.Drawing.Point(174, 52);
            this.radTextBoxPKWiU.Name = "radTextBoxPKWiU";
            this.radTextBoxPKWiU.Size = new System.Drawing.Size(212, 20);
            this.radTextBoxPKWiU.TabIndex = 2;
            // 
            // radTextBoxUnit
            // 
            this.radTextBoxUnit.Location = new System.Drawing.Point(175, 78);
            this.radTextBoxUnit.Name = "radTextBoxUnit";
            this.radTextBoxUnit.Size = new System.Drawing.Size(211, 20);
            this.radTextBoxUnit.TabIndex = 3;
            // 
            // radLabelGrossUnitPrice
            // 
            this.radLabelGrossUnitPrice.Location = new System.Drawing.Point(83, 100);
            this.radLabelGrossUnitPrice.Name = "radLabelGrossUnitPrice";
            this.radLabelGrossUnitPrice.Size = new System.Drawing.Size(84, 18);
            this.radLabelGrossUnitPrice.TabIndex = 11;
            this.radLabelGrossUnitPrice.Text = "Cena brutto [zł]";
            // 
            // radTextBoxGrossUnitPrice
            // 
            this.radTextBoxGrossUnitPrice.Location = new System.Drawing.Point(174, 99);
            this.radTextBoxGrossUnitPrice.Name = "radTextBoxGrossUnitPrice";
            this.radTextBoxGrossUnitPrice.Size = new System.Drawing.Size(212, 20);
            this.radTextBoxGrossUnitPrice.TabIndex = 6;
            this.radTextBoxGrossUnitPrice.TextChanged += new System.EventHandler(this.radTextBoxGrossUnitPrice_TextChanged);
            this.radTextBoxGrossUnitPrice.Enter += new System.EventHandler(this.radTextBoxGrossUnitPrice_Enter);
            this.radTextBoxGrossUnitPrice.Leave += new System.EventHandler(this.radTextBoxGrossUnitPrice_Leave);
            // 
            // radLabelTax
            // 
            this.radLabelTax.Location = new System.Drawing.Point(121, 48);
            this.radLabelTax.Name = "radLabelTax";
            this.radLabelTax.Size = new System.Drawing.Size(46, 18);
            this.radLabelTax.TabIndex = 9;
            this.radLabelTax.Text = "VAT [%]";
            // 
            // radLabelNetUnitPrice
            // 
            this.radLabelNetUnitPrice.Location = new System.Drawing.Point(88, 74);
            this.radLabelNetUnitPrice.Name = "radLabelNetUnitPrice";
            this.radLabelNetUnitPrice.Size = new System.Drawing.Size(79, 18);
            this.radLabelNetUnitPrice.TabIndex = 5;
            this.radLabelNetUnitPrice.Text = "Cena netto [zł]";
            // 
            // radTextBoxNetUnitPrice
            // 
            this.radTextBoxNetUnitPrice.Location = new System.Drawing.Point(174, 73);
            this.radTextBoxNetUnitPrice.Name = "radTextBoxNetUnitPrice";
            this.radTextBoxNetUnitPrice.Size = new System.Drawing.Size(212, 20);
            this.radTextBoxNetUnitPrice.TabIndex = 5;
            this.radTextBoxNetUnitPrice.TextChanged += new System.EventHandler(this.radTextBoxNetUnitPrice_TextChanged);
            this.radTextBoxNetUnitPrice.Enter += new System.EventHandler(this.radTextBoxNetUnitPrice_Enter);
            this.radTextBoxNetUnitPrice.Leave += new System.EventHandler(this.radTextBoxNetUnitPrice_Leave);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.comboBoxTax);
            this.radGroupBox1.Controls.Add(this.radTextBoxDiscount);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radTextBoxQuantity);
            this.radGroupBox1.Controls.Add(this.radLabelTax);
            this.radGroupBox1.Controls.Add(this.radLabelGrossUnitPrice);
            this.radGroupBox1.Controls.Add(this.radLabelNetUnitPrice);
            this.radGroupBox1.Controls.Add(this.radTextBoxGrossUnitPrice);
            this.radGroupBox1.Controls.Add(this.radTextBoxNetUnitPrice);
            this.radGroupBox1.HeaderText = "Parametry sprzedaży";
            this.radGroupBox1.Location = new System.Drawing.Point(14, 141);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(415, 171);
            this.radGroupBox1.TabIndex = 13;
            this.radGroupBox1.Text = "Parametry sprzedaży";
            // 
            // comboBoxTax
            // 
            this.comboBoxTax.FormattingEnabled = true;
            this.comboBoxTax.Items.AddRange(new object[] {
            "23",
            "8",
            "7",
            "5",
            "0",
            "zw.",
            "np.",
            "oo."});
            this.comboBoxTax.Location = new System.Drawing.Point(174, 46);
            this.comboBoxTax.Name = "comboBoxTax";
            this.comboBoxTax.Size = new System.Drawing.Size(212, 21);
            this.comboBoxTax.TabIndex = 7;
            this.comboBoxTax.SelectedIndexChanged += new System.EventHandler(this.comboBoxTax_SelectedIndexChanged);
            // 
            // radTextBoxDiscount
            // 
            this.radTextBoxDiscount.Location = new System.Drawing.Point(174, 125);
            this.radTextBoxDiscount.Name = "radTextBoxDiscount";
            this.radTextBoxDiscount.Size = new System.Drawing.Size(212, 20);
            this.radTextBoxDiscount.TabIndex = 8;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(113, 126);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(54, 18);
            this.radLabel2.TabIndex = 14;
            this.radLabel2.Text = "Rabat [%]";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(138, 21);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(29, 18);
            this.radLabel1.TabIndex = 13;
            this.radLabel1.Text = "Ilość";
            // 
            // radTextBoxQuantity
            // 
            this.radTextBoxQuantity.Location = new System.Drawing.Point(174, 20);
            this.radTextBoxQuantity.Name = "radTextBoxQuantity";
            this.radTextBoxQuantity.Size = new System.Drawing.Size(212, 20);
            this.radTextBoxQuantity.TabIndex = 4;
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Location = new System.Drawing.Point(14, 326);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(0, 13);
            this.labelProductID.TabIndex = 12;
            this.labelProductID.Visible = false;
            // 
            // AddInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 362);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radButtonCancel);
            this.Controls.Add(this.radButtonAdd);
            this.Controls.Add(this.radGroupBoxCustomerDetails);
            this.Name = "AddInvoiceDetails";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Dodawanie nowego wpisu";
            this.Load += new System.EventHandler(this.AddInvoiceDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxCustomerDetails)).EndInit();
            this.radGroupBoxCustomerDetails.ResumeLayout(false);
            this.radGroupBoxCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddFromList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPKWiU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxPKWiU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelGrossUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxGrossUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelNetUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxNetUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButtonCancel;
        private Telerik.WinControls.UI.RadButton radButtonAdd;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxCustomerDetails;
        private Telerik.WinControls.UI.RadLabel radLabelGrossUnitPrice;
        private Telerik.WinControls.UI.RadLabel radLabelTax;
        private Telerik.WinControls.UI.RadLabel radLabelUnit;
        private Telerik.WinControls.UI.RadLabel radLabelPKWiU;
        private Telerik.WinControls.UI.RadLabel radLabelNetUnitPrice;
        private Telerik.WinControls.UI.RadLabel radLabelProductName;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radButtonAddFromList;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        public Telerik.WinControls.UI.RadTextBox radTextBoxGrossUnitPrice;
        public Telerik.WinControls.UI.RadTextBox radTextBoxProductName;
        public Telerik.WinControls.UI.RadTextBox radTextBoxNetUnitPrice;
        public Telerik.WinControls.UI.RadTextBox radTextBoxPKWiU;
        public Telerik.WinControls.UI.RadTextBox radTextBoxUnit;
        public Telerik.WinControls.UI.RadTextBox radTextBoxDiscount;
        public Telerik.WinControls.UI.RadTextBox radTextBoxQuantity;
        public System.Windows.Forms.ComboBox comboBoxTax;
        public System.Windows.Forms.Label labelProductID;
    }
}
