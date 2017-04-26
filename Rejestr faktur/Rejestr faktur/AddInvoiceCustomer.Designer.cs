namespace Rejestr_Faktur
{
    partial class AddInvoiceCustomer
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
            this.radButtonSelect = new Telerik.WinControls.UI.RadButton();
            this.objectListViewCustomers = new BrightIdeasSoftware.ObjectListView();
            this.groupBoxSearchCustomers = new System.Windows.Forms.GroupBox();
            this.radTextBoxSearchCustomers = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewCustomers)).BeginInit();
            this.groupBoxSearchCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxSearchCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButtonSelect
            // 
            this.radButtonSelect.Location = new System.Drawing.Point(12, 27);
            this.radButtonSelect.Name = "radButtonSelect";
            this.radButtonSelect.Size = new System.Drawing.Size(110, 24);
            this.radButtonSelect.TabIndex = 6;
            this.radButtonSelect.Text = "Wybierz";
            this.radButtonSelect.Click += new System.EventHandler(this.radButtonSelect_Click);
            // 
            // objectListViewCustomers
            // 
            this.objectListViewCustomers.CellEditUseWholeCell = false;
            this.objectListViewCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewCustomers.FullRowSelect = true;
            this.objectListViewCustomers.GridLines = true;
            this.objectListViewCustomers.Location = new System.Drawing.Point(12, 57);
            this.objectListViewCustomers.Name = "objectListViewCustomers";
            this.objectListViewCustomers.ShowGroups = false;
            this.objectListViewCustomers.Size = new System.Drawing.Size(735, 319);
            this.objectListViewCustomers.TabIndex = 5;
            this.objectListViewCustomers.UseCompatibleStateImageBehavior = false;
            this.objectListViewCustomers.UseFiltering = true;
            this.objectListViewCustomers.View = System.Windows.Forms.View.Details;
            this.objectListViewCustomers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.objectListViewCustomers_MouseDoubleClick);
            // 
            // groupBoxSearchCustomers
            // 
            this.groupBoxSearchCustomers.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBoxSearchCustomers.Controls.Add(this.radTextBoxSearchCustomers);
            this.groupBoxSearchCustomers.Location = new System.Drawing.Point(562, 12);
            this.groupBoxSearchCustomers.Name = "groupBoxSearchCustomers";
            this.groupBoxSearchCustomers.Size = new System.Drawing.Size(185, 39);
            this.groupBoxSearchCustomers.TabIndex = 7;
            this.groupBoxSearchCustomers.TabStop = false;
            this.groupBoxSearchCustomers.Text = "Szukaj";
            // 
            // radTextBoxSearchCustomers
            // 
            this.radTextBoxSearchCustomers.Location = new System.Drawing.Point(5, 17);
            this.radTextBoxSearchCustomers.Name = "radTextBoxSearchCustomers";
            this.radTextBoxSearchCustomers.Size = new System.Drawing.Size(174, 20);
            this.radTextBoxSearchCustomers.TabIndex = 4;
            this.radTextBoxSearchCustomers.TextChanged += new System.EventHandler(this.radTextBoxSearchCustomers_TextChanged);
            // 
            // AddInvoiceCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 388);
            this.Controls.Add(this.groupBoxSearchCustomers);
            this.Controls.Add(this.radButtonSelect);
            this.Controls.Add(this.objectListViewCustomers);
            this.Name = "AddInvoiceCustomer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Wybierz klienta";
            this.Load += new System.EventHandler(this.AddInvoiceCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewCustomers)).EndInit();
            this.groupBoxSearchCustomers.ResumeLayout(false);
            this.groupBoxSearchCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxSearchCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButtonSelect;
        private BrightIdeasSoftware.ObjectListView objectListViewCustomers;
        private System.Windows.Forms.GroupBox groupBoxSearchCustomers;
        private Telerik.WinControls.UI.RadTextBox radTextBoxSearchCustomers;
    }
}
