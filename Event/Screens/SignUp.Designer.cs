namespace EventManagementSystem.Screens
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headingLabel = new Label();
            subHeadingLabel = new Label();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            phoneNumberLabel = new Label();
            locationLabel = new Label();
            passwordLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            passwordTextBox = new TextBox();
            signUpButton = new Button();
            cancelButton = new Button();
            locationComboBox = new ComboBox();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI Black", 15.000001F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            headingLabel.Location = new Point(141, 69);
            headingLabel.Margin = new Padding(2, 0, 2, 0);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(112, 36);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "Sign Up";
            // 
            // subHeadingLabel
            // 
            subHeadingLabel.AutoSize = true;
            subHeadingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            subHeadingLabel.Location = new Point(134, 120);
            subHeadingLabel.Margin = new Padding(2, 0, 2, 0);
            subHeadingLabel.Name = "subHeadingLabel";
            subHeadingLabel.Size = new Size(390, 28);
            subHeadingLabel.TabIndex = 1;
            subHeadingLabel.Text = "Register now and play your way, today!";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(141, 192);
            firstNameLabel.Margin = new Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(93, 23);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(141, 259);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(91, 23);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.Location = new Point(141, 325);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(51, 23);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumberLabel.Location = new Point(141, 392);
            phoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(127, 23);
            phoneNumberLabel.TabIndex = 5;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            locationLabel.Location = new Point(141, 459);
            locationLabel.Margin = new Padding(2, 0, 2, 0);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(75, 23);
            locationLabel.TabIndex = 6;
            locationLabel.Text = "Location";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(141, 525);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(82, 23);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.ForeColor = SystemColors.ScrollBar;
            firstNameTextBox.Location = new Point(141, 225);
            firstNameTextBox.Margin = new Padding(2);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(349, 27);
            firstNameTextBox.TabIndex = 8;
            firstNameTextBox.Text = "Enter your first name";
            firstNameTextBox.Enter += firstNameTextBox_Enter;
            firstNameTextBox.Leave += firstNameTextBox_Leave;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.ForeColor = SystemColors.ScrollBar;
            lastNameTextBox.Location = new Point(141, 292);
            lastNameTextBox.Margin = new Padding(2);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(349, 27);
            lastNameTextBox.TabIndex = 9;
            lastNameTextBox.Text = "Enter your last name";
            lastNameTextBox.Enter += lastNameTextBox_Enter;
            lastNameTextBox.Leave += lastNameTextBox_Leave;
            // 
            // emailTextBox
            // 
            emailTextBox.ForeColor = SystemColors.ScrollBar;
            emailTextBox.Location = new Point(141, 359);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(349, 27);
            emailTextBox.TabIndex = 10;
            emailTextBox.Text = "Enter your email address";
            emailTextBox.Enter += emailTextBox_Enter;
            emailTextBox.Leave += emailTextBox_Leave;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.ForeColor = SystemColors.ScrollBar;
            phoneNumberTextBox.Location = new Point(141, 425);
            phoneNumberTextBox.Margin = new Padding(2);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(349, 27);
            phoneNumberTextBox.TabIndex = 11;
            phoneNumberTextBox.Text = "Enter your phone number";
            phoneNumberTextBox.Enter += phoneNumberTextBox_Enter;
            phoneNumberTextBox.Leave += phoneNumberTextBox_Leave;
            // 
            // passwordTextBox
            // 
            passwordTextBox.ForeColor = SystemColors.ScrollBar;
            passwordTextBox.Location = new Point(141, 559);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(349, 27);
            passwordTextBox.TabIndex = 13;
            passwordTextBox.Text = "Enter your password";
            passwordTextBox.Enter += passwordTextBox_Enter;
            passwordTextBox.Leave += passwordTextBox_Leave;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.DarkSeaGreen;
            signUpButton.FlatStyle = FlatStyle.Popup;
            signUpButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            signUpButton.Location = new Point(141, 625);
            signUpButton.Margin = new Padding(2);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(347, 27);
            signUpButton.TabIndex = 14;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.LavenderBlush;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.Location = new Point(141, 667);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(347, 27);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // locationComboBox
            // 
            locationComboBox.ForeColor = SystemColors.ScrollBar;
            locationComboBox.FormattingEnabled = true;
            locationComboBox.Items.AddRange(new object[] { "Sydney", "Melbourne", "Brisbane", "Perth", "Adelaide", "Canberra", "Hobart", "Darwin" });
            locationComboBox.Location = new Point(141, 492);
            locationComboBox.Margin = new Padding(2);
            locationComboBox.Name = "locationComboBox";
            locationComboBox.Size = new Size(349, 28);
            locationComboBox.TabIndex = 16;
            locationComboBox.Text = "Select your location";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(637, 751);
            Controls.Add(locationComboBox);
            Controls.Add(cancelButton);
            Controls.Add(signUpButton);
            Controls.Add(passwordTextBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(locationLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(emailLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(subHeadingLabel);
            Controls.Add(headingLabel);
            Margin = new Padding(2);
            Name = "SignUp";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headingLabel;
        private Label subHeadingLabel;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label phoneNumberLabel;
        private Label locationLabel;
        private Label passwordLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox passwordTextBox;
        private Button signUpButton;
        private Button cancelButton;
        private ComboBox locationComboBox;
    }
}