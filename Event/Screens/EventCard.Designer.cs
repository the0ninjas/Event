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
            // 
            // EventCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cardJoinButton);
            Controls.Add(cardPictureBox);
            Name = "EventCard";
            Size = new Size(480, 300);
            ((System.ComponentModel.ISupportInitialize)cardPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox cardPictureBox;
        private Button cardJoinButton;
    }
}
