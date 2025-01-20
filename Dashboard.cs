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
using EventaDesktop;

namespace EventManagementSystem
{
    public partial class Dashboard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-0VTIUPTU\SQLEXPRESS;Initial Catalog=Eventa;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        public Dashboard()
        {

            DisplayAllAttendees();
            InitializeComponent();
            displayTotalEvents();
            displayTotalAttendees();
            displayTotalMoney();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

           
        }

        public void DisplayAllAttendees()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string getAllAttendeesQuery = "SELECT * FROM event_attendees WHERE event_id in (SELECT id FROM events WHERE created_by = @userId)";
                    using (SqlCommand getAllAttendees= new SqlCommand(getAllAttendeesQuery, connect))
                    {
                        getAllAttendees.Parameters.AddWithValue("@userId", UserData.UserId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(getAllAttendees))
                        {
                            DataTable atdsTable = new DataTable();
                            adapter.Fill(atdsTable);

                            // Bind the data to the DataGridView
                            atdsGridView.DataSource = atdsTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }

            }
        }

        public void displayTotalEvents()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    // Use COUNT query to get the number of events
                    string selectData = "SELECT COUNT(*) FROM events WHERE created_by = @userId";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@userId", UserData.UserId);

                        // Execute the query and get the count
                        int eventCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // update a label/control with the value
                        totalEvents_count.Text = eventCount.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to get total events count.Please try again!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        public void displayTotalAttendees()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    // Query to get the number of attendees for events created by the current user
                    string selectData = "SELECT COUNT(*) FROM event_attendees WHERE event_id IN (SELECT id FROM events WHERE created_by = @userId)";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@userId", UserData.UserId);

                        // Execute the query and get the count of attendees
                        int atdCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // Update a label/control with the attendee count
                        totalAtds_count.Text = atdCount.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to get total attendees count. Please try again!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        public void displayTotalMoney()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    // Query to get the total income from attendees' event price
                    string selectData = @"
                        SELECT SUM(e.price) 
                        FROM event_attendees ea
                        JOIN events e ON ea.event_id = e.id
                        WHERE e.created_by = @userId";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@userId", UserData.UserId);

                        // Execute the query and get the sum of the event prices
                        object result = cmd.ExecuteScalar();

                        // If there are no attendees or no events, the result will be null
                        decimal totalIncome = result == DBNull.Value ? 0 : Convert.ToDecimal(result);

                        // Update a label/control with the total income
                        totalIncome_count.Text = totalIncome.ToString("C"); // Format as currency
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to get total income. Please try again!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

    }
}
