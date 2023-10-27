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
            updateButton = new Button();
            locationComboBox = new ComboBox();
            phoneTextBox = new TextBox();
            emailTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI Black", 15.000001F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            headingLabel.Location = new Point(103, 50);
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
            firstNameLabel.Location = new Point(103, 157);
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
            lastNameLabel.Location = new Point(103, 224);
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
            emailLabel.Location = new Point(103, 291);
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
            phoneLabel.Location = new Point(103, 357);
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
            locationLabel.Location = new Point(103, 424);
            locationLabel.Margin = new Padding(2, 0, 2, 0);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(75, 23);
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
            panel1.Location = new Point(203, 30);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 570);
            panel1.TabIndex = 7;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.DarkSeaGreen;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            updateButton.Location = new Point(305, 493);
            updateButton.Margin = new Padding(2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(87, 27);
            updateButton.TabIndex = 15;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // locationComboBox
            // 
            locationComboBox.FormattingEnabled = true;
            locationComboBox.Items.AddRange(new object[] { "Sydney", "Melbourne", "Brisbane", "Perth", "Adelaide", "Canberra", "Hobart", "Darwin" });
            locationComboBox.Location = new Point(305, 424);
            locationComboBox.Margin = new Padding(2);
            locationComboBox.Name = "locationComboBox";
            locationComboBox.Size = new Size(277, 28);
            locationComboBox.TabIndex = 14;
            locationComboBox.SelectedIndexChanged += locationComboBox_SelectedIndexChanged;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(305, 357);
            phoneTextBox.Margin = new Padding(2);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(277, 27);
            phoneTextBox.TabIndex = 10;
            phoneTextBox.TextChanged += phoneTextBox_TextChanged;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(305, 291);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(277, 27);
            emailTextBox.TabIndex = 9;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(305, 224);
            lastNameTextBox.Margin = new Padding(2);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(277, 27);
            lastNameTextBox.TabIndex = 8;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(305, 157);
            firstNameTextBox.Margin = new Padding(2);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(277, 27);
            firstNameTextBox.TabIndex = 7;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1081, 748);
            Controls.Add(panel1);
            Margin = new Padding(2);
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