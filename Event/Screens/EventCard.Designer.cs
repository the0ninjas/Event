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
            cardPictureBox.Location = new Point(3, 3);
            cardPictureBox.Name = "cardPictureBox";
            cardPictureBox.Size = new Size(474, 294);
            cardPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cardPictureBox.TabIndex = 3;
            cardPictureBox.TabStop = false;
            cardPictureBox.Paint += cardPictureBox_Paint;
            // 
            // cardJoinButton
            // 
            cardJoinButton.Location = new Point(330, 239);
            cardJoinButton.Name = "cardJoinButton";
            cardJoinButton.Size = new Size(131, 40);
            cardJoinButton.TabIndex = 6;
            cardJoinButton.Text = "Join";
            cardJoinButton.UseVisualStyleBackColor = true;
            cardJoinButton.Click += cardJoinButton_Click;
            // 
            // cardLeaveButton
            // 
            cardLeaveButton.Location = new Point(330, 239);
            cardLeaveButton.Name = "cardLeaveButton";
            cardLeaveButton.Size = new Size(131, 40);
            cardLeaveButton.TabIndex = 7;
            cardLeaveButton.Text = "Leave";
            cardLeaveButton.UseVisualStyleBackColor = true;
            cardLeaveButton.Click += cardLeaveButton_Click;
            // 
            // cardDeleteButton
            // 
            cardDeleteButton.Location = new Point(330, 239);
            cardDeleteButton.Name = "cardDeleteButton";
            cardDeleteButton.Size = new Size(131, 40);
            cardDeleteButton.TabIndex = 8;
            cardDeleteButton.Text = "Delete";
            cardDeleteButton.UseVisualStyleBackColor = true;
            cardDeleteButton.Click += button1_Click;
            // 
            // EventCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cardDeleteButton);
            Controls.Add(cardLeaveButton);
            Controls.Add(cardJoinButton);
            Controls.Add(cardPictureBox);
            Name = "EventCard";
            Size = new Size(480, 300);
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
