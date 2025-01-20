using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventaDesktop;

namespace EventManagementSystem
{
    public partial class MainForm : Form
    {

        private AddEvent addEventControl;
        private Dashboard dashboardControl;
        private ViewEvents viewEventsControl;

        public MainForm()
        {
            InitializeComponent();

            dashboardControl = new Dashboard();
            addEventControl = new AddEvent();
            viewEventsControl = new ViewEvents();

        }

        private void LoadUserControl(UserControl userControl)
        {
            panel3.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(userControl);
        }


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
                , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {

            LoadUserControl(dashboardControl);
        }

        private void addEvent_btn_Click(object sender, EventArgs e)
        {
            LoadUserControl(addEventControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(viewEventsControl);
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

