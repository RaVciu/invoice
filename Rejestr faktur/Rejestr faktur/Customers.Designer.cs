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
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListViewCustomers
            // 
            this.objectListViewCustomers.CellEditUseWholeCell = false;
            this.objectListViewCustomers.FullRowSelect = true;
            this.objectListViewCustomers.Location = new System.Drawing.Point(12, 57);
            this.objectListViewCustomers.Name = "objectListViewCustomers";
            this.objectListViewCustomers.ShowGroups = false;
            this.objectListViewCustomers.Size = new System.Drawing.Size(735, 319);
            this.objectListViewCustomers.TabIndex = 0;
            this.objectListViewCustomers.UseCompatibleStateImageBehavior = false;
            this.objectListViewCustomers.View = System.Windows.Forms.View.Details;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 388);
            this.Controls.Add(this.objectListViewCustomers);
            this.Name = "Customers";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Klienci";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListViewCustomers;
    }
}
