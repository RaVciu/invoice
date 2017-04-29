using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.SqlClient;
using System.Configuration;
using BrightIdeasSoftware;

namespace Rejestr_Faktur
{
    public partial class EditInvoice : Telerik.WinControls.UI.RadForm
    {
        public EditInvoice()
        {
            InitializeComponent();
            Generator.GenerateColumns(objectListViewInvoiceDetails, typeof(InvoiceDetails), true);
            Generator.GenerateColumns(objectListViewTaxList, typeof(TaxList), true);
            TaxLResetObjects();
        }
        List<TaxList> TaxL = new List<TaxList>();
        private void TaxLResetObjects()
        {
            TaxL.Clear();
            TaxL.Add(new TaxList("23", "23", 0, 0, 0));
            TaxL.Add(new TaxList("8", "8", 0, 0, 0));
            TaxL.Add(new TaxList("7", "7", 0, 0, 0));
            TaxL.Add(new TaxList("6", "6", 0, 0, 0));
            TaxL.Add(new TaxList("5", "5", 0, 0, 0));
            TaxL.Add(new TaxList("zw.", "0", 0, 0, 0));
            TaxL.Add(new TaxList("np.", "0", 0, 0, 0));
            TaxL.Add(new TaxList("oo.", "0", 0, 0, 0));
        }
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        SqlConnection connection = new SqlConnection(ConnectionString);
        public int InvoiceID;
        int CompanyID;
        string comCity, comIBAN, CompanyName, Address, City, PostalCode, NIP, InvoiceNo, IssuedBy, PaymentMethod, CustomerID;
        string Sum;
        bool FocusedNIP = false;
        private void radTextBox_cusNIP_TextChanged(object sender, EventArgs e)
        {
            if(FocusedNIP == true)
            {
                labelCustomerID.Text = "";
            }
        }

        private void radTextBox_cusNIP_Enter(object sender, EventArgs e)
        {
            FocusedNIP = true;
        }

        private void radTextBox_cusNIP_Leave(object sender, EventArgs e)
        {
            FocusedNIP = false;
        }

