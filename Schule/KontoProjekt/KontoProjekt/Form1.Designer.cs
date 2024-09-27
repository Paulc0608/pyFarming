namespace KontoProjekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            passwordTextbox = new TextBox();
            label4 = new Label();
            vornameTextbox = new TextBox();
            nameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            anmeldenButton = new Button();
            label6 = new Label();
            abmeldenButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(passwordTextbox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(vornameTextbox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(40, 60);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1063, 242);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anmelden";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(124, 154);
            passwordTextbox.Margin = new Padding(4, 5, 4, 5);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(307, 31);
            passwordTextbox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 156);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            // 
            // vornameTextbox
            // 
            vornameTextbox.Location = new Point(124, 100);
            vornameTextbox.Margin = new Padding(4, 5, 4, 5);
            vornameTextbox.Name = "vornameTextbox";
            vornameTextbox.Size = new Size(307, 31);
            vornameTextbox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(124, 43);
            nameTextBox.Margin = new Padding(4, 5, 4, 5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(307, 31);
            nameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Vorname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(471, 9);
            label5.Name = "label5";
            label5.Size = new Size(149, 54);
            label5.TabIndex = 4;
            label5.Text = "Konten";
            // 
            // anmeldenButton
            // 
            anmeldenButton.Location = new Point(471, 362);
            anmeldenButton.Margin = new Padding(4, 5, 4, 5);
            anmeldenButton.Name = "anmeldenButton";
            anmeldenButton.Size = new Size(107, 38);
            anmeldenButton.TabIndex = 2;
            anmeldenButton.Text = "Anmelden";
            anmeldenButton.UseVisualStyleBackColor = true;
            anmeldenButton.Click += anmeldenButton_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 16);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 5;
            // 
            // abmeldenButton
            // 
            abmeldenButton.Location = new Point(991, 18);
            abmeldenButton.Name = "abmeldenButton";
            abmeldenButton.Size = new Size(112, 34);
            abmeldenButton.TabIndex = 6;
            abmeldenButton.Text = "Abmelden";
            abmeldenButton.UseVisualStyleBackColor = true;
            abmeldenButton.Click += abmeldenButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(abmeldenButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(anmeldenButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox passwordTextbox;
        private Label label4;
        private TextBox vornameTextbox;
        private TextBox nameTextBox;
        private Label label2;
        private Label label1;
        private Button anmeldenButton;
        private Label label5;
        private Label label6;
        private Button abmeldenButton;
    }
}