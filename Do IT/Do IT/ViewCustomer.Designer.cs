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
            this.CustomerDetailsTable = new System.Windows.Forms.TableLayoutPanel();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.SearchByComboBox = new System.Windows.Forms.ComboBox();
            this.SearchByTextBoxHeaderLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MainLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            // CustomerDetailsTable
            // 
            this.CustomerDetailsTable.ColumnCount = 8;
            this.CustomerDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.CustomerDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.CustomerDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.CustomerDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.CustomerDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.CustomerDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CustomerDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CustomerDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.CustomerDetailsTable.Location = new System.Drawing.Point(69, 175);
            this.CustomerDetailsTable.Name = "CustomerDetailsTable";
            this.CustomerDetailsTable.RowCount = 1;
            this.CustomerDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.CustomerDetailsTable.Size = new System.Drawing.Size(1200, 50);
            this.CustomerDetailsTable.TabIndex = 3;
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
            this.MainLayoutPanel.Location = new System.Drawing.Point(69, 249);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.Size = new System.Drawing.Size(1300, 600);
            this.MainLayoutPanel.TabIndex = 10;
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.MainLayoutPanel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchByTextBoxHeaderLabel);
            this.Controls.Add(this.SearchByComboBox);
            this.Controls.Add(this.SearchByLabel);
            this.Controls.Add(this.CustomerDetailsTable);
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
        private System.Windows.Forms.TableLayoutPanel CustomerDetailsTable;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.ComboBox SearchByComboBox;
        private System.Windows.Forms.Label SearchByTextBoxHeaderLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.FlowLayoutPanel MainLayoutPanel;
    }
}