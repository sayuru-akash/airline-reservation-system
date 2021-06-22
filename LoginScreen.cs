using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airline_reservation_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text=="admin"&&txtPassword.Text=="password")
            {
                new Form2().Show();
                this.Hide();
            }
            else if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter Credentials!");
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
