using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;



namespace Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        class Invoice
        {
            public Invoice(string comCompanyName, string comAddress, string comPostalCode, string comCity, string cusCompanyName, string ContactName, string cusAddress, string cusCity, string cusPostalCode, string NIP, string ProductName, double UnitPrice, string Unit, string PKWiU, double Tax)
            {
                this.comCompanyName = comCompanyName;
                this.comAddress = comAddress;
                this.comPostalCode = comPostalCode;
                this.comCity = comCity;
                this.cusCompanyName = cusCompanyName;
                this.ContactName = ContactName;
                this.cusAddress = cusAddress;
                this.cusCity = cusCity;
                this.cusPostalCode = cusPostalCode;
                this.NIP = NIP;
                this.ProductName = ProductName;
                this.UnitPrice = UnitPrice;
                this.Unit = Unit;
                this.PKWiU = PKWiU;
                this.Tax = Tax;
            }

            public string comCompanyName { get; set; }
            public string comAddress { get; set; }
            public string comPostalCode { get; set; }
            public string comCity { get; set; }
            public string cusCompanyName { get; set; }
            public string ContactName { get; set; }
            public string cusAddress { get; set; }
            public string cusCity { get; set; }
            public string cusPostalCode { get; set; }
            public string NIP { get; set; }
            public string ProductName { get; set; }
            public double UnitPrice { get; set; }
            public string Unit { get; set; }
            public string PKWiU { get; set; }
            public double Tax { get; set; }

            //public override string ToString()
            //{
            //    return comCompanyName+ " " +comAddress + " " + comPostalCode + " " + comCity + " " + cusCompanyName + " " + ContactName + " " + cusAddress + " " + cusCity + " " + cusPostalCode + " " + NIP + " " + ProductName + " " + UnitPrice +" " + Unit + " " + PKWiU +" " +Tax;
            //}
        }



        class ComboBoxItems
        {
            public ComboBoxItems(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public int id { get; set; }
            public string name { get; set; }

            public override string ToString()
            {
                return id + " " + name;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataClassesDataContext db = new DataClassesDataContext();

            //var query = db.Customers.Select(n => n);


            //List<Customers> ls = new List<Customers>();
            //foreach (var q in query)
            //{
            //    ls.Add(new Customers(q.CompanyName, q.ContactName, q.Address, q.City, q.Country));
            //}

            ////     objectListView.SetObjects(ls);



            //string cs = "Server=DESKTOP-8CTIS47\\SQLEXPRESS; Database=Rejestr; Integrated Security = SSPI";
            //SqlConnection con = new SqlConnection(cs);

            //con.Open();
            //string sql = (@"SELECT com.CompanyName , com.Address, com.PostalCode, com.City, cus.CompanyName , cus.ContactName, cus.Address, cus.City, cus.PostalCode, cus.NIP, 
            //                prod.ProductName, prod.UnitPrice, prod.Unit, prod.PKWiU, invd.Tax
            //                FROM Invoices as inv
            //                JOIN Company as com ON com.CompanyID = inv.CompanyID
            //                JOIN Customers as cus ON cus.CustomerID = inv.CustomerID
            //                JOIN InvoiceDetails as invd ON invd.InvoiceID = inv.InvoiceID
            //                JOIN Products as prod ON prod.ProductID = invd.ProductID");

            //SqlCommand cmd = new SqlCommand(sql, con);

            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //List<Invoice> list = new List<Invoice>();

            //foreach (DataRow row in ds.Tables[0].Rows)
            //{
            //    list.Add(new Invoice(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString(), Double.Parse(row[11].ToString()), row[12].ToString(), row[13].ToString(), Double.Parse(row[14].ToString())));
            //}
            
            //objectListView.SetObjects(list);

            //ListViewItem lvi = new ListViewItem(q.CompanyName);

            //lvi.SubItems.Add(q.ContactName);
            //lvi.SubItems.Add(q.Address);
            //lvi.SubItems.Add(q.City);
            //lvi.SubItems.Add(q.Country);

            //listView.Items.Add(lvi);


            comboBox.Items.Add(new ComboBoxItems(1, "A"));
            comboBox.Items.Add(new ComboBoxItems(2, "B"));
            comboBox.Items.Add(new ComboBoxItems(3, "C"));


        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            label1.Text = ((ComboBoxItems)comboBox.SelectedItem).id.ToString();
            label2.Text = ((ComboBoxItems)comboBox.SelectedItem).name;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = (Double.Parse(textBox1.Text)*1.23).ToString();
            }

            catch
            {
                if (textBox1.Text == "")
                {
                    textBox2.Text = "";
                }
            }
                
        }

        private void objectListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = ((Invoice)objectListView.SelectedObject).UnitPrice.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (Double.Parse(textBox2.Text) / 1.23).ToString();
            }

            catch
            {
                if (textBox2.Text == "")
                {
                    textBox1.Text = "";
                }
            }
        }
    }
    
}
