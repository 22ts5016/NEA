namespace Do_IT
{
    partial class ItemsInABay
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
            this.TypeLabel = new System.Windows.Forms.Label();
            this.LayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddItemToLocationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(1412, 759);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(160, 90);
            this.MainMenuButton.TabIndex = 6;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(103, 67);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(23, 13);
            this.TypeLabel.TabIndex = 7;
            this.TypeLabel.Text = "null";
            // 
            // LayoutPanel1
            // 
            this.LayoutPanel1.AutoScroll = true;
            this.LayoutPanel1.Location = new System.Drawing.Point(106, 97);
            this.LayoutPanel1.Name = "LayoutPanel1";
            this.LayoutPanel1.Size = new System.Drawing.Size(1300, 665);
            this.LayoutPanel1.TabIndex = 8;
            // 
            // AddItemToLocationButton
            // 
            this.AddItemToLocationButton.Location = new System.Drawing.Point(1412, 663);
            this.AddItemToLocationButton.Name = "AddItemToLocationButton";
            this.AddItemToLocationButton.Size = new System.Drawing.Size(160, 90);
            this.AddItemToLocationButton.TabIndex = 9;
            this.AddItemToLocationButton.Text = "Add Item To This Location";
            this.AddItemToLocationButton.UseVisualStyleBackColor = true;
            this.AddItemToLocationButton.Click += new System.EventHandler(this.AddItemToLocationButton_Click);
            // 
            // ItemsInABay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.AddItemToLocationButton);
            this.Controls.Add(this.LayoutPanel1);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "ItemsInABay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items In A Bay";
            this.Load += new System.EventHandler(this.ItemsInABay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel1;
        private System.Windows.Forms.Button AddItemToLocationButton;
    }
}