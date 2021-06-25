using System;
using System.Data;
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

        public int checkUserTaken(string uName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM UserTable WHERE Username= '" + uName + "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int reservationExist = (int)command.ExecuteScalar();
            connection.Close();

            if (reservationExist > 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int validateLogin(string uName, string pass)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM UserTable WHERE Username LIKE '"+uName+"' AND Password = '"+pass+"'");
            
            command.Connection = connection;
            connection.Open();

            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataSet);
            connection.Close();

            bool loginSuccess = ((dataSet.Tables.Count > 0) && (dataSet.Tables[0].Rows.Count > 0));

            if (loginSuccess)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
