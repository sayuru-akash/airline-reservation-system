using System;
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

                FunctionsClass functions = new FunctionsClass();

                if(functions.checkSeatTaken(date, sNumber) == 0)
                {
                    new PopupMessage("Sorry, The expected seat is already reserved on that day!").ShowDialog();
                }
                else
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(functions.connectionString);
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
                        new PopupMessage("Reservation made successfully! Your Reservation Number is " + reservationNum).ShowDialog();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        new PopupMessage("Error making reservation!" + ex).ShowDialog();
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
                new PopupMessage("Enter all required information!").ShowDialog();
            }
        }
    }
}