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
using System.IO;
using EventaDesktop;
using System.Diagnostics.Eventing;
using System.Runtime.InteropServices.ComTypes;

namespace EventManagementSystem
{
    public partial class AddEvent : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-0VTIUPTU\SQLEXPRESS;Initial Catalog=Eventa;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private MainForm mainForm;
        public int selectedEventId = 0;

        public AddEvent(MainForm form)
        {
            InitializeComponent();
            mainForm = form;

            // TO DISPLAY THE DATA FROM DATABASE TO DATA GRID VIEW
            displayEventsData();
        }


        

        //REFRESH DATA
        public void RefreshData()
        {
            displayEventsData();
        }


        //LOAD ALL EVENTS WHICH WHERE CREATED BY CURRENT USER
        public void displayEventsData()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string getAllEventsQuery = "SELECT * FROM events WHERE created_by = @userId";
                    using (SqlCommand getAllEvents = new SqlCommand(getAllEventsQuery, connect))
                    {
                        getAllEvents.Parameters.AddWithValue("@userId", UserData.UserId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(getAllEvents))
                        {
                            DataTable eventsTable = new DataTable();
                            adapter.Fill(eventsTable);

                            // Clear the old DataSource
                            eventsDataGrid.DataSource = null;

                            // Bind the new DataSource
                            eventsDataGrid.DataSource = eventsTable;

                            // Refresh the DataGridView to apply changes
                            eventsDataGrid.Refresh();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not retrieve events.Try again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
               
            }
        }

