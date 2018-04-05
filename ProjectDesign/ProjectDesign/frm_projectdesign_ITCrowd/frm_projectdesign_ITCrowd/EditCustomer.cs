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
    public partial class EditCustomer : Form
    {
        Customer[] cusList;
        Customer editCus;
        int cusID;
        string newLastName = "Mustermann";
        string newEmail = "max.musti@orf.at";

        public EditCustomer(Customer[] customer, int customerID, bool english)
        {
            InitializeComponent();
            cusList = customer;
            cusID = customerID;
            editCus = cusList[cusID - 1];
            newLastName = editCus.LastName;
            newEmail = editCus.Email;

            //language
            if (english)
            {
                btnCloseEdit.Text = "Close";
                lbEmail.Text = "Email Address";
                lbLastName.Text = "Last Name";
            }
            else
            {
                btnCloseEdit.Text = "Schließen";
                lbEmail.Text = "Email Adresse";
                lbLastName.Text = "Nachname";
            }
        }

        private void btnOKEdit_Click(object sender, EventArgs e)
        {
            editCus.Email = newEmail;
            editCus.LastName = newLastName.ToUpper();
        }

        public Customer ReturnCustomer
        {
            get
            {
                return editCus;
            }
        }

        private void tbLastNameEdit_Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            //Check Last Name if only letters
            for (int i = 0; i < tbLastNameEdit.Text.Length; i++)
            {
                if (!char.IsLetter(tbLastNameEdit.Text[i]))
                {
                    epErrorEdit.SetError(tbLastNameEdit, "only letters");
                    e.Cancel = true;
                }
                else
                {
                    this.epErrorEdit.Clear();
                }
            }
        }

        private void tbEmailEdit_Validating(object sender, CancelEventArgs e)
        {
            bool uniqueEmail = true;

            //check if the email address is unique
            for (int i = 0; i < cusList.Length; i++)
            {
                if (cusList[i] != null)
                {
                    if (tbEmailEdit.Text == cusList[i].Email)
                    {
                        uniqueEmail = false;
                        epErrorEdit.SetError(tbEmailEdit, "existent email address");
                        e.Cancel = true;
                        break;
                    }
                }
            }

            //Check Email Address
            if (!Customer.EmailChek(tbEmailEdit.Text))
            {
                epErrorEdit.SetError(tbEmailEdit, "incorrect email address");
                e.Cancel = true;
            }
            else
            {
                if (uniqueEmail == true)
                {
                    this.epErrorEdit.Clear();
                }
            }
        }

        private void tbLastNameEdit_Validated(object sender, EventArgs e)
        {
            this.newLastName = tbLastNameEdit.Text;
        }

        private void tbEmailEdit_Validated(object sender, EventArgs e)
        {
            this.newEmail = tbEmailEdit.Text;
        }

        private void btnCloseEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
