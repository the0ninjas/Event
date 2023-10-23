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
            headingPanel = new Panel();
            searchTextBox = new TextBox();
            headingLabel = new Label();
            joinedEventFlowLayoutPanel = new FlowLayoutPanel();
            joinedEventHScrollBar = new HScrollBar();
            eventCard1 = new EventCard();
            flowLayoutPanel1 = new FlowLayoutPanel();
            headingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headingPanel
            // 
            headingPanel.BackColor = Color.DarkSeaGreen;
            headingPanel.Controls.Add(searchTextBox);
            headingPanel.Controls.Add(headingLabel);
            headingPanel.Dock = DockStyle.Top;
            headingPanel.Location = new Point(0, 0);
            headingPanel.Name = "headingPanel";
            headingPanel.Size = new Size(1625, 105);
            headingPanel.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.ForeColor = SystemColors.ScrollBar;
            searchTextBox.Location = new Point(1248, 43);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(327, 35);
            searchTextBox.TabIndex = 1;
            searchTextBox.Text = "Search";
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI Black", 15.000001F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            headingLabel.Location = new Point(34, 32);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(194, 48);
            headingLabel.TabIndex = 1;
            headingLabel.Text = "EventHub";
            // 
            // joinedEventFlowLayoutPanel
            // 
            joinedEventFlowLayoutPanel.AutoScroll = true;
            joinedEventFlowLayoutPanel.Location = new Point(7, 184);
            joinedEventFlowLayoutPanel.Name = "joinedEventFlowLayoutPanel";
            joinedEventFlowLayoutPanel.Size = new Size(1603, 305);
            joinedEventFlowLayoutPanel.TabIndex = 1;
            joinedEventFlowLayoutPanel.ControlAdded += joinedEventFlowLayoutPanel_ControlAdded;
            joinedEventFlowLayoutPanel.ControlRemoved += joinedEventFlowLayoutPanel_ControlRemoved;
            // 
            // joinedEventHScrollBar
            // 
            joinedEventHScrollBar.Location = new Point(7, 495);
            joinedEventHScrollBar.Name = "joinedEventHScrollBar";
            joinedEventHScrollBar.Size = new Size(1606, 31);
            joinedEventHScrollBar.TabIndex = 4;
            joinedEventHScrollBar.Scroll += joinedEventHScrollBar_Scroll;
            // 
            // eventCard1
            // 
            eventCard1.Capacity = null;
            eventCard1.Date = null;
            eventCard1.Name = "eventCard1";
            eventCard1.Picture = null;
            eventCard1.Size = new Size(8, 8);
            eventCard1.TabIndex = 5;
            eventCard1.Time = null;
            eventCard1.Title = null;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 105);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1625, 1068);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1625, 1173);
            Controls.Add(eventCard1);
            Controls.Add(joinedEventHScrollBar);
            Controls.Add(joinedEventFlowLayoutPanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(headingPanel);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            headingPanel.ResumeLayout(false);
            headingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel headingPanel;
        private TextBox searchTextBox;
        private Label headingLabel;
        private FlowLayoutPanel joinedEventFlowLayoutPanel;
        private HScrollBar joinedEventHScrollBar;
        private EventCard eventCard1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}