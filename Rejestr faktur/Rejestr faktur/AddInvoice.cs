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
    public partial class AddInvoice : Telerik.WinControls.UI.RadForm
    {
        public AddInvoice()
        {
            InitializeComponent();
            Generator.GenerateColumns(objectListViewInvoiceDetails, typeof(InvoiceDetails), true);
            Generator.GenerateColumns(objectListViewTaxList, typeof(TaxList), true);
            TaxLResetObjects();
        }

        private void TaxLResetObjects()
        {
            TaxL.Clear();
            TaxL.Add(new TaxList("23", "23", 0, 0, 0));
            TaxL.Add(new TaxList("8", "8", 0, 0, 0));
            TaxL.Add(new TaxList("7", "7", 0, 0, 0));
            TaxL.Add(new TaxList("5", "5", 0, 0, 0));
            TaxL.Add(new TaxList("zw.", "0", 0, 0, 0));
            TaxL.Add(new TaxList("np.", "0", 0, 0, 0));
            TaxL.Add(new TaxList("oo.", "0", 0, 0, 0));
        }

        string comCompanyName, comAddress, comCity, comPostalCode, comNIP, comIBAN, comBankName;
        int CompanyID;
        public string ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private void InsertCompanyDetails()
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            string CompanyQuery = "SELECT CompanyName, Address, City, PostalCode, NIP, IBAN, BankName, CompanyID FROM Company";
            SqlDataAdapter da = new SqlDataAdapter(CompanyQuery, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                comCompanyName = row[0].ToString();
                comAddress = row[1].ToString();
                comCity = row[2].ToString();
                comPostalCode = row[3].ToString();
                comNIP = row[4].ToString();
                comIBAN = row[5].ToString();
                comBankName = row[6].ToString();
                CompanyID = int.Parse(row[7].ToString());
            }
            radTextBox_comIBAN.Text = comIBAN;
            radTextBox_comCity.Text = comCity;

        }

        List<TaxList> TaxL = new List<TaxList>();

        private void radButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string cusCompanyName = radRichTextEditor_cusCompanyName.Text;
            string cusAddress = radTextBox_cusAddress.Text;
            string cusCity = radTextBox_cusCity.Text;
            string cusPostalCode = radTextBox_cusPostalCode.Text;
            string cusNIP = radTextBox_cusNIP.Text;
            string CustomerID;
            string InvoiceNo = radTextBoxInvoiceNo.Text;
            int CompanyID = this.CompanyID;
            if (labelCustomerID.Text != "")
            {
                 CustomerID = labelCustomerID.Text;
            } else { CustomerID = ""; }
            string IssuedBy = radTextBoxIssuedBy.Text;
            string PaymentMethod = comboBoxPaymentMethod.SelectedItem.ToString();
            string Sum = (radLabelGrossSum.Text).Replace(",", ".");
            int InvoiceID;

                if (radCheckBoxCustomerAdd.Checked)
                {
                    string QueryCustomer = "INSERT INTO Customers (CompanyName, Address, City, PostalCode, NIP) VALUES ('" + cusCompanyName + "', '" + cusAddress + "', '" + cusCity + "', '" + cusPostalCode + "', '" + cusNIP + "') SELECT SCOPE_IDENTITY()";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(QueryCustomer, connection);
                    CustomerID = cmd.ExecuteScalar().ToString();
                    string QueryInvoice = "INSERT INTO Invoices (InvoiceNo, CompanyID, CustomerID, IssuedBy, OrderDate, InvoiceDate, PaymentDate, PaymentMethod, CompanyName, Address, City, PostalCode, NIP, Sum) VALUES('" + InvoiceNo + "', " + CompanyID + ", " + CustomerID + " ,'" + IssuedBy + "', @OrderDate, @InvoiceDate, @PaymentDate, '" + PaymentMethod + "', '" + cusCompanyName + "', '" + cusAddress + "', '" + cusCity + "', '" + cusPostalCode + "', '" + cusNIP + "', " + Sum + ") SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd2 = new SqlCommand(QueryInvoice, connection);
                    cmd2.Parameters.Add("@OrderDate", SqlDbType.Date).Value = dateTimePickerOrderDate.Value.Date;
                    cmd2.Parameters.Add("@InvoiceDate", SqlDbType.Date).Value = dateTimePickerInvoiceDate.Value.Date;
                    cmd2.Parameters.Add("@PaymentDate", SqlDbType.Date).Value = dateTimePickerPaymentDate.Value.Date;
                    InvoiceID = int.Parse(cmd2.ExecuteScalar().ToString());
                    connection.Close();
                }

                else
                {
                    string QueryInvoice = "INSERT INTO Invoices (InvoiceNo, CompanyID, IssuedBy, OrderDate, InvoiceDate, PaymentDate, PaymentMethod, CompanyName, Address, City, PostalCode, NIP, Sum) VALUES('" + InvoiceNo + "', " + CompanyID + ", '" + IssuedBy + "', @OrderDate, @InvoiceDate, @PaymentDate, '" + PaymentMethod + "', '" + cusCompanyName + "', '" + cusAddress + "', '" + cusCity + "', '" + cusPostalCode + "', '" + cusNIP + "', " + Sum + "); SELECT SCOPE_IDENTITY()";
                    connection.Open();
                    SqlCommand cmd2 = new SqlCommand(QueryInvoice, connection);
                    cmd2.Parameters.Add("@OrderDate", SqlDbType.Date).Value = dateTimePickerOrderDate.Value.Date;
                    cmd2.Parameters.Add("@InvoiceDate", SqlDbType.Date).Value = dateTimePickerInvoiceDate.Value.Date;
                    cmd2.Parameters.Add("@PaymentDate", SqlDbType.Date).Value = dateTimePickerPaymentDate.Value.Date;
                    InvoiceID = int.Parse(cmd2.ExecuteScalar().ToString());
                    connection.Close();
                }

                foreach (InvoiceDetails invd in objectListViewInvoiceDetails.Objects)
                {

                    string ProductID = invd.ProductID;
                    if(ProductID == "") { ProductID = "NULL"; }
                    string ProductName = invd.ProductName;
                    string NetUnitPrice = invd.NetUnitPrice.ToString().Replace(",", ".");
                    string GrossUnitPrice = invd.GrossUnitPrice.ToString().Replace(",", ".");
                    string PKWiU = invd.PKWiU;
                    string Unit = invd.Unit;
                    string Tax = invd.Tax;
                    int Quantity = invd.Quantity;
                    decimal Discount = invd.Discount;
                    string NetValue = invd.NetValue.ToString().Replace(",", ".");
                    string GrossValue = invd.GrossValue.ToString().Replace(",", ".");
                    connection.Open();
                    string QueryInvoiceDetails = "INSERT INTO InvoiceDetails VALUES(" + InvoiceID + ", " + ProductID + ", '" + ProductName + "', " + NetUnitPrice + ", " + GrossUnitPrice + ", '" + PKWiU + "', '" + Unit + "', '" + Tax + "', '" + Quantity + "', " + Discount + ", " + NetValue + ", " + GrossValue + ")";
                    SqlCommand cmd = new SqlCommand(QueryInvoiceDetails, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                foreach (TaxList taxl in objectListViewTaxList.Objects)
                {

                    string Tax = taxl.Tax.ToString();
                    string TaxName = taxl.TaxName.ToString();
                    string NetValue = taxl.NetValue.ToString().Replace(",", ".");
                    string TaxValue = taxl.TaxValue.ToString().Replace(",", ".");
                    string GrossValue = taxl.GrossValue.ToString().Replace(",", ".");

                    string QueryTaxDetails = "INSERT INTO TaxDetails VALUES(" + InvoiceID + ", '" + TaxName + "', '" + Tax + "', " + NetValue + ", " + TaxValue + ", " + GrossValue + ")";
                    SqlCommand cmd = new SqlCommand(QueryTaxDetails, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Pomyślnie dodano fakturę");
                this.Close();
            }
            catch { MessageBox.Show("Niepoprawny format danych bądź występują puste pola"); }
        }

        private void radButtonDeleteInvoiceDetail_Click(object sender, EventArgs e)
        {
            objectListViewInvoiceDetails.RemoveObject(objectListViewInvoiceDetails.SelectedObject);
        }

        private void radButtonEditInvoiceDetail_Click(object sender, EventArgs e)
        {
            EditInvoiceDetails editInvD = new EditInvoiceDetails();
            editInvD.radTextBoxProductName.Text = ((InvoiceDetails)objectListViewInvoiceDetails.SelectedObject).ProductName;
            editInvD.radTextBoxPKWiU.Text = ((InvoiceDetails)objectListViewInvoiceDetails.SelectedObject).PKWiU;
            editInvD.radTextBoxUnit.Text = ((InvoiceDetails)objectListViewInvoiceDetails.SelectedObject).Unit;
            editInvD.radTextBoxQuantity.Text = ((InvoiceDetails)objectListViewInvoiceDetails.SelectedObject).Quantity.ToString();
            editInvD.radTextBoxNetUnitPrice.Text = ((InvoiceDetails)objectListViewInvoiceDetails.SelectedObject).NetUnitPrice.ToString();
            editInvD.radTextBoxGrossUnitPrice.Text = ((InvoiceDetails)objectListViewInvoiceDetails.SelectedObject).GrossUnitPrice.ToString();
            editInvD.radTextBoxDiscount.Text = ((InvoiceDetails)objectListViewInvoiceDetails.SelectedObject).Discount.ToString();
            editInvD.SelectedObjectIndex = objectListViewInvoiceDetails.SelectedIndex;
            editInvD.Owner = this;
            editInvD.Show();
        }

        private void objectListViewInvoiceDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectListViewInvoiceDetails.SelectedObjects.Count > 0)
            {
                radButtonEditInvoiceDetail.Enabled = true;
            }
            else { radButtonEditInvoiceDetail.Enabled = false; }
        }

        private void radButton_SelectCustomer_Click(object sender, EventArgs e)
        {
            AddInvoiceCustomer AddCustomer = new AddInvoiceCustomer();
            AddCustomer.Owner = this;
            AddCustomer.Show();
        }

        private void AddInvoice_Load(object sender, EventArgs e)
        {

            InsertCompanyDetails();
            radButtonEditInvoiceDetail.Enabled = false;
        }

        public string ProductName, PKWiU, Unit, Tax;

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
                objectListViewTaxList.SetObjects(TaxL.FindAll(x => x.NetValue>0));
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
        
        public decimal NetValue, GrossValue, TaxValue;
        private void radButtonAddInvoiceDetail_Click(object sender, EventArgs e)
        {
            AddInvoiceDetails AddInvD = new AddInvoiceDetails();
            AddInvD.Owner = this;
            AddInvD.Show();

            
        }
        




    }
}
