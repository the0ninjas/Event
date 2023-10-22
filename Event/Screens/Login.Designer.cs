namespace EventManagementSystem.Screens
{
    partial class Login
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
            loginGroupBox = new GroupBox();
            signInButton = new Button();
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            passwordLabel = new Label();
            emailLabel = new Label();
            signUpButton = new Button();
            loginGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.BackColor = Color.Transparent;
            headingLabel.Font = new Font("Segoe UI Black", 15.000001F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            headingLabel.Location = new Point(21, 104);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(916, 48);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "Find Your Time, Find Your Team: Play on Demand!";
            // 
            // loginGroupBox
            // 
            loginGroupBox.BackColor = Color.MintCream;
            loginGroupBox.Controls.Add(signUpButton);
            loginGroupBox.Controls.Add(signInButton);
            loginGroupBox.Controls.Add(passwordTextBox);
            loginGroupBox.Controls.Add(emailTextBox);
            loginGroupBox.Controls.Add(passwordLabel);
            loginGroupBox.Controls.Add(emailLabel);
            loginGroupBox.Location = new Point(202, 274);
            loginGroupBox.Name = "loginGroupBox";
            loginGroupBox.Size = new Size(561, 453);
            loginGroupBox.TabIndex = 1;
            loginGroupBox.TabStop = false;
            // 
            // signInButton
            // 
            signInButton.BackColor = Color.DarkSeaGreen;
            signInButton.FlatStyle = FlatStyle.Popup;
            signInButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            signInButton.Location = new Point(207, 283);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(130, 40);
            signInButton.TabIndex = 4;
            signInButton.Text = "Sign In";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += signInButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.ForeColor = SystemColors.ScrollBar;
            passwordTextBox.Location = new Point(74, 206);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(414, 35);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.Text = "Enter your password";
            passwordTextBox.Enter += passwordTextBox_Enter;
            passwordTextBox.Leave += passwordTextBox_Leave;
            // 
            // emailTextBox
            // 
            emailTextBox.ForeColor = SystemColors.ScrollBar;
            emailTextBox.Location = new Point(74, 105);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(414, 35);
            emailTextBox.TabIndex = 2;
            emailTextBox.Text = "Enter your email address";
            emailTextBox.Enter += emailTextBox_Enter;
            emailTextBox.Leave += emailTextBox_Leave;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(74, 154);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(115, 32);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.Location = new Point(74, 56);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(72, 32);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email";
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.DarkSeaGreen;
            signUpButton.FlatStyle = FlatStyle.Popup;
            signUpButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            signUpButton.Location = new Point(207, 363);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(130, 40);
            signUpButton.TabIndex = 5;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.remi_jacquaint_WQEP0mrTD8Y_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(956, 1126);
            Controls.Add(loginGroupBox);
            Controls.Add(headingLabel);
            Name = "Login";
            Text = "Login";
            loginGroupBox.ResumeLayout(false);
            loginGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headingLabel;
        private GroupBox loginGroupBox;
        private TextBox emailTextBox;
        private Label passwordLabel;
        private Label emailLabel;
        private TextBox passwordTextBox;
        private Button signInButton;
        private Button signUpButton;
    }
}