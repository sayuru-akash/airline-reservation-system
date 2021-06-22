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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text=="admin"&&txtPassword.Text=="password")
            {
                new MainMenuScreen().Show();
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