        private void radButtonSave_Click(object sender, EventArgs e)
        {
            string cusCompanyName = radRichTextEditor_cusCompanyName.Text;
            string cusAddress = radTextBox_cusAddress.Text;
            string cusCity = radTextBox_cusCity.Text;
            string cusPostalCode = radTextBox_cusPostalCode.Text;
            string cusNIP = radTextBox_cusNIP.Text;
            if (labelCustomerID.Text != "")
            {
                CustomerID = labelCustomerID.Text;
            } else { CustomerID = "NULL"; }
            string InvoiceNo = radTextBoxInvoiceNo.Text;
            string IssuedBy = radTextBoxIssuedBy.Text;
            string PaymentMethod = comboBoxPaymentMethod.SelectedItem.ToString();
            string Sum = (radLabelGrossSum.Text).Replace(",", ".");

            string QueryDeleteInvoiceDetails = "DELETE FROM InvoiceDetails WHERE InvoiceID = "+InvoiceID+"";

            if (radCheckBoxCustomerAdd.Checked)
            {
                string QueryCustomer = "INSERT INTO Customers (CompanyName, Address, City, PostalCode, NIP) VALUES ('" + cusCompanyName + "', '" + cusAddress + "', '" + cusCity + "', '" + cusPostalCode + "', '" + cusNIP + "') SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(QueryCustomer, connection);
                connection.Open();
                CustomerID = cmd.ExecuteScalar().ToString();
                connection.Close();
                string QueryUpdateInvoice = "UPDATE Invoices SET InvoiceNo = '" + InvoiceNo + "', CustomerID = '" + CustomerID + "', IssuedBy = '" + IssuedBy + "', OrderDate = @OrderDate, InvoiceDate = @InvoiceDate, PaymentDate = @PaymentDate, PaymentMethod = '" + PaymentMethod + "', CompanyName = '" + cusCompanyName + "', Address = '" + cusAddress + "', City = '" + cusCity + "', PostalCode = '" + cusPostalCode + "', NIP = '" + cusNIP + "', Sum = " + Sum + " WHERE InvoiceID = " + InvoiceID + "";
                SqlCommand cmdUpdateInv = new SqlCommand(QueryUpdateInvoice, connection);
                SqlCommand cmdDeleteInvD = new SqlCommand(QueryDeleteInvoiceDetails, connection);
                connection.Open();
                cmdUpdateInv.Parameters.Add("@OrderDate", SqlDbType.Date).Value = dateTimePickerOrderDate.Value.Date;
                cmdUpdateInv.Parameters.Add("@InvoiceDate", SqlDbType.Date).Value = dateTimePickerInvoiceDate.Value.Date;
                cmdUpdateInv.Parameters.Add("@PaymentDate", SqlDbType.Date).Value = dateTimePickerPaymentDate.Value.Date;
                cmdUpdateInv.ExecuteNonQuery();
                cmdDeleteInvD.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                string QueryUpdateInvoice = "UPDATE Invoices SET InvoiceNo = '" + InvoiceNo + "', CustomerID = "+CustomerID+", IssuedBy = '" + IssuedBy + "', OrderDate = @OrderDate, InvoiceDate = @InvoiceDate, PaymentDate = @PaymentDate, PaymentMethod = '" + PaymentMethod + "', CompanyName = '" + cusCompanyName + "', Address = '" + cusAddress + "', City = '" + cusCity + "', PostalCode = '" + cusPostalCode + "', NIP = '" + cusNIP + "', Sum = " + Sum + " WHERE InvoiceID = " + InvoiceID + "";
                SqlCommand cmdUpdateInv = new SqlCommand(QueryUpdateInvoice, connection);
                SqlCommand cmdDeleteInvD = new SqlCommand(QueryDeleteInvoiceDetails, connection);
                connection.Open();
                cmdUpdateInv.Parameters.Add("@OrderDate", SqlDbType.Date).Value = dateTimePickerOrderDate.Value.Date;
                cmdUpdateInv.Parameters.Add("@InvoiceDate", SqlDbType.Date).Value = dateTimePickerInvoiceDate.Value.Date;
                cmdUpdateInv.Parameters.Add("@PaymentDate", SqlDbType.Date).Value = dateTimePickerPaymentDate.Value.Date;
                cmdUpdateInv.ExecuteNonQuery();
                cmdDeleteInvD.ExecuteNonQuery();
                connection.Close();
            }
            foreach (InvoiceDetails invd in objectListViewInvoiceDetails.Objects)
            {
                string ProductID;
                if (invd.ProductID != "")
                {
                    ProductID = invd.ProductID;
                }else { ProductID = "NULL"; }

                string ProductName = invd.ProductName;
                string NetUnitPrice = invd.NetUnitPrice.ToString().Replace(",", ".");
                string GrossUnitPrice = invd.GrossUnitPrice.ToString().Replace(",", ".");
                string PKWiU = invd.PKWiU;
                string Unit = invd.Unit;
                string Tax = invd.Tax;
                int Quantity = invd.Quantity;
                string Discount = invd.Discount.ToString().Replace(",", ".");
                string NetValue = invd.NetValue.ToString().Replace(",", ".");
                string GrossValue = invd.GrossValue.ToString().Replace(",", ".");
                string QueryAddInvoiceDetails = "INSERT INTO InvoiceDetails VALUES(" + InvoiceID + ", " + ProductID + ", '" + ProductName + "', " + NetUnitPrice + ", " + GrossUnitPrice + ", '" + PKWiU + "', '" + Unit + "', '" + Tax + "', '" + Quantity + "', " + Discount + ", " + NetValue + ", " + GrossValue + ")";
                SqlCommand cmdAddInvD = new SqlCommand(QueryAddInvoiceDetails, connection);
                connection.Open();
                cmdAddInvD.ExecuteNonQuery();
                connection.Close();
                
                this.Close();
            }
            MessageBox.Show("Pomyślnie edytowano fakturę");
        }

        private void radButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButtonDeleteInvoiceDetail_Click(object sender, EventArgs e)
        {
            objectListViewInvoiceDetails.RemoveObject(objectListViewInvoiceDetails.SelectedObject);
        }

        DateTime OrderDate, InvoiceDate, PaymentDate;
        
        
        private void EditInvoice_Load(object sender, EventArgs e)
        {

            string QueryLoadInvoice = "SELECT inv.InvoiceID, inv.InvoiceNo, inv.CompanyID, inv.CustomerID, inv.IssuedBy, inv.OrderDate, inv.InvoiceDate, inv.PaymentDate, inv.PaymentMethod, inv.CompanyName, inv.Address, inv.City, inv.PostalCode, inv.NIP, inv.Sum, com.City, com.IBAN FROM Invoices as inv JOIN Company as com ON com.CompanyID = inv.CompanyID WHERE InvoiceID = " + InvoiceID+"";
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(QueryLoadInvoice, connection);
            connection.Close();
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                InvoiceID = int.Parse(row[0].ToString());
                InvoiceNo = row[1].ToString();
                CompanyID = int.Parse(row[2].ToString());
                CustomerID = row[3].ToString();
                IssuedBy = row[4].ToString();
                OrderDate = DateTime.Parse(row[5].ToString());
                InvoiceDate = DateTime.Parse(row[6].ToString());
                PaymentDate = DateTime.Parse(row[7].ToString());
                PaymentMethod = row[8].ToString();
                CompanyName = row[9].ToString();
                Address = row[10].ToString();
                City = row[11].ToString();
                PostalCode = row[12].ToString();
                NIP = row[13].ToString();
                Sum = row[14].ToString();
                comCity = row[15].ToString();
                comIBAN = row[16].ToString();
            }

