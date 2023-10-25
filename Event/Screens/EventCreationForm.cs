using EventManagementSystem.Models;
using EventManagementSystem.Utilities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventManagementSystem.Screens
{
    public partial class EventCreationForm : Form
    {
        public EventCreationForm()
        {
            InitializeComponent();
        }

        private void titleTextBox_Enter(object sender, EventArgs e)
        {
            if (titleTextBox.Text == "Enter event title")
            {
                titleTextBox.Text = "";
                titleTextBox.ForeColor = Color.Black;
            }
        }

        private void titleTextBox_Leave(object sender, EventArgs e)
        {
            if (titleTextBox.Text == "")
            {
                titleTextBox.Text = "Enter event title";
                titleTextBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void locationComboBox_Enter(object sender, EventArgs e)
        {
            if (locationComboBox.Text == "Select the location")
            {
                locationComboBox.Text = "";
                locationComboBox.ForeColor = Color.Black;
            }
        }

        private void locationComboBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(locationComboBox.Text))
            {
                locationComboBox.Text = "Select the location";
                locationComboBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(locationComboBox.Text) && locationComboBox.Text != "Select the location")
            {
                locationComboBox.ForeColor = Color.Black;
            }
        }

        private void capacityTextBox_Enter(object sender, EventArgs e)
        {
            if (capacityTextBox.Text == "Enter max capacity")
            {
                capacityTextBox.Text = "";
                capacityTextBox.ForeColor = Color.Black;
            }
        }

        private void capacityTextBox_Leave(object sender, EventArgs e)
        {
            if (capacityTextBox.Text == "")
            {
                capacityTextBox.Text = "Enter max capacity";
                capacityTextBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void descriptionTextBox_Enter(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text == "Enter event description")
            {
                descriptionTextBox.Text = "";
                descriptionTextBox.ForeColor = Color.Black;
            }
        }

        private void descriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text == "")
            {
                descriptionTextBox.Text = "Enter event description";
                descriptionTextBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string title = titleTextBox.Text;
                DateTime date = datePicker.Value;
                DateTime time = timePicker.Value;
                string location = locationComboBox.Text;
                int capacity = int.Parse(capacityTextBox.Text);
                string description = descriptionTextBox.Text;

                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(location) ||
                        string.IsNullOrWhiteSpace(description))
                {
                    throw new Exception("Please provide all required information.");
                }

                using (var context = new ConnectionFactory())
                {
                    Event newEvent = new Event(title, date, time, location, capacity, description)
                    {
                        title = title,
                        date = date,
                        time = time,
                        location = location,
                        capacity = capacity,
                        description = description,
                    };           
                
                    User authenticatedUser = UserSession.AuthenticatedUser;

                    EventAdministrator Admin = new EventAdministrator(newEvent.eventId, authenticatedUser.email)
                    {
                        eventId = newEvent.eventId,
                        adminId = authenticatedUser.email,
                    };

                    context.Events.Add(newEvent);
                    context.EventAdministrators.Add(Admin);
                    context.SaveChanges();
                }

                this.Close();

                // Display a success message
                MessageBox.Show($"Event creation successful!");
            }
            catch (Exception ex)
            {
                // Display an error message to prompt for correct input
                MessageBox.Show($"Event creation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
