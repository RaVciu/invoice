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


            List<Customers> ls = new List<Customers>();
            foreach (var q in query)
            {
                ls.Add(new Customers(q.CompanyName, q.ContactName, q.Address, q.City, q.Country));
            }
 
            objectListView.SetObjects(ls);


            //ListViewItem lvi = new ListViewItem(q.CompanyName);

            //lvi.SubItems.Add(q.ContactName);
            //lvi.SubItems.Add(q.Address);
            //lvi.SubItems.Add(q.City);
            //lvi.SubItems.Add(q.Country);

            //listView.Items.Add(lvi);



        }
      }
    
}
