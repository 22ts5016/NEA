namespace Do_IT
{
    partial class ViewEmployeeActions
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
            this.SearchForLabel = new System.Windows.Forms.Label();
            this.SearchByComboBox = new System.Windows.Forms.ComboBox();
            this.MainLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderHeadersTable = new System.Windows.Forms.TableLayoutPanel();
            this.ActionHeaderLabel = new System.Windows.Forms.Label();
            this.ActionTypeHeaderLabel = new System.Windows.Forms.Label();
            this.SurnameHeaderLabel = new System.Windows.Forms.Label();
            this.ForenameHeaderLabel = new System.Windows.Forms.Label();
            this.EmployeeIDHeaderLabel = new System.Windows.Forms.Label();
            this.SpecificComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.OrderHeadersTable.SuspendLayout();
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
            // SearchForLabel
            // 
            this.SearchForLabel.AutoSize = true;
            this.SearchForLabel.Location = new System.Drawing.Point(74, 39);
            this.SearchForLabel.Name = "SearchForLabel";
            this.SearchForLabel.Size = new System.Drawing.Size(58, 13);
            this.SearchForLabel.TabIndex = 3;
            this.SearchForLabel.Text = "Search by:";
            // 
            // SearchByComboBox
            // 
            this.SearchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchByComboBox.FormattingEnabled = true;
            this.SearchByComboBox.Items.AddRange(new object[] {
            "Any",
            "Employee",
            "Type of Action"});
            this.SearchByComboBox.Location = new System.Drawing.Point(149, 36);
            this.SearchByComboBox.Name = "SearchByComboBox";
            this.SearchByComboBox.Size = new System.Drawing.Size(114, 21);
            this.SearchByComboBox.TabIndex = 4;
            this.SearchByComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.AutoScroll = true;
            this.MainLayoutPanel.Location = new System.Drawing.Point(93, 196);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.Size = new System.Drawing.Size(1300, 545);
            this.MainLayoutPanel.TabIndex = 5;
            // 
            // OrderHeadersTable
            // 
            this.OrderHeadersTable.ColumnCount = 5;
            this.OrderHeadersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.OrderHeadersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.OrderHeadersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.OrderHeadersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.OrderHeadersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.OrderHeadersTable.Controls.Add(this.ActionHeaderLabel, 4, 0);
            this.OrderHeadersTable.Controls.Add(this.ActionTypeHeaderLabel, 3, 0);
            this.OrderHeadersTable.Controls.Add(this.SurnameHeaderLabel, 1, 0);
            this.OrderHeadersTable.Controls.Add(this.ForenameHeaderLabel, 0, 0);
            this.OrderHeadersTable.Controls.Add(this.EmployeeIDHeaderLabel, 2, 0);
            this.OrderHeadersTable.Location = new System.Drawing.Point(93, 149);
            this.OrderHeadersTable.Name = "OrderHeadersTable";
            this.OrderHeadersTable.RowCount = 1;
            this.OrderHeadersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderHeadersTable.Size = new System.Drawing.Size(1280, 28);
            this.OrderHeadersTable.TabIndex = 13;
            // 
            // ActionHeaderLabel
            // 
            this.ActionHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ActionHeaderLabel.AutoSize = true;
            this.ActionHeaderLabel.Location = new System.Drawing.Point(1021, 0);
            this.ActionHeaderLabel.Name = "ActionHeaderLabel";
            this.ActionHeaderLabel.Size = new System.Drawing.Size(37, 13);
            this.ActionHeaderLabel.TabIndex = 4;
            this.ActionHeaderLabel.Text = "Action";
            // 
            // ActionTypeHeaderLabel
            // 
            this.ActionTypeHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ActionTypeHeaderLabel.AutoSize = true;
            this.ActionTypeHeaderLabel.Location = new System.Drawing.Point(668, 0);
            this.ActionTypeHeaderLabel.Name = "ActionTypeHeaderLabel";
            this.ActionTypeHeaderLabel.Size = new System.Drawing.Size(64, 13);
            this.ActionTypeHeaderLabel.TabIndex = 3;
            this.ActionTypeHeaderLabel.Text = "Action Type";
            // 
            // SurnameHeaderLabel
            // 
            this.SurnameHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SurnameHeaderLabel.AutoSize = true;
            this.SurnameHeaderLabel.Location = new System.Drawing.Point(275, 0);
            this.SurnameHeaderLabel.Name = "SurnameHeaderLabel";
            this.SurnameHeaderLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameHeaderLabel.TabIndex = 1;
            this.SurnameHeaderLabel.Text = "Surname";
            // 
            // ForenameHeaderLabel
            // 
            this.ForenameHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ForenameHeaderLabel.AutoSize = true;
            this.ForenameHeaderLabel.Location = new System.Drawing.Point(73, 0);
            this.ForenameHeaderLabel.Name = "ForenameHeaderLabel";
            this.ForenameHeaderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ForenameHeaderLabel.Size = new System.Drawing.Size(54, 13);
            this.ForenameHeaderLabel.TabIndex = 0;
            this.ForenameHeaderLabel.Text = "Forename";
            // 
            // EmployeeIDHeaderLabel
            // 
            this.EmployeeIDHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmployeeIDHeaderLabel.AutoSize = true;
            this.EmployeeIDHeaderLabel.Location = new System.Drawing.Point(466, 0);
            this.EmployeeIDHeaderLabel.Name = "EmployeeIDHeaderLabel";
            this.EmployeeIDHeaderLabel.Size = new System.Drawing.Size(67, 13);
            this.EmployeeIDHeaderLabel.TabIndex = 2;
            this.EmployeeIDHeaderLabel.Text = "Employee ID";
            // 
            // SpecificComboBox
            // 
            this.SpecificComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecificComboBox.FormattingEnabled = true;
            this.SpecificComboBox.Location = new System.Drawing.Point(149, 83);
            this.SpecificComboBox.Name = "SpecificComboBox";
            this.SpecificComboBox.Size = new System.Drawing.Size(171, 21);
            this.SpecificComboBox.TabIndex = 14;
            this.SpecificComboBox.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(406, 31);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(93, 29);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ViewEmployeeActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SpecificComboBox);
            this.Controls.Add(this.OrderHeadersTable);
            this.Controls.Add(this.MainLayoutPanel);
            this.Controls.Add(this.SearchByComboBox);
            this.Controls.Add(this.SearchForLabel);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "ViewEmployeeActions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Employee Actions";
            this.OrderHeadersTable.ResumeLayout(false);
            this.OrderHeadersTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label SearchForLabel;
        private System.Windows.Forms.ComboBox SearchByComboBox;
        private System.Windows.Forms.FlowLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel OrderHeadersTable;
        private System.Windows.Forms.Label ActionHeaderLabel;
        private System.Windows.Forms.Label ActionTypeHeaderLabel;
        private System.Windows.Forms.Label SurnameHeaderLabel;
        private System.Windows.Forms.Label ForenameHeaderLabel;
        private System.Windows.Forms.Label EmployeeIDHeaderLabel;
        private System.Windows.Forms.ComboBox SpecificComboBox;
        private System.Windows.Forms.Button SearchButton;
    }
}