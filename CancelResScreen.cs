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
    public partial class CancelResScreen : Form
    {
        public CancelResScreen()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (checkBoxAgree.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please agree you understand that you can not reverse this cancellation");
            }
            else
            {
                int reserveId = int.Parse(textBoxRID.Text);
                string passportId = textBoxPassport.Text;
            }
        }
    }
}
