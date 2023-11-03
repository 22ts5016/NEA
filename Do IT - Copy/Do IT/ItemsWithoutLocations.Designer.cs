namespace Do_IT
{
    partial class ItemsWithoutLocations
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
            this.LayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddSelectedItemsToLocationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(1412, 759);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(160, 90);
            this.MainMenuButton.TabIndex = 8;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.AutoScroll = true;
            this.LayoutPanel.Location = new System.Drawing.Point(12, 59);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(1394, 694);
            this.LayoutPanel.TabIndex = 9;
            // 
            // AddSelectedItemsToLocationButton
            // 
            this.AddSelectedItemsToLocationButton.Location = new System.Drawing.Point(1412, 663);
            this.AddSelectedItemsToLocationButton.Name = "AddSelectedItemsToLocationButton";
            this.AddSelectedItemsToLocationButton.Size = new System.Drawing.Size(160, 90);
            this.AddSelectedItemsToLocationButton.TabIndex = 10;
            this.AddSelectedItemsToLocationButton.Text = "Add Selected Items to Location";
            this.AddSelectedItemsToLocationButton.UseVisualStyleBackColor = true;
            this.AddSelectedItemsToLocationButton.Click += new System.EventHandler(this.AddSelectedItemsToLocationButton_Click);
            // 
            // ItemsWithoutLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.AddSelectedItemsToLocationButton);
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "ItemsWithoutLocations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items Without Locations";
            this.Load += new System.EventHandler(this.ItemsWithoutLocations_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel;
        private System.Windows.Forms.Button AddSelectedItemsToLocationButton;
    }
}