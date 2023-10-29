using EventManagementSystem.Utilities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace EventManagementSystem.Screens
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void firstNameTextBox_Enter(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "Enter your first name")
            {
                firstNameTextBox.Text = "";
                firstNameTextBox.ForeColor = Color.Black;
            }
        }

        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "")
            {
                firstNameTextBox.Text = "Enter your first name";
                firstNameTextBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void lastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "Enter your last name")
            {
                lastNameTextBox.Text = "";
                lastNameTextBox.ForeColor = Color.Black;
            }
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "")
            {
                lastNameTextBox.Text = "Enter your last name";
                lastNameTextBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Enter your email address")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }

        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "Enter your email address";
                emailTextBox.ForeColor = SystemColors.ScrollBar;
            }


        }

        private void phoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (phoneNumberTextBox.Text == "Enter your phone number")
            {
                phoneNumberTextBox.Text = "";
                phoneNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void phoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (phoneNumberTextBox.Text == "")
            {
                phoneNumberTextBox.Text = "Enter your phone number";
                phoneNumberTextBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void locationComboBox_Enter(object sender, EventArgs e)
        {
            if (locationComboBox.Text == "Select your location")
            {
                locationComboBox.Text = "";
                locationComboBox.ForeColor = Color.Black;
            }
        }

        private void locationComboBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(locationComboBox.Text))
            {
                locationComboBox.Text = "Select your location";
                locationComboBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(locationComboBox.Text) && locationComboBox.Text != "Select your location")
            {
                locationComboBox.ForeColor = Color.Black;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Enter your password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Enter your password";
                passwordTextBox.ForeColor = SystemColors.ScrollBar;
                passwordTextBox.PasswordChar = '\0';
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            // Check if the ErrorProvider has any error messages displayed
            if (errorProvider3.GetError(locationComboBox) != "" || errorProvider1.GetError(emailTextBox) != "" || errorProvider2.GetError(phoneNumberTextBox) != "")
            {
                // Display an error message to the user
                MessageBox.Show("Please correct the errors before signing up.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler to prevent the form submission
            }

            if (locationComboBox.SelectedItem == null)
            {
                errorProvider3.SetError(locationComboBox, "Please select a location.");
                return; // Exit the event handler to prevent the form submission
            }

            if (firstNameTextBox.Text == "Enter your first name" || lastNameTextBox.Text == "Enter your last name" || passwordTextBox.Text == "Enter your password" || emailTextBox.Text == "Enter your email address")
            {
                MessageBox.Show("Please provide all required information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler to prevent the form submission
            }

            try
            {
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string password = passwordTextBox.Text;
                string email = emailTextBox.Text;
                string phoneNumber = phoneNumberTextBox.Text;
                string location = locationComboBox.SelectedItem.ToString();

                using (var context = new ConnectionFactory())
                {
                    User newUser = new User(firstName, lastName, password, email, phoneNumber, location)
                    {
                        firstName = firstName,
                        lastName = lastName,
                        password = password,
                        email = email,
                        phoneNumber = phoneNumber,
                        location = location
                    };

                    context.Users.Add(newUser);
                    context.SaveChanges();
                }

                this.Close();

                // Initialize the EmailSender with your SMTP server details and credentials
                EmailSender emailSender = new EmailSender("smtp.gmail.com", 587, "eventhubforyou@gmail.com", "oajb cbpz cflk oyly");

                // Get email body
                string emailBody = emailSender.getBodyEmailSignup(firstName);

                // Send an email
                emailSender.SendEmail(email, "Welcome to EventHub", emailBody);
            }

            catch (Exception ex)
            {
                // Display an error message to prompt for correct input
                MessageBox.Show($"Sign-up failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            string emailPattern = @".+@.+";
            if (!Regex.IsMatch(emailTextBox.Text, emailPattern))
            {
                errorProvider1.SetError(emailTextBox, "Invalid email format.");
                //e.Cancel = true; // Prevent focus from leaving the TextBox.
            }
            else
            {
                errorProvider1.SetError(emailTextBox, ""); // Clear the error message.
            }
        }

        private void phoneNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            string phonePattern = @"^0\d*$"; // Matches a string that starts with '0' and is followed by zero or more numeric digits

            if (!Regex.IsMatch(phoneNumberTextBox.Text, phonePattern))
            {
                errorProvider2.SetError(phoneNumberTextBox, "Invalid format. Phone number should start with '0' and consist of only numeric digits.");
                // e.Cancel = true; // Remove or comment out this line to allow moving to other textboxes.
            }
            else
            {
                errorProvider2.SetError(phoneNumberTextBox, ""); // Clear the error message.
            }
        }

        private void locationComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (locationComboBox.SelectedItem == null)
            {
                errorProvider3.SetError(locationComboBox, "Please select a location.");
                //e.Cancel = true; // Prevent focus from leaving the ComboBox.
            }
            else
            {
                errorProvider3.SetError(locationComboBox, ""); // Clear the error message.
            }
        }
    }
}
