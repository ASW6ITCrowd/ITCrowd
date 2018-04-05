using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using class_customer;
using System.IO;
using frm_projectdesign_ITCrowd;

namespace frm_projectdesign_ITCrowd
{


    public partial class MainForm : Form
    {

        Customer[] customer = new Customer[100];
        string cryptPassword = "xandl95";
        int intCusID;
        int intCusIDchange;


        public MainForm()
        {
            InitializeComponent();

            customer = Customer.ReadCSV(cryptPassword);

            UpdateReadBox();
        }

        #region Save as CSV
        private void btnSaveCSV_Click(object sender, EventArgs e)
        {
            Customer.WriteCSV(customer, cryptPassword);
        }
#endregion

        #region Add Customer
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            NewCustomer dialogNewCustomer = new NewCustomer(customer, rbEnglish.Checked);
            DialogResult result = dialogNewCustomer.ShowDialog();

            if (result == DialogResult.OK)
            {
                Customer newCus = dialogNewCustomer.ReturnCustomer;
                
                customer[newCus.CusID - 1] = newCus;

                UpdateReadBox();
            }
        }
        #endregion

        #region Close Form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
#endregion

        #region Edit Customer
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            EditCustomer dialogEditCustomer = new EditCustomer(customer, Convert.ToInt32(tbEditID.Text), rbEnglish.Checked);
            DialogResult result = dialogEditCustomer.ShowDialog();

