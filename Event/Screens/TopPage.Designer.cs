namespace EventManagementSystem.Screens
{
    partial class TopPage
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
            sideBarFlowLayoutPanel = new FlowLayoutPanel();
            menuPanel = new Panel();
            menuLabel = new Label();
            menuButton = new PictureBox();
            panel2 = new Panel();
            homeButton = new Button();
            panel3 = new Panel();
            profileButton = new Button();
            panel4 = new Panel();
            eventCreationButton = new Button();
            panel6 = new Panel();
            myEventsButton = new Button();
            panel7 = new Panel();
            searchEventsButton = new Button();
            timerForSidebar = new System.Windows.Forms.Timer(components);
            sideBarFlowLayoutPanel.SuspendLayout();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // sideBarFlowLayoutPanel
            // 
            sideBarFlowLayoutPanel.BackColor = Color.DarkSeaGreen;
            sideBarFlowLayoutPanel.Controls.Add(menuPanel);
            sideBarFlowLayoutPanel.Controls.Add(panel2);
            sideBarFlowLayoutPanel.Controls.Add(panel3);
            sideBarFlowLayoutPanel.Controls.Add(panel4);
            sideBarFlowLayoutPanel.Controls.Add(panel6);
            sideBarFlowLayoutPanel.Controls.Add(panel7);
            sideBarFlowLayoutPanel.Dock = DockStyle.Left;
            sideBarFlowLayoutPanel.Location = new Point(0, 0);
            sideBarFlowLayoutPanel.MaximumSize = new Size(330, 879);
            sideBarFlowLayoutPanel.MinimumSize = new Size(89, 879);
            sideBarFlowLayoutPanel.Name = "sideBarFlowLayoutPanel";
            sideBarFlowLayoutPanel.Size = new Size(330, 879);
            sideBarFlowLayoutPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(menuLabel);
            menuPanel.Controls.Add(menuButton);
            menuPanel.Location = new Point(3, 3);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(350, 146);
            menuPanel.TabIndex = 0;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            menuLabel.Location = new Point(147, 57);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(77, 32);
            menuLabel.TabIndex = 1;
            menuLabel.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.menu_burger;
            menuButton.Location = new Point(19, 46);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(50, 50);
            menuButton.SizeMode = PictureBoxSizeMode.AutoSize;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(homeButton);
            panel2.Location = new Point(3, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 66);
            panel2.TabIndex = 1;
            // 
            // homeButton
            // 
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            homeButton.Image = Properties.Resources.home;
            homeButton.ImageAlign = ContentAlignment.MiddleLeft;
            homeButton.Location = new Point(-11, -12);
            homeButton.Name = "homeButton";
            homeButton.Padding = new Padding(20, 0, 0, 0);
            homeButton.Size = new Size(376, 91);
            homeButton.TabIndex = 1;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(profileButton);
            panel3.Location = new Point(3, 227);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 66);
            panel3.TabIndex = 2;
            // 
            // profileButton
            // 
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            profileButton.Image = Properties.Resources.user;
            profileButton.ImageAlign = ContentAlignment.MiddleLeft;
            profileButton.Location = new Point(-11, -12);
            profileButton.Name = "profileButton";
            profileButton.Padding = new Padding(20, 0, 0, 0);
            profileButton.Size = new Size(376, 91);
            profileButton.TabIndex = 1;
            profileButton.Text = "Profile";
            profileButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(eventCreationButton);
            panel4.Location = new Point(3, 299);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 66);
            panel4.TabIndex = 3;
            // 
            // eventCreationButton
            // 
            eventCreationButton.FlatStyle = FlatStyle.Flat;
            eventCreationButton.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            eventCreationButton.Image = Properties.Resources.calendar_pen;
            eventCreationButton.ImageAlign = ContentAlignment.MiddleLeft;
            eventCreationButton.Location = new Point(-11, -12);
            eventCreationButton.Name = "eventCreationButton";
            eventCreationButton.Padding = new Padding(20, 0, 0, 0);
            eventCreationButton.Size = new Size(376, 91);
            eventCreationButton.TabIndex = 1;
            eventCreationButton.Text = "Create Event";
            eventCreationButton.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(myEventsButton);
            panel6.Location = new Point(3, 371);
            panel6.Name = "panel6";
            panel6.Size = new Size(350, 66);
            panel6.TabIndex = 5;
            // 
            // myEventsButton
            // 
            myEventsButton.FlatStyle = FlatStyle.Flat;
            myEventsButton.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            myEventsButton.Image = Properties.Resources.calendar_check;
            myEventsButton.ImageAlign = ContentAlignment.MiddleLeft;
            myEventsButton.Location = new Point(-11, -12);
            myEventsButton.Name = "myEventsButton";
            myEventsButton.Padding = new Padding(20, 0, 0, 0);
            myEventsButton.Size = new Size(376, 91);
            myEventsButton.TabIndex = 1;
            myEventsButton.Text = "My Events";
            myEventsButton.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(searchEventsButton);
            panel7.Location = new Point(3, 443);
            panel7.Name = "panel7";
            panel7.Size = new Size(350, 66);
            panel7.TabIndex = 6;
            // 
            // searchEventsButton
            // 
            searchEventsButton.FlatStyle = FlatStyle.Flat;
            searchEventsButton.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            searchEventsButton.Image = Properties.Resources.search;
            searchEventsButton.ImageAlign = ContentAlignment.MiddleLeft;
            searchEventsButton.Location = new Point(-11, -12);
            searchEventsButton.Name = "searchEventsButton";
            searchEventsButton.Padding = new Padding(20, 0, 0, 0);
            searchEventsButton.Size = new Size(376, 91);
            searchEventsButton.TabIndex = 1;
            searchEventsButton.Text = "Search Events";
            searchEventsButton.UseVisualStyleBackColor = true;
            // 
            // timerForSidebar
            // 
            timerForSidebar.Interval = 7;
            timerForSidebar.Tick += timerForSidebar_Tick;
            // 
            // TopPage
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1497, 879);
            Controls.Add(sideBarFlowLayoutPanel);
            Name = "TopPage";
            Text = "Top Page";
            sideBarFlowLayoutPanel.ResumeLayout(false);
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sideBarFlowLayoutPanel;
        private Panel panel2;
        private Button homeButton;
        private Panel panel3;
        private Button profileButton;
        private Panel panel4;
        private Button eventCreationButton;
        private Panel panel5;
        private Button myCreatedEventButton;
        private Panel panel6;
        private Button myEventsButton;
        private Panel panel7;
        private Button searchEventsButton;
        private Label menuLabel;
        private PictureBox menuButton;
        private System.Windows.Forms.Timer timerForSidebar;
        private Panel menuPanel;
    }
}