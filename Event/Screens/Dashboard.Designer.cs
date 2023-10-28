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
            joinedEventFlowLayoutPanel.Location = new Point(3, 79);
            joinedEventFlowLayoutPanel.Margin = new Padding(3, 3, 3, 20);
            joinedEventFlowLayoutPanel.Name = "joinedEventFlowLayoutPanel";
            joinedEventFlowLayoutPanel.Size = new Size(1603, 350);
            joinedEventFlowLayoutPanel.TabIndex = 1;
            joinedEventFlowLayoutPanel.WrapContents = false;
            // 
            // eventCard1
            // 
            eventCard1.Name = "eventCard1";
            eventCard1.Picture = null;
            eventCard1.Size = new Size(8, 8);
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
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(1626, 1386);
            dashboardPanel.TabIndex = 6;
            // 
            // joinedEventTitleFlowLayoutPanel
            // 
            joinedEventTitleFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            joinedEventTitleFlowLayoutPanel.Controls.Add(joinedEventTitleLabel);
            joinedEventTitleFlowLayoutPanel.Location = new Point(3, 3);
            joinedEventTitleFlowLayoutPanel.Name = "joinedEventTitleFlowLayoutPanel";
            joinedEventTitleFlowLayoutPanel.Size = new Size(1603, 70);
            joinedEventTitleFlowLayoutPanel.TabIndex = 1;
            // 
            // joinedEventTitleLabel
            // 
            joinedEventTitleLabel.AutoSize = true;
            joinedEventTitleLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            joinedEventTitleLabel.Location = new Point(3, 0);
            joinedEventTitleLabel.Name = "joinedEventTitleLabel";
            joinedEventTitleLabel.Size = new Size(244, 38);
            joinedEventTitleLabel.TabIndex = 0;
            joinedEventTitleLabel.Text = "My Joined Event";
            // 
            // createdEventTitleFlowLayoutPanel
            // 
            createdEventTitleFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            createdEventTitleFlowLayoutPanel.Controls.Add(createdEventTitleLabel);
            createdEventTitleFlowLayoutPanel.Location = new Point(3, 452);
            createdEventTitleFlowLayoutPanel.Name = "createdEventTitleFlowLayoutPanel";
            createdEventTitleFlowLayoutPanel.Size = new Size(1603, 70);
            createdEventTitleFlowLayoutPanel.TabIndex = 2;
            // 
            // createdEventTitleLabel
            // 
            createdEventTitleLabel.AutoSize = true;
            createdEventTitleLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            createdEventTitleLabel.Location = new Point(3, 0);
            createdEventTitleLabel.Name = "createdEventTitleLabel";
            createdEventTitleLabel.Size = new Size(261, 38);
            createdEventTitleLabel.TabIndex = 0;
            createdEventTitleLabel.Text = "My Created Event";
            // 
            // createdEventFlowLayoutPanel
            // 
            createdEventFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            createdEventFlowLayoutPanel.AutoScroll = true;
            createdEventFlowLayoutPanel.Location = new Point(3, 528);
            createdEventFlowLayoutPanel.Margin = new Padding(3, 3, 3, 20);
            createdEventFlowLayoutPanel.Name = "createdEventFlowLayoutPanel";
            createdEventFlowLayoutPanel.Size = new Size(1603, 350);
            createdEventFlowLayoutPanel.TabIndex = 3;
            createdEventFlowLayoutPanel.WrapContents = false;
            // 
            // upcomingEventTitleFlowLayoutPanel
            // 
            upcomingEventTitleFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            upcomingEventTitleFlowLayoutPanel.Controls.Add(upcomingEventTitleLabel);
            upcomingEventTitleFlowLayoutPanel.Location = new Point(3, 901);
            upcomingEventTitleFlowLayoutPanel.Name = "upcomingEventTitleFlowLayoutPanel";
            upcomingEventTitleFlowLayoutPanel.Size = new Size(1603, 70);
            upcomingEventTitleFlowLayoutPanel.TabIndex = 4;
            // 
            // upcomingEventTitleLabel
            // 
            upcomingEventTitleLabel.AutoSize = true;
            upcomingEventTitleLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            upcomingEventTitleLabel.Location = new Point(3, 0);
            upcomingEventTitleLabel.Name = "upcomingEventTitleLabel";
            upcomingEventTitleLabel.Size = new Size(242, 38);
            upcomingEventTitleLabel.TabIndex = 0;
            upcomingEventTitleLabel.Text = "Upcoming Event";
            // 
            // upcomingEventFlowLayoutPanel
            // 
            upcomingEventFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            upcomingEventFlowLayoutPanel.AutoScroll = true;
            upcomingEventFlowLayoutPanel.Location = new Point(3, 977);
            upcomingEventFlowLayoutPanel.Margin = new Padding(3, 3, 3, 20);
            upcomingEventFlowLayoutPanel.Name = "upcomingEventFlowLayoutPanel";
            upcomingEventFlowLayoutPanel.Size = new Size(1603, 350);
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
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1626, 1386);
            Controls.Add(eventCard1);
            Controls.Add(dashboardPanel);
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