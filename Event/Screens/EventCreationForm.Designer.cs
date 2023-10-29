namespace EventManagementSystem.Screens
{
    partial class EventCreationForm
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
            components = new System.ComponentModel.Container();
            headingLabel = new Label();
            titleLabel = new Label();
            dateLabel = new Label();
            timeLabel = new Label();
            locationLabel = new Label();
            descriptionLabel = new Label();
            capacityLabel = new Label();
            titleTextBox = new TextBox();
            datePicker = new DateTimePicker();
            timePicker = new DateTimePicker();
            locationComboBox = new ComboBox();
            capacityTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            createEventPanel = new Panel();
            pictureBox = new PictureBox();
            imageComboBox = new ComboBox();
            imageLabel = new Label();
            submitButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            createEventPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI Black", 15.000001F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            headingLabel.Location = new Point(112, 38);
            headingLabel.Margin = new Padding(2, 0, 2, 0);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(174, 36);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "Create Event";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(112, 105);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(42, 23);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            dateLabel.Location = new Point(112, 172);
            dateLabel.Margin = new Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(46, 23);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Date";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            timeLabel.Location = new Point(112, 239);
            timeLabel.Margin = new Padding(2, 0, 2, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(47, 23);
            timeLabel.TabIndex = 3;
            timeLabel.Text = "Time";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            locationLabel.Location = new Point(112, 305);
            locationLabel.Margin = new Padding(2, 0, 2, 0);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(75, 23);
            locationLabel.TabIndex = 4;
            locationLabel.Text = "Location";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(112, 439);
            descriptionLabel.Margin = new Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(96, 23);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description";
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            capacityLabel.Location = new Point(112, 372);
            capacityLabel.Margin = new Padding(2, 0, 2, 0);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new Size(115, 23);
            capacityLabel.TabIndex = 6;
            capacityLabel.Text = "Max Capacity";
            // 
            // titleTextBox
            // 
            titleTextBox.ForeColor = SystemColors.ScrollBar;
            titleTextBox.Location = new Point(270, 105);
            titleTextBox.Margin = new Padding(2, 2, 2, 2);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(235, 27);
            titleTextBox.TabIndex = 7;
            titleTextBox.Text = "Enter event title";
            titleTextBox.Enter += titleTextBox_Enter;
            titleTextBox.Leave += titleTextBox_Leave;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(270, 172);
            datePicker.Margin = new Padding(2, 2, 2, 2);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(235, 27);
            datePicker.TabIndex = 8;
            // 
            // timePicker
            // 
            timePicker.CustomFormat = "hh:mm tt";
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.Location = new Point(270, 239);
            timePicker.Margin = new Padding(2, 2, 2, 2);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(235, 27);
            timePicker.TabIndex = 9;
            // 
            // locationComboBox
            // 
            locationComboBox.ForeColor = SystemColors.ScrollBar;
            locationComboBox.FormattingEnabled = true;
            locationComboBox.Items.AddRange(new object[] { "Sydney", "Melbourne", "Brisbane", "Perth", "Adelaide", "Canberra", "Hobart", "Darwin" });
            locationComboBox.Location = new Point(270, 305);
            locationComboBox.Margin = new Padding(2, 2, 2, 2);
            locationComboBox.Name = "locationComboBox";
            locationComboBox.Size = new Size(235, 28);
            locationComboBox.TabIndex = 10;
            locationComboBox.Text = "Select the location";
            locationComboBox.SelectedIndexChanged += locationComboBox_SelectedIndexChanged;
            locationComboBox.Enter += locationComboBox_Enter;
            locationComboBox.Leave += locationComboBox_Leave;
            // 
            // capacityTextBox
            // 
            capacityTextBox.ForeColor = SystemColors.ScrollBar;
            capacityTextBox.Location = new Point(270, 372);
            capacityTextBox.Margin = new Padding(2, 2, 2, 2);
            capacityTextBox.Name = "capacityTextBox";
            capacityTextBox.Size = new Size(235, 27);
            capacityTextBox.TabIndex = 11;
            capacityTextBox.Text = "Enter max capacity";
            capacityTextBox.Enter += capacityTextBox_Enter;
            capacityTextBox.Leave += capacityTextBox_Leave;
            capacityTextBox.Validating += capacityTextBox_Validating;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.ForeColor = SystemColors.ScrollBar;
            descriptionTextBox.Location = new Point(270, 439);
            descriptionTextBox.Margin = new Padding(2, 2, 2, 2);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(235, 80);
            descriptionTextBox.TabIndex = 12;
            descriptionTextBox.Text = "Enter event description";
            descriptionTextBox.Enter += descriptionTextBox_Enter;
            descriptionTextBox.Leave += descriptionTextBox_Leave;
            // 
            // createEventPanel
            // 
            createEventPanel.Controls.Add(pictureBox);
            createEventPanel.Controls.Add(imageComboBox);
            createEventPanel.Controls.Add(imageLabel);
            createEventPanel.Controls.Add(submitButton);
            createEventPanel.Controls.Add(timePicker);
            createEventPanel.Controls.Add(descriptionTextBox);
            createEventPanel.Controls.Add(headingLabel);
            createEventPanel.Controls.Add(capacityTextBox);
            createEventPanel.Controls.Add(titleLabel);
            createEventPanel.Controls.Add(locationComboBox);
            createEventPanel.Controls.Add(dateLabel);
            createEventPanel.Controls.Add(timeLabel);
            createEventPanel.Controls.Add(datePicker);
            createEventPanel.Controls.Add(locationLabel);
            createEventPanel.Controls.Add(titleTextBox);
            createEventPanel.Controls.Add(descriptionLabel);
            createEventPanel.Controls.Add(capacityLabel);
            createEventPanel.Location = new Point(250, 51);
            createEventPanel.Margin = new Padding(2, 2, 2, 2);
            createEventPanel.Name = "createEventPanel";
            createEventPanel.Size = new Size(611, 823);
            createEventPanel.TabIndex = 13;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(270, 588);
            pictureBox.Margin = new Padding(2, 2, 2, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(233, 133);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 16;
            pictureBox.TabStop = false;
            // 
            // imageComboBox
            // 
            imageComboBox.ForeColor = SystemColors.ScrollBar;
            imageComboBox.FormattingEnabled = true;
            imageComboBox.Location = new Point(270, 559);
            imageComboBox.Margin = new Padding(2, 2, 2, 2);
            imageComboBox.Name = "imageComboBox";
            imageComboBox.Size = new Size(235, 28);
            imageComboBox.TabIndex = 15;
            imageComboBox.Text = "Select the image";
            imageComboBox.SelectedIndexChanged += imageComboBox_SelectedIndexChanged;
            imageComboBox.Enter += imageComboBox_Enter;
            imageComboBox.Leave += imageComboBox_Leave;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            imageLabel.Location = new Point(112, 559);
            imageLabel.Margin = new Padding(2, 0, 2, 0);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(58, 23);
            imageLabel.TabIndex = 14;
            imageLabel.Text = "Image";
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.DarkSeaGreen;
            submitButton.FlatStyle = FlatStyle.Popup;
            submitButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            submitButton.Location = new Point(270, 761);
            submitButton.Margin = new Padding(2, 2, 2, 2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(87, 27);
            submitButton.TabIndex = 13;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // EventCreationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1084, 924);
            Controls.Add(createEventPanel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "EventCreationForm";
            Text = "Event Creation Form";
            Load += EventCreationForm_Load;
            createEventPanel.ResumeLayout(false);
            createEventPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label headingLabel;
        private Label titleLabel;
        private Label dateLabel;
        private Label timeLabel;
        private Label locationLabel;
        private Label descriptionLabel;
        private Label capacityLabel;
        private TextBox titleTextBox;
        private DateTimePicker datePicker;
        private DateTimePicker timePicker;
        private ComboBox locationComboBox;
        private TextBox capacityTextBox;
        private TextBox descriptionTextBox;
        private Panel createEventPanel;
        private Button submitButton;
        private ComboBox imageComboBox;
        private Label imageLabel;
        private PictureBox pictureBox;
        private ErrorProvider errorProvider1;
    }
}