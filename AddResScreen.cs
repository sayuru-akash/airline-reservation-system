using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace airline_reservation_system
{
    public partial class AddResScreen : Form
    {
        public AddResScreen()
        {
            InitializeComponent();
        }

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sayur\Documents\GitHub\airline-reservation-system\Database\ReservationDb.mdf;Integrated Security=True;Connect Timeout=30";
        

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
                var name = textBoxName.Text;
                int pNumber = int.Parse(textBoxPassport.Text);
                var destination = destinationList.Text;
                var date = datePicker.Value.ToShortDateString();
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

                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    string query = "INSERT INTO AirlineReservationTable (Name, PassportID, Destination, Date, TicketClass, TicketType, SeatNumber) VALUES ('" + name+ "','" + pNumber + "','" + destination + "','" + date + "','" + tClass + "','" + tType + "','" + sNumber + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Reservation made successfully!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error making reservation!" + ex);
                }
                finally
                {
                    textBoxName.Text = "";
                    textBoxPassport.Text = "";
                    destinationList.Text = "";
                    ticketType.Text = "";
                    seatNumber.Text = "";
                    checkBoxClassA.CheckState = CheckState.Unchecked;
                    checkBoxClassB.CheckState = CheckState.Unchecked;
                    checkBoxClassC.CheckState = CheckState.Unchecked;
                }
            }
            else
            {
                MessageBox.Show("Enter all required information!");
            }
            
        }
    }
}