            radTextBoxInvoiceNo.Text = InvoiceNo;
            radTextBoxIssuedBy.Text = IssuedBy;
            dateTimePickerOrderDate.Value = OrderDate;
            dateTimePickerInvoiceDate.Value = InvoiceDate;
            dateTimePickerPaymentDate.Value = PaymentDate;
            comboBoxPaymentMethod.Text = PaymentMethod;
            radRichTextEditor_cusCompanyName.Text = CompanyName;
            radTextBox_cusAddress.Text = Address;
            radTextBox_cusCity.Text = City;
            radTextBox_cusPostalCode.Text = PostalCode;
            radTextBox_cusNIP.Text = NIP;
            radLabelGrossSum.Text = Sum.ToString();
            radTextBox_comCity.Text = comCity;
            radTextBox_comIBAN.Text = comIBAN;

            string QueryLoadInvoiceDetails = "SELECT ProductID, ProductName, NetUnitPrice, GrossUnitPrice, PKWiU, Unit, Tax, Quantity, Discount, NetValue, GrossValue FROM InvoiceDetails WHERE InvoiceID = " + InvoiceID + "";
            connection.Open();
            SqlDataAdapter da2 = new SqlDataAdapter(QueryLoadInvoiceDetails, connection);
            connection.Close();
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            int Quantity;
            int Ordinal = 0;
            string ProductName, PKWiU, Unit, Tax, ProductID;
            decimal NetUnitPrice, GrossUnitPrice, Discount, NetValue, GrossValue;
            foreach(DataRow row in ds2.Tables[0].Rows)
            {
                ProductID = row[0].ToString();
                ProductName = row[1].ToString();
                NetUnitPrice = Decimal.Parse(row[2].ToString());
                GrossUnitPrice = Decimal.Parse(row[3].ToString());
                PKWiU = row[4].ToString();
                Unit = row[5].ToString();
                Tax = row[6].ToString();
                Quantity = int.Parse(row[7].ToString());
                Discount = Decimal.Parse(row[8].ToString());
                NetValue = Decimal.Parse(row[9].ToString());
                GrossValue = Decimal.Parse(row[10].ToString());
                Ordinal += 1;
                objectListViewInvoiceDetails.AddObject(new InvoiceDetails(Ordinal, ProductID, ProductName, NetUnitPrice, GrossUnitPrice, PKWiU, Unit, Tax, Quantity, Discount, NetValue, GrossValue));
            }
        }
        int Ordinal = 0;
        private void objectListViewInvoiceDetails_ItemsChanged(object sender, ItemsChangedEventArgs e)
        {

            TaxLResetObjects();
            if (objectListViewInvoiceDetails.GetItemCount() > 0)
            {
                foreach (InvoiceDetails invd in objectListViewInvoiceDetails.Objects)
                {
                    var index = TaxL.FindIndex(x => x.TaxName == invd.Tax);
                    TaxL[index].NetValue = 0;
                    TaxL[index].GrossValue = 0;
                    TaxL[index].TaxValue = 0;
                    
                }

                foreach (InvoiceDetails invd in objectListViewInvoiceDetails.Objects)
                {
                    var index = TaxL.FindIndex(x => x.TaxName == invd.Tax);

                        TaxL[index].NetValue += invd.NetValue;
                        TaxL[index].GrossValue += invd.GrossValue;
                        TaxL[index].TaxValue += (invd.GrossValue - invd.NetValue);

                }

                objectListViewTaxList.SetObjects(TaxL.FindAll(x => x.NetValue > 0));
            }
            else { objectListViewTaxList.ClearObjects(); }

            decimal GrossSum = 0;
            try
            {
                foreach (InvoiceDetails obj in objectListViewInvoiceDetails.Objects)
                {
                    GrossSum += obj.GrossValue;
                }
            }
            catch { }
            radLabelGrossSum.Text = GrossSum.ToString();
        }

        private void radButton_SelectCustomer_Click(object sender, EventArgs e)
        {
            AddInvoiceCustomer AddCustomer = new AddInvoiceCustomer();
            AddCustomer.Owner = this;
            AddCustomer.Show();
        }

        public string Tax;
        public decimal NetValue, GrossValue, TaxValue;
        private void radButtonAddInvoiceDetail_Click(object sender, EventArgs e)
        {
            AddInvoiceDetails AddInvD = new AddInvoiceDetails();
            AddInvD.Owner = this;
            AddInvD.Show();


        }
    }
}
