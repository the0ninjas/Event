using EventManagementSystem.Models;
using EventManagementSystem.Repository;
using EventManagementSystem.Utilities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventManagementSystem.Screens
{
    public partial class EventCreationForm : Form
    {
        public EventCreationForm()
        {
            InitializeComponent();
            datePicker.MinDate = DateTime.Today;
        }

        // titleTextBox format change

        // Check if the text in the textbox is the default placeholder text
        // When entering the textbox, clear the textbox and set the font color to black
        private void titleTextBox_Enter(object sender, EventArgs e)
        {
            if (titleTextBox.Text == "Enter event title")
            {
                titleTextBox.Text = "";
                titleTextBox.ForeColor = Color.Black;
            }
        }

        // Check if the text in the textbox is empty
        // When leaving the textbox, set the textbox to display the default placeholder text and change the font color to a grey color
        private void titleTextBox_Leave(object sender, EventArgs e)
        {
            if (titleTextBox.Text == "")
            {
                titleTextBox.Text = "Enter event title";
                titleTextBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        // locationComboBox format change
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

        // capacityTextBox format change
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

        // imageComboBox format change
        private void imageComboBox_Enter(object sender, EventArgs e)
        {
            if (imageComboBox.Text == "Select the image")
            {
                imageComboBox.Text = "";
                imageComboBox.ForeColor = Color.Black;
            }
        }

        private void imageComboBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imageComboBox.Text))
            {
                imageComboBox.Text = "Select the image";
                imageComboBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void imageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(imageComboBox.Text) && imageComboBox.Text != "Select the image")
            {
                imageComboBox.ForeColor = Color.Black;
            }
        }


        private void EventCreationForm_Load(object sender, EventArgs e)
        {
            // Get the resource set from the project resources
            ResourceSet resourceSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);

            // Iterate through all the resources and identify images
            foreach (DictionaryEntry entry in resourceSet)
            {
                string resourceName = entry.Key.ToString();

                // Check if the resource name doesn't start with "icon"
                if (entry.Value is Bitmap && !resourceName.StartsWith("icon_", StringComparison.OrdinalIgnoreCase))
                {
                    // Add the resource name to the ComboBox
                    imageComboBox.Items.Add(resourceName);
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            CreatedEventRepo createdEventRepo = new CreatedEventRepo();
            JoinedEventsRepo joinedEventsRepo = new JoinedEventsRepo();

            if (titleTextBox.Text == "Enter event title" || locationComboBox.Text == "Select the location" || capacityTextBox.Text == "Enter max capacity"
                || imageComboBox.Text == "Select the image")
            {
                MessageBox.Show("Please provide all required information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler to prevent the form submission
            }

            try
            {
                using (var context = new ConnectionFactory())
                {
                    // Get the object of the user that is currently logged in
                    User authenticatedUser = UserSession.AuthenticatedUser;

                    if (createdEventRepo.GetEventsOfAdmin(authenticatedUser.email, context) == null || createdEventRepo.GetEventsOfAdmin(authenticatedUser.email, context).Count < 10)
                    {
                        string title = titleTextBox.Text;
                        DateTime selectedDate = datePicker.Value;
                        TimeSpan selectedTime = timePicker.Value.TimeOfDay;
                        DateTime combinedDateTime = selectedDate.Date + selectedTime;
                        string location = locationComboBox.Text;
                        int capacity = int.Parse(capacityTextBox.Text);
                        string imageName = imageComboBox.Text;

                        // Create a new event object that stores the details entered by the user
                        Event newEvent = new Event(title, combinedDateTime, location, capacity, imageName);

                        // Create an instance of EventRepo
                        EventRepo eventRepo = new EventRepo();

                        // Call createEvent function to save the event in the database
                        bool eventCreated = eventRepo.createEvent(newEvent, context);

                        if (eventCreated)
                        {
                            context.Entry(newEvent).Reload();
                            int eventId = newEvent.eventId;

                            // Call createEventAdmin function to save the admin / event combination in the database
                            bool eventAdminCreated = createdEventRepo.createEventAdmin(newEvent.eventId, authenticatedUser.email, context);

                            if (eventAdminCreated)
                            {
                                MessageBox.Show("Event created successfully.");
                                this.Close();

                                // Initialize the EmailSender with your SMTP server details and credentials
                                EmailSender emailSender = new EmailSender("smtp.gmail.com", 587, "eventhubforyou@gmail.com", "xduw ibjk vxyw jgey");

                                // Get email body
                                string emailBody = emailSender.getBodyEmailEventCreated(authenticatedUser.firstName, newEvent);

                                // Send an email
                                emailSender.SendEmail(authenticatedUser.email, "Event Successfully Created!", emailBody);
                            }
                            else
                            {
                                eventRepo.deleteEvent(newEvent.eventId, context);
                                MessageBox.Show("Failed to create the event admin. The event has been deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to create the event. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You cannot create more than 10 events. Wait until one of your created events has passed or delete one of the events.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                MessageBox.Show("An error occurred. Please try again.");
            }
        }

        private void titleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the length will exceed 15 characters after the keypress
            if (titleTextBox.Text.Length >= 15 && e.KeyChar != '\b') // '\b' is the backspace character
            {
                // Cancel the keypress
                e.Handled = true;
            }
        }

        //Validation logic for the capacityTextBox input
        private void capacityTextBox_Validating(object sender, CancelEventArgs e)
        {
            int capacity;

            if (!int.TryParse(capacityTextBox.Text, out capacity))
            {
                errorProvider1.SetError(capacityTextBox, "Please enter a valid number.");
            }
            else
            {
                if (capacity <= 0 || capacity >= 100)
                {
                    errorProvider1.SetError(capacityTextBox, "Capacity must be greater than 0 and less than 100.");
                }
                else
                {
                    errorProvider1.SetError(capacityTextBox, ""); // Clear the error message.
                }
            }
        }
    }
}



