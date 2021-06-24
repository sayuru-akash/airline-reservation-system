using System;
using System.Data.SqlClient;

namespace airline_reservation_system
{
    class FunctionsClass
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sayur\Documents\GitHub\airline-reservation-system\Database\ReservationDb.mdf;Integrated Security=True;Connect Timeout=30";

        public int checkSeatTaken(string rDate, string sNum)
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
