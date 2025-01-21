using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System;
using EventaDesktop;
namespace EventManagementSystem
{
    public partial class ViewEvents : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-0VTIUPTU\SQLEXPRESS;Initial Catalog=Eventa;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        public ViewEvents()
        {
            // Add a FlowLayoutPanel to the control for better layout management
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true, // Enable scrolling for overflow
                WrapContents = true, // Wrap cards if the width is exceeded
                Padding = new Padding(10),
                BackColor = Color.White
            };
            this.Controls.Add(flowLayoutPanel);

            displayEventsData(flowLayoutPanel);
        }

        public void displayEventsData(FlowLayoutPanel flowLayoutPanel)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string getAllEventsQuery = "SELECT * FROM events";
                    using (SqlCommand getAllEvents = new SqlCommand(getAllEventsQuery, connect))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(getAllEvents))
                        {
                            DataTable eventsTable = new DataTable();
                            adapter.Fill(eventsTable);

                            // Clear previous cards
                            flowLayoutPanel.Controls.Clear();

                            // Loop through each event and create a card
                            foreach (DataRow row in eventsTable.Rows)
                            {
                                int createdBy = Convert.ToInt32(row["createdBy"]);
                                int eventId = Convert.ToInt32(row["id"]);
                                string eventName = row["name"].ToString();
                                string eventDescription = row["description"].ToString();
                                string eventLocation = row["location"].ToString();
                                string eventPrice = row["price"].ToString();
                                DateTime startTime = Convert.ToDateTime(row["start_time"]);

                                // Create a card (Panel) for the event
                                Panel eventCard = CreateEventCard(eventId, eventName, eventDescription, eventLocation, startTime, eventPrice, createdBy);
                                flowLayoutPanel.Controls.Add(eventCard);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private Panel CreateEventCard(int id, string name, string description, string location, DateTime startTime, string price, int authorId)
        {
            // Create the panel
            Panel card = new Panel
            {
                Size = new Size(300, 210), 
                BackColor = Color.LightGray,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Add labels for event details
            Label lblName = new Label
            {
                Text = $"Name: {name}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 10)
            };

            Label lblDescription = new Label
            {
                Text = $"Description: {description}",
                Font = new Font("Arial", 10),
                AutoSize = true,
                Location = new Point(10, 40)
            };

            Label lblLocation = new Label
            {
                Text = $"Location: {location}",
                Font = new Font("Arial", 10),
                AutoSize = true,
                Location = new Point(10, 70)
            };

            Label lblDates = new Label
            {
                Text = $"Dates: {startTime:MM/dd/yyyy}",
                Font = new Font("Arial", 10),
                AutoSize = true,
                Location = new Point(10, 100)
            };

            Label lblPrice = new Label
            {
                Text = $"Price: ${price}",
                Font = new Font("Arial", 10),
                AutoSize = true,
                Location = new Point(10, 130)
            };

            Button participateBtn = new Button
            {
                Text = "Participate",
                Font = new Font("Arial", 10),
                AutoSize = true,
                Location = new Point(10, 160),
            };

            participateBtn.Click += (sender, e) =>
            {
                // Confirm participation
                DialogResult result = MessageBox.Show($"Are you sure you want to participate in the event '{name}'?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (UserData.UserId == authorId)
                    {
                        MessageBox.Show("Can not register to your own event!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { 
                        AddUserAsAttendee(id);
                    }
                }
            };

            // Add controls to the card
            card.Controls.Add(lblName);
            card.Controls.Add(lblDescription);
            card.Controls.Add(lblLocation);
            card.Controls.Add(lblDates);
            card.Controls.Add(lblPrice);
            card.Controls.Add(participateBtn);

            return card;
        }

        private void AddUserAsAttendee(int eventId)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                // Check if the user is already an attendee
                string checkAttendeeQuery = "SELECT COUNT(*) FROM event_attendees WHERE event_id = @eventId AND user_id = @userId";
                using (SqlCommand checkAttendeeCmd = new SqlCommand(checkAttendeeQuery, connect))
                {
                    checkAttendeeCmd.Parameters.AddWithValue("@eventId", eventId);
                    checkAttendeeCmd.Parameters.AddWithValue("@userId", UserData.UserId);

                    int count = (int)checkAttendeeCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("You are already an attendee of this event.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                // Add the user as an attendee
                string addAttendeeQuery = "INSERT INTO event_attendees (event_id, user_id) VALUES (@eventId, @userId)";
                using (SqlCommand addAttendeeCmd = new SqlCommand(addAttendeeQuery, connect))
                {
                    addAttendeeCmd.Parameters.AddWithValue("@eventId", eventId);
                    addAttendeeCmd.Parameters.AddWithValue("@userId", UserData.UserId);

                    addAttendeeCmd.ExecuteNonQuery();
                    MessageBox.Show("You have successfully registered for the event!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

    }

}
