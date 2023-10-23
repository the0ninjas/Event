namespace EventManagementSystem.Screens
{
    partial class UserProfile
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            phoneLabel = new Label();
            locationLabel = new Label();
            notificationLabel = new Label();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI Black", 15.000001F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            headingLabel.Location = new Point(103, 97);
            headingLabel.Margin = new Padding(2, 0, 2, 0);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(163, 36);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "User Profile";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(446, 167);
            firstNameLabel.Margin = new Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(93, 23);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(446, 233);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(91, 23);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.Location = new Point(446, 300);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(116, 23);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email Address";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            phoneLabel.Location = new Point(446, 367);
            phoneLabel.Margin = new Padding(2, 0, 2, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(127, 23);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Phone Number";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            locationLabel.Location = new Point(446, 433);
            locationLabel.Margin = new Padding(2, 0, 2, 0);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(75, 23);
            locationLabel.TabIndex = 5;
            locationLabel.Text = "Location";
            // 
            // notificationLabel
            // 
            notificationLabel.AutoSize = true;
            notificationLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            notificationLabel.Location = new Point(446, 500);
            notificationLabel.Margin = new Padding(2, 0, 2, 0);
            notificationLabel.Name = "notificationLabel";
            notificationLabel.Size = new Size(100, 23);
            notificationLabel.TabIndex = 6;
            notificationLabel.Text = "Notification";
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1081, 748);
            Controls.Add(notificationLabel);
            Controls.Add(locationLabel);
            Controls.Add(phoneLabel);
            Controls.Add(emailLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(headingLabel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UserProfile";
            Text = "User Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headingLabel;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private Label locationLabel;
        private Label notificationLabel;
    }
}