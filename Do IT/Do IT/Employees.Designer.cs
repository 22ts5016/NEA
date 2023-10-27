namespace Do_IT
{
    partial class Employees
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
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.ViewEmployeeActionsButton = new System.Windows.Forms.Button();
            this.ResetPasswordButton = new System.Windows.Forms.Button();
            this.ViewEmployeeDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(1412, 759);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(160, 90);
            this.MainMenuButton.TabIndex = 1;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(889, 64);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(176, 116);
            this.AddEmployeeButton.TabIndex = 2;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Visible = false;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // ViewEmployeeActionsButton
            // 
            this.ViewEmployeeActionsButton.Location = new System.Drawing.Point(91, 64);
            this.ViewEmployeeActionsButton.Name = "ViewEmployeeActionsButton";
            this.ViewEmployeeActionsButton.Size = new System.Drawing.Size(176, 116);
            this.ViewEmployeeActionsButton.TabIndex = 3;
            this.ViewEmployeeActionsButton.Text = "View Employees Actions";
            this.ViewEmployeeActionsButton.UseVisualStyleBackColor = true;
            this.ViewEmployeeActionsButton.Click += new System.EventHandler(this.ViewEmployeeActionsButton_Click);
            // 
            // ResetPasswordButton
            // 
            this.ResetPasswordButton.Location = new System.Drawing.Point(371, 64);
            this.ResetPasswordButton.Name = "ResetPasswordButton";
            this.ResetPasswordButton.Size = new System.Drawing.Size(176, 116);
            this.ResetPasswordButton.TabIndex = 4;
            this.ResetPasswordButton.Text = "Reset Password";
            this.ResetPasswordButton.UseVisualStyleBackColor = true;
            this.ResetPasswordButton.Visible = false;
            this.ResetPasswordButton.Click += new System.EventHandler(this.ResetPasswordButton_Click);
            // 
            // ViewEmployeeDetailsButton
            // 
            this.ViewEmployeeDetailsButton.Location = new System.Drawing.Point(636, 64);
            this.ViewEmployeeDetailsButton.Name = "ViewEmployeeDetailsButton";
            this.ViewEmployeeDetailsButton.Size = new System.Drawing.Size(176, 116);
            this.ViewEmployeeDetailsButton.TabIndex = 5;
            this.ViewEmployeeDetailsButton.Text = "View Employees Details";
            this.ViewEmployeeDetailsButton.UseVisualStyleBackColor = true;
            this.ViewEmployeeDetailsButton.Visible = false;
            this.ViewEmployeeDetailsButton.Click += new System.EventHandler(this.ViewEmployeeDetailsButton_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.ViewEmployeeDetailsButton);
            this.Controls.Add(this.ResetPasswordButton);
            this.Controls.Add(this.ViewEmployeeActionsButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button ViewEmployeeActionsButton;
        private System.Windows.Forms.Button ResetPasswordButton;
        private System.Windows.Forms.Button ViewEmployeeDetailsButton;
    }
}