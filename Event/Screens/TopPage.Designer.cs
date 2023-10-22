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
            subButton1 = new Button();
            panel7 = new Panel();
            subButton2 = new Button();
            timerForSidebar = new System.Windows.Forms.Timer(components);
            topPagePane = new Panel();
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
            sideBarFlowLayoutPanel.MaximumSize = new Size(330, 1250);
            sideBarFlowLayoutPanel.MinimumSize = new Size(89, 879);
            sideBarFlowLayoutPanel.Name = "sideBarFlowLayoutPanel";
            sideBarFlowLayoutPanel.Size = new Size(330, 1186);
            sideBarFlowLayoutPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(menuLabel);
            menuPanel.Controls.Add(menuButton);
            menuPanel.Location = new Point(3, 3);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(350, 114);
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
            panel2.Location = new Point(3, 123);
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
            homeButton.Click += homeButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(profileButton);
            panel3.Location = new Point(3, 195);
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
            profileButton.Click += profileButton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(eventCreationButton);
            panel4.Location = new Point(3, 267);
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
            eventCreationButton.Click += eventCreationButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(subButton1);
            panel6.Location = new Point(3, 339);
            panel6.Name = "panel6";
            panel6.Size = new Size(350, 66);
            panel6.TabIndex = 5;
            // 
            // subButton1
            // 
            subButton1.FlatStyle = FlatStyle.Flat;
            subButton1.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            subButton1.ImageAlign = ContentAlignment.MiddleLeft;
            subButton1.Location = new Point(-11, -12);
            subButton1.Name = "subButton1";
            subButton1.Padding = new Padding(20, 0, 0, 0);
            subButton1.Size = new Size(376, 91);
            subButton1.TabIndex = 1;
            subButton1.Text = "(Sub)";
            subButton1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(subButton2);
            panel7.Location = new Point(3, 411);
            panel7.Name = "panel7";
            panel7.Size = new Size(350, 66);
            panel7.TabIndex = 6;
            // 
            // subButton2
            // 
            subButton2.FlatStyle = FlatStyle.Flat;
            subButton2.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            subButton2.ImageAlign = ContentAlignment.MiddleLeft;
            subButton2.Location = new Point(-11, -12);
            subButton2.Name = "subButton2";
            subButton2.Padding = new Padding(20, 0, 0, 0);
            subButton2.Size = new Size(376, 91);
            subButton2.TabIndex = 1;
            subButton2.Text = "(Sub)";
            subButton2.UseVisualStyleBackColor = true;
            // 
            // timerForSidebar
            // 
            timerForSidebar.Interval = 7;
            timerForSidebar.Tick += timerForSidebar_Tick;
            // 
            // topPagePane
            // 
            topPagePane.Dock = DockStyle.Fill;
            topPagePane.Location = new Point(330, 0);
            topPagePane.Name = "topPagePane";
            topPagePane.Size = new Size(1646, 1186);
            topPagePane.TabIndex = 1;
            // 
            // TopPage
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1976, 1186);
            Controls.Add(topPagePane);
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
        private Button subButton1;
        private Panel panel7;
        private Button subButton2;
        private Label menuLabel;
        private PictureBox menuButton;
        private System.Windows.Forms.Timer timerForSidebar;
        private Panel menuPanel;
        private Panel topPagePane;
    }
}