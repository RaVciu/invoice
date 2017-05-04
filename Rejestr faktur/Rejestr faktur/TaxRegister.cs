using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using BrightIdeasSoftware;
using System.Configuration;
using System.Data.SqlClient;

namespace Rejestr_Faktur
{
    public partial class TaxRegister : Telerik.WinControls.UI.RadForm
    {
        class Quarters
        {
            public Quarters(int _FromMonth, int _ToMonth, string _Name)
            {
                FromMonth = _FromMonth;
                ToMonth = _ToMonth;
                Name = _Name;
            }
            public int FromMonth { get; set; }
            public int ToMonth { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }


        public TaxRegister()
        {
            InitializeComponent();
            Generator.GenerateColumns(objectListViewTaxRegister, typeof(TaxRegister_Class), true);

        }

        private void Fill_Lists()
        {
            RegisterType.Add("Kwartalny");
            RegisterType.Add("Miesięczny");

            PeriodOfTime_monthly.Add("Styczeń");
            PeriodOfTime_monthly.Add("Luty");
            PeriodOfTime_monthly.Add("Marzec");
            PeriodOfTime_monthly.Add("Kwiecień");
            PeriodOfTime_monthly.Add("Maj");
            PeriodOfTime_monthly.Add("Czerwiec");
            PeriodOfTime_monthly.Add("Lipiec");
            PeriodOfTime_monthly.Add("Sierpień");
            PeriodOfTime_monthly.Add("Wrzesień");
            PeriodOfTime_monthly.Add("Październik");
            PeriodOfTime_monthly.Add("Listopad");
            PeriodOfTime_monthly.Add("Grudzień");

            PeriodOfTime_quarterly.Add(new Quarters(1, 3, "I styczeń - marzec"));
            PeriodOfTime_quarterly.Add(new Quarters(4, 6, "II kwiecień - czerwiec"));
            PeriodOfTime_quarterly.Add(new Quarters(7, 9, "III lipiec - wrzesień"));
            PeriodOfTime_quarterly.Add(new Quarters(10, 12, "IV październik - grudzień"));
            var owner = ((Register)this.Owner);
            try
            {
                foreach (Invoice inv in owner.objectListViewInvoices.Objects)
                {
                    DateTime date = DateTime.Parse(inv.InvoiceDate.ToString());
                    Year.Add(date.ToString("yyyy"));
                }
                
            }
            catch { }
        }

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        SqlConnection connection = new SqlConnection(ConnectionString);

        List<string> RegisterType = new List<string>();
        List<Quarters> PeriodOfTime_quarterly = new List<Quarters>();
        List<string> PeriodOfTime_monthly = new List<string>();
        List<string> Year = new List<string>();
        List<TaxRegister_Class> TaxRegist = new List<TaxRegister_Class>();
        List<TaxRegister_Class> TaxRegist_Distinct = new List<TaxRegister_Class>();
        private void TaxRegister_Load(object sender, EventArgs e)
        {
            Fill_Lists();
            foreach (Quarters qr in PeriodOfTime_quarterly)
            {
                comboBoxPeriodOfTime.Items.Add(qr);
                comboBoxPeriodOfTime.SelectedIndex = 0;
            }
            
            comboBoxRegisterType.DataSource = RegisterType;
            comboBoxYear.DataSource = Year.Distinct().ToList();
            string QueryTaxRegister = "SELECT inv.InvoiceNo, inv.InvoiceDate, inv.OrderDate, inv.NIP, inv.CompanyName, inv.Address, inv.PostalCode, inv.City, tax.GrossValue, tax.NetValue, tax.TaxValue, tax.TaxName FROM Invoices as inv JOIN TaxDetails as tax ON inv.InvoiceID = tax.InvoiceID";
            SqlDataAdapter daTaxRegister = new SqlDataAdapter(QueryTaxRegister, connection);
            DataSet dsTaxRegister = new DataSet();
            daTaxRegister.Fill(dsTaxRegister);
            int Ordinal = 1;
            decimal TaxValue23 = 0;
            decimal TaxValue8 = 0;
            decimal TaxValue5 = 0;
            decimal TaxValueTotal = 0;
            foreach (DataRow row in dsTaxRegister.Tables[0].Rows)
            {
                string FullAddress = row[5].ToString() + " " + row[6].ToString() + " " + row[7].ToString();

                if (TaxRegist_Distinct.FindIndex(x => x.InvoiceNo == row[0].ToString()) == -1)
                {
                    TaxRegist_Distinct.Add(new TaxRegister_Class(Ordinal, row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), FullAddress, decimal.Parse(row[8].ToString()),0,0,0,0,0,0,0,0,0,0,0));
                    Ordinal++;
                }

                var index = TaxRegist_Distinct.FindIndex(x => x.InvoiceNo == row[0].ToString());
                if (row[11].ToString() == "23")
                {
                    TaxRegist_Distinct[index].NetValue23 = Decimal.Parse(row[9].ToString());
                    TaxRegist_Distinct[index].TaxValue23 = Decimal.Parse(row[10].ToString());
                    TaxValue23 = Decimal.Parse(row[10].ToString());
                } 
                else if(row[11].ToString() == "8" || row[11].ToString() == "7")
                {
                    TaxRegist_Distinct[index].NetValue8 = Decimal.Parse(row[9].ToString());
                    TaxRegist_Distinct[index].TaxValue8 = Decimal.Parse(row[10].ToString());
                    TaxValue8 = Decimal.Parse(row[10].ToString());

                }
                else if(row[11].ToString() == "5")
                {
                    TaxRegist_Distinct[index].NetValue5 = Decimal.Parse(row[9].ToString());
                    TaxRegist_Distinct[index].TaxValue5 = Decimal.Parse(row[10].ToString());
                    TaxValue5 = Decimal.Parse(row[10].ToString());

                }
                else if(row[11].ToString() == "0")
                {
                    TaxRegist_Distinct[index].NetValue0 = Decimal.Parse(row[9].ToString());
                    
                }
                else if(row[11].ToString() == "oo")
                {
                    TaxRegist_Distinct[index].NetValueOO = Decimal.Parse(row[9].ToString());
                }
                else if (row[11].ToString() == "zw")
                {
                    TaxRegist_Distinct[index].NetValueZW = Decimal.Parse(row[9].ToString());
                }
                else if (row[11].ToString() == "np")
                {
                    TaxRegist_Distinct[index].NetValueNP = Decimal.Parse(row[9].ToString());
                }
                TaxValueTotal = TaxValue23 + TaxValue8 + TaxValue5;
                TaxRegist_Distinct[index].TaxValue = TaxValueTotal;
            }

