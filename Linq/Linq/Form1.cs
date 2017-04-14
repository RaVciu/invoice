using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var query = db.Customers.Select(n => n);

            listView.View = View.Details;
            listView.Columns.Add("Company Name", 90);
            listView.Columns.Add("Contact Name", 90);
            listView.Columns.Add("Address", 90);
            listView.Columns.Add("City", 90);
            listView.Columns.Add("Country", 90);

            List<Customers> ls = new List<Customers>();
            foreach (var q in query)
            {
                ls.Add(new Customers(q.CompanyName, q.ContactName, q.Address, q.City, q.Country));
            }
            textBox.Text = ls.Count.ToString();

            int i = 0;
            do
            { 
                ListViewItem lvi = new ListViewItem(ls[i].CompanyName);
                lvi.SubItems.Add(ls[i].ContactName);
                lvi.SubItems.Add(ls[i].Address);
                lvi.SubItems.Add(ls[i].City);
                lvi.SubItems.Add(ls[i].Country);
                listView.Items.Add(lvi);
                i++;
            }

            while (i <= (ls.Count - 1));

            //ListViewItem lvi = new ListViewItem(q.CompanyName);

            //lvi.SubItems.Add(q.ContactName);
            //lvi.SubItems.Add(q.Address);
            //lvi.SubItems.Add(q.City);
            //lvi.SubItems.Add(q.Country);

            //listView.Items.Add(lvi);



        }
      }
    
}
