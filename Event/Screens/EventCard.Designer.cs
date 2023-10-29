namespace EventManagementSystem.Screens
{
    partial class EventCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cardPictureBox = new PictureBox();
            cardJoinButton = new Button();
            cardLeaveButton = new Button();
            cardDeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cardPictureBox).BeginInit();
            SuspendLayout();
            // 
            // cardPictureBox
            // 
            cardPictureBox.Location = new Point(2, 2);
            cardPictureBox.Margin = new Padding(2, 2, 2, 2);
            cardPictureBox.Name = "cardPictureBox";
            cardPictureBox.Size = new Size(316, 196);
            cardPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cardPictureBox.TabIndex = 3;
            cardPictureBox.TabStop = false;
            cardPictureBox.Paint += cardPictureBox_Paint;
            // 
            // cardJoinButton
            // 
            cardJoinButton.BackColor = Color.DarkSeaGreen;
            cardJoinButton.FlatStyle = FlatStyle.Popup;
            cardJoinButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cardJoinButton.Location = new Point(220, 159);
            cardJoinButton.Margin = new Padding(2, 2, 2, 2);
            cardJoinButton.Name = "cardJoinButton";
            cardJoinButton.Size = new Size(87, 27);
            cardJoinButton.TabIndex = 6;
            cardJoinButton.Text = "Join";
            cardJoinButton.UseVisualStyleBackColor = false;
            cardJoinButton.Click += cardJoinButton_Click;
            // 
            // cardLeaveButton
            // 
            cardLeaveButton.BackColor = Color.LavenderBlush;
            cardLeaveButton.FlatStyle = FlatStyle.Popup;
            cardLeaveButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cardLeaveButton.Location = new Point(220, 159);
            cardLeaveButton.Margin = new Padding(2, 2, 2, 2);
            cardLeaveButton.Name = "cardLeaveButton";
            cardLeaveButton.Size = new Size(87, 27);
            cardLeaveButton.TabIndex = 7;
            cardLeaveButton.Text = "Leave";
            cardLeaveButton.UseVisualStyleBackColor = false;
            cardLeaveButton.Click += cardLeaveButton_Click;
            // 
            // cardDeleteButton
            // 
            cardDeleteButton.BackColor = Color.LavenderBlush;
            cardDeleteButton.FlatStyle = FlatStyle.Popup;
            cardDeleteButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cardDeleteButton.Location = new Point(220, 159);
            cardDeleteButton.Margin = new Padding(2, 2, 2, 2);
            cardDeleteButton.Name = "cardDeleteButton";
            cardDeleteButton.Size = new Size(87, 27);
            cardDeleteButton.TabIndex = 8;
            cardDeleteButton.Text = "Delete";
            cardDeleteButton.UseVisualStyleBackColor = false;
            cardDeleteButton.Click += button1_Click;
            // 
            // EventCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cardDeleteButton);
            Controls.Add(cardLeaveButton);
            Controls.Add(cardJoinButton);
            Controls.Add(cardPictureBox);
            Margin = new Padding(2, 2, 2, 2);
            Name = "EventCard";
            Size = new Size(320, 200);
            ((System.ComponentModel.ISupportInitialize)cardPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox cardPictureBox;
        public Button cardJoinButton;
        public Button cardLeaveButton;
        public Button cardDeleteButton;
    }
}
