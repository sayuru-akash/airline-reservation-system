using System;
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (checkBoxAgree.CheckState == CheckState.Unchecked)
            {
                new PopupMessage("Please agree you understand that you can not reverse this cancellation").ShowDialog();
            }
            else
            {
                if(textBoxRID.Text != "" && textBoxPassport.Text != "")
                {
                    int reservationId = int.Parse(textBoxRID.Text);
                    int passportId = int.Parse(textBoxPassport.Text);

                    FunctionsClass functions = new FunctionsClass();

                    try
                    {
                        SqlConnection connection = new SqlConnection(functions.connectionString);
                        string query = @"DELETE FROM ReservationTable WHERE (ReservationID= '" + reservationId + "' AND PassportID= '" + passportId + "')";
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        new PopupMessage("Reservation Cancellation Success!").ShowDialog();
                        connection.Close();
                    }
                    catch(Exception ex)
                    {
                        new PopupMessage("Reservation not found!" + ex).ShowDialog();
                    }
                    finally
                    {
                        textBoxRID.Text = "";
                        textBoxPassport.Text = "";
                        checkBoxAgree.CheckState = CheckState.Unchecked;
                    }
                }
                else
                {
                    new PopupMessage("Please input all required details!").ShowDialog();
                }
            }
        }
    }
}
