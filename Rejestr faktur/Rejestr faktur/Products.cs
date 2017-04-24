using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Configuration;
using System.Data.SqlClient;
using BrightIdeasSoftware;

namespace Rejestr_Faktur
{
    public partial class Products : Telerik.WinControls.UI.RadForm
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            Reload_objectListViewProducts();
            radButtonEdit.Enabled = false;
            radButtonDelete.Enabled = false;
        }


        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private void Reload_objectListViewProducts()
        {   string ProductsQuery = "SELECT ProductName, NetUnitPrice, GrossUnitPrice, PKWiU, Unit, Tax, ProductID FROM Products";

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter(ProductsQuery,connection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Product> listOfProducts = new List<Product>();
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                listOfProducts.Add(new Product(row[0].ToString(), Decimal.Parse(row[1].ToString()), Decimal.Parse(row[2].ToString()), row[3].ToString(), row[4].ToString(), Int16.Parse(row[5].ToString()), Int16.Parse(row[6].ToString())));
            }
            Generator.GenerateColumns(objectListViewProducts, typeof(Product), true);
            objectListViewProducts.SetObjects(listOfProducts);
        }


        private void radButtonAdd_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            add.Show();
        }


        private void radTextBoxSearchCustomers_TextChanged(object sender, EventArgs e)
        {
            objectListViewProducts.ModelFilter = TextMatchFilter.Contains(objectListViewProducts, radTextBoxSearchProducts.Text);
        }


        private void objectListViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectListViewProducts.SelectedObjects.Count > 0)
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
            try
            {
                EditProduct edit = new EditProduct();
                edit.ProductName = ((Product)objectListViewProducts.SelectedObject).ProductName;
                edit.NetUnitPrice = (((Product)objectListViewProducts.SelectedObject).NetUnitPrice.ToString());
                edit.GrossUnitPrice = (((Product)objectListViewProducts.SelectedObject).GrossUnitPrice.ToString());
                edit.PKWiU = ((Product)objectListViewProducts.SelectedObject).PKWiU;
                edit.Unit = ((Product)objectListViewProducts.SelectedObject).Unit;
                edit.Tax = ((Product)objectListViewProducts.SelectedObject).Tax;
                edit.ProductID = ((Product)objectListViewProducts.SelectedObject).ProductID;
                edit.Show();
            }

            catch
            { }
        }


        private void objectListViewProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            radButtonEdit_Click(sender, e);
        }


        private void radButtonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string DeleteProductQuery = "DELETE FROM Products WHERE ProductID = '"+((Product)objectListViewProducts.SelectedObject).ProductID+"'";
            SqlCommand command = new SqlCommand(DeleteProductQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
            Reload_objectListViewProducts();
        }
    }
}
