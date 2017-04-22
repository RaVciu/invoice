namespace Rejestr_Faktur
{
    partial class Products
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
            this.groupBoxSearchProducts = new System.Windows.Forms.GroupBox();
            this.radTextBoxSearchProducts = new Telerik.WinControls.UI.RadTextBox();
            this.radButtonDelete = new Telerik.WinControls.UI.RadButton();
            this.radButtonEdit = new Telerik.WinControls.UI.RadButton();
            this.radButtonAdd = new Telerik.WinControls.UI.RadButton();
            this.objectListViewProducts = new BrightIdeasSoftware.ObjectListView();
            this.groupBoxSearchProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxSearchProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearchProducts
            // 
            this.groupBoxSearchProducts.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBoxSearchProducts.Controls.Add(this.radTextBoxSearchProducts);
            this.groupBoxSearchProducts.Location = new System.Drawing.Point(562, 13);
            this.groupBoxSearchProducts.Name = "groupBoxSearchProducts";
            this.groupBoxSearchProducts.Size = new System.Drawing.Size(185, 39);
            this.groupBoxSearchProducts.TabIndex = 10;
            this.groupBoxSearchProducts.TabStop = false;
            this.groupBoxSearchProducts.Text = "Szukaj";
            // 
            // radTextBoxSearchProducts
            // 
            this.radTextBoxSearchProducts.Location = new System.Drawing.Point(5, 17);
            this.radTextBoxSearchProducts.Name = "radTextBoxSearchProducts";
            this.radTextBoxSearchProducts.Size = new System.Drawing.Size(174, 20);
            this.radTextBoxSearchProducts.TabIndex = 4;
            this.radTextBoxSearchProducts.TextChanged += new System.EventHandler(this.radTextBoxSearchCustomers_TextChanged);
            // 
            // radButtonDelete
            // 
            this.radButtonDelete.Enabled = false;
            this.radButtonDelete.Location = new System.Drawing.Point(244, 28);
            this.radButtonDelete.Name = "radButtonDelete";
            this.radButtonDelete.Size = new System.Drawing.Size(110, 24);
            this.radButtonDelete.TabIndex = 9;
            this.radButtonDelete.Text = "Usuń";
            this.radButtonDelete.Click += new System.EventHandler(this.radButtonDelete_Click);
            // 
            // radButtonEdit
            // 
            this.radButtonEdit.Enabled = false;
            this.radButtonEdit.Location = new System.Drawing.Point(128, 28);
            this.radButtonEdit.Name = "radButtonEdit";
            this.radButtonEdit.Size = new System.Drawing.Size(110, 24);
            this.radButtonEdit.TabIndex = 8;
            this.radButtonEdit.Text = "Zmień";
            this.radButtonEdit.Click += new System.EventHandler(this.radButtonEdit_Click);
            // 
            // radButtonAdd
            // 
            this.radButtonAdd.Location = new System.Drawing.Point(12, 28);
            this.radButtonAdd.Name = "radButtonAdd";
            this.radButtonAdd.Size = new System.Drawing.Size(110, 24);
            this.radButtonAdd.TabIndex = 7;
            this.radButtonAdd.Text = "Dodaj";
            this.radButtonAdd.Click += new System.EventHandler(this.radButtonAdd_Click);
            // 
            // objectListViewProducts
            // 
            this.objectListViewProducts.CellEditUseWholeCell = false;
            this.objectListViewProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewProducts.FullRowSelect = true;
            this.objectListViewProducts.Location = new System.Drawing.Point(12, 58);
            this.objectListViewProducts.Name = "objectListViewProducts";
            this.objectListViewProducts.ShowGroups = false;
            this.objectListViewProducts.Size = new System.Drawing.Size(735, 319);
            this.objectListViewProducts.TabIndex = 6;
            this.objectListViewProducts.UseCompatibleStateImageBehavior = false;
            this.objectListViewProducts.UseFiltering = true;
            this.objectListViewProducts.View = System.Windows.Forms.View.Details;
            this.objectListViewProducts.SelectedIndexChanged += new System.EventHandler(this.objectListViewProducts_SelectedIndexChanged);
            this.objectListViewProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.objectListViewProducts_MouseDoubleClick);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 388);
            this.Controls.Add(this.groupBoxSearchProducts);
            this.Controls.Add(this.radButtonDelete);
            this.Controls.Add(this.radButtonEdit);
            this.Controls.Add(this.radButtonAdd);
            this.Controls.Add(this.objectListViewProducts);
            this.Name = "Products";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Produkty";
            this.Activated += new System.EventHandler(this.Products_Load);
            this.Load += new System.EventHandler(this.Products_Load);
            this.groupBoxSearchProducts.ResumeLayout(false);
            this.groupBoxSearchProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxSearchProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearchProducts;
        private Telerik.WinControls.UI.RadTextBox radTextBoxSearchProducts;
        private Telerik.WinControls.UI.RadButton radButtonDelete;
        private Telerik.WinControls.UI.RadButton radButtonEdit;
        private Telerik.WinControls.UI.RadButton radButtonAdd;
        private BrightIdeasSoftware.ObjectListView objectListViewProducts;
    }
}
