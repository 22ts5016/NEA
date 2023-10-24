﻿namespace Do_IT
{
    partial class ViewOrder
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
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.OrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
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
            this.OrderStatusTitleLabel = new System.Windows.Forms.Label();
            this.MainLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderHeadersTable = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BarcodeHeaderLabel = new System.Windows.Forms.Label();
            this.ImageHeaderLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DetailsTableLayoutPanel.SuspendLayout();
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
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Location = new System.Drawing.Point(71, 54);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(76, 13);
            this.OrderNumberLabel.TabIndex = 3;
            this.OrderNumberLabel.Text = "Order Number:";
            // 
            // OrderNumberTextBox
            // 
            this.OrderNumberTextBox.Location = new System.Drawing.Point(153, 51);
            this.OrderNumberTextBox.Name = "OrderNumberTextBox";
            this.OrderNumberTextBox.Size = new System.Drawing.Size(119, 20);
            this.OrderNumberTextBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(318, 46);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(93, 29);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DetailsTableLayoutPanel
            // 
            this.DetailsTableLayoutPanel.ColumnCount = 10;
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.DetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.DetailsTableLayoutPanel.Controls.Add(this.EmailTitleLabel, 7, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.PhoneNumberTitleLabel, 6, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.PostcodeTitleLabel, 5, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.AddressTitleLabel, 4, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.SurnameTitleLabel, 3, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.TtitleTitleLabel, 1, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.CustomerNumberTitleLabel, 0, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.ForenameTitelLabel, 2, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.OrderTypeLabel, 8, 0);
            this.DetailsTableLayoutPanel.Controls.Add(this.OrderStatusTitleLabel, 9, 0);
            this.DetailsTableLayoutPanel.Location = new System.Drawing.Point(74, 106);
            this.DetailsTableLayoutPanel.Name = "DetailsTableLayoutPanel";
            this.DetailsTableLayoutPanel.RowCount = 2;
            this.DetailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DetailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DetailsTableLayoutPanel.Size = new System.Drawing.Size(1300, 100);
            this.DetailsTableLayoutPanel.TabIndex = 10;
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
            // OrderStatusTitleLabel
            // 
            this.OrderStatusTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrderStatusTitleLabel.AutoSize = true;
            this.OrderStatusTitleLabel.Location = new System.Drawing.Point(1256, 0);
            this.OrderStatusTitleLabel.Name = "OrderStatusTitleLabel";
            this.OrderStatusTitleLabel.Size = new System.Drawing.Size(37, 13);
            this.OrderStatusTitleLabel.TabIndex = 9;
            this.OrderStatusTitleLabel.Text = "Status";
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.AutoScroll = true;
            this.MainLayoutPanel.Location = new System.Drawing.Point(74, 304);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.Size = new System.Drawing.Size(1300, 545);
            this.MainLayoutPanel.TabIndex = 11;
            // 
            // OrderHeadersTable
            // 
            this.OrderHeadersTable.ColumnCount = 5;
            this.OrderHeadersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.OrderHeadersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.OrderHeadersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 542F));
            this.OrderHeadersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.OrderHeadersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.OrderHeadersTable.Controls.Add(this.label4, 4, 0);
            this.OrderHeadersTable.Controls.Add(this.label5, 3, 0);
            this.OrderHeadersTable.Controls.Add(this.BarcodeHeaderLabel, 1, 0);
            this.OrderHeadersTable.Controls.Add(this.ImageHeaderLabel, 0, 0);
            this.OrderHeadersTable.Controls.Add(this.label8, 2, 0);
            this.OrderHeadersTable.Location = new System.Drawing.Point(74, 256);
            this.OrderHeadersTable.Name = "OrderHeadersTable";
            this.OrderHeadersTable.RowCount = 1;
            this.OrderHeadersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderHeadersTable.Size = new System.Drawing.Size(1300, 28);
            this.OrderHeadersTable.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1109, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(866, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity";
            // 
            // BarcodeHeaderLabel
            // 
            this.BarcodeHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BarcodeHeaderLabel.AutoSize = true;
            this.BarcodeHeaderLabel.Location = new System.Drawing.Point(184, 0);
            this.BarcodeHeaderLabel.Name = "BarcodeHeaderLabel";
            this.BarcodeHeaderLabel.Size = new System.Drawing.Size(47, 13);
            this.BarcodeHeaderLabel.TabIndex = 1;
            this.BarcodeHeaderLabel.Text = "Barcode";
            // 
            // ImageHeaderLabel
            // 
            this.ImageHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImageHeaderLabel.AutoSize = true;
            this.ImageHeaderLabel.Location = new System.Drawing.Point(53, 0);
            this.ImageHeaderLabel.Name = "ImageHeaderLabel";
            this.ImageHeaderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ImageHeaderLabel.Size = new System.Drawing.Size(36, 13);
            this.ImageHeaderLabel.TabIndex = 0;
            this.ImageHeaderLabel.Text = "Image";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Product Name";
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.OrderHeadersTable);
            this.Controls.Add(this.MainLayoutPanel);
            this.Controls.Add(this.DetailsTableLayoutPanel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.OrderNumberTextBox);
            this.Controls.Add(this.OrderNumberLabel);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "ViewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewOrder";
            this.DetailsTableLayoutPanel.ResumeLayout(false);
            this.DetailsTableLayoutPanel.PerformLayout();
            this.OrderHeadersTable.ResumeLayout(false);
            this.OrderHeadersTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.TextBox OrderNumberTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TableLayoutPanel DetailsTableLayoutPanel;
        private System.Windows.Forms.Label TtitleTitleLabel;
        private System.Windows.Forms.Label CustomerNumberTitleLabel;
        private System.Windows.Forms.Label ForenameTitelLabel;
        private System.Windows.Forms.Label EmailTitleLabel;
        private System.Windows.Forms.Label PhoneNumberTitleLabel;
        private System.Windows.Forms.Label PostcodeTitleLabel;
        private System.Windows.Forms.Label AddressTitleLabel;
        private System.Windows.Forms.Label SurnameTitleLabel;
        private System.Windows.Forms.Label OrderTypeLabel;
        private System.Windows.Forms.Label OrderStatusTitleLabel;
        private System.Windows.Forms.FlowLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel OrderHeadersTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BarcodeHeaderLabel;
        private System.Windows.Forms.Label ImageHeaderLabel;
        private System.Windows.Forms.Label label8;
    }
}