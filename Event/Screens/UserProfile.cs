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
                firstNameTextBox.Text = authenticatedUser.FirstName;
                lastNameTextBox.Text = authenticatedUser.LastName;
                emailTextBox.Text = authenticatedUser.Email;
                // Add other data as needed
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

        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
