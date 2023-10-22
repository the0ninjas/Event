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

namespace EventManagementSystem.Screens
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Enter your email address")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "Enter your email address";
                emailTextBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Enter your password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Enter your password";
                passwordTextBox.ForeColor = SystemColors.ScrollBar;
                passwordTextBox.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            TopPage toppage = new TopPage();
            toppage.Show();
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    using (var context = new ConnectionFactory())
        //    {
        //        string username = textBox1.Text;
        //        string password = textBox2.Text;

                // Check if the user with the given username and password exists
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    // Successful login
                    MessageBox.Show("Login successful!");
                    // You can now navigate to another form or perform other actions.
                }
                else
                {
                    // Invalid credentials
                    MessageBox.Show("Login failed. Please check your username and password.");
                }
            }
        }
    }
}
