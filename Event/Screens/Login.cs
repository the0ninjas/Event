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

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            // Check if the text in the textbox is the default placeholder text
            if (emailTextBox.Text == "Enter your email address")
            {
                // When entering the textbox, clear the textbox and set the font color to black
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }

        
        
        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            // Check if the text in the textbox is empty
            if (emailTextBox.Text == "")
            {
                // Set the textbox to display the default placeholder text and change the font color to grey
                emailTextBox.Text = "Enter your email address";
                emailTextBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            // Check if the text in the textbox is the default placeholder text
            if (passwordTextBox.Text == "Enter your password")
            {
                // When entering the textbox, clear the textbox and set the passwordChar and font color to black
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.PasswordChar = '*';
            }
        }

        
        
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            // Check if the text in the textbox is empty
            if (passwordTextBox.Text == "")
            {
                // Set the textbox to display the default placeholder text and change the font color to a grey
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

                //Check if the user exists with the provided username and password
                User user = context.Users.FirstOrDefault(u => u.email == email && u.password == password);

                if (user != null)
                {
                    // Store the authenticated user in UserSession
                    UserSession.AuthenticateUser(user);
                    // When login successfully, navigate to the TopPage
                    TopPage topPage = new TopPage();
                    topPage.Show(); 
                    this.Hide();
                }
                else
                {
                    // When invalid credentials are input
                    MessageBox.Show("Login failed. Please check your email and password.");
                }
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            // Open sign up form
            SignUp signUp = new SignUp();

            signUp.Show();
            this.Hide();
        }
    }
}
