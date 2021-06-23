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
    public partial class RescheduleResScreen : Form
    {
        public RescheduleResScreen()
        {
            InitializeComponent();
        }

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sayur\Documents\GitHub\airline-reservation-system\Database\ReservationDb.mdf;Integrated Security=True;Connect Timeout=30";

        private void validateButton_Click(object sender, EventArgs e)
        {
            if (textBoxRID.Text != "")
            {
                int reservationID = int.Parse(textBoxRID.Text);
                int reservationNum = 0;

                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    string query1 = @"SELECT ReservationID FROM ReservationTable WHERE ReservationID LIKE '" + reservationID + "'";
                    try
                    {
                        using (SqlCommand command1 = new SqlCommand(query1, connection))
                        {
                            using (SqlDataReader reader = command1.ExecuteReader())
                            {
                                reader.Read();
                                reservationNum = reader.GetInt32(0);
                                reader.Close();
                            }
                        }
                        if (reservationNum != 0)
                        {
                            MessageBox.Show("Reservation Validated Successfully!");
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Reservation is invalid!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Validation error! " + ex);
                }
            }
            else
            {
                MessageBox.Show("Enter Reservation ID!");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int reservationID = int.Parse(textBoxRID.Text);
            string sNumber = seatNumber.Text;
            string date = datePicker.Value.ToShortDateString();

            if (textBoxRID.Text != "" && seatNumber.Text != "")
            {
                if (checkSeatTaken(date, sNumber) == 0)
                {
                    MessageBox.Show("Sorry, The expected seat is already reserved on that day!");
                }
                else
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(connectionString);
                        string query2 = @"UPDATE ReservationTable SET Date = '" + date + "', SeatNumber= '" + sNumber + "' WHERE ReservationID = '" + reservationID + "'";
                        SqlCommand command = new SqlCommand(query2, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Reservation Reschedule Success!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Reservation Reschedule Error!" + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter all required information!");
            }
        }

        private int checkSeatTaken(string rDate, string sNum)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM ReservationTable WHERE Date= '" + rDate + "' AND SeatNumber= '" + sNum + "'";
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
