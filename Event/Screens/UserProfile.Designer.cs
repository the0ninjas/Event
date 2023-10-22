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
            panel1 = new Panel();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            phoneTextBox = new TextBox();
            locationComboBox = new ComboBox();
            updateButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI Black", 15.000001F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            headingLabel.Location = new Point(154, 75);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(230, 48);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "User Profile";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(154, 236);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(132, 32);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(154, 336);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(130, 32);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.Location = new Point(154, 436);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(165, 32);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email Address";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            phoneLabel.Location = new Point(154, 536);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(179, 32);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Phone Number";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            locationLabel.Location = new Point(154, 636);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(107, 32);
            locationLabel.TabIndex = 5;
            locationLabel.Text = "Location";
            // 
            // panel1
            // 
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(locationComboBox);
            panel1.Controls.Add(phoneTextBox);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(lastNameTextBox);
            panel1.Controls.Add(firstNameTextBox);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(headingLabel);
            panel1.Controls.Add(firstNameLabel);
            panel1.Controls.Add(locationLabel);
            panel1.Controls.Add(lastNameLabel);
            panel1.Controls.Add(phoneLabel);
            panel1.Location = new Point(304, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 855);
            panel1.TabIndex = 7;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(458, 236);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(414, 35);
            firstNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(458, 336);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(414, 35);
            lastNameTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(458, 436);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(414, 35);
            emailTextBox.TabIndex = 9;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(458, 536);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(414, 35);
            phoneTextBox.TabIndex = 10;
            // 
            // locationComboBox
            // 
            locationComboBox.FormattingEnabled = true;
            locationComboBox.Items.AddRange(new object[] { "Sydney", "Melbourne", "Brisbane", "Perth", "Adelaide", "Canberra", "Hobart", "Darwin" });
            locationComboBox.Location = new Point(458, 636);
            locationComboBox.Name = "locationComboBox";
            locationComboBox.Size = new Size(414, 38);
            locationComboBox.TabIndex = 14;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.DarkSeaGreen;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            updateButton.Location = new Point(458, 740);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(131, 40);
            updateButton.TabIndex = 15;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1622, 1122);
            Controls.Add(panel1);
            Name = "UserProfile";
            Text = "User Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label headingLabel;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private Label locationLabel;
        private Panel panel1;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox phoneTextBox;
        private TextBox emailTextBox;
        private ComboBox locationComboBox;
        private Button updateButton;
    }
}