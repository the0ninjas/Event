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
