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
    public partial class AddResScreen : Form
    {
        public AddResScreen()
        {
            InitializeComponent();
        }

        private void checkBoxClassA_Clicked(object sender, EventArgs e)
        {
            checkBoxClassB.CheckState = CheckState.Unchecked;
            checkBoxClassC.CheckState = CheckState.Unchecked;
        }

        private void checkBoxClassB_Clicked(object sender, EventArgs e)
        {
            checkBoxClassA.CheckState = CheckState.Unchecked;
            checkBoxClassC.CheckState = CheckState.Unchecked;
        }

        private void checkBoxClassC_Clicked(object sender, EventArgs e)
        {
            checkBoxClassA.CheckState = CheckState.Unchecked;
            checkBoxClassB.CheckState = CheckState.Unchecked;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text!="" && textBoxPassport.Text!="" && destinationList.Text!="" && ticketType.Text!="" && seatNumber.Text!="")
            {
                string name = textBoxName.Text;
                int pNumber = int.Parse(textBoxPassport.Text);
                string destination = destinationList.Text;
                DateTime date = datePicker.Value;
                string tClass = "";
                string tType = ticketType.Text;
                string sNumber = seatNumber.Text;
                if (checkBoxClassA.Checked)
                {
                    tClass = "A";
                }
                else if (checkBoxClassB.Checked)
                {
                    tClass = "B";
                }
                else if (checkBoxClassC.Checked)
                {
                    tClass = "C";
                }
                MessageBox.Show(tClass);
            }
            else
            {
                MessageBox.Show("Enter all required information!");
            }
            
        }
    }
}
