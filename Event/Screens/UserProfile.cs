using EventManagementSystem.Models;
using EventManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventManagementSystem.Screens
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
            LoadUserData();
        }
        private void LoadUserData()
        {
            User authenticatedUser = UserSession.AuthenticatedUser;

            if (authenticatedUser != null)
            {
                // Populate UI elements with user data
                firstNameTextBox.Text = authenticatedUser.firstName;
                lastNameTextBox.Text = authenticatedUser.lastName;
                emailTextBox.Text = authenticatedUser.email;
                phoneTextBox.Text = authenticatedUser.phoneNumber.ToString();
                locationComboBox.SelectedItem = authenticatedUser.location;
                
            }
        }
        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //User authenticatedUser = UserSession.AuthenticatedUser;

            //if (authenticatedUser != null)
            //{
            //    // Populate the TextBox with the user's first name
            //    firstNameTextBox.Text = authenticatedUser.FirstName;
            //}
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            emailTextBox.ReadOnly = true;
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Retrieve the modified user data from the input fields
            string newFirstName = firstNameTextBox.Text;
            string newLastName = lastNameTextBox.Text;
            string newEmail = emailTextBox.Text;

            // Access the authenticated user from UserSession
            User authenticatedUser = UserSession.AuthenticatedUser;

            if (authenticatedUser != null)
            {
                // Update the user's data in the database using DbContext
                using (var context = new ConnectionFactory()) 
                {
                    // Retrieve the user from the database based on the user's ID or another unique identifier
                    User userToUpdate = context.Users.FirstOrDefault(u => u.email == authenticatedUser.email);
                    
                    // Update user data
                    userToUpdate.firstName = firstNameTextBox.Text;
                    userToUpdate.lastName = lastNameTextBox.Text;
                    userToUpdate.email = emailTextBox.Text;
                    userToUpdate.phoneNumber = int.Parse(phoneTextBox.Text);
                    userToUpdate.location = locationComboBox.SelectedItem.ToString();

                    // Save changes to the database
                    context.SaveChanges();
                    UserSession.AuthenticateUser(userToUpdate);

                    MessageBox.Show("User data updated successfully.");
                 }
             }
            
            else
            {
                MessageBox.Show("User not authenticated. Update failed.");
            }
        }
    }
}
