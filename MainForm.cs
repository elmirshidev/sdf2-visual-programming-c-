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
            addEventControl = new AddEvent(this);
            viewEventsControl = new ViewEvents(this);

            // Set the default panel to dashboard
            LoadUserControl(dashboardControl);

        }

        private void LoadUserControl(UserControl userControl)
        {
            mainForm_panel.Controls.Clear();

            // Trigger refresh methods if available
            if (userControl is Dashboard dashboard)
            {
                dashboard.ReloadDashboard();
            }
            else if (userControl is ViewEvents viewEvents)
            {
                viewEvents.displayEventsData();
            }
            else if (userControl is AddEvent addEvent)
            {
                addEvent.displayEventsData();
                addEvent.clearFields();
            }

            userControl.Dock = DockStyle.Fill;
            mainForm_panel.Controls.Add(userControl);
        }

        public void RefreshAddEventControl()
        {
            // Remove the existing AddEvent control
            mainForm_panel.Controls.Remove(addEventControl);

            // Reinitialize AddEvent and add it back
            addEventControl = new AddEvent(this); // Pass `this` if MainForm is required in AddEvent
            addEventControl.Dock = DockStyle.Fill;

            // Add the control back to the panel
            mainForm_panel.Controls.Add(addEventControl);
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
                UserData.Clear();
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

