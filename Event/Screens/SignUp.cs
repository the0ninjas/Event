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
            if (locationComboBox.Text == "")
            {
                locationComboBox.Text = "Select your location";
                locationComboBox.ForeColor = SystemColors.ScrollBar;
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
    }
}
