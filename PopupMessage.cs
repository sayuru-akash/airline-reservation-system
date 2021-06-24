using System;
using System.Windows.Forms;

namespace airline_reservation_system
{
    public partial class PopupMessage : Form
    {
        public PopupMessage(string txtMessage)
        {
            InitializeComponent();
            displayMessage(txtMessage);
        }

        private void displayMessage(string txt)
        {
            lblMessage.Text = txt;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
