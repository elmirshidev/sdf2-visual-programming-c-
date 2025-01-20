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

            //default open panel is dashboard control
            mainForm_panel.Controls.Add(dashboardControl);

        }

        //helper function for removing current panel and adding requested one
        private void LoadUserControl(UserControl userControl)
        {
            mainForm_panel.Controls.Clear();
            //fill parent's available size
            userControl.Dock = DockStyle.Fill;
            mainForm_panel.Controls.Add(userControl);
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

        //loads dashboard panel
        private void dashboard_btn_Click(object sender, EventArgs e)
        {

            LoadUserControl(dashboardControl);
        }

        //loads add form panel
        private void addEvent_btn_Click(object sender, EventArgs e)
        {
            LoadUserControl(addEventControl);
        }


        //loads view all events panel
        private void viewEvents_Click(object sender, EventArgs e)
        {
            LoadUserControl(viewEventsControl);
        }

    }
}