            if (result == DialogResult.OK)
            {
                customer[dialogEditCustomer.ReturnCustomer.CusID - 1] = dialogEditCustomer.ReturnCustomer;
                
                UpdateReadBox();
            }
        }

        private void tbEditID_Validating(object sender, CancelEventArgs e)
        {
            bool existingID = false;

            //Check if text is integer
            if (int.TryParse(tbEditID.Text, out intCusID))
            {
                this.epErrorMain.Clear();
            }
            else
            {
                epErrorMain.SetError(tbEditID, "invalid custome ID");
                e.Cancel = true;
            }

            for (int i = 0; i < customer.Length; i++)
            {
                if (customer[i] != null)
                {
                    if (customer[i].CusID == intCusID)
                    {
                        existingID = true;
                        break;
                    }
                }
            }

            if (existingID)
            {
                this.epErrorMain.Clear();
            }
            else
            {
                epErrorMain.SetError(tbEditID, "custome ID doesn't exist");
                e.Cancel = true;
            }
        }
        #endregion
        
        #region Pay - Owe Money
        private void btnPay_Click(object sender, EventArgs e)
        {
            Customer.Pay(customer[Convert.ToInt32(tbChangeCustomerID.Text) - 1], Convert.ToDouble(tbAmount.Text));
            UpdateReadBox();
        }

        private void btnOwe_Click(object sender, EventArgs e)
        {
            Customer.Owe(customer[Convert.ToInt32(tbChangeCustomerID.Text) - 1], Convert.ToDouble(tbAmount.Text));
            UpdateReadBox();
        }

        private void tbChangeCustomerID_Validating(object sender, CancelEventArgs e)
        {
            bool existingID = false;

            //Check if text is integer
            if (int.TryParse(tbChangeCustomerID.Text, out intCusIDchange))
            {
                this.epErrorMain.Clear();
            }
            else
            {
                epErrorMain.SetError(tbChangeCustomerID, "invalid custome ID");
                e.Cancel = true;
            }

            for (int i = 0; i < customer.Length; i++)
            {
                if (customer[i] != null)
                {
                    if (customer[i].CusID == intCusIDchange)
                    {
                        existingID = true;
                        break;
                    }
                }
            }

            if (existingID)
            {
                this.epErrorMain.Clear();
            }
            else
            {
                epErrorMain.SetError(tbChangeCustomerID, "custome ID doesn't exist");
                e.Cancel = true;
            }
        }

        private void tbAmount_Validating(object sender, CancelEventArgs e)
        {
            //Check if text is integer
            if (double.TryParse(tbAmount.Text, out double changeAmount))
            {
                this.epErrorMain.Clear();
            }
            else
            {
                epErrorMain.SetError(tbAmount, "invalid amount");
                e.Cancel = true;
            }
        }
        #endregion

        #region Search Customer
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool isTheSame = false;
            int length = 0;
            tbReadBox.Rows.Clear();
            for (int i = 0; i < customer.Length; i++)
            {
                if (customer[i] != null)
                {
                    if (tbSearch.Text.Length < customer[i].LastName.Length)
                    {
                        for (int j = 0; j < tbSearch.Text.Length; j++)
                        {
                            if (customer[i].LastName[j] == Char.ToUpper(tbSearch.Text[j]))
                            {
                                isTheSame = true;
                            }
                            else
                            {
                                isTheSame = false;
                                break;
                            }
                        }
                        if (isTheSame)
                        {
                            string[] splitCustomer = customer[i].ToString().Split(' ');
                            tbReadBox.Rows.Add(splitCustomer);
                            isTheSame = false;
                        }
                    }
                }
            }
        }

        private void tbSearch_Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            //Check Last Name if only letters
            for (int i = 0; i < tbSearch.Text.Length; i++)
            {
                if (!char.IsLetter(tbSearch.Text[i]))
                {
                    epErrorMain.SetError(tbSearch, "only letters");
                    e.Cancel = true;
                }
                else
                {
                    this.epErrorMain.Clear();
                }
            }
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            UpdateReadBox();
        }
        #endregion

        #region Update ReadBox
        public void UpdateReadBox()
        {
            tbReadBox.Rows.Clear();
            for (int i = 0; i < customer.Length; i++)
            {
                if (customer[i] != null)
                {
                    string[] splitCustomer = customer[i].ToString().Split(' ');
                    tbReadBox.Rows.Add(splitCustomer);
                }
            }
        }
        #endregion

        #region Change Language
        private void rbGerman_CheckedChanged(object sender, EventArgs e)
        {
            //buttons
            btnAddCustomer.Text = "Hinzufügen";
            btnAll.Text = "Alle anzeigen";
            btnClose.Text = "Schließen";
            btnEditCustomer.Text = "Bearbeiten";
            btnPay.Text = "Zahlen";
            btnSaveCSV.Text = "Speichern";
            btnOwe.Text = "Schulden";
            btnSearch.Text = "Suchen";

            //labels
            lbAmount.Text = "Betrag";
            lbLastNameSearch.Text = "Nachname";

            //groupbox
            gbAmount.Text = "Guthaben ändern";
            gbCustomer.Text = "Kunde";

            //dataGridView
            tbReadBox.Columns[0].HeaderText = "Kunden ID";
            tbReadBox.Columns[1].HeaderText = "Vorname";
            tbReadBox.Columns[2].HeaderText = "Nachname";
            tbReadBox.Columns[3].HeaderText = "Guthaben";
            tbReadBox.Columns[4].HeaderText = "Email Adresse";
            tbReadBox.Columns[5].HeaderText = "Letze Änderung";
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            //buttons
            btnAddCustomer.Text = "Add Customer";
            btnAll.Text = "Show All";
            btnClose.Text = "Close";
            btnEditCustomer.Text = "Edit Customer";
            btnPay.Text = "PAY";
            btnSaveCSV.Text = "Save";
            btnOwe.Text = "OWE";
            btnSearch.Text = "Search";

            //labels
            lbAmount.Text = "Amount";
            lbLastNameSearch.Text = "Last Name";

            //groupbox
            gbAmount.Text = "Change Balance";
            gbCustomer.Text = "Customer";

            //dataGridView
            tbReadBox.Columns[0].HeaderText = "Customer ID";
            tbReadBox.Columns[1].HeaderText = "First Name";
            tbReadBox.Columns[2].HeaderText = "Last Name";
            tbReadBox.Columns[3].HeaderText = "Account Balance";
            tbReadBox.Columns[4].HeaderText = "Email Address";
            tbReadBox.Columns[5].HeaderText = "Last Change";
        }
        #endregion
    }


}



