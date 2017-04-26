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
    public partial class AddInvoiceProdukt : Telerik.WinControls.UI.RadForm
    {
        public AddInvoiceProdukt()
        {
            InitializeComponent();
        }

        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private void Reload_objectListViewProducts()
        {
            string ProductsQuery = "SELECT ProductName, NetUnitPrice, GrossUnitPrice, PKWiU, Unit, Tax, ProductID FROM Products";

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter(ProductsQuery, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Product> listOfProducts = new List<Product>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listOfProducts.Add(new Product(row[0].ToString(), Decimal.Parse(row[1].ToString()), Decimal.Parse(row[2].ToString()), row[3].ToString(), row[4].ToString(), row[5].ToString(), Int16.Parse(row[6].ToString())));
            }
            Generator.GenerateColumns(objectListViewProducts, typeof(Product), true);
            objectListViewProducts.SetObjects(listOfProducts);
        }

        private void radTextBoxSearchProducts_TextChanged(object sender, EventArgs e)
        {
            objectListViewProducts.ModelFilter = TextMatchFilter.Contains(objectListViewProducts, radTextBoxSearchProducts.Text);
        }

        private void AddInvoiceProdukt_Load(object sender, EventArgs e)
        {
            Reload_objectListViewProducts();
        }

        string ProductName, PKWiU, Unit, TaxName;

        private void objectListViewProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            radButtonAdd_Click(sender, e);
        }

        int ProductID;
        decimal NetUnitPrice, GrossUnitPrice;
        private void radButtonAdd_Click(object sender, EventArgs e)
        {
            var owner = ((AddInvoiceDetails)this.Owner);
            var olvprod = ((Product)objectListViewProducts.SelectedObject);

            ProductName = olvprod.ProductName;
            PKWiU = olvprod.PKWiU;
            Unit = olvprod.Unit;
            TaxName = olvprod.Tax;
            ProductID = olvprod.ProductID;
            NetUnitPrice = olvprod.NetUnitPrice;
            GrossUnitPrice = olvprod.GrossUnitPrice;

            owner.radTextBoxProductName.Text = ProductName;
            owner.radTextBoxPKWiU.Text = PKWiU;
            owner.radTextBoxUnit.Text = Unit;
            owner.comboBoxTax.Text = TaxName;
            owner.labelProductID.Text = ProductID.ToString();
            owner.radTextBoxNetUnitPrice.Text = NetUnitPrice.ToString();
            owner.radTextBoxGrossUnitPrice.Text = GrossUnitPrice.ToString();
            this.Close();

        }
    }
}
