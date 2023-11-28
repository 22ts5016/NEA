namespace Do_IT
{
    partial class ViewCustomer
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
            this.CustomerDetailsHeaderTable = new System.Windows.Forms.TableLayoutPanel();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.SearchByComboBox = new System.Windows.Forms.ComboBox();
            this.SearchByTextBoxHeaderLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MainLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateCustomerAccountButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
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
            // CustomerDetailsHeaderTable
            // 
            this.CustomerDetailsHeaderTable.ColumnCount = 8;
            this.CustomerDetailsHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.CustomerDetailsHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.CustomerDetailsHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.CustomerDetailsHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.CustomerDetailsHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.CustomerDetailsHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CustomerDetailsHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CustomerDetailsHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.CustomerDetailsHeaderTable.Location = new System.Drawing.Point(69, 175);
            this.CustomerDetailsHeaderTable.Name = "CustomerDetailsHeaderTable";
            this.CustomerDetailsHeaderTable.RowCount = 1;
            this.CustomerDetailsHeaderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.CustomerDetailsHeaderTable.Size = new System.Drawing.Size(1100, 50);
            this.CustomerDetailsHeaderTable.TabIndex = 3;
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Location = new System.Drawing.Point(66, 52);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(59, 13);
            this.SearchByLabel.TabIndex = 4;
            this.SearchByLabel.Text = "Search By:";
            // 
            // SearchByComboBox
            // 
            this.SearchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchByComboBox.FormattingEnabled = true;
            this.SearchByComboBox.Location = new System.Drawing.Point(141, 49);
            this.SearchByComboBox.Name = "SearchByComboBox";
            this.SearchByComboBox.Size = new System.Drawing.Size(152, 21);
            this.SearchByComboBox.TabIndex = 5;
            this.SearchByComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchByComboBox_SelectedIndexChanged);
            // 
            // SearchByTextBoxHeaderLabel
            // 
            this.SearchByTextBoxHeaderLabel.AutoSize = true;
            this.SearchByTextBoxHeaderLabel.Location = new System.Drawing.Point(66, 93);
            this.SearchByTextBoxHeaderLabel.Name = "SearchByTextBoxHeaderLabel";
            this.SearchByTextBoxHeaderLabel.Size = new System.Drawing.Size(149, 13);
            this.SearchByTextBoxHeaderLabel.TabIndex = 6;
            this.SearchByTextBoxHeaderLabel.Text = "Please enter the customer\'s ...";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(69, 127);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(224, 20);
            this.SearchTextBox.TabIndex = 7;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(308, 122);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(93, 29);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.AutoScroll = true;
            this.MainLayoutPanel.Location = new System.Drawing.Point(69, 249);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.Size = new System.Drawing.Size(1325, 600);
            this.MainLayoutPanel.TabIndex = 10;
            // 
            // CreateCustomerAccountButton
            // 
            this.CreateCustomerAccountButton.Location = new System.Drawing.Point(1412, 663);
            this.CreateCustomerAccountButton.Name = "CreateCustomerAccountButton";
            this.CreateCustomerAccountButton.Size = new System.Drawing.Size(160, 90);
            this.CreateCustomerAccountButton.TabIndex = 11;
            this.CreateCustomerAccountButton.Text = "Create A New Customer Account";
            this.CreateCustomerAccountButton.UseVisualStyleBackColor = true;
            this.CreateCustomerAccountButton.Click += new System.EventHandler(this.CreateCustomerAccountButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(416, 122);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(93, 29);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CreateCustomerAccountButton);
            this.Controls.Add(this.MainLayoutPanel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchByTextBoxHeaderLabel);
            this.Controls.Add(this.SearchByComboBox);
            this.Controls.Add(this.SearchByLabel);
            this.Controls.Add(this.CustomerDetailsHeaderTable);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "ViewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCustomer";
            this.Load += new System.EventHandler(this.ViewCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.TableLayoutPanel CustomerDetailsHeaderTable;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.ComboBox SearchByComboBox;
        private System.Windows.Forms.Label SearchByTextBoxHeaderLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.FlowLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.Button CreateCustomerAccountButton;
        private System.Windows.Forms.Button ResetButton;
    }
}