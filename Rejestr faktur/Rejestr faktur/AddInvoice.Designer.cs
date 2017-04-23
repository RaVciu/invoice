namespace Rejestr_Faktur
{
    partial class AddInvoice
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 13);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(302, 154);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "radGroupBox1";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.HeaderText = "radGroupBox2";
            this.radGroupBox2.Location = new System.Drawing.Point(321, 13);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(554, 154);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "radGroupBox2";
            // 
            // AddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 523);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "AddInvoice";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "AddInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
    }
}
