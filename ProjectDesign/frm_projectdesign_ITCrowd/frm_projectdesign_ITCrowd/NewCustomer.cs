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

namespace frm_projectdesign_ITCrowd
{
    public partial class NewCustomer : Form
    {
        Customer[] cusList;
        Customer newCus;
        private string firstName = "Max";
        private string lastName = "Mustermann";
        private string emailAddress = "max.musti@orf.at";
        private double accBalance = 0.0;

        public NewCustomer(Customer[] customer, bool english)
        {
            InitializeComponent();
            cusList = customer;

            //language
            if (!english)
            {
                btnCloseNewCus.Text = "Schließen";
                lbBalance.Text = "Guthaben";
                lbEmail.Text = "Email Adresse";
                lbFirstName.Text = "Vorname";
                lbLastName.Text = "Nachname";
            }
            else
            {
                btnCloseNewCus.Text = "Close";
                lbBalance.Text = "Account Balance";
                lbEmail.Text = "Email Address";
                lbFirstName.Text = "First Name";
                lbLastName.Text = "Last Name";
            }
        }
        
        private void btnOKNewCus_Click(object sender, EventArgs e)
        {
            int cusID = 0;

            // check for a free ID Number
            for (int i = 0; i < cusList.Length; i++)
            {
                if (cusList[i] == null)
                {
                    cusID = i + 1;
                    break;
                }
            }

            newCus = new Customer(this.firstName.ToUpper(), this.lastName.ToUpper(), this.emailAddress, this.accBalance, cusID);
           
        }

        public Customer ReturnCustomer
        {
            get
            {
                return newCus;
            }
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            //Check First Name if only letters
            for (int i = 0; i < tbFirstName.Text.Length; i++)
            {
                if (!char.IsLetter(tbFirstName.Text[i]))
                {
                    this.epError.SetError(textbox, "only letters");
                    e.Cancel = true;
                }
                else
                {
                    this.epError.Clear();
                }
            }
        }
        

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            //Check Last Name if only letters
            for (int i = 0; i < tbLastName.Text.Length; i++)
            {
                if (!char.IsLetter(tbLastName.Text[i]))
                {
                    epError.SetError(tbLastName, "only letters");
                    e.Cancel = true;
                }
                else
                {
                    this.epError.Clear();
                }
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            bool uniqueEmail = true;

            //check if the email address is unique
            for (int i = 0; i < cusList.Length; i++)
            {
                if (cusList[i] != null)
                {
                    if (tbEmail.Text == cusList[i].Email)
                    {
                        uniqueEmail = false;
                        epError.SetError(tbEmail, "existent email address");
                        e.Cancel = true;
                        break;
                    }
                }
            }

            //Check Email Address
            if (!Customer.EmailChek(tbEmail.Text))
            {
                epError.SetError(tbEmail, "incorrect email address");
                e.Cancel = true;
            }
            else
            {
                if (uniqueEmail == true)
                {
                    this.epError.Clear();
                }
            }
        }

        private void tbAccBalance_Validating(object sender, CancelEventArgs e)
        {
            //Check Account Balance
            if (Double.TryParse(tbAccBalance.Text, out this.accBalance))
            {
                this.epError.Clear();
            }
            else
            {
                epError.SetError(tbAccBalance, "invalid account balance");
                e.Cancel = true;
            }
        }

        private void tbLastName_Validated(object sender, EventArgs e)
        {
            this.lastName = tbLastName.Text;
            for (int i = 0; i < lastName.Length; i++)
            {
                Char.ToUpper(lastName[i]);
            }
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            this.emailAddress = tbEmail.Text;
            for (int i = 0; i < emailAddress.Length; i++)
            {
                Char.ToLower(emailAddress[i]);
            }
        }

        private void tbFirstName_Validated(object sender, EventArgs e)
        {
            this.firstName = tbFirstName.Text;
            for (int i = 0; i < firstName.Length; i++)
            {
                Char.ToUpper(firstName[i]);
            }
        }

        private void btnCloseNewCus_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
