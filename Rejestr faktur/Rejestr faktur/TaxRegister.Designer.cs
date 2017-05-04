namespace Rejestr_Faktur
{
    partial class TaxRegister
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
            this.objectListViewTaxRegister = new BrightIdeasSoftware.ObjectListView();
            this.comboBoxRegisterType = new System.Windows.Forms.ComboBox();
            this.comboBoxPeriodOfTime = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.radLabelRegisterType = new Telerik.WinControls.UI.RadLabel();
            this.radLabelPeriodOfTime = new Telerik.WinControls.UI.RadLabel();
            this.radLabelYear = new Telerik.WinControls.UI.RadLabel();
            this.groupBoxSearch = new Telerik.WinControls.UI.RadGroupBox();
            this.textBoxFilter = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewTaxRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRegisterType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPeriodOfTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxSearch)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListViewTaxRegister
            // 
            this.objectListViewTaxRegister.CellEditUseWholeCell = false;
            this.objectListViewTaxRegister.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewTaxRegister.FullRowSelect = true;
            this.objectListViewTaxRegister.GridLines = true;
            this.objectListViewTaxRegister.Location = new System.Drawing.Point(12, 64);
            this.objectListViewTaxRegister.Name = "objectListViewTaxRegister";
            this.objectListViewTaxRegister.ShowGroups = false;
            this.objectListViewTaxRegister.Size = new System.Drawing.Size(1012, 359);
            this.objectListViewTaxRegister.TabIndex = 0;
            this.objectListViewTaxRegister.UseCompatibleStateImageBehavior = false;
            this.objectListViewTaxRegister.UseFiltering = true;
            this.objectListViewTaxRegister.View = System.Windows.Forms.View.Details;
            this.objectListViewTaxRegister.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.objectListViewTaxRegister_ItemsChanged);
            // 
            // comboBoxRegisterType
            // 
            this.comboBoxRegisterType.FormattingEnabled = true;
            this.comboBoxRegisterType.Location = new System.Drawing.Point(99, 30);
            this.comboBoxRegisterType.Name = "comboBoxRegisterType";
            this.comboBoxRegisterType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRegisterType.TabIndex = 1;
            this.comboBoxRegisterType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegisterType_SelectedIndexChanged);
            // 
            // comboBoxPeriodOfTime
            // 
            this.comboBoxPeriodOfTime.FormattingEnabled = true;
            this.comboBoxPeriodOfTime.Location = new System.Drawing.Point(298, 30);
            this.comboBoxPeriodOfTime.Name = "comboBoxPeriodOfTime";
            this.comboBoxPeriodOfTime.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPeriodOfTime.TabIndex = 2;
            this.comboBoxPeriodOfTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriodOfTime_SelectedIndexChanged);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(476, 30);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYear.TabIndex = 3;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // radLabelRegisterType
            // 
            this.radLabelRegisterType.Location = new System.Drawing.Point(12, 32);
            this.radLabelRegisterType.Name = "radLabelRegisterType";
            this.radLabelRegisterType.Size = new System.Drawing.Size(81, 18);
            this.radLabelRegisterType.TabIndex = 4;
            this.radLabelRegisterType.Text = "Rodzaj rejestru";
            // 
            // radLabelPeriodOfTime
            // 
            this.radLabelPeriodOfTime.Location = new System.Drawing.Point(249, 32);
            this.radLabelPeriodOfTime.Name = "radLabelPeriodOfTime";
            this.radLabelPeriodOfTime.Size = new System.Drawing.Size(43, 18);
            this.radLabelPeriodOfTime.TabIndex = 5;
            this.radLabelPeriodOfTime.Text = "Kwartał";
            // 
            // radLabelYear
            // 
            this.radLabelYear.Location = new System.Drawing.Point(445, 32);
            this.radLabelYear.Name = "radLabelYear";
            this.radLabelYear.Size = new System.Drawing.Size(25, 18);
            this.radLabelYear.TabIndex = 6;
            this.radLabelYear.Text = "Rok";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBoxSearch.Controls.Add(this.textBoxFilter);
            this.groupBoxSearch.HeaderImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.groupBoxSearch.HeaderText = "Filtruj";
            this.groupBoxSearch.Location = new System.Drawing.Point(795, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(229, 45);
            this.groupBoxSearch.TabIndex = 7;
            this.groupBoxSearch.Text = "Filtruj";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(5, 20);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(219, 20);
            this.textBoxFilter.TabIndex = 1;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // TaxRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 435);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.radLabelYear);
            this.Controls.Add(this.radLabelPeriodOfTime);
            this.Controls.Add(this.radLabelRegisterType);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxPeriodOfTime);
            this.Controls.Add(this.comboBoxRegisterType);
            this.Controls.Add(this.objectListViewTaxRegister);
            this.Name = "TaxRegister";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Rejestr VAT";
            this.Load += new System.EventHandler(this.TaxRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewTaxRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRegisterType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPeriodOfTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxSearch)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListViewTaxRegister;
        private System.Windows.Forms.ComboBox comboBoxRegisterType;
        private System.Windows.Forms.ComboBox comboBoxPeriodOfTime;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private Telerik.WinControls.UI.RadLabel radLabelRegisterType;
        private Telerik.WinControls.UI.RadLabel radLabelPeriodOfTime;
        private Telerik.WinControls.UI.RadLabel radLabelYear;
        private Telerik.WinControls.UI.RadGroupBox groupBoxSearch;
        private Telerik.WinControls.UI.RadTextBox textBoxFilter;
    }
}