            try
            {
                DateTime dtFilter_To;
                DateTime dtFilter_From = new DateTime(int.Parse(comboBoxYear.SelectedItem.ToString()), ((Quarters)(comboBoxPeriodOfTime.SelectedItem)).FromMonth, 1);
                if (((Quarters)comboBoxPeriodOfTime.SelectedItem).ToMonth.ToString() == "3" || ((Quarters)comboBoxPeriodOfTime.SelectedItem).ToMonth.ToString() == "12")
                {
                    dtFilter_To = new DateTime(int.Parse(comboBoxYear.SelectedItem.ToString()), ((Quarters)comboBoxPeriodOfTime.SelectedItem).ToMonth, 31);
                }
                else
                {
                    dtFilter_To = new DateTime(int.Parse(comboBoxYear.SelectedItem.ToString()), ((Quarters)comboBoxPeriodOfTime.SelectedItem).ToMonth, 30);
                }
                objectListViewTaxRegister.SetObjects(TaxRegist_Distinct.FindAll(x => DateTime.Parse(x.OrderDate).Date >= dtFilter_From.Date && DateTime.Parse(x.OrderDate).Date <= dtFilter_To.Date));
            }
            catch { }
        }

        private void comboBoxRegisterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxRegisterType.SelectedItem.ToString() == "Kwartalny")
            {
                if (comboBoxPeriodOfTime.Items.Count == 0 || comboBoxPeriodOfTime.Items.Count == 12)
                {
                    comboBoxPeriodOfTime.DataSource = null;
                    foreach (Quarters qr in PeriodOfTime_quarterly)
                    {
                        comboBoxPeriodOfTime.Items.Add(qr);
                        comboBoxPeriodOfTime.SelectedIndex = 0;
                    }
                    radLabelPeriodOfTime.Text = "Kwartał";
                }
            }
            else
            {
                comboBoxPeriodOfTime.DataSource = PeriodOfTime_monthly;
                radLabelPeriodOfTime.Text = "Miesiąc";
            }
        }

        private void comboBoxPeriodOfTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dtFilter_To;
                DateTime dtFilter_From = new DateTime(int.Parse(comboBoxYear.SelectedItem.ToString()), ((Quarters)(comboBoxPeriodOfTime.SelectedItem)).FromMonth, 1);
                if (((Quarters)comboBoxPeriodOfTime.SelectedItem).ToMonth.ToString() == "3" || ((Quarters)comboBoxPeriodOfTime.SelectedItem).ToMonth.ToString() == "12")
                {
                    dtFilter_To = new DateTime(int.Parse(comboBoxYear.SelectedItem.ToString()), ((Quarters)comboBoxPeriodOfTime.SelectedItem).ToMonth, 31);
                }
                else
                {
                    dtFilter_To = new DateTime(int.Parse(comboBoxYear.SelectedItem.ToString()), ((Quarters)comboBoxPeriodOfTime.SelectedItem).ToMonth, 30);
                }
                objectListViewTaxRegister.SetObjects(TaxRegist_Distinct.FindAll(x => (DateTime.Parse(x.OrderDate)).Date >= dtFilter_From.Date && (DateTime.Parse(x.OrderDate)).Date <= dtFilter_To.Date));
                int Ordinal = 1;
                foreach (TaxRegister_Class taxR in objectListViewTaxRegister.Objects)
                {
                    taxR.Ordinal = Ordinal;
                    Ordinal++;
                }
            }
            catch { }
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPeriodOfTime_SelectedIndexChanged(sender, e);
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            objectListViewTaxRegister.ModelFilter = TextMatchFilter.Contains(objectListViewTaxRegister, textBoxFilter.Text);
        }

        private void objectListViewTaxRegister_ItemsChanged(object sender, ItemsChangedEventArgs e)
        {
            int Ordinal = 1;
            try
            {
                foreach (TaxRegister_Class taxR in objectListViewTaxRegister.Objects)
                {
                    taxR.Ordinal = Ordinal;
                    Ordinal++;
                }
            }
            catch { }
        }
    }
}
