namespace Do_IT
{
    partial class ResetPassword
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
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.RevealPaswordButton = new System.Windows.Forms.Button();
            this.RevealConfirmPasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(1412, 759);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(160, 90);
            this.MainMenuButton.TabIndex = 2;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Location = new System.Drawing.Point(66, 53);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(416, 13);
            this.ConfirmLabel.TabIndex = 3;
            this.ConfirmLabel.Text = "Please enter the username of the employee that you would like to reset the paswor" +
    "d of:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(69, 81);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(222, 20);
            this.UsernameTextBox.TabIndex = 4;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(66, 122);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(158, 13);
            this.NewPasswordLabel.TabIndex = 5;
            this.NewPasswordLabel.Text = "Please enter the new password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(69, 153);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(222, 20);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please confirm the new password:";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(69, 239);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(222, 20);
            this.ConfirmPasswordTextBox.TabIndex = 8;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(69, 311);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(151, 64);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // RevealPaswordButton
            // 
            this.RevealPaswordButton.Location = new System.Drawing.Point(323, 153);
            this.RevealPaswordButton.Name = "RevealPaswordButton";
            this.RevealPaswordButton.Size = new System.Drawing.Size(67, 20);
            this.RevealPaswordButton.TabIndex = 10;
            this.RevealPaswordButton.Text = "Reveal";
            this.RevealPaswordButton.UseVisualStyleBackColor = true;
            this.RevealPaswordButton.Click += new System.EventHandler(this.RevealPaswordButton_Click);
            // 
            // RevealConfirmPasswordButton
            // 
            this.RevealConfirmPasswordButton.Location = new System.Drawing.Point(323, 239);
            this.RevealConfirmPasswordButton.Name = "RevealConfirmPasswordButton";
            this.RevealConfirmPasswordButton.Size = new System.Drawing.Size(67, 20);
            this.RevealConfirmPasswordButton.TabIndex = 11;
            this.RevealConfirmPasswordButton.Text = "Reveal";
            this.RevealConfirmPasswordButton.UseVisualStyleBackColor = true;
            this.RevealConfirmPasswordButton.Click += new System.EventHandler(this.RevealConfirmPasswordButton_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.RevealConfirmPasswordButton);
            this.Controls.Add(this.RevealPaswordButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button RevealPaswordButton;
        private System.Windows.Forms.Button RevealConfirmPasswordButton;
    }
}