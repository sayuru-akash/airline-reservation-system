using System;
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
                new PopupMessage("Log In Success!").ShowDialog();
                this.Hide();
            }
            else if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                new PopupMessage("Enter Credentials!").ShowDialog();
                txtPassword.Text = "";
            }
            else
            {
                new PopupMessage("Invalid Credentials!").ShowDialog();
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
