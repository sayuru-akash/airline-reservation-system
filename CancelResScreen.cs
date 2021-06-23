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
    public partial class CancelResScreen : Form
    {
        public CancelResScreen()
        {
            InitializeComponent();
        }

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sayur\Documents\GitHub\airline-reservation-system\Database\ReservationDb.mdf;Integrated Security=True;Connect Timeout=30";

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (checkBoxAgree.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please agree you understand that you can not reverse this cancellation");
            }
            else
            {
                if(textBoxRID.Text != "" && textBoxPassport.Text != "")
                {
                    int reservationId = int.Parse(textBoxRID.Text);
                    int passportId = Int32.Parse(textBoxPassport.Text);

                    try
                    {
                        SqlConnection connection = new SqlConnection(connectionString);
                        string query = @"DELETE FROM ReservationTable WHERE (ReservationID= '"+ reservationId + "' AND PassportID= '"+ passportId+"')";
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Reservation Cancellation Success!");
                        connection.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Reservation not found!" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Please input all required details!");
                }
            }
        }
    }
}
