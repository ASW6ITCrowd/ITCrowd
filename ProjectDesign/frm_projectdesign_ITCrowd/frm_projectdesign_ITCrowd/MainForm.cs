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

        public MainForm()
        {
            InitializeComponent();

            customer = Customer.ReadCSV(cryptPassword);

            for (int i = 0; i < customer.Length; i++)
            {
                if (customer[i] != null)
                {
                    tbReadBox.Text = tbReadBox.Text + customer[i].ToString() + "\r\n";
                }
            }

        }

        private void btnSaveCSV_Click(object sender, EventArgs e)
        {
            Customer.WriteCSV(customer, cryptPassword);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            NewCustomer dialogNewCustomer = new NewCustomer();
            DialogResult result = dialogNewCustomer.ShowDialog();

            if (result == DialogResult.OK)
            {
                Customer newCus = dialogNewCustomer.ReturnCustomer;

                for (int i = 0; i < customer.Length; i++)
                {
                    if (customer[i] == null)
                    {
                        newCus.CusID = i + 1;
                        break;
                    }
                }

                customer[newCus.CusID - 1] = newCus;

                tbReadBox.Clear();
                for (int i = 0; i < customer.Length; i++)
                {
                    if (customer[i] != null)
                    {
                        tbReadBox.Text = tbReadBox.Text + customer[i].ToString() + "\r\n";
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    

}



