namespace UserManagementSystem
{
    partial class loginForm
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
            this.addUserLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUserLabel
            // 
            this.addUserLabel.AutoSize = true;
            this.addUserLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addUserLabel.Location = new System.Drawing.Point(31, 44);
            this.addUserLabel.Name = "addUserLabel";
            this.addUserLabel.Size = new System.Drawing.Size(79, 21);
            this.addUserLabel.TabIndex = 0;
            this.addUserLabel.Text = "Add User";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(31, 75);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(60, 15);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(31, 133);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(31, 93);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(154, 23);
            this.usernameField.TabIndex = 3;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(31, 151);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(154, 23);
            this.passwordField.TabIndex = 4;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(31, 190);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(100, 23);
            this.addUserButton.TabIndex = 5;
            this.addUserButton.Text = "Add New User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 408);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.addUserLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "loginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label addUserLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameField;
        private TextBox passwordField;
        private Button addUserButton;
    }
}