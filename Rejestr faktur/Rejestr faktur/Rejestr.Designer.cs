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
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListViewInvoices
            // 
            this.objectListViewInvoices.CellEditUseWholeCell = false;
            this.objectListViewInvoices.Location = new System.Drawing.Point(364, 61);
            this.objectListViewInvoices.Name = "objectListViewInvoices";
            this.objectListViewInvoices.Size = new System.Drawing.Size(998, 551);
            this.objectListViewInvoices.TabIndex = 0;
            this.objectListViewInvoices.UseCompatibleStateImageBehavior = false;
            this.objectListViewInvoices.View = System.Windows.Forms.View.Details;
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
    }
}