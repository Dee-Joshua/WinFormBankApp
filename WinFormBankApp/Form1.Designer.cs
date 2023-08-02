namespace WinFormBankApp
{
    public partial class FormRegister
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtComPassword = new TextBox();
            label4 = new Label();
            checkBoxShowPassword = new CheckBox();
            signUp = new Button();
            label5 = new Label();
            label6 = new Label();
            txtMobile = new TextBox();
            label7 = new Label();
            txtFirstName = new TextBox();
            label8 = new Label();
            txtLastName = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 229);
            label2.Name = "label2";
            label2.Size = new Size(95, 17);
            label2.TabIndex = 1;
            label2.Text = "Email Address";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(33, 249);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(33, 305);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 285);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Cursor = Cursors.IBeam;
            txtComPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtComPassword.Location = new Point(33, 361);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.Size = new Size(216, 28);
            txtComPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 341);
            label4.Name = "label4";
            label4.Size = new Size(120, 17);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.FlatStyle = FlatStyle.Flat;
            checkBoxShowPassword.Location = new Point(129, 395);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(119, 21);
            checkBoxShowPassword.TabIndex = 7;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            // 
            // signUp
            // 
            signUp.BackColor = Color.FromArgb(116, 86, 174);
            signUp.Cursor = Cursors.Hand;
            signUp.FlatAppearance.BorderSize = 0;
            signUp.FlatStyle = FlatStyle.Flat;
            signUp.ForeColor = Color.White;
            signUp.Location = new Point(32, 433);
            signUp.Name = "signUp";
            signUp.Size = new Size(216, 35);
            signUp.TabIndex = 8;
            signUp.Text = "SIGNUP";
            signUp.UseVisualStyleBackColor = false;
            signUp.Click += signUp_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 484);
            label5.Name = "label5";
            label5.Size = new Size(165, 17);
            label5.TabIndex = 9;
            label5.Text = "Already have an account?";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(90, 502);
            label6.Name = "label6";
            label6.Size = new Size(97, 17);
            label6.TabIndex = 10;
            label6.Text = "Back to LOGIN";
            label6.Click += label6_Click;
            // 
            // txtMobile
            // 
            txtMobile.BackColor = Color.FromArgb(230, 231, 233);
            txtMobile.BorderStyle = BorderStyle.None;
            txtMobile.Cursor = Cursors.IBeam;
            txtMobile.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMobile.Location = new Point(33, 195);
            txtMobile.Multiline = true;
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(216, 28);
            txtMobile.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 175);
            label7.Name = "label7";
            label7.Size = new Size(101, 17);
            label7.TabIndex = 13;
            label7.Text = "Phone Number";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(230, 231, 233);
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Cursor = Cursors.IBeam;
            txtFirstName.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(33, 139);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(216, 28);
            txtFirstName.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 119);
            label8.Name = "label8";
            label8.Size = new Size(99, 17);
            label8.TabIndex = 11;
            label8.Text = "Other Name(s)";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(230, 231, 233);
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Cursor = Cursors.IBeam;
            txtLastName.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(32, 86);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(216, 28);
            txtLastName.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 66);
            label9.Name = "label9";
            label9.Size = new Size(62, 17);
            label9.TabIndex = 15;
            label9.Text = "Surname";
            label9.Click += label9_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 544);
            Controls.Add(txtLastName);
            Controls.Add(label9);
            Controls.Add(txtMobile);
            Controls.Add(label7);
            Controls.Add(txtFirstName);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(signUp);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(txtComPassword);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtComPassword;
        private Label label4;
        private CheckBox checkBoxShowPassword;
        private Button signUp;
        private Label label5;
        private Label label6;
        private TextBox txtMobile;
        private Label label7;
        private TextBox txtFirstName;
        private Label label8;
        private TextBox txtLastName;
        private Label label9;
    }
}