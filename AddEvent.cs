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

        public AddEvent()
        {
            InitializeComponent();

            //EXECUTE THIS FUNCTION AS SOON AS THE CONTROL LOADS
            this.Load += AddEvent_Load;

            // TO DISPLAY THE DATA FROM DATABASE TO DATA GRID VIEW
            displayEventsData();
        }


        //SET DATE'S DATA
        private void AddEvent_Load(object sender, EventArgs e)
        {
            eventSDate_input.MinDate = DateTime.Now;
            eventEDate_input.MinDate = DateTime.Now.AddHours(3);
        }
        

        //REFRESH DATA
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
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

                            // Bind the data to the DataGridView
                            eventsDataGrid.DataSource = eventsTable;
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


            //ADD NEW EVENT
            private void addEvent_addBtn_Click(object sender, EventArgs e)
            {
                var eventName = eventName_input.Text.Trim();
                var eventDesc = eventDesc_input.Text.Trim();
                var eventLocation = eventLocation_input.Text.Trim();
                var eventPrice = eventPrice_input.Text.Trim();


                if (!ValidationHelper.ValidateEventDetails(eventName, eventDesc, eventLocation, eventPhoto.Image, eventSDate_input.Text, eventEDate_input.Text, eventPrice, out string errorMessage))
                {
                    MessageBox.Show(errorMessage, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var sDate = DateTime.Parse(eventSDate_input.Text);
                var eDate = DateTime.Parse(eventEDate_input.Text);

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
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO events " +
                                    "(name, description, location, start_time, end_time, created_by, image, price)" +
                                    "VALUES(@evName, @evDesc, @evLoc, @evST, @evET, @userId, @evImg, @evPrice)";

                                string path = Path.Combine(@"C:\Users\Elmir\source\repos\EventaDesktop\Directory\"
                                    + eventName + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(eventPhoto.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@evName", eventName);
                                    cmd.Parameters.AddWithValue("@evDesc", eventDesc);
                                    cmd.Parameters.AddWithValue("@evLoc", eventLocation);
                                    cmd.Parameters.AddWithValue("@evST", sDate);
                                    cmd.Parameters.AddWithValue("@evET", eDate);
                                    cmd.Parameters.AddWithValue("@userId", 1);
                                    cmd.Parameters.AddWithValue("@evImg", path);
                                    cmd.Parameters.AddWithValue("@evPrice", eventPrice);

                                    cmd.ExecuteNonQuery();

                                    displayEventsData();

                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Error: " + ex, "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = eventsDataGrid.Rows[e.RowIndex];
                    eventName_input.Text = row.Cells[1].Value.ToString();
                    eventDesc_input.Text = row.Cells[2].Value.ToString();
                    eventLocation_input.Text = row.Cells[3].Value.ToString();
                    eventSDate_input.Text = row.Cells[4].Value.ToString();
                    eventEDate_input.Text = row.Cells[5].Value.ToString();
                    string imagePath = row.Cells[6].Value.ToString();
                    eventPrice_input.Text = row.Cells[7].Value.ToString();

                    if (imagePath != null)
                    {
                        eventPhoto.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        eventPhoto.Image = null;
                    }

                }
            }


            //CLEAR ALL FIELDS
            public void clearFields()
            {
                eventName_input.Text = "";
                eventDesc_input.Text = "";
                eventLocation_input.Text = "";
                eventSDate_input.MinDate = DateTime.Now;
                eventEDate_input.MinDate = DateTime.Now.AddHours(3);
                eventPhoto.Image = null;
            }

            private void addEvent_updateBtn_Click(object sender, EventArgs e)
            {
                var eventName = eventName_input.Text.Trim();
                var eventDesc = eventDesc_input.Text.Trim();
                var eventLocation = eventLocation_input.Text.Trim();
                var eventPrice = eventPrice_input.Text.Trim();


                if (!ValidationHelper.ValidateEventDetails(eventName, eventDesc, eventLocation, eventPhoto.Image, eventSDate_input.Text, eventEDate_input.Text, eventPrice, out string errorMessage))
                {
                    MessageBox.Show(errorMessage, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var sDate = DateTime.Parse(eventSDate_input.Text);
                var eDate = DateTime.Parse(eventEDate_input.Text);

                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                        "Event: " + eventName + "?", "Confirmation Message"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                    //string insertData = "INSERT INTO events " +
                    //                "(name, description, location, start_time, end_time, created_by, image, price)" +
                    //                "VALUES(@evName, @evDesc, @evLoc, @evST, @evET, @userId, @evImg, @evPrice)";

                        string updateData = "UPDATE events SET name = @evName" +
                            ", description = @evDesc, location = @evLoc" +
                            ", start_time = @evST, end_time = @evET, image = @evImg, price = @evPrice" +
                            "WHERE id = @evId";

                        string path = Path.Combine(@"C:\Users\Elmir\source\repos\EventaDesktop\Directory\"
                                        + eventName + ".jpg");

                        string directoryPath = Path.GetDirectoryName(path);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        File.Copy(eventPhoto.ImageLocation, path, true);

                    using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@evName", eventName);
                            cmd.Parameters.AddWithValue("@evDesc", eventDesc);
                            cmd.Parameters.AddWithValue("@evLoc", eventLocation);
                            cmd.Parameters.AddWithValue("@evST", sDate);
                            cmd.Parameters.AddWithValue("@evET", eDate);
                            cmd.Parameters.AddWithValue("@evImg", path);
                            cmd.Parameters.AddWithValue("@evPrice", eventPrice);
                            cmd.Parameters.AddWithValue("@evId", 1);

                            cmd.ExecuteNonQuery();

                            displayEventsData();

                            MessageBox.Show("Updated successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (eventName_input.Text == ""
                    || eventDesc_input.Text == ""
                    || eventLocation_input.Text == ""
                    || eventPhoto.Image == null)
                {
                    MessageBox.Show("Please fill all blank fields"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                        "Employee ID: " + eventName_input.Text.Trim() + "?", "Confirmation Message"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE employees SET delete_date = @deleteDate " +
                                "WHERE employee_id = @employeeID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@deleteDate", today);
                                cmd.Parameters.AddWithValue("@employeeID", eventName_input.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayEventsData();

                                MessageBox.Show("Update successfully!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex
                            , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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