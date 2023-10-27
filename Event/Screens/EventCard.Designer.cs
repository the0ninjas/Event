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
            cardTitleLabel = new Label();
            cardDateLabel = new Label();
            cardTimeLabel = new Label();
            cardPictureBox = new PictureBox();
            cardLocationLabel = new Label();
            cardCapacityLabel = new Label();
            cardJoinButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cardPictureBox).BeginInit();
            SuspendLayout();
            // 
            // cardTitleLabel
            // 
            cardTitleLabel.AutoSize = true;
            cardTitleLabel.Location = new Point(25, 27);
            cardTitleLabel.Name = "cardTitleLabel";
            cardTitleLabel.Size = new Size(52, 30);
            cardTitleLabel.TabIndex = 0;
            cardTitleLabel.Text = "Title";
            // 
            // cardDateLabel
            // 
            cardDateLabel.AutoSize = true;
            cardDateLabel.Location = new Point(25, 249);
            cardDateLabel.Name = "cardDateLabel";
            cardDateLabel.Size = new Size(57, 30);
            cardDateLabel.TabIndex = 1;
            cardDateLabel.Text = "Date";
            // 
            // cardTimeLabel
            // 
            cardTimeLabel.AutoSize = true;
            cardTimeLabel.Location = new Point(100, 249);
            cardTimeLabel.Name = "cardTimeLabel";
            cardTimeLabel.Size = new Size(58, 30);
            cardTimeLabel.TabIndex = 2;
            cardTimeLabel.Text = "Time";
            // 
            // cardPictureBox
            // 
            cardPictureBox.Location = new Point(3, 3);
            cardPictureBox.Name = "cardPictureBox";
            cardPictureBox.Size = new Size(474, 294);
            cardPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cardPictureBox.TabIndex = 3;
            cardPictureBox.TabStop = false;
            // 
            // cardLocationLabel
            // 
            cardLocationLabel.AutoSize = true;
            cardLocationLabel.Location = new Point(25, 200);
            cardLocationLabel.Name = "cardLocationLabel";
            cardLocationLabel.Size = new Size(92, 30);
            cardLocationLabel.TabIndex = 4;
            cardLocationLabel.Text = "Location";
            // 
            // cardCapacityLabel
            // 
            cardCapacityLabel.AutoSize = true;
            cardCapacityLabel.Location = new Point(369, 27);
            cardCapacityLabel.Name = "cardCapacityLabel";
            cardCapacityLabel.Size = new Size(92, 30);
            cardCapacityLabel.TabIndex = 5;
            cardCapacityLabel.Text = "Capacity";
            // 
            // cardJoinButton
            // 
            cardJoinButton.Location = new Point(330, 239);
            cardJoinButton.Name = "cardJoinButton";
            cardJoinButton.Size = new Size(131, 40);
            cardJoinButton.TabIndex = 6;
            cardJoinButton.Text = "Join";
            cardJoinButton.UseVisualStyleBackColor = true;
            // 
            // EventCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cardJoinButton);
            Controls.Add(cardCapacityLabel);
            Controls.Add(cardLocationLabel);
            Controls.Add(cardTimeLabel);
            Controls.Add(cardDateLabel);
            Controls.Add(cardTitleLabel);
            Controls.Add(cardPictureBox);
            Name = "EventCard";
            Size = new Size(480, 300);
            ((System.ComponentModel.ISupportInitialize)cardPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cardTitleLabel;
        private Label cardDateLabel;
        private Label cardTimeLabel;
        private PictureBox cardPictureBox;
        private Label cardLocationLabel;
        private Label cardCapacityLabel;
        private Button cardJoinButton;
    }
}
