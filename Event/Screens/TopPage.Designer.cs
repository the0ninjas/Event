using EventManagementSystem.Repository;
using EventManagementSystem.Utilities;

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
            logoutButton = new Button();
            timerForSidebar = new System.Windows.Forms.Timer(components);
            headingPanel = new Panel();
            searchBarTextBox = new TextBox();
            headerTitleLabel = new Label();
            topPagePane = new Panel();
            sideBarFlowLayoutPanel.SuspendLayout();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            headingPanel.SuspendLayout();
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
            sideBarFlowLayoutPanel.Dock = DockStyle.Left;
            sideBarFlowLayoutPanel.Location = new Point(0, 0);
            sideBarFlowLayoutPanel.Margin = new Padding(2);
            sideBarFlowLayoutPanel.MaximumSize = new Size(220, 1049);
            sideBarFlowLayoutPanel.MinimumSize = new Size(59, 586);
            sideBarFlowLayoutPanel.Name = "sideBarFlowLayoutPanel";
            sideBarFlowLayoutPanel.Size = new Size(220, 703);
            sideBarFlowLayoutPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(menuLabel);
            menuPanel.Controls.Add(menuButton);
            menuPanel.Location = new Point(2, 2);
            menuPanel.Margin = new Padding(2);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(233, 76);
            menuPanel.TabIndex = 0;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            menuLabel.Location = new Point(98, 38);
            menuLabel.Margin = new Padding(2, 0, 2, 0);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(55, 23);
            menuLabel.TabIndex = 1;
            menuLabel.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.icon_menu_burger35;
            menuButton.Location = new Point(13, 31);
            menuButton.Margin = new Padding(2);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(35, 35);
            menuButton.SizeMode = PictureBoxSizeMode.AutoSize;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(homeButton);
            panel2.Location = new Point(2, 82);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 44);
            panel2.TabIndex = 1;
            // 
            // homeButton
            // 
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            homeButton.Image = Properties.Resources.icon_home35;
            homeButton.ImageAlign = ContentAlignment.MiddleLeft;
            homeButton.Location = new Point(-7, -8);
            homeButton.Margin = new Padding(2);
            homeButton.Name = "homeButton";
            homeButton.Padding = new Padding(13, 0, 0, 0);
            homeButton.Size = new Size(251, 61);
            homeButton.TabIndex = 1;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(profileButton);
            panel3.Location = new Point(2, 130);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 44);
            panel3.TabIndex = 2;
            // 
            // profileButton
            // 
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            profileButton.Image = Properties.Resources.icon_user35;
            profileButton.ImageAlign = ContentAlignment.MiddleLeft;
            profileButton.Location = new Point(-7, -8);
            profileButton.Margin = new Padding(2);
            profileButton.Name = "profileButton";
            profileButton.Padding = new Padding(13, 0, 0, 0);
            profileButton.Size = new Size(251, 61);
            profileButton.TabIndex = 1;
            profileButton.Text = "Profile";
            profileButton.UseVisualStyleBackColor = true;
            profileButton.Click += profileButton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(eventCreationButton);
            panel4.Location = new Point(2, 178);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 44);
            panel4.TabIndex = 3;
            // 
            // eventCreationButton
            // 
            eventCreationButton.FlatStyle = FlatStyle.Flat;
            eventCreationButton.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            eventCreationButton.Image = Properties.Resources.icon_calendar_pen35;
            eventCreationButton.ImageAlign = ContentAlignment.MiddleLeft;
            eventCreationButton.Location = new Point(-7, -8);
            eventCreationButton.Margin = new Padding(2);
            eventCreationButton.Name = "eventCreationButton";
            eventCreationButton.Padding = new Padding(13, 0, 0, 0);
            eventCreationButton.Size = new Size(251, 61);
            eventCreationButton.TabIndex = 1;
            eventCreationButton.Text = "Create Event";
            eventCreationButton.UseVisualStyleBackColor = true;
            eventCreationButton.Click += eventCreationButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(logoutButton);
            panel6.Location = new Point(2, 226);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(233, 44);
            panel6.TabIndex = 5;
            // 
            // logoutButton
            // 
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.Image = Properties.Resources.icon_sign_out_alt35;
            logoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logoutButton.Location = new Point(-7, -8);
            logoutButton.Margin = new Padding(2);
            logoutButton.Name = "logoutButton";
            logoutButton.Padding = new Padding(13, 0, 0, 0);
            logoutButton.Size = new Size(251, 61);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // timerForSidebar
            // 
            timerForSidebar.Interval = 7;
            timerForSidebar.Tick += timerForSidebar_Tick;
            // 
            // headingPanel
            // 
            headingPanel.BackColor = Color.DarkSeaGreen;
            headingPanel.Controls.Add(searchBarTextBox);
            headingPanel.Controls.Add(headerTitleLabel);
            headingPanel.Dock = DockStyle.Top;
            headingPanel.Location = new Point(220, 0);
            headingPanel.Margin = new Padding(2);
            headingPanel.Name = "headingPanel";
            headingPanel.Size = new Size(1063, 78);
            headingPanel.TabIndex = 1;
            // 
            // searchBarTextBox
            // 
            searchBarTextBox.ForeColor = SystemColors.ScrollBar;
            searchBarTextBox.Location = new Point(824, 33);
            searchBarTextBox.Margin = new Padding(2);
            searchBarTextBox.Name = "searchBarTextBox";
            searchBarTextBox.Size = new Size(264, 27);
            searchBarTextBox.TabIndex = 1;
            searchBarTextBox.Text = "Search";
            searchBarTextBox.Visible = false;
            // 
            // headerTitleLabel
            // 
            headerTitleLabel.AutoSize = true;
            headerTitleLabel.Font = new Font("Segoe UI Black", 15.000001F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            headerTitleLabel.Location = new Point(25, 23);
            headerTitleLabel.Margin = new Padding(2, 0, 2, 0);
            headerTitleLabel.Name = "headerTitleLabel";
            headerTitleLabel.Size = new Size(145, 36);
            headerTitleLabel.TabIndex = 0;
            headerTitleLabel.Text = "Event Hub";
            // 
            // topPagePane
            // 
            topPagePane.Dock = DockStyle.Fill;
            topPagePane.Location = new Point(220, 78);
            topPagePane.Margin = new Padding(2);
            topPagePane.Name = "topPagePane";
            topPagePane.Size = new Size(1063, 625);
            topPagePane.TabIndex = 2;
            // 
            // TopPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1283, 703);
            Controls.Add(topPagePane);
            Controls.Add(headingPanel);
            Controls.Add(sideBarFlowLayoutPanel);
            Margin = new Padding(2);
            Name = "TopPage";
            Text = "Event Hub";
            sideBarFlowLayoutPanel.ResumeLayout(false);
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            headingPanel.ResumeLayout(false);
            headingPanel.PerformLayout();
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
        private Button logoutButton;
        private Label menuLabel;
        private PictureBox menuButton;
        private System.Windows.Forms.Timer timerForSidebar;
        private Panel menuPanel;
        private Panel headingPanel;
        private TextBox searchBarTextBox;
        private Label headerTitleLabel;
        private Panel topPagePane;
    }
}