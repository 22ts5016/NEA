namespace Do_IT
{
    partial class AddLocation
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
            this.AddButton = new System.Windows.Forms.Button();
            this.BayTextBox = new System.Windows.Forms.TextBox();
            this.BayLabel = new System.Windows.Forms.Label();
            this.IsleTextBox = new System.Windows.Forms.TextBox();
            this.IsleLabel = new System.Windows.Forms.Label();
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
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(459, 80);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 30);
            this.AddButton.TabIndex = 21;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BayTextBox
            // 
            this.BayTextBox.Location = new System.Drawing.Point(301, 86);
            this.BayTextBox.Name = "BayTextBox";
            this.BayTextBox.Size = new System.Drawing.Size(97, 20);
            this.BayTextBox.TabIndex = 20;
            // 
            // BayLabel
            // 
            this.BayLabel.AutoSize = true;
            this.BayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BayLabel.Location = new System.Drawing.Point(261, 84);
            this.BayLabel.Name = "BayLabel";
            this.BayLabel.Size = new System.Drawing.Size(36, 20);
            this.BayLabel.TabIndex = 19;
            this.BayLabel.Text = "Bay";
            // 
            // IsleTextBox
            // 
            this.IsleTextBox.Location = new System.Drawing.Point(122, 84);
            this.IsleTextBox.Name = "IsleTextBox";
            this.IsleTextBox.Size = new System.Drawing.Size(97, 20);
            this.IsleTextBox.TabIndex = 18;
            // 
            // IsleLabel
            // 
            this.IsleLabel.AutoSize = true;
            this.IsleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsleLabel.Location = new System.Drawing.Point(82, 82);
            this.IsleLabel.Name = "IsleLabel";
            this.IsleLabel.Size = new System.Drawing.Size(34, 20);
            this.IsleLabel.TabIndex = 17;
            this.IsleLabel.Text = "Isle";
            // 
            // AddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BayTextBox);
            this.Controls.Add(this.BayLabel);
            this.Controls.Add(this.IsleTextBox);
            this.Controls.Add(this.IsleLabel);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "AddLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        public System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.TextBox BayTextBox;
        private System.Windows.Forms.Label BayLabel;
        public System.Windows.Forms.TextBox IsleTextBox;
        private System.Windows.Forms.Label IsleLabel;
    }
}