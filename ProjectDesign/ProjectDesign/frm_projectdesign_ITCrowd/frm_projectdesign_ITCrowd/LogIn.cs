using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_projectdesign_ITCrowd
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogInOK_Click(object sender, EventArgs e)
        {
            //if (this.tbUser.Text == "Admin" && this.tbPassword.Text == "1234")
            //{
                MainForm dialogLogIn = new MainForm();
                DialogResult result = dialogLogIn.ShowDialog();

            //}
            //else
            //{
            //    MessageBox.Show("Incorrect username or password.");
            //}
            
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
