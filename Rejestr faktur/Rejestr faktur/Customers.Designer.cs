namespace Rejestr_Faktur
{
    partial class Customers
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
            this.objectListViewCustomers = new BrightIdeasSoftware.ObjectListView();
            this.radButtonAdd = new Telerik.WinControls.UI.RadButton();
            this.radButtonEdit = new Telerik.WinControls.UI.RadButton();
            this.radButtonDelete = new Telerik.WinControls.UI.RadButton();
            this.radTextBoxSearchCustomers = new Telerik.WinControls.UI.RadTextBox();
            this.groupBoxSearchCustomers = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxSearchCustomers)).BeginInit();
            this.groupBoxSearchCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListViewCustomers
            // 
            this.objectListViewCustomers.CellEditUseWholeCell = false;
            this.objectListViewCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewCustomers.FullRowSelect = true;
            this.objectListViewCustomers.Location = new System.Drawing.Point(12, 57);
            this.objectListViewCustomers.Name = "objectListViewCustomers";
            this.objectListViewCustomers.ShowGroups = false;
            this.objectListViewCustomers.Size = new System.Drawing.Size(735, 319);
            this.objectListViewCustomers.TabIndex = 0;
            this.objectListViewCustomers.UseCompatibleStateImageBehavior = false;
            this.objectListViewCustomers.UseFiltering = true;
            this.objectListViewCustomers.View = System.Windows.Forms.View.Details;
            this.objectListViewCustomers.SelectedIndexChanged += new System.EventHandler(this.objectListViewCustomers_SelectedIndexChanged);
            // 
            // radButtonAdd
            // 
            this.radButtonAdd.Location = new System.Drawing.Point(12, 27);
            this.radButtonAdd.Name = "radButtonAdd";
            this.radButtonAdd.Size = new System.Drawing.Size(110, 24);
            this.radButtonAdd.TabIndex = 1;
            this.radButtonAdd.Text = "Dodaj";
            this.radButtonAdd.Click += new System.EventHandler(this.radButtonAdd_Click);
            // 
            // radButtonEdit
            // 
            this.radButtonEdit.Enabled = false;
            this.radButtonEdit.Location = new System.Drawing.Point(128, 27);
            this.radButtonEdit.Name = "radButtonEdit";
            this.radButtonEdit.Size = new System.Drawing.Size(110, 24);
            this.radButtonEdit.TabIndex = 2;
            this.radButtonEdit.Text = "Zmień";
            // 
            // radButtonDelete
            // 
            this.radButtonDelete.Enabled = false;
            this.radButtonDelete.Location = new System.Drawing.Point(244, 27);
            this.radButtonDelete.Name = "radButtonDelete";
            this.radButtonDelete.Size = new System.Drawing.Size(110, 24);
            this.radButtonDelete.TabIndex = 3;
            this.radButtonDelete.Text = "Usuń";
            // 
            // radTextBoxSearchCustomers
            // 
            this.radTextBoxSearchCustomers.Location = new System.Drawing.Point(5, 17);
            this.radTextBoxSearchCustomers.Name = "radTextBoxSearchCustomers";
            this.radTextBoxSearchCustomers.Size = new System.Drawing.Size(174, 20);
            this.radTextBoxSearchCustomers.TabIndex = 4;
            this.radTextBoxSearchCustomers.TextChanged += new System.EventHandler(this.radTextBoxSearchCustomers_TextChanged);
            // 
            // groupBoxSearchCustomers
            // 
            this.groupBoxSearchCustomers.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBoxSearchCustomers.Controls.Add(this.radTextBoxSearchCustomers);
            this.groupBoxSearchCustomers.Location = new System.Drawing.Point(562, 12);
            this.groupBoxSearchCustomers.Name = "groupBoxSearchCustomers";
            this.groupBoxSearchCustomers.Size = new System.Drawing.Size(185, 39);
            this.groupBoxSearchCustomers.TabIndex = 5;
            this.groupBoxSearchCustomers.TabStop = false;
            this.groupBoxSearchCustomers.Text = "Szukaj";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 388);
            this.Controls.Add(this.groupBoxSearchCustomers);
            this.Controls.Add(this.radButtonDelete);
            this.Controls.Add(this.radButtonEdit);
            this.Controls.Add(this.radButtonAdd);
            this.Controls.Add(this.objectListViewCustomers);
            this.Name = "Customers";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Klienci";
            this.Activated += new System.EventHandler(this.Customers_Load);
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxSearchCustomers)).EndInit();
            this.groupBoxSearchCustomers.ResumeLayout(false);
            this.groupBoxSearchCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListViewCustomers;
        private Telerik.WinControls.UI.RadButton radButtonAdd;
        private Telerik.WinControls.UI.RadButton radButtonEdit;
        private Telerik.WinControls.UI.RadButton radButtonDelete;
        private Telerik.WinControls.UI.RadTextBox radTextBoxSearchCustomers;
        private System.Windows.Forms.GroupBox groupBoxSearchCustomers;
    }
}
