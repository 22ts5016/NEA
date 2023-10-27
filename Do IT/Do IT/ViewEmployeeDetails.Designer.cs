namespace Do_IT
{
    partial class ViewEmployeeDetails
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeeIDHeaderLabel = new System.Windows.Forms.Label();
            this.ForenameHeaderLabel = new System.Windows.Forms.Label();
            this.SurnameHeaderLabel = new System.Windows.Forms.Label();
            this.RoleHeaderLabel = new System.Windows.Forms.Label();
            this.DepartmentHeaderLabel = new System.Windows.Forms.Label();
            this.UsernameHeaderLabel = new System.Windows.Forms.Label();
            this.PasswordHeaderLabel = new System.Windows.Forms.Label();
            this.MainTable.SuspendLayout();
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
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(71, 79);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(222, 20);
            this.InputTextBox.TabIndex = 6;
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Location = new System.Drawing.Point(68, 51);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(516, 13);
            this.ConfirmLabel.TabIndex = 5;
            this.ConfirmLabel.Text = "Please enter the employee number or the username of the employee that you would l" +
    "ike to see the details of:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(71, 121);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(93, 29);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 7;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MainTable.Controls.Add(this.PasswordHeaderLabel, 6, 0);
            this.MainTable.Controls.Add(this.UsernameHeaderLabel, 5, 0);
            this.MainTable.Controls.Add(this.DepartmentHeaderLabel, 4, 0);
            this.MainTable.Controls.Add(this.RoleHeaderLabel, 3, 0);
            this.MainTable.Controls.Add(this.SurnameHeaderLabel, 2, 0);
            this.MainTable.Controls.Add(this.ForenameHeaderLabel, 1, 0);
            this.MainTable.Controls.Add(this.EmployeeIDHeaderLabel, 0, 0);
            this.MainTable.Location = new System.Drawing.Point(71, 198);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.Size = new System.Drawing.Size(1299, 80);
            this.MainTable.TabIndex = 17;
            // 
            // EmployeeIDHeaderLabel
            // 
            this.EmployeeIDHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmployeeIDHeaderLabel.AutoSize = true;
            this.EmployeeIDHeaderLabel.Location = new System.Drawing.Point(55, 0);
            this.EmployeeIDHeaderLabel.Name = "EmployeeIDHeaderLabel";
            this.EmployeeIDHeaderLabel.Size = new System.Drawing.Size(64, 13);
            this.EmployeeIDHeaderLabel.TabIndex = 0;
            this.EmployeeIDHeaderLabel.Text = "EmployeeID";
            // 
            // ForenameHeaderLabel
            // 
            this.ForenameHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ForenameHeaderLabel.AutoSize = true;
            this.ForenameHeaderLabel.Location = new System.Drawing.Point(248, 0);
            this.ForenameHeaderLabel.Name = "ForenameHeaderLabel";
            this.ForenameHeaderLabel.Size = new System.Drawing.Size(54, 13);
            this.ForenameHeaderLabel.TabIndex = 1;
            this.ForenameHeaderLabel.Text = "Forename";
            // 
            // SurnameHeaderLabel
            // 
            this.SurnameHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SurnameHeaderLabel.AutoSize = true;
            this.SurnameHeaderLabel.Location = new System.Drawing.Point(450, 0);
            this.SurnameHeaderLabel.Name = "SurnameHeaderLabel";
            this.SurnameHeaderLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameHeaderLabel.TabIndex = 2;
            this.SurnameHeaderLabel.Text = "Surname";
            // 
            // RoleHeaderLabel
            // 
            this.RoleHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RoleHeaderLabel.AutoSize = true;
            this.RoleHeaderLabel.Location = new System.Drawing.Point(648, 0);
            this.RoleHeaderLabel.Name = "RoleHeaderLabel";
            this.RoleHeaderLabel.Size = new System.Drawing.Size(29, 13);
            this.RoleHeaderLabel.TabIndex = 3;
            this.RoleHeaderLabel.Text = "Role";
            // 
            // DepartmentHeaderLabel
            // 
            this.DepartmentHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DepartmentHeaderLabel.AutoSize = true;
            this.DepartmentHeaderLabel.Location = new System.Drawing.Point(794, 0);
            this.DepartmentHeaderLabel.Name = "DepartmentHeaderLabel";
            this.DepartmentHeaderLabel.Size = new System.Drawing.Size(62, 13);
            this.DepartmentHeaderLabel.TabIndex = 4;
            this.DepartmentHeaderLabel.Text = "Department";
            // 
            // UsernameHeaderLabel
            // 
            this.UsernameHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UsernameHeaderLabel.AutoSize = true;
            this.UsernameHeaderLabel.Location = new System.Drawing.Point(972, 0);
            this.UsernameHeaderLabel.Name = "UsernameHeaderLabel";
            this.UsernameHeaderLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameHeaderLabel.TabIndex = 5;
            this.UsernameHeaderLabel.Text = "Username";
            // 
            // PasswordHeaderLabel
            // 
            this.PasswordHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordHeaderLabel.AutoSize = true;
            this.PasswordHeaderLabel.Location = new System.Drawing.Point(1173, 0);
            this.PasswordHeaderLabel.Name = "PasswordHeaderLabel";
            this.PasswordHeaderLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordHeaderLabel.TabIndex = 6;
            this.PasswordHeaderLabel.Text = "Password";
            // 
            // ViewEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.MainTable);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "ViewEmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmployeeDetails";
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Label PasswordHeaderLabel;
        private System.Windows.Forms.Label UsernameHeaderLabel;
        private System.Windows.Forms.Label DepartmentHeaderLabel;
        private System.Windows.Forms.Label RoleHeaderLabel;
        private System.Windows.Forms.Label SurnameHeaderLabel;
        private System.Windows.Forms.Label ForenameHeaderLabel;
        private System.Windows.Forms.Label EmployeeIDHeaderLabel;
    }
}