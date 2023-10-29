using EventManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem.Screens
{
    public partial class TopPage : Form
    {
        private Form activeForm;
        public TopPage()
        {
            InitializeComponent();

            // Maximize the TopPage window
            this.WindowState = FormWindowState.Maximized;

            // Create a new instance of Dashboard
            Dashboard dashboardForm = new Dashboard();

            dashboardForm.TopLevel = false;
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            dashboardForm.Dock = DockStyle.Fill;

            // Add the Dashboard form to the topPagePane
            this.topPagePane.Controls.Add(dashboardForm);

            dashboardForm.BringToFront();
            dashboardForm.Show();
        }

        bool openSideMenuBar;
        private void timerForSidebar_Tick(object sender, EventArgs e)
        {
            if (openSideMenuBar)
            {
                sideBarFlowLayoutPanel.Width -= 10;
                if (sideBarFlowLayoutPanel.Width == sideBarFlowLayoutPanel.MinimumSize.Width)
                {
                    openSideMenuBar = false;
                    timerForSidebar.Stop();
                }
            }
            else
            {
                sideBarFlowLayoutPanel.Width += 10;
                if (sideBarFlowLayoutPanel.Width == sideBarFlowLayoutPanel.MaximumSize.Width)
                {
                    openSideMenuBar = true;
                    timerForSidebar.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            timerForSidebar.Start();
        }

        private void OpenSelectedMenu(Form selectedMenu, object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = selectedMenu;
            selectedMenu.TopLevel = false;
            selectedMenu.FormBorderStyle = FormBorderStyle.None;
            selectedMenu.Dock = DockStyle.Fill;
            this.topPagePane.Controls.Add(selectedMenu);
            this.topPagePane.Tag = selectedMenu;
            selectedMenu.BringToFront();
            selectedMenu.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            OpenSelectedMenu(new Screens.UserProfile(), sender);
        }

        private void eventCreationButton_Click(object sender, EventArgs e)
        {
            OpenSelectedMenu(new Screens.EventCreationForm(), sender);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            OpenSelectedMenu(new Screens.Dashboard(), sender);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                // Clear the user session or authentication information.
                UserSession.ClearAuthentication();

                // Close the current form
                this.Close();

                // Show the login form 
                Login loginForm = new Login();
                loginForm.Show();
            }
            // If the user clicks "Cancel," do nothing and stay on the current page.
        }
    }
}
