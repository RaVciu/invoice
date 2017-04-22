﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Rejestr_Faktur
{
    public partial class EditProduct : Telerik.WinControls.UI.RadForm
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        public string ProductName, PKWiU, Unit, UnitPrice;
        public int ProductID, Tax;

        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private void radButtonEdit_Click(object sender, EventArgs e)
        {
            ProductName = radTextBoxProductName.Text;
            UnitPrice = radTextBoxUnitPrice.Text;
            PKWiU = radTextBoxPKWiU.Text;
            Unit = radTextBoxUnit.Text;
            Tax = Int16.Parse(radTextBoxTax.Text);

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string EditProductQuery = "UPDATE Products SET ProductName = '" + ProductName + "', UnitPrice = " + UnitPrice + ", PKWiU = '" + PKWiU + "', Unit = '" + Unit + "', Tax = '" + Tax + "' WHERE ProductID = '"+ProductID+"'";
            SqlCommand cmd = new SqlCommand(EditProductQuery, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            this.Close();

        }



        private void EditProduct_Load(object sender, EventArgs e)
        {
            radTextBoxProductName.Text = ProductName;
            radTextBoxUnitPrice.Text = UnitPrice.ToString();
            radTextBoxPKWiU.Text = PKWiU;
            radTextBoxUnit.Text = Unit;
            radTextBoxTax.Text = Tax.ToString();
        }



    }
}