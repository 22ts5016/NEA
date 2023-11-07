namespace Do_IT
{
    partial class CreateOrder
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
            this.MainLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductQueryButton = new System.Windows.Forms.Button();
            this.DetailsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EmailTitleLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTitleLabel = new System.Windows.Forms.Label();
            this.PostcodeTitleLabel = new System.Windows.Forms.Label();
            this.AddressTitleLabel = new System.Windows.Forms.Label();
            this.SurnameTitleLabel = new System.Windows.Forms.Label();
            this.TtitleTitleLabel = new System.Windows.Forms.Label();
            this.CustomerNumberTitleLabel = new System.Windows.Forms.Label();
            this.ForenameTitelLabel = new System.Windows.Forms.Label();
            this.OrderTypeLabel = new System.Windows.Forms.Label();
            this.SelectCustomerButton = new System.Windows.Forms.Button();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.TotalProductCountLabel = new System.Windows.Forms.Label();
            this.SubmitOrderButton = new System.Windows.Forms.Button();
            this.ClearOrderButton = new System.Windows.Forms.Button();
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.DetailsTableLayoutPanel.SuspendLayout();
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
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.AutoScroll = true;
            this.MainLayoutPanel.Location = new System.Drawing.Point(71, 199);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.Size = new System.Drawing.Size(1325, 650);
            this.MainLayoutPanel.TabIndex = 3;
            // 
            // ProductQueryButton
            // 
            this.ProductQueryButton.Location = new System.Drawing.Point(1412, 663);
            this.ProductQueryButton.Name = "ProductQueryButton";
            this.ProductQueryButton.Size = new System.Drawing.Size(160, 90);
            this.ProductQueryButton.TabIndex = 4;
            this.ProductQueryButton.Text = "Add Items To Order";
            this.ProductQueryButton.UseVisualStyleBackColor = true;
            this.ProductQueryButton.Click += new System.EventHandler(this.ProductQueryButton_Click);
            // 
            // DetailsTableLayoutPanel
            // 
            this.DetailsTableLayoutPanel.ColumnCount = 9;
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.DetailsTableLayoutPanel.Controls.Add(this.EmailTitleLabel, 7, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.PhoneNumberTitleLabel, 6, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.PostcodeTitleLabel, 5, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.AddressTitleLabel, 4, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.SurnameTitleLabel, 3, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.TtitleTitleLabel, 1, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.CustomerNumberTitleLabel, 0, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.ForenameTitelLabel, 2, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.OrderTypeLabel, 8, 0);
            this.DetailsTableLayoutPanel.Location = new System.Drawing.Point(71, 73);
            this.DetailsTableLayoutPanel.Name = "DetailsTableLayoutPanel";
            this.DetailsTableLayoutPanel.RowCount = 2;
            this.DetailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DetailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DetailsTableLayoutPanel.Size = new System.Drawing.Size(1250, 100);
            this.DetailsTableLayoutPanel.TabIndex = 11;
            // 
            // EmailTitleLabel
            // 
            this.EmailTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmailTitleLabel.AutoSize = true;
            this.EmailTitleLabel.Location = new System.Drawing.Point(963, 0);
            this.EmailTitleLabel.Name = "EmailTitleLabel";
            this.EmailTitleLabel.Size = new System.Drawing.Size(73, 13);
            this.EmailTitleLabel.TabIndex = 7;
            this.EmailTitleLabel.Text = "Email Address";
            // 
            // PhoneNumberTitleLabel
            // 
            this.PhoneNumberTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhoneNumberTitleLabel.AutoSize = true;
            this.PhoneNumberTitleLabel.Location = new System.Drawing.Point(811, 0);
            this.PhoneNumberTitleLabel.Name = "PhoneNumberTitleLabel";
            this.PhoneNumberTitleLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberTitleLabel.TabIndex = 6;
            this.PhoneNumberTitleLabel.Text = "Phone Number";
            // 
            // PostcodeTitleLabel
            // 
            this.PostcodeTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PostcodeTitleLabel.AutoSize = true;
            this.PostcodeTitleLabel.Location = new System.Drawing.Point(724, 0);
            this.PostcodeTitleLabel.Name = "PostcodeTitleLabel";
            this.PostcodeTitleLabel.Size = new System.Drawing.Size(52, 13);
            this.PostcodeTitleLabel.TabIndex = 5;
            this.PostcodeTitleLabel.Text = "Postcode";
            // 
            // AddressTitleLabel
            // 
            this.AddressTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddressTitleLabel.AutoSize = true;
            this.AddressTitleLabel.Location = new System.Drawing.Point(577, 0);
            this.AddressTitleLabel.Name = "AddressTitleLabel";
            this.AddressTitleLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressTitleLabel.TabIndex = 4;
            this.AddressTitleLabel.Text = "Address";
            // 
            // SurnameTitleLabel
            // 
            this.SurnameTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SurnameTitleLabel.AutoSize = true;
            this.SurnameTitleLabel.Location = new System.Drawing.Point(400, 0);
            this.SurnameTitleLabel.Name = "SurnameTitleLabel";
            this.SurnameTitleLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameTitleLabel.TabIndex = 3;
            this.SurnameTitleLabel.Text = "Surname";
            // 
            // TtitleTitleLabel
            // 
            this.TtitleTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TtitleTitleLabel.AutoSize = true;
            this.TtitleTitleLabel.Location = new System.Drawing.Point(161, 0);
            this.TtitleTitleLabel.Name = "TtitleTitleLabel";
            this.TtitleTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TtitleTitleLabel.TabIndex = 1;
            this.TtitleTitleLabel.Text = "Title";
            // 
            // CustomerNumberTitleLabel
            // 
            this.CustomerNumberTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CustomerNumberTitleLabel.AutoSize = true;
            this.CustomerNumberTitleLabel.Location = new System.Drawing.Point(29, 0);
            this.CustomerNumberTitleLabel.Name = "CustomerNumberTitleLabel";
            this.CustomerNumberTitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomerNumberTitleLabel.Size = new System.Drawing.Size(91, 13);
            this.CustomerNumberTitleLabel.TabIndex = 0;
            this.CustomerNumberTitleLabel.Text = "Customer Number";
            // 
            // ForenameTitelLabel
            // 
            this.ForenameTitelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ForenameTitelLabel.AutoSize = true;
            this.ForenameTitelLabel.Location = new System.Drawing.Point(248, 0);
            this.ForenameTitelLabel.Name = "ForenameTitelLabel";
            this.ForenameTitelLabel.Size = new System.Drawing.Size(54, 13);
            this.ForenameTitelLabel.TabIndex = 2;
            this.ForenameTitelLabel.Text = "Forename";
            // 
            // OrderTypeLabel
            // 
            this.OrderTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrderTypeLabel.AutoSize = true;
            this.OrderTypeLabel.Location = new System.Drawing.Point(1145, 0);
            this.OrderTypeLabel.Name = "OrderTypeLabel";
            this.OrderTypeLabel.Size = new System.Drawing.Size(60, 13);
            this.OrderTypeLabel.TabIndex = 8;
            this.OrderTypeLabel.Text = "Order Type";
            // 
            // SelectCustomerButton
            // 
            this.SelectCustomerButton.Location = new System.Drawing.Point(1412, 144);
            this.SelectCustomerButton.Name = "SelectCustomerButton";
            this.SelectCustomerButton.Size = new System.Drawing.Size(126, 29);
            this.SelectCustomerButton.TabIndex = 12;
            this.SelectCustomerButton.Text = "Select Customer";
            this.SelectCustomerButton.UseVisualStyleBackColor = true;
            this.SelectCustomerButton.Click += new System.EventHandler(this.SelectCustomerButton_Click);
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(1409, 614);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(67, 13);
            this.TotalCostLabel.TabIndex = 14;
            this.TotalCostLabel.Text = "Total Cost: £";
            // 
            // TotalProductCountLabel
            // 
            this.TotalProductCountLabel.AutoSize = true;
            this.TotalProductCountLabel.Location = new System.Drawing.Point(1409, 637);
            this.TotalProductCountLabel.Name = "TotalProductCountLabel";
            this.TotalProductCountLabel.Size = new System.Drawing.Size(108, 13);
            this.TotalProductCountLabel.TabIndex = 15;
            this.TotalProductCountLabel.Text = "Total Product Count: \r\n";
            // 
            // SubmitOrderButton
            // 
            this.SubmitOrderButton.Location = new System.Drawing.Point(1412, 225);
            this.SubmitOrderButton.Name = "SubmitOrderButton";
            this.SubmitOrderButton.Size = new System.Drawing.Size(126, 29);
            this.SubmitOrderButton.TabIndex = 16;
            this.SubmitOrderButton.Text = "Submit Order";
            this.SubmitOrderButton.UseVisualStyleBackColor = true;
            this.SubmitOrderButton.Click += new System.EventHandler(this.SubmitOrderButton_Click);
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.Location = new System.Drawing.Point(1412, 296);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(126, 29);
            this.ClearOrderButton.TabIndex = 17;
            this.ClearOrderButton.Text = "Clear Order";
            this.ClearOrderButton.UseVisualStyleBackColor = true;
            this.ClearOrderButton.Click += new System.EventHandler(this.ClearOrderButton_Click);
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.AutoSize = true;
            this.OrderIDLabel.Location = new System.Drawing.Point(1409, 73);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(50, 13);
            this.OrderIDLabel.TabIndex = 18;
            this.OrderIDLabel.Text = "OrderID: ";
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.OrderIDLabel);
            this.Controls.Add(this.ClearOrderButton);
            this.Controls.Add(this.SubmitOrderButton);
            this.Controls.Add(this.TotalProductCountLabel);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.SelectCustomerButton);
            this.Controls.Add(this.DetailsTableLayoutPanel);
            this.Controls.Add(this.ProductQueryButton);
            this.Controls.Add(this.MainLayoutPanel);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "CreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateOrder";
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            this.DetailsTableLayoutPanel.ResumeLayout(false);
            this.DetailsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.FlowLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.Button ProductQueryButton;
        private System.Windows.Forms.Label EmailTitleLabel;
        private System.Windows.Forms.Label PhoneNumberTitleLabel;
        private System.Windows.Forms.Label PostcodeTitleLabel;
        private System.Windows.Forms.Label AddressTitleLabel;
        private System.Windows.Forms.Label SurnameTitleLabel;
        private System.Windows.Forms.Label TtitleTitleLabel;
        private System.Windows.Forms.Label CustomerNumberTitleLabel;
        private System.Windows.Forms.Label ForenameTitelLabel;
        private System.Windows.Forms.Label OrderTypeLabel;
        public System.Windows.Forms.Button SelectCustomerButton;
        public System.Windows.Forms.TableLayoutPanel DetailsTableLayoutPanel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label TotalProductCountLabel;
        public System.Windows.Forms.Button SubmitOrderButton;
        public System.Windows.Forms.Button ClearOrderButton;
        private System.Windows.Forms.Label OrderIDLabel;
    }
}