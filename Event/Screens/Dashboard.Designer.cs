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
            headingLabel = new Label();
            searchTextBox = new TextBox();
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
            headingPanel.Size = new Size(1622, 105);
            headingPanel.TabIndex = 0;
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
            // searchTextBox
            // 
            searchTextBox.ForeColor = SystemColors.ScrollBar;
            searchTextBox.Location = new Point(1248, 43);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(327, 35);
            searchTextBox.TabIndex = 1;
            searchTextBox.Text = "Search";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1622, 1122);
            Controls.Add(headingPanel);
            Name = "Dashboard";
            Text = "Dashboard";
            headingPanel.ResumeLayout(false);
            headingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel headingPanel;
        private TextBox searchTextBox;
        private Label headingLabel;
    }
}