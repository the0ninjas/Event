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

namespace EventManagementSystem.Screens
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // emailTextBox format change

        // Check if the text in the textbox is the default placeholder text
        // When entering the textbox, clear the textbox and set the font color to black
        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Enter your email address")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }

        // Check if the text in the textbox is empty
        // When leaving the textbox, set the textbox to display the default placeholder text and change the font color to a grey color
        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "Enter your email address";
                emailTextBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        // passwordTextBox format change

        // Check if the text in the textbox is the default placeholder text
        // When entering the textbox, clear the textbox and set the passwordChar and font color to black
        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Enter your password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.PasswordChar = '*';
            }
        }

        // Check if the text in the textbox is empty
        // When leaving the textbox, set the textbox to display the default placeholder text without passwordChar and change the font color to a grey color
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Enter your password";
                passwordTextBox.ForeColor = SystemColors.ScrollBar;
                passwordTextBox.PasswordChar = '\0';
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            using (var context = new ConnectionFactory())
            {
                string email = emailTextBox.Text;
                string password = passwordTextBox.Text;

                //Check if the user with the given username and password exists
                User user = context.Users.FirstOrDefault(u => u.email == email && u.password == password);

                if (user != null)
                {
                    // Store the authenticated user in UserSession
                    UserSession.AuthenticateUser(user);
                    // Successful login, navigate to the TopPage
                    TopPage topPage = new TopPage();
                    topPage.Show(); // or topPage.ShowDialog(); if you want it to be modal
                    this.Hide(); // Hide the login form
                }
                else
                {
                    // Invalid credentials
                    MessageBox.Show("Login failed. Please check your email and password.");
                }
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();

            signUp.Show();
            this.Hide();
        }
    }
}
