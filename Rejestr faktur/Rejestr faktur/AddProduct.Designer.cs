namespace Rejestr_Faktur
{
    partial class AddProduct
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
            this.radLabelGrossUnitPrice = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxGrossUnitPrice = new Telerik.WinControls.UI.RadTextBox();
            this.radLabelTax = new Telerik.WinControls.UI.RadLabel();
            this.radLabelUnit = new Telerik.WinControls.UI.RadLabel();
            this.radLabelPKWiU = new Telerik.WinControls.UI.RadLabel();
            this.radLabelNetUnitPrice = new Telerik.WinControls.UI.RadLabel();
            this.radLabelProductName = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxProductName = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBoxNetUnitPrice = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBoxPKWiU = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBoxUnit = new Telerik.WinControls.UI.RadTextBox();
            this.comboBoxTax = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxCustomerDetails)).BeginInit();
            this.radGroupBoxCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelGrossUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxGrossUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPKWiU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelNetUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxNetUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxPKWiU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButtonCancel
            // 
            this.radButtonCancel.Location = new System.Drawing.Point(259, 225);
            this.radButtonCancel.Name = "radButtonCancel";
            this.radButtonCancel.Size = new System.Drawing.Size(110, 24);
            this.radButtonCancel.TabIndex = 7;
            this.radButtonCancel.Text = "Anuluj";
            this.radButtonCancel.Click += new System.EventHandler(this.radButtonCancel_Click);
            // 
            // radButtonAdd
            // 
            this.radButtonAdd.Location = new System.Drawing.Point(105, 225);
            this.radButtonAdd.Name = "radButtonAdd";
            this.radButtonAdd.Size = new System.Drawing.Size(110, 24);
            this.radButtonAdd.TabIndex = 6;
            this.radButtonAdd.Text = "Dodaj";
            this.radButtonAdd.Click += new System.EventHandler(this.radButtonAdd_Click);
            // 
            // radGroupBoxCustomerDetails
            // 
            this.radGroupBoxCustomerDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxCustomerDetails.Controls.Add(this.comboBoxTax);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radLabelGrossUnitPrice);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radTextBoxGrossUnitPrice);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radLabelTax);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radLabelUnit);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radLabelPKWiU);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radLabelNetUnitPrice);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radLabelProductName);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radTextBoxProductName);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radTextBoxNetUnitPrice);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radTextBoxPKWiU);
            this.radGroupBoxCustomerDetails.Controls.Add(this.radTextBoxUnit);
            this.radGroupBoxCustomerDetails.HeaderText = "Dane produktu";
            this.radGroupBoxCustomerDetails.Location = new System.Drawing.Point(28, 25);
            this.radGroupBoxCustomerDetails.Name = "radGroupBoxCustomerDetails";
            this.radGroupBoxCustomerDetails.Size = new System.Drawing.Size(415, 194);
            this.radGroupBoxCustomerDetails.TabIndex = 2;
            this.radGroupBoxCustomerDetails.Text = "Dane produktu";
            // 
            // radLabelGrossUnitPrice
            // 
            this.radLabelGrossUnitPrice.Location = new System.Drawing.Point(84, 133);
            this.radLabelGrossUnitPrice.Name = "radLabelGrossUnitPrice";
            this.radLabelGrossUnitPrice.Size = new System.Drawing.Size(84, 18);
            this.radLabelGrossUnitPrice.TabIndex = 11;
            this.radLabelGrossUnitPrice.Text = "Cena brutto [zł]";
            // 
            // radTextBoxGrossUnitPrice
            // 
            this.radTextBoxGrossUnitPrice.Location = new System.Drawing.Point(174, 132);
            this.radTextBoxGrossUnitPrice.Name = "radTextBoxGrossUnitPrice";
            this.radTextBoxGrossUnitPrice.Size = new System.Drawing.Size(212, 20);
            this.radTextBoxGrossUnitPrice.TabIndex = 2;
            this.radTextBoxGrossUnitPrice.TextChanged += new System.EventHandler(this.radTextBoxGrossUnitPrice_TextChanged);
            this.radTextBoxGrossUnitPrice.Enter += new System.EventHandler(this.radTextBoxGrossUnitPrice_Enter);
            this.radTextBoxGrossUnitPrice.Leave += new System.EventHandler(this.radTextBoxGrossUnitPrice_Leave);
            // 
            // radLabelTax
            // 
            this.radLabelTax.Location = new System.Drawing.Point(122, 160);
            this.radLabelTax.Name = "radLabelTax";
            this.radLabelTax.Size = new System.Drawing.Size(46, 18);
            this.radLabelTax.TabIndex = 9;
            this.radLabelTax.Text = "VAT [%]";
            // 
            // radLabelUnit
            // 
            this.radLabelUnit.Location = new System.Drawing.Point(113, 82);
            this.radLabelUnit.Name = "radLabelUnit";
            this.radLabelUnit.Size = new System.Drawing.Size(56, 18);
            this.radLabelUnit.TabIndex = 5;
            this.radLabelUnit.Text = "Jednostka";
            // 
            // radLabelPKWiU
            // 
            this.radLabelPKWiU.Location = new System.Drawing.Point(128, 55);
            this.radLabelPKWiU.Name = "radLabelPKWiU";
            this.radLabelPKWiU.Size = new System.Drawing.Size(40, 18);
            this.radLabelPKWiU.TabIndex = 6;
            this.radLabelPKWiU.Text = "PKWiU";
            // 
            // radLabelNetUnitPrice
            // 
            this.radLabelNetUnitPrice.Location = new System.Drawing.Point(89, 107);
            this.radLabelNetUnitPrice.Name = "radLabelNetUnitPrice";
            this.radLabelNetUnitPrice.Size = new System.Drawing.Size(79, 18);
            this.radLabelNetUnitPrice.TabIndex = 5;
            this.radLabelNetUnitPrice.Text = "Cena netto [zł]";
            // 
            // radLabelProductName
            // 
            this.radLabelProductName.Location = new System.Drawing.Point(128, 29);
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
            this.radTextBoxProductName.TabIndex = 0;
            // 
            // radTextBoxNetUnitPrice
            // 
            this.radTextBoxNetUnitPrice.Location = new System.Drawing.Point(174, 106);
            this.radTextBoxNetUnitPrice.Name = "radTextBoxNetUnitPrice";
            this.radTextBoxNetUnitPrice.Size = new System.Drawing.Size(212, 20);
            this.radTextBoxNetUnitPrice.TabIndex = 1;
            this.radTextBoxNetUnitPrice.TextChanged += new System.EventHandler(this.radTextBoxNetUnitPrice_TextChanged);
            this.radTextBoxNetUnitPrice.Enter += new System.EventHandler(this.radTextBoxNetUnitPrice_Enter);
            this.radTextBoxNetUnitPrice.Leave += new System.EventHandler(this.radTextBoxNetUnitPrice_Leave);
            // 
            // radTextBoxPKWiU
            // 
            this.radTextBoxPKWiU.Location = new System.Drawing.Point(174, 54);
            this.radTextBoxPKWiU.Name = "radTextBoxPKWiU";
            this.radTextBoxPKWiU.Size = new System.Drawing.Size(212, 20);
            this.radTextBoxPKWiU.TabIndex = 3;
            // 
            // radTextBoxUnit
            // 
            this.radTextBoxUnit.Location = new System.Drawing.Point(175, 80);
            this.radTextBoxUnit.Name = "radTextBoxUnit";
            this.radTextBoxUnit.Size = new System.Drawing.Size(211, 20);
            this.radTextBoxUnit.TabIndex = 4;
            // 
            // comboBoxTax
            // 
            this.comboBoxTax.FormattingEnabled = true;
            this.comboBoxTax.Items.AddRange(new object[] {
            "23",
            "8",
            "7",
            "6",
            "5",
            "0",
            "zw.",
            "np.",
            "oo."});
            this.comboBoxTax.Location = new System.Drawing.Point(174, 158);
            this.comboBoxTax.Name = "comboBoxTax";
            this.comboBoxTax.Size = new System.Drawing.Size(212, 21);
            this.comboBoxTax.TabIndex = 12;
            this.comboBoxTax.SelectedIndexChanged += new System.EventHandler(this.comboBoxTax_SelectedIndexChanged);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.radButtonCancel);
            this.Controls.Add(this.radButtonAdd);
            this.Controls.Add(this.radGroupBoxCustomerDetails);
            this.Name = "AddProduct";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Dodaj produkt";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxCustomerDetails)).EndInit();
            this.radGroupBoxCustomerDetails.ResumeLayout(false);
            this.radGroupBoxCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelGrossUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxGrossUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPKWiU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelNetUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxNetUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxPKWiU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButtonCancel;
        private Telerik.WinControls.UI.RadButton radButtonAdd;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxCustomerDetails;
        private Telerik.WinControls.UI.RadLabel radLabelTax;
        private Telerik.WinControls.UI.RadLabel radLabelUnit;
        private Telerik.WinControls.UI.RadLabel radLabelPKWiU;
        private Telerik.WinControls.UI.RadLabel radLabelNetUnitPrice;
        private Telerik.WinControls.UI.RadLabel radLabelProductName;
        private Telerik.WinControls.UI.RadTextBox radTextBoxProductName;
        private Telerik.WinControls.UI.RadTextBox radTextBoxNetUnitPrice;
        private Telerik.WinControls.UI.RadTextBox radTextBoxPKWiU;
        private Telerik.WinControls.UI.RadTextBox radTextBoxUnit;
        private Telerik.WinControls.UI.RadLabel radLabelGrossUnitPrice;
        private Telerik.WinControls.UI.RadTextBox radTextBoxGrossUnitPrice;
        public System.Windows.Forms.ComboBox comboBoxTax;
    }
}
