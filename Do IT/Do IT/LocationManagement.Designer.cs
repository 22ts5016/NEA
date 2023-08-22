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
            // LocationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
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
        private System.Windows.Forms.TextBox IsleTextBox;
        private System.Windows.Forms.Label BayLabel;
        private System.Windows.Forms.TextBox BayTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button MainMenuButton;
    }
}