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
            sideMenuBar = new FlowLayoutPanel();
            menuBar = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            panel7 = new Panel();
            button6 = new Button();
            timerForSidebar = new System.Windows.Forms.Timer(components);
            sideMenuBar.SuspendLayout();
            menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // sideMenuBar
            // 
            sideMenuBar.BackColor = Color.DarkSeaGreen;
            sideMenuBar.Controls.Add(menuBar);
            sideMenuBar.Controls.Add(panel2);
            sideMenuBar.Controls.Add(panel3);
            sideMenuBar.Controls.Add(panel4);
            sideMenuBar.Controls.Add(panel5);
            sideMenuBar.Controls.Add(panel6);
            sideMenuBar.Controls.Add(panel7);
            sideMenuBar.Dock = DockStyle.Left;
            sideMenuBar.Location = new Point(0, 0);
            sideMenuBar.MaximumSize = new Size(330, 879);
            sideMenuBar.MinimumSize = new Size(89, 879);
            sideMenuBar.Name = "sideMenuBar";
            sideMenuBar.Size = new Size(330, 879);
            sideMenuBar.TabIndex = 0;
            // 
            // menuBar
            // 
            menuBar.Controls.Add(label1);
            menuBar.Controls.Add(menuButton);
            menuBar.Location = new Point(3, 3);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(350, 146);
            menuBar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(147, 57);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 1;
            label1.Text = "Menu";
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
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 66);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.home;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-11, -12);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(376, 91);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 227);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 66);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.user;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-11, -12);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(376, 91);
            button2.TabIndex = 1;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 299);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 66);
            panel4.TabIndex = 3;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.calendar_pen;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-11, -12);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(376, 91);
            button3.TabIndex = 1;
            button3.Text = "Create New Event";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 371);
            panel5.Name = "panel5";
            panel5.Size = new Size(350, 66);
            panel5.TabIndex = 4;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = Properties.Resources.calendar_plus;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-11, -12);
            button4.Name = "button4";
            button4.Padding = new Padding(20, 0, 0, 0);
            button4.Size = new Size(376, 91);
            button4.TabIndex = 1;
            button4.Text = "My Created Event";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(3, 443);
            panel6.Name = "panel6";
            panel6.Size = new Size(350, 66);
            panel6.TabIndex = 5;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Image = Properties.Resources.calendar_check;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-11, -12);
            button5.Name = "button5";
            button5.Padding = new Padding(20, 0, 0, 0);
            button5.Size = new Size(376, 91);
            button5.TabIndex = 1;
            button5.Text = "My Joined Event";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(button6);
            panel7.Location = new Point(3, 515);
            panel7.Name = "panel7";
            panel7.Size = new Size(350, 66);
            panel7.TabIndex = 6;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-11, -12);
            button6.Name = "button6";
            button6.Padding = new Padding(20, 0, 0, 0);
            button6.Size = new Size(376, 91);
            button6.TabIndex = 1;
            button6.Text = "(Sub)";
            button6.UseVisualStyleBackColor = true;
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
            Controls.Add(sideMenuBar);
            Name = "TopPage";
            Text = "Top Page";
            sideMenuBar.ResumeLayout(false);
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sideMenuBar;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Button button5;
        private Panel panel7;
        private Button button6;
        private Label label1;
        private PictureBox menuButton;
        private System.Windows.Forms.Timer timerForSidebar;
        private Panel menuBar;
    }
}