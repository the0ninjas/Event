namespace EventManagementSystem.Screens
{
    partial class SignUp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.000001F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(212, 103);
            label1.Name = "label1";
            label1.Size = new Size(158, 48);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(201, 180);
            label2.Name = "label2";
            label2.Size = new Size(544, 38);
            label2.TabIndex = 1;
            label2.Text = "Register now and play your way, today!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(212, 288);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(212, 388);
            label4.Name = "label4";
            label4.Size = new Size(130, 32);
            label4.TabIndex = 3;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(212, 488);
            label5.Name = "label5";
            label5.Size = new Size(72, 32);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(212, 588);
            label6.Name = "label6";
            label6.Size = new Size(179, 32);
            label6.TabIndex = 5;
            label6.Text = "Phone Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(212, 688);
            label7.Name = "label7";
            label7.Size = new Size(107, 32);
            label7.TabIndex = 6;
            label7.Text = "Location";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(212, 788);
            label8.Name = "label8";
            label8.Size = new Size(115, 32);
            label8.TabIndex = 7;
            label8.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(212, 338);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(521, 35);
            textBox1.TabIndex = 8;
            textBox1.Text = "Enter your first name";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(212, 438);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(521, 35);
            textBox2.TabIndex = 9;
            textBox2.Text = "Enter your last name";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(212, 538);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(521, 35);
            textBox3.TabIndex = 10;
            textBox3.Text = "Enter your email address";
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // textBox4
            // 
            textBox4.ForeColor = SystemColors.ScrollBar;
            textBox4.Location = new Point(212, 638);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(521, 35);
            textBox4.TabIndex = 11;
            textBox4.Text = "Enter your phone number";
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // textBox5
            // 
            textBox5.AutoCompleteCustomSource.AddRange(new string[] { "Sydney", "Melbourne", "Brisbane", "Perth", "Adelaide", "Canberra", "Hobart", "Darwin" });
            textBox5.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox5.ForeColor = SystemColors.ScrollBar;
            textBox5.Location = new Point(212, 738);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(521, 35);
            textBox5.TabIndex = 12;
            textBox5.Text = "Select your location";
            textBox5.Enter += textBox5_Enter;
            textBox5.Leave += textBox5_Leave;
            // 
            // textBox6
            // 
            textBox6.ForeColor = SystemColors.ScrollBar;
            textBox6.Location = new Point(212, 838);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(521, 35);
            textBox6.TabIndex = 13;
            textBox6.Text = "Enter your password";
            textBox6.Enter += textBox6_Enter;
            textBox6.Leave += textBox6_Leave;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(212, 938);
            button1.Name = "button1";
            button1.Size = new Size(521, 40);
            button1.TabIndex = 14;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LavenderBlush;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(212, 1000);
            button2.Name = "button2";
            button2.Size = new Size(521, 40);
            button2.TabIndex = 15;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(956, 1126);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
    }
}