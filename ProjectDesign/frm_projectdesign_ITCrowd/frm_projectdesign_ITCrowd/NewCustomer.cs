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

        Customer newCus;
        private string firstName = "Max";
        private string lastName = "Mustermann";
        private string emailAddress = "max.musti@orf.at";
        private double accBalance = 0.0;

        public NewCustomer()
        {
            InitializeComponent();
        }
        
        private void btnOKNewCus_Click(object sender, EventArgs e)
        {
            int cusID = 0;
            
            newCus = new Customer(this.firstName, this.lastName, this.emailAddress, this.accBalance, cusID);
           
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
            //Check Email Address
            if (!Customer.EmailChek(tbEmail.Text))
            {
                epError.SetError(tbEmail, "incorrect email address");
                e.Cancel = true;
            }
            else
            {
                this.epError.Clear();
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
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            this.emailAddress = tbEmail.Text;
        }

        private void tbFirstName_Validated(object sender, EventArgs e)
        {
            this.firstName = tbFirstName.Text;
        }

    }
}
