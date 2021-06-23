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
            if(textBoxName.Text!="" && textBoxPassport.Text!="" && destinationList.Text!="" && ticketType.Text!="" && seatNumber.Text!="" && (checkBoxClassA.CheckState==CheckState.Checked || checkBoxClassB.CheckState == CheckState.Checked || checkBoxClassC.CheckState == CheckState.Checked))
            {
                string name = textBoxName.Text;
                int pNumber = int.Parse(textBoxPassport.Text);
                string destination = destinationList.Text;
                string date = datePicker.Value.ToShortDateString();
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
                if(checkSeatTaken(date, sNumber, destination, tClass) == 0)
                {
                    MessageBox.Show("Sorry, The expected seat is already reserved on that day!");
                }
                else
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(connectionString);
                        string query = "INSERT INTO ReservationTable (Name, PassportID, Destination, Date, TicketClass, TicketType, SeatNumber) VALUES ('" + name + "','" + pNumber + "','" + destination + "','" + date + "','" + tClass + "','" + tType + "','" + sNumber + "')";
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        int reservationNum;
                        string query2 = "SELECT MAX(ReservationID) FROM ReservationTable";
                        using (SqlCommand command2 = new SqlCommand(query2, connection))
                        {
                            using (SqlDataReader reader = command2.ExecuteReader())
                            {
                                reader.Read();
                                reservationNum = reader.GetInt32(0);
                                reader.Close();
                            }
                        }
                        MessageBox.Show("Reservation made successfully! Your Reservation Number is " + reservationNum);
                        connection.Close();
                    }
                    catch (Exception ex)
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
            }
            else
            {
                MessageBox.Show("Enter all required information!");
            }
            
        }

        private int checkSeatTaken(string rDate, string sNum, string dest, string tClass)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM ReservationTable WHERE Destination= '"+dest+"' AND Date= '"+rDate+"' AND TicketClass= '"+tClass+"' AND SeatNumber= '"+sNum+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int reservationExist = (int)command.ExecuteScalar();

            if (reservationExist > 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
