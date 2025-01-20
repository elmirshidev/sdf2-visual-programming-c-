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

namespace EventManagementSystem
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect 
            = new SqlConnection(@"Data Source=LAPTOP-0VTIUPTU\SQLEXPRESS;Initial Catalog=Eventa;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            var email = email_input.Text.Trim();
            var username = username_input.Text.Trim();
            var password = password_input.Text.Trim();
            if (
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password)
                )
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        // TO CHECK IF THE USER IS EXISTING ALREADY
                        string selectEmail = "SELECT COUNT(id) FROM users WHERE email = @email";

                        using(SqlCommand checkUser = new SqlCommand(selectEmail, connect))
                        {
                            checkUser.Parameters.AddWithValue("@email", email);
                            int count = (int)checkUser.ExecuteScalar();

                            //Success,means already taken
                            if(count >= 1)
                            {
                                MessageBox.Show(email + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                //Create new record
                                DateTime ts = DateTime.Now;

                                string insertData = "INSERT INTO users " +
                                    "(email, username, password, created_at) " +
                                    "VALUES(@email, @username, @password, @dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", email);
                                    cmd.Parameters.AddWithValue("@username", username);
                                    cmd.Parameters.AddWithValue("@password", password);
                                    cmd.Parameters.AddWithValue("@dateReg", ts);

                                    //Insert new user into database
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm loginForm = new LoginForm();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }

                        

                    }catch(Exception ex)
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
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            password_input.PasswordChar = register_showPassword_checkbox.Checked ? '\0' : '*';
        }

    }
}