            private string handleImage(string eventName)
            {
                // Use a relative directory path within the application's working directory
                string baseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EventImages");
                string imagePath = Path.Combine(baseDirectory, eventName + ".jpg");
                // Ensure the directory exists
                if (!Directory.Exists(baseDirectory))
                {
                    Directory.CreateDirectory(baseDirectory);
                }

                // Ensure the image path is valid before copying
                if (!string.IsNullOrEmpty(eventPhoto.ImageLocation) && File.Exists(eventPhoto.ImageLocation))
                {
                    try
                    {
                        // Copy the image to the directory
                        File.Copy(eventPhoto.ImageLocation, imagePath, true);
                        return imagePath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error copying image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return "";
                    }
                }
                else
                {
                    MessageBox.Show("Image location is invalid or image not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";

                }
            }


            //ADD NEW EVENT
            private async void addEvent_addBtn_Click(object sender, EventArgs e)
            {
                var eventName = eventName_input.Text.Trim();
                var eventDesc = eventDesc_input.Text.Trim();
                var eventLocation = eventLocation_input.Text.Trim();
                var eventPrice = eventPrice_input.Text.Trim();


                if (!ValidationHelper.ValidateEventDetails(eventName, eventDesc, eventLocation, eventPhoto.Image, eventSDate_input.Text, eventPrice, out string errorMessage))
                {
                    MessageBox.Show(errorMessage, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var sDate = DateTime.Parse(eventSDate_input.Text);

                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEvName = "SELECT COUNT(*) FROM events WHERE name = @evName";

                        using (SqlCommand checkEv = new SqlCommand(checkEvName, connect))
                        {
                            checkEv.Parameters.AddWithValue("@evName", eventName);
                            int count = (int)checkEv.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(eventName + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                //DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO events " +
                                    "(name, description, location, start_time, created_by, image, price)" +
                                    "VALUES(@evName, @evDesc, @evLoc, @evST, @userId, @evImg, @evPrice)";


                            string imagePath = handleImage(eventName);
                            if(imagePath != "")
                            {
                                return;
                            }

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@evName", eventName);
                                    cmd.Parameters.AddWithValue("@evDesc", eventDesc);
                                    cmd.Parameters.AddWithValue("@evLoc", eventLocation);
                                    cmd.Parameters.AddWithValue("@evST", sDate);
                                    cmd.Parameters.AddWithValue("@userId", UserData.UserId);
                                    cmd.Parameters.AddWithValue("@evImg", imagePath);
                                    cmd.Parameters.AddWithValue("@evPrice", eventPrice);

                                    cmd.ExecuteNonQuery();

                                    

                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                    // Refresh the AddEvent control in the MainForm
                                    mainForm.RefreshAddEventControl();
                            }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not add event.Try again ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }


            //IMPORT PHOTO
            private void addEvent_importBtn_Click(object sender, EventArgs e)
            {
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                    string imagePath = "";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        imagePath = dialog.FileName;
                        eventPhoto.ImageLocation = imagePath;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not choose img.Try again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void eventsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = eventsDataGrid.Rows[e.RowIndex];
                    selectedEventId = Convert.ToInt32(row.Cells[0].Value);
                    eventName_input.Text = row.Cells[1].Value.ToString();
                    eventDesc_input.Text = row.Cells[2].Value.ToString();
                    eventLocation_input.Text = row.Cells[3].Value.ToString();
                    // Try to parse the value as DateTime
                    //if (row.Cells[4].Value != DBNull.Value && DateTime.TryParse(row.Cells[4].Value.ToString(), out DateTime startDate))
                    //{
                    //    eventSDate_input.Value = startDate;
                    //}

                   
                   
                    eventPrice_input.Text = row.Cells[9].Value.ToString();

                    string relativeImagePath = row.Cells[8].Value.ToString(); // Assuming the relative path stored is like "Directory\\event.jpg"
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory; // The directory where the app is running from

                    string fullImagePath = Path.Combine(baseDirectory, relativeImagePath);

                    if (File.Exists(fullImagePath))
                    {
                        eventPhoto.Image = Image.FromFile(fullImagePath);
                    }
                    else
                    {
                        MessageBox.Show("Image file not found: " + fullImagePath, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        eventPhoto.Image = null;
                    }

            }
        }


            //CLEAR ALL FIELDS
            public void clearFields()
            {
                selectedEventId = 0;
                eventName_input.Text = "";
                eventDesc_input.Text = "";
                eventLocation_input.Text = "";
                eventSDate_input.MinDate = DateTime.Now;
                eventPhoto.Image = null;
                eventPrice_input.Text = "";
            }

            private void addEvent_updateBtn_Click(object sender, EventArgs e)
            {
                if(selectedEventId == 0)
                {
                    MessageBox.Show("You have not selected an event for updating", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var eventName = eventName_input.Text.Trim();
                var eventDesc = eventDesc_input.Text.Trim();
                var eventLocation = eventLocation_input.Text.Trim();
                var eventPrice = eventPrice_input.Text.Trim();


                if (!ValidationHelper.ValidateEventDetails(eventName, eventDesc, eventLocation, eventPhoto.Image, eventSDate_input.Text, eventPrice, out string errorMessage))
                {
                    MessageBox.Show(errorMessage, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var sDate = DateTime.Parse(eventSDate_input.Text);

                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                        "Event: " + eventName + "?", "Confirmation Message"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

            

                        string updateData = "UPDATE events SET name = @evName" +
                            ", description = @evDesc, location = @evLoc" +
                            ", start_time = @evST, image = @evImg, price = @evPrice" +
                            "WHERE id = @evId";

                        string imagePath = handleImage(eventName);
                        if (imagePath != "")
                        {
                            return;
                        }

                    using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@evName", eventName);
                            cmd.Parameters.AddWithValue("@evDesc", eventDesc);
                            cmd.Parameters.AddWithValue("@evLoc", eventLocation);
                            cmd.Parameters.AddWithValue("@evST", sDate);
                            cmd.Parameters.AddWithValue("@evImg", imagePath);
                            cmd.Parameters.AddWithValue("@evPrice", eventPrice);
                            cmd.Parameters.AddWithValue("@evId", 1);

                            cmd.ExecuteNonQuery();


                            MessageBox.Show("Updated successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                            // Refresh the AddEvent control in the MainForm
                            mainForm.RefreshAddEventControl();
                    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not update event.Try again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void addEvent_clearBtn_Click(object sender, EventArgs e)
            {
                clearFields();
            }

            private void addEvent_deleteBtn_Click(object sender, EventArgs e)
            {
                if (selectedEventId == 0)
                {
                    MessageBox.Show("Please select one row from data grid"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                        "Event: " + eventName_input.Text.Trim() + "?", "Confirmation Message"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "DELETE events WHERE id = @evId";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@evId", selectedEventId);

                                cmd.ExecuteNonQuery();

                                displayEventsData();

                                MessageBox.Show("Deleted successfully!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                                // Refresh the AddEvent control in the MainForm
                                mainForm.RefreshAddEventControl();
                        }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: Could not delete.Try again!" , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled."
                            , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }

        }
    }