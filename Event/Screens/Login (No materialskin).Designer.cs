namespace Event.Screens
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(250, 200);
            label1.Name = "label1";
            label1.Size = new Size(715, 41);
            label1.TabIndex = 0;
            label1.Text = "Find Your Time, Find Your Team: Play on Demand!";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MintCream;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(333, 273);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 348);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 55);
            label2.Name = "label2";
            label2.Size = new Size(63, 30);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 155);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(73, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 35);
            textBox1.TabIndex = 2;
            textBox1.Text = "Enter your email address";
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(73, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(414, 35);
            textBox2.TabIndex = 3;
            textBox2.Text = "Enter your password";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(217, 277);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 4;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.meric_tuna_Gy5v76fswgo_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1205, 793);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
    }
}