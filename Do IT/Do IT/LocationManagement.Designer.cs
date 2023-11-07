namespace Do_IT
{
    partial class LocationManagement
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
            this.IsleLabel = new System.Windows.Forms.Label();
            this.IsleTextBox = new System.Windows.Forms.TextBox();
            this.BayLabel = new System.Windows.Forms.Label();
            this.BayTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SellingButton = new System.Windows.Forms.Button();
            this.SellingLabel = new System.Windows.Forms.Label();
            this.OverstockLabel = new System.Windows.Forms.Label();
            this.OverstockButton = new System.Windows.Forms.Button();
            this.MultiLocationButton = new System.Windows.Forms.Button();
            this.MultiLocationLabel = new System.Windows.Forms.Label();
            this.ItemsWithoutLocationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IsleLabel
            // 
            this.IsleLabel.AutoSize = true;
            this.IsleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsleLabel.Location = new System.Drawing.Point(121, 41);
            this.IsleLabel.Name = "IsleLabel";
            this.IsleLabel.Size = new System.Drawing.Size(34, 20);
            this.IsleLabel.TabIndex = 0;
            this.IsleLabel.Text = "Isle";
            // 
            // IsleTextBox
            // 
            this.IsleTextBox.Location = new System.Drawing.Point(161, 43);
            this.IsleTextBox.Name = "IsleTextBox";
            this.IsleTextBox.Size = new System.Drawing.Size(97, 20);
            this.IsleTextBox.TabIndex = 1;
            // 
            // BayLabel
            // 
            this.BayLabel.AutoSize = true;
            this.BayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BayLabel.Location = new System.Drawing.Point(300, 43);
            this.BayLabel.Name = "BayLabel";
            this.BayLabel.Size = new System.Drawing.Size(36, 20);
            this.BayLabel.TabIndex = 2;
            this.BayLabel.Text = "Bay";
            // 
            // BayTextBox
            // 
            this.BayTextBox.Location = new System.Drawing.Point(340, 45);
            this.BayTextBox.Name = "BayTextBox";
            this.BayTextBox.Size = new System.Drawing.Size(97, 20);
            this.BayTextBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(498, 39);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(113, 30);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(1412, 759);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(160, 90);
            this.MainMenuButton.TabIndex = 5;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // SellingButton
            // 
            this.SellingButton.Location = new System.Drawing.Point(161, 273);
            this.SellingButton.Name = "SellingButton";
            this.SellingButton.Size = new System.Drawing.Size(763, 41);
            this.SellingButton.TabIndex = 6;
            this.SellingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SellingButton.UseVisualStyleBackColor = true;
            this.SellingButton.Visible = false;
            this.SellingButton.Click += new System.EventHandler(this.SellingButton_Click);
            // 
            // SellingLabel
            // 
            this.SellingLabel.AutoSize = true;
            this.SellingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingLabel.Location = new System.Drawing.Point(157, 235);
            this.SellingLabel.Name = "SellingLabel";
            this.SellingLabel.Size = new System.Drawing.Size(56, 20);
            this.SellingLabel.TabIndex = 7;
            this.SellingLabel.Text = "Selling";
            this.SellingLabel.Visible = false;
            // 
            // OverstockLabel
            // 
            this.OverstockLabel.AutoSize = true;
            this.OverstockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverstockLabel.Location = new System.Drawing.Point(157, 444);
            this.OverstockLabel.Name = "OverstockLabel";
            this.OverstockLabel.Size = new System.Drawing.Size(80, 20);
            this.OverstockLabel.TabIndex = 8;
            this.OverstockLabel.Text = "Overstock";
            this.OverstockLabel.Visible = false;
            // 
            // OverstockButton
            // 
            this.OverstockButton.Location = new System.Drawing.Point(161, 478);
            this.OverstockButton.Name = "OverstockButton";
            this.OverstockButton.Size = new System.Drawing.Size(763, 41);
            this.OverstockButton.TabIndex = 9;
            this.OverstockButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OverstockButton.UseVisualStyleBackColor = true;
            this.OverstockButton.Visible = false;
            this.OverstockButton.Click += new System.EventHandler(this.OverstockButton_Click);
            // 
            // MultiLocationButton
            // 
            this.MultiLocationButton.Location = new System.Drawing.Point(161, 376);
            this.MultiLocationButton.Name = "MultiLocationButton";
            this.MultiLocationButton.Size = new System.Drawing.Size(763, 41);
            this.MultiLocationButton.TabIndex = 10;
            this.MultiLocationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MultiLocationButton.UseVisualStyleBackColor = true;
            this.MultiLocationButton.Visible = false;
            this.MultiLocationButton.Click += new System.EventHandler(this.MultiLocationButton_Click);
            // 
            // MultiLocationLabel
            // 
            this.MultiLocationLabel.AutoSize = true;
            this.MultiLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiLocationLabel.Location = new System.Drawing.Point(157, 337);
            this.MultiLocationLabel.Name = "MultiLocationLabel";
            this.MultiLocationLabel.Size = new System.Drawing.Size(103, 20);
            this.MultiLocationLabel.TabIndex = 11;
            this.MultiLocationLabel.Text = "MultiLocation";
            this.MultiLocationLabel.Visible = false;
            // 
            // ItemsWithoutLocationButton
            // 
            this.ItemsWithoutLocationButton.Location = new System.Drawing.Point(693, 41);
            this.ItemsWithoutLocationButton.Name = "ItemsWithoutLocationButton";
            this.ItemsWithoutLocationButton.Size = new System.Drawing.Size(231, 30);
            this.ItemsWithoutLocationButton.TabIndex = 12;
            this.ItemsWithoutLocationButton.Text = "View Products Without Locations";
            this.ItemsWithoutLocationButton.UseVisualStyleBackColor = true;
            this.ItemsWithoutLocationButton.Click += new System.EventHandler(this.ItemsWithoutLocationButton_Click);
            // 
            // LocationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.ItemsWithoutLocationButton);
            this.Controls.Add(this.MultiLocationLabel);
            this.Controls.Add(this.MultiLocationButton);
            this.Controls.Add(this.OverstockButton);
            this.Controls.Add(this.OverstockLabel);
            this.Controls.Add(this.SellingLabel);
            this.Controls.Add(this.SellingButton);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BayTextBox);
            this.Controls.Add(this.BayLabel);
            this.Controls.Add(this.IsleTextBox);
            this.Controls.Add(this.IsleLabel);
            this.Name = "LocationManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IsleLabel;
        private System.Windows.Forms.Label BayLabel;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button SellingButton;
        private System.Windows.Forms.Label SellingLabel;
        private System.Windows.Forms.Label OverstockLabel;
        private System.Windows.Forms.Button OverstockButton;
        private System.Windows.Forms.Button MultiLocationButton;
        private System.Windows.Forms.Label MultiLocationLabel;
        private System.Windows.Forms.Button ItemsWithoutLocationButton;
        public System.Windows.Forms.TextBox IsleTextBox;
        public System.Windows.Forms.TextBox BayTextBox;
        public System.Windows.Forms.Button SearchButton;
    }
}