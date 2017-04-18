﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Globalization;

namespace Rejestr_Faktur
{
    public partial class Rejestr : Telerik.WinControls.UI.RadForm
    {
        public Rejestr()
        {
            InitializeComponent();
        }

        private void Rejestr_Load(object sender, EventArgs e)
        {
            Reload_objectListViewInvoices();
        }

        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public void Reload_objectListViewInvoices()
        {
            string InvoiceQuery = (@"SELECT com.CompanyName, inv.IssuedBy, com.Address, com.City, com.PostalCode, com.Country, com.NIP, com.IBAN, com.BankName, 
                                inv.CompanyName, inv.NIP, inv.Address, inv.City, inv.PostalCode, inv.Country, inv.InvoiceNo, inv.OrderDate, inv.InvoiceDate, inv.PaymentDate, inv.PaymentMethod,  inv.Sum
                                    FROM Invoices as inv
                                    JOIN Company as com ON com.CompanyID = inv.CompanyID
                                    JOIN Customers as cus ON cus.CustomerID = inv.CustomerID");

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(InvoiceQuery, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Invoice> list = new List<Invoice>();
            decimal GrossValue = 0;

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                DateTime OrderDate = DateTime.Parse(row[16].ToString());
                DateTime InvoiceDate = DateTime.Parse(row[17].ToString());
                DateTime PaymentDate = DateTime.Parse(row[18].ToString());

                decimal Sum = Decimal.Round(Decimal.Parse(row[20].ToString()), 2);
                GrossValue += Sum;

                list.Add(new Invoice(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(),
                                     row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString(), row[11].ToString(), row[12].ToString(), row[13].ToString(),
                                     row[14].ToString(), row[15].ToString(), OrderDate.ToString("dd.MM.yyyy"), InvoiceDate.ToString("dd.MM.yyyy"), PaymentDate.ToString("dd.MM.yyyy"), row[19].ToString(), Sum));
            }
            objectListViewInvoices.SetObjects(list);
            labelGrossValue.Text = GrossValue.ToString();
        }
    }
}
