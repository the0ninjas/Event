using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace EventManagementSystem.Screens
{
    [TestFixture]
    public class SignUpFormTests
    {
        [Test]
        public void SignUpButton_Click_ValidInput_Success()
        {
            // Arrange: Create an instance of your form, set up form controls, and test data.
            SignUp signUpForm = new SignUp();
            signUpForm.firstNameTextBox.Text = "John";
            signUpForm.lastNameTextBox.Text = "Doe";
            signUpForm.passwordTextBox.Text = "StrongPassword123";
            signUpForm.emailTextBox.Text = "johndoe@example.com";
            signUpForm.phoneNumberTextBox.Text = "01234567890";
            signUpForm.locationComboBox.SelectedItem = "Sydney";

            // Act: Simulate a button click (invoke the event handler).
            signUpForm.signUpButton_Click(null, EventArgs.Empty);

            // Assert: Check if the form was closed (indicating successful sign-up).
            Assert.IsTrue(signUpForm.IsDisposed);
            // You may add more assertions to check other post-sign-up conditions in your application.
        }

        [Test]
        public void SignUpButton_Click_InvalidInput_Failure()
        {
            // Arrange: Create an instance of your form and set up form controls with invalid data.
            SignUp signUpForm = new SignUp();
            signUpForm.firstNameTextBox.Text = "";
            signUpForm.lastNameTextBox.Text = "Doe"; // Missing first name
            signUpForm.passwordTextBox.Text = "1234";
            signUpForm.emailTextBox.Text = "invalid-email"; // Invalid email
            signUpForm.phoneNumberTextBox.Text = "1234567890"; // Invalid password
            signUpForm.locationComboBox.SelectedItem = "Location";

            // Act: Simulate a button click (invoke the event handler).
            signUpForm.signUpButton_Click(null, EventArgs.Empty);

            // Assert: Check if the form is not closed (indicating a failed sign-up).
            Assert.IsFalse(signUpForm.IsDisposed);
            // You may add more assertions to check error message handling or other behaviors.
        }
    }
}