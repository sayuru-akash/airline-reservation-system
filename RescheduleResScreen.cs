using System;
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


        private void validateButton_Click(object sender, EventArgs e)
        {
            if (textBoxRID.Text != "")
            {
                int reservationID = int.Parse(textBoxRID.Text);
                int reservationNum = 0;
                FunctionsClass functions = new FunctionsClass();

                try
                {
                    SqlConnection connection = new SqlConnection(functions.connectionString);
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
                            new PopupMessage("Reservation Validated Successfully!").ShowDialog();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        new PopupMessage("Reservation is invalid!").ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    new PopupMessage("Validation Error!" + ex).ShowDialog();
                }
            }
            else
            {
                new PopupMessage("Enter Reservation ID!").ShowDialog();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int reservationID = int.Parse(textBoxRID.Text);
            string sNumber = seatNumber.Text;
            string date = datePicker.Value.ToShortDateString();

            FunctionsClass functions = new FunctionsClass();

            if (textBoxRID.Text != "" && seatNumber.Text != "")
            {
                if (functions.checkSeatTaken(date, sNumber) == 0)
                {
                    new PopupMessage("Sorry, The expected seat is already reserved on that day!").ShowDialog();
                }
                else
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(functions.connectionString);
                        string query2 = @"UPDATE ReservationTable SET Date = '" + date + "', SeatNumber= '" + sNumber + "' WHERE ReservationID = '" + reservationID + "'";
                        SqlCommand command = new SqlCommand(query2, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        new PopupMessage("Reservation Reschedule Success!").ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        new PopupMessage("Reservation Reschedule Error!" + ex).ShowDialog();
                    }
                }
            }
            else
            {
                new PopupMessage("Enter all required information!").ShowDialog();
            }
        }
    }
}
