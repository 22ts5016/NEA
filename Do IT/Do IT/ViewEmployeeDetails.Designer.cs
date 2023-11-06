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
            this.MainTable.Location = new System.Drawing.Point(71, 198);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.Size = new System.Drawing.Size(1299, 80);
            this.MainTable.TabIndex = 17;
            // 
            // ViewEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.MainTable);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "ViewEmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmployeeDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TableLayoutPanel MainTable;
    }
}