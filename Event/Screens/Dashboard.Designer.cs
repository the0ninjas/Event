namespace EventManagementSystem.Screens
{
    partial class Dashboard
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
            joinedEventFlowLayoutPanel = new FlowLayoutPanel();
            eventCard1 = new EventCard();
            dashboardPanel = new FlowLayoutPanel();
            joinedEventTitleFlowLayoutPanel = new FlowLayoutPanel();
            joinedEventTitleLabel = new Label();
            createdEventTitleFlowLayoutPanel = new FlowLayoutPanel();
            createdEventTitleLabel = new Label();
            createdEventFlowLayoutPanel = new FlowLayoutPanel();
            upcomingEventTitleFlowLayoutPanel = new FlowLayoutPanel();
            upcomingEventTitleLabel = new Label();
            upcomingEventFlowLayoutPanel = new FlowLayoutPanel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dashboardPanel.SuspendLayout();
            joinedEventTitleFlowLayoutPanel.SuspendLayout();
            createdEventTitleFlowLayoutPanel.SuspendLayout();
            upcomingEventTitleFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // joinedEventFlowLayoutPanel
            // 
            joinedEventFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            joinedEventFlowLayoutPanel.AutoScroll = true;
            joinedEventFlowLayoutPanel.Location = new Point(2, 53);
            joinedEventFlowLayoutPanel.Margin = new Padding(2, 2, 2, 13);
            joinedEventFlowLayoutPanel.Name = "joinedEventFlowLayoutPanel";
            joinedEventFlowLayoutPanel.Size = new Size(1069, 233);
            joinedEventFlowLayoutPanel.TabIndex = 1;
            joinedEventFlowLayoutPanel.WrapContents = false;
            // 
            // eventCard1
            // 
            eventCard1.EventCapacity = null;
            eventCard1.EventDate = null;
            eventCard1.EventId = 0;
            eventCard1.EventLocation = null;
            eventCard1.EventTime = null;
            eventCard1.EventTitle = null;
            eventCard1.Location = new Point(0, 0);
            eventCard1.Margin = new Padding(1);
            eventCard1.Name = "eventCard1";
            eventCard1.Picture = null;
            eventCard1.Size = new Size(5, 5);
            eventCard1.TabIndex = 5;
            // 
            // dashboardPanel
            // 
            dashboardPanel.AutoScroll = true;
            dashboardPanel.Controls.Add(joinedEventTitleFlowLayoutPanel);
            dashboardPanel.Controls.Add(joinedEventFlowLayoutPanel);
            dashboardPanel.Controls.Add(createdEventTitleFlowLayoutPanel);
            dashboardPanel.Controls.Add(createdEventFlowLayoutPanel);
            dashboardPanel.Controls.Add(upcomingEventTitleFlowLayoutPanel);
            dashboardPanel.Controls.Add(upcomingEventFlowLayoutPanel);
            dashboardPanel.Dock = DockStyle.Fill;
            dashboardPanel.Location = new Point(0, 0);
            dashboardPanel.Margin = new Padding(2);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(1084, 924);
            dashboardPanel.TabIndex = 6;
            // 
            // joinedEventTitleFlowLayoutPanel
            // 
            joinedEventTitleFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            joinedEventTitleFlowLayoutPanel.Controls.Add(joinedEventTitleLabel);
            joinedEventTitleFlowLayoutPanel.Location = new Point(2, 2);
            joinedEventTitleFlowLayoutPanel.Margin = new Padding(2);
            joinedEventTitleFlowLayoutPanel.Name = "joinedEventTitleFlowLayoutPanel";
            joinedEventTitleFlowLayoutPanel.Size = new Size(1069, 47);
            joinedEventTitleFlowLayoutPanel.TabIndex = 1;
            // 
            // joinedEventTitleLabel
            // 
            joinedEventTitleLabel.AutoSize = true;
            joinedEventTitleLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            joinedEventTitleLabel.Location = new Point(2, 0);
            joinedEventTitleLabel.Margin = new Padding(2, 0, 2, 0);
            joinedEventTitleLabel.Name = "joinedEventTitleLabel";
            joinedEventTitleLabel.Size = new Size(173, 28);
            joinedEventTitleLabel.TabIndex = 0;
            joinedEventTitleLabel.Text = "My Joined Event";
            // 
            // createdEventTitleFlowLayoutPanel
            // 
            createdEventTitleFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            createdEventTitleFlowLayoutPanel.Controls.Add(createdEventTitleLabel);
            createdEventTitleFlowLayoutPanel.Location = new Point(2, 301);
            createdEventTitleFlowLayoutPanel.Margin = new Padding(2);
            createdEventTitleFlowLayoutPanel.Name = "createdEventTitleFlowLayoutPanel";
            createdEventTitleFlowLayoutPanel.Size = new Size(1069, 47);
            createdEventTitleFlowLayoutPanel.TabIndex = 2;
            // 
            // createdEventTitleLabel
            // 
            createdEventTitleLabel.AutoSize = true;
            createdEventTitleLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            createdEventTitleLabel.Location = new Point(2, 0);
            createdEventTitleLabel.Margin = new Padding(2, 0, 2, 0);
            createdEventTitleLabel.Name = "createdEventTitleLabel";
            createdEventTitleLabel.Size = new Size(186, 28);
            createdEventTitleLabel.TabIndex = 0;
            createdEventTitleLabel.Text = "My Created Event";
            // 
            // createdEventFlowLayoutPanel
            // 
            createdEventFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            createdEventFlowLayoutPanel.AutoScroll = true;
            createdEventFlowLayoutPanel.Location = new Point(2, 352);
            createdEventFlowLayoutPanel.Margin = new Padding(2, 2, 2, 13);
            createdEventFlowLayoutPanel.Name = "createdEventFlowLayoutPanel";
            createdEventFlowLayoutPanel.Size = new Size(1069, 233);
            createdEventFlowLayoutPanel.TabIndex = 3;
            createdEventFlowLayoutPanel.WrapContents = false;
            // 
            // upcomingEventTitleFlowLayoutPanel
            // 
            upcomingEventTitleFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            upcomingEventTitleFlowLayoutPanel.Controls.Add(upcomingEventTitleLabel);
            upcomingEventTitleFlowLayoutPanel.Location = new Point(2, 600);
            upcomingEventTitleFlowLayoutPanel.Margin = new Padding(2);
            upcomingEventTitleFlowLayoutPanel.Name = "upcomingEventTitleFlowLayoutPanel";
            upcomingEventTitleFlowLayoutPanel.Size = new Size(1069, 47);
            upcomingEventTitleFlowLayoutPanel.TabIndex = 4;
            // 
            // upcomingEventTitleLabel
            // 
            upcomingEventTitleLabel.AutoSize = true;
            upcomingEventTitleLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            upcomingEventTitleLabel.Location = new Point(2, 0);
            upcomingEventTitleLabel.Margin = new Padding(2, 0, 2, 0);
            upcomingEventTitleLabel.Name = "upcomingEventTitleLabel";
            upcomingEventTitleLabel.Size = new Size(172, 28);
            upcomingEventTitleLabel.TabIndex = 0;
            upcomingEventTitleLabel.Text = "Upcoming Event";
            // 
            // upcomingEventFlowLayoutPanel
            // 
            upcomingEventFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            upcomingEventFlowLayoutPanel.AutoScroll = true;
            upcomingEventFlowLayoutPanel.Location = new Point(2, 651);
            upcomingEventFlowLayoutPanel.Margin = new Padding(2, 2, 2, 13);
            upcomingEventFlowLayoutPanel.Name = "upcomingEventFlowLayoutPanel";
            upcomingEventFlowLayoutPanel.Size = new Size(1069, 233);
            upcomingEventFlowLayoutPanel.TabIndex = 5;
            upcomingEventFlowLayoutPanel.WrapContents = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1084, 924);
            Controls.Add(eventCard1);
            Controls.Add(dashboardPanel);
            Margin = new Padding(2);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            dashboardPanel.ResumeLayout(false);
            joinedEventTitleFlowLayoutPanel.ResumeLayout(false);
            joinedEventTitleFlowLayoutPanel.PerformLayout();
            createdEventTitleFlowLayoutPanel.ResumeLayout(false);
            createdEventTitleFlowLayoutPanel.PerformLayout();
            upcomingEventTitleFlowLayoutPanel.ResumeLayout(false);
            upcomingEventTitleFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel joinedEventFlowLayoutPanel;
        private EventCard eventCard1;
        private FlowLayoutPanel dashboardPanel;
        private FlowLayoutPanel joinedEventTitleFlowLayoutPanel;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private FlowLayoutPanel createdEventTitleFlowLayoutPanel;
        private FlowLayoutPanel createdEventFlowLayoutPanel;
        private FlowLayoutPanel upcomingEventTitleFlowLayoutPanel;
        private FlowLayoutPanel upcomingEventFlowLayoutPanel;
        private Label joinedEventTitleLabel;
        private Label createdEventTitleLabel;
        private Label upcomingEventTitleLabel;
    }
}