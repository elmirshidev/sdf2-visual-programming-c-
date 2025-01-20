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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection connect
            = new SqlConnection(@"Data Source=LAPTOP-0VTIUPTU\SQLEXPRESS;Initial Catalog=Eventa;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password_input.PasswordChar = login_showPass_checkbox.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            String email = login_email_input.Text.Trim();
            String password = login_password_input.Text.Trim();
            if (!ValidationHelper.IsValidEmail(email, out string emailError))
            {
                MessageBox.Show(emailError, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidationHelper.IsValidPassword(password, out string passwordError))
            {
                MessageBox.Show(passwordError, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    //Check if there is a record like that
                    string selectData = "SELECT * FROM users WHERE email = @email " +
                        "AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        //Success
                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Login successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Go to main form and close this one
                            MainForm mForm = new MainForm();
                            mForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password"
                                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
