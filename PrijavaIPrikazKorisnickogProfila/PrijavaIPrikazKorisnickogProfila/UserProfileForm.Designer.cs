namespace PrijavaIPrikazKorisnickogProfila
{
    partial class UserProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.administratorRadioButton = new System.Windows.Forms.RadioButton();
            this.guestRadioButton = new System.Windows.Forms.RadioButton();
            this.employeeRadioButton = new System.Windows.Forms.RadioButton();
            this.logOutButton = new System.Windows.Forms.Button();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "lastname";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employeeRadioButton);
            this.groupBox1.Controls.Add(this.guestRadioButton);
            this.groupBox1.Controls.Add(this.administratorRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(188, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Type";
            // 
            // administratorRadioButton
            // 
            this.administratorRadioButton.AutoSize = true;
            this.administratorRadioButton.Enabled = false;
            this.administratorRadioButton.Location = new System.Drawing.Point(20, 37);
            this.administratorRadioButton.Name = "administratorRadioButton";
            this.administratorRadioButton.Size = new System.Drawing.Size(85, 17);
            this.administratorRadioButton.TabIndex = 0;
            this.administratorRadioButton.TabStop = true;
            this.administratorRadioButton.Text = "Administrator";
            this.administratorRadioButton.UseVisualStyleBackColor = true;
            // 
            // guestRadioButton
            // 
            this.guestRadioButton.AutoSize = true;
            this.guestRadioButton.Enabled = false;
            this.guestRadioButton.Location = new System.Drawing.Point(20, 61);
            this.guestRadioButton.Name = "guestRadioButton";
            this.guestRadioButton.Size = new System.Drawing.Size(53, 17);
            this.guestRadioButton.TabIndex = 1;
            this.guestRadioButton.TabStop = true;
            this.guestRadioButton.Text = "Guest";
            this.guestRadioButton.UseVisualStyleBackColor = true;
            // 
            // employeeRadioButton
            // 
            this.employeeRadioButton.AutoSize = true;
            this.employeeRadioButton.Enabled = false;
            this.employeeRadioButton.Location = new System.Drawing.Point(20, 85);
            this.employeeRadioButton.Name = "employeeRadioButton";
            this.employeeRadioButton.Size = new System.Drawing.Size(71, 17);
            this.employeeRadioButton.TabIndex = 2;
            this.employeeRadioButton.TabStop = true;
            this.employeeRadioButton.Text = "Employee";
            this.employeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(188, 326);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(132, 30);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(141, 51);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.ReadOnly = true;
            this.firstnameTextBox.Size = new System.Drawing.Size(120, 20);
            this.firstnameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(141, 78);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(141, 143);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.userNameTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(141, 171);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(120, 20);
            this.passwordTextBox.TabIndex = 9;
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 368);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserProfileForm";
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.UserProfileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton employeeRadioButton;
        private System.Windows.Forms.RadioButton guestRadioButton;
        private System.Windows.Forms.RadioButton administratorRadioButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        public System.Windows.Forms.TextBox lastNameTextBox;
    }
}