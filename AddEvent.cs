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

namespace EventManagementSystem
{
    public partial class AddEvent : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\WINDOWS 10\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public AddEvent()
        {
            InitializeComponent();

            this.Load += AddEvent_Load;

            // TO DISPLAY THE DATA FROM DATABASE TO YOUR DATA GRID VIEW
            displayEmployeeData();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            eventSDate_input.MinDate = DateTime.Now;
            eventEDate_input.MinDate = DateTime.Now.AddHours(3);       
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployeeData();
        }

        public void displayEmployeeData()
        {
            //EmployeeData ed = new EmployeeData();
            //List<EmployeeData> listData = ed.employeeListData();

            //dataGridView1.DataSource = listData;
        }

        private bool eventDetailsValidation()
        {
            if (eventName_input.Text.Trim() == ""
                || eventDesc_input.Text.Trim() == ""
                || eventLocation_input.Text.Trim() == ""
                || eventPhoto.Image == null
                || eventPrice_input.Text.Trim() == ""
             )
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int diff = DateTime.Compare(DateTime.Parse(eventSDate_input.Text), DateTime.Parse(eventEDate_input.Text));
            if (diff >= 0)
            {
                MessageBox.Show("Start Date can't be equal or after the End Date"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string priceText = eventPrice_input.Text.Trim();
            bool convertSuccess = float.TryParse(priceText, out float price);

            if (!convertSuccess)
            {
                MessageBox.Show("Enter valid price!"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void addEvent_addBtn_Click(object sender, EventArgs e)
        {
            bool ans = eventDetailsValidation();
            
            if(!ans)
            {
                return;
            }

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string checkEvName = "SELECT COUNT(*) FROM events WHERE name = @evName";

                    using (SqlCommand checkEv = new SqlCommand(checkEvName, connect))
                    {
                        checkEv.Parameters.AddWithValue("@evName", eventName_input.Text.Trim());
                        int count = (int)checkEv.ExecuteScalar();

                        if (count >= 1)
                        {
                            MessageBox.Show(eventName_input.Text.Trim() + " is already taken"
                                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DateTime today = DateTime.Today;
                            string insertData = "INSERT INTO events " +
                                "(name, description, location, start_time, end_time, image, price)" +
                                "VALUES(@evName, @evDesc, @evLoc, @evST, @evET, @evImg, @evPrice)";

                            string path = Path.Combine(@"C:\Users\Elmir\source\repos\EventaDesktop\Directory\"
                                + eventName_input.Text.Trim() + ".jpg");

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(eventPhoto.ImageLocation, path, true);

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@evName", eventName_input.Text.Trim());
                                cmd.Parameters.AddWithValue("@evDesc", eventDesc_input.Text.Trim());
                                cmd.Parameters.AddWithValue("@evLoc", eventLocation_input.Text.Trim());
                                cmd.Parameters.AddWithValue("@evST", DateTime.Parse(eventSDate_input.Text));
                                cmd.Parameters.AddWithValue("@evET", DateTime.Parse(eventEDate_input.Text));
                                cmd.Parameters.AddWithValue("@evImg", path);

                                cmd.ExecuteNonQuery();

                                displayEmployeeData();

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
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = eventsDataGrid.Rows[e.RowIndex];
                eventName_input.Text = row.Cells[1].Value.ToString();
                eventDesc_input.Text = row.Cells[2].Value.ToString();
                eventLocation_input.Text = row.Cells[3].Value.ToString();
                eventSDate_input.Text = row.Cells[4].Value.ToString();
                eventEDate_input.Text = row.Cells[5].Value.ToString();
                string imagePath = row.Cells[6].Value.ToString();
                eventPrice_input.Text = row.Cells [7].Value.ToString();

                if(imagePath != null)
                {
                    eventPhoto.Image = Image.FromFile(imagePath);
                }
                else
                {
                    eventPhoto.Image = null;
                }

            }
        }

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
            if (!eventDetailsValidation()) return;

            DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Employee ID: " + eventName_input.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (check == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    DateTime today = DateTime.Today;

                    string updateData = "UPDATE employees SET full_name = @fullName" +
                        ", gender = @gender, contact_number = @contactNum" +
                        ", position = @position, update_date = @updateDate, status = @status " +
                        "WHERE employee_id = @employeeID";

                    using (SqlCommand cmd = new SqlCommand(updateData, connect))
                    {
                        //cmd.Parameters.AddWithValue("@fullName", addEvent_description.Text.Trim());
                        //cmd.Parameters.AddWithValue("@gender", addEvent_gender.Text.Trim());
                        //cmd.Parameters.AddWithValue("@contactNum", addEvent_location.Text.Trim());
                        //cmd.Parameters.AddWithValue("@position", addEvent_position.Text.Trim());
                        //cmd.Parameters.AddWithValue("@updateDate", today);
                        //cmd.Parameters.AddWithValue("@status", addEvent_status.Text.Trim());
                        //cmd.Parameters.AddWithValue("@employeeID", addEvent_eventName.Text.Trim());

                        cmd.ExecuteNonQuery();

                        displayEmployeeData();

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

                            displayEmployeeData();

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
