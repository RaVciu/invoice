﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BrightIdeasSoftware;

namespace Rejestr_Faktur
{
    public partial class Customers : Telerik.WinControls.UI.RadForm
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            Reload_objectListViewCustomers();
            radButtonEdit.Enabled = false;
            radButtonDelete.Enabled = false;
        }
        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private void Reload_objectListViewCustomers()
        {
            string InvoiceQuery = (@"SELECT CompanyName, ContactName, NIP, Address, City, PostalCode, IBAN,
                                            PhoneNumber, Email, WWW, CustomerID
                                    FROM Customers");

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(InvoiceQuery, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            List<Customer> listOfCustomers = new List<Customer>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listOfCustomers.Add(new Customer(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(),
                                    row[8].ToString(), row[9].ToString(), Int16.Parse(row[10].ToString())));
            }
            Generator.GenerateColumns(objectListViewCustomers, typeof(Customer), true);
            objectListViewCustomers.SetObjects(listOfCustomers);

        }

        private void radTextBoxSearchCustomers_TextChanged(object sender, EventArgs e)
        {
            objectListViewCustomers.ModelFilter = TextMatchFilter.Contains(objectListViewCustomers, radTextBoxSearchCustomers.Text);
        }

        private void radButtonAdd_Click(object sender, EventArgs e)
        {
            AddCustomer_cs add = new AddCustomer_cs();
            add.Show();
        }

        private void objectListViewCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectListViewCustomers.SelectedItems.Count > 0)
            {
                radButtonEdit.Enabled = true;
                radButtonDelete.Enabled = true;
            }

            else
            {
                radButtonEdit.Enabled = false;
                radButtonDelete.Enabled = false;
            }

        }

        private void radButtonEdit_Click(object sender, EventArgs e)
        {
            EditCustomer edit = new EditCustomer();
            try
            {
                edit.CompanyName = ((Customer)objectListViewCustomers.SelectedObject).CompanyName;
                edit.ContactName = ((Customer)objectListViewCustomers.SelectedObject).ContactName;
                edit.NIP = ((Customer)objectListViewCustomers.SelectedObject).NIP;
                edit.Address = ((Customer)objectListViewCustomers.SelectedObject).Address;
                edit.City = ((Customer)objectListViewCustomers.SelectedObject).City;
                edit.PostalCode = ((Customer)objectListViewCustomers.SelectedObject).PostalCode;
                edit.IBAN = ((Customer)objectListViewCustomers.SelectedObject).IBAN;
                edit.PhoneNumber = ((Customer)objectListViewCustomers.SelectedObject).PhoneNumber;
                edit.Email = ((Customer)objectListViewCustomers.SelectedObject).Email;
                edit.WWW = ((Customer)objectListViewCustomers.SelectedObject).WWW;
                edit.CustomerID = ((Customer)objectListViewCustomers.SelectedObject).CustomerID;
                edit.Show();
            }
            catch { }

        }

        private void objectListViewCustomers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            radButtonEdit_Click(sender, e);
        }

        private void radButtonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string DeleteCustomerQuery = "DELETE FROM Customers WHERE CustomerID = '"+((Customer)objectListViewCustomers.SelectedObject).CustomerID+"'";
            SqlCommand command = new SqlCommand(DeleteCustomerQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
            Reload_objectListViewCustomers();
        }
    }
}
