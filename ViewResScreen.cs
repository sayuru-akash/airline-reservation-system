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
    public partial class ViewResScreen : Form
    {
        public ViewResScreen()
        {
            InitializeComponent();
            loadDataGrid();
        }

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sayur\Documents\GitHub\airline-reservation-system\Database\ReservationDb.mdf;Integrated Security=True;Connect Timeout=30";

        private void loadDataGrid()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT * FROM ReservationTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "ReservationTable");
                dataGridView1.DataSource = dataSet.Tables["ReservationTable"].DefaultView;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data fetch unsuccessful" + ex);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (textBoxPassport.Text != "")
            {
                int pNumber = int.Parse(textBoxPassport.Text);

                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

                    string query2 = "SELECT * FROM ReservationTable WHERE PassportID='" + pNumber + "'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query2, connection);

                    DataSet dataSet = new DataSet();

                    dataAdapter.Fill(dataSet, "ReservationTable");
                    dataGridView1.DataSource = dataSet.Tables["ReservationTable"].DefaultView;

                    connection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Search unsuccessful!" + ex);
                }
                finally
                {
                    textBoxPassport.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Enter passport number!");
            }
        }

        private void refreshAllButton_Click(object sender, EventArgs e)
        {
            loadDataGrid();
        }
    }
}
