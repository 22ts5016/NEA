﻿namespace Do_IT
{
    partial class RemoveLocation
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
            this.RemoveButton = new System.Windows.Forms.Button();
            this.BayTextBox = new System.Windows.Forms.TextBox();
            this.BayLabel = new System.Windows.Forms.Label();
            this.AisleTextBox = new System.Windows.Forms.TextBox();
            this.AisleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(1412, 759);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(160, 90);
            this.MainMenuButton.TabIndex = 11;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(470, 74);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(113, 30);
            this.RemoveButton.TabIndex = 16;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // BayTextBox
            // 
            this.BayTextBox.Location = new System.Drawing.Point(312, 80);
            this.BayTextBox.Name = "BayTextBox";
            this.BayTextBox.Size = new System.Drawing.Size(97, 20);
            this.BayTextBox.TabIndex = 15;
            // 
            // BayLabel
            // 
            this.BayLabel.AutoSize = true;
            this.BayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BayLabel.Location = new System.Drawing.Point(272, 78);
            this.BayLabel.Name = "BayLabel";
            this.BayLabel.Size = new System.Drawing.Size(36, 20);
            this.BayLabel.TabIndex = 14;
            this.BayLabel.Text = "Bay";
            // 
            // AisleTextBox
            // 
            this.AisleTextBox.Location = new System.Drawing.Point(133, 78);
            this.AisleTextBox.Name = "AisleTextBox";
            this.AisleTextBox.Size = new System.Drawing.Size(97, 20);
            this.AisleTextBox.TabIndex = 13;
            // 
            // AisleLabel
            // 
            this.AisleLabel.AutoSize = true;
            this.AisleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AisleLabel.Location = new System.Drawing.Point(88, 76);
            this.AisleLabel.Name = "AisleLabel";
            this.AisleLabel.Size = new System.Drawing.Size(43, 20);
            this.AisleLabel.TabIndex = 12;
            this.AisleLabel.Text = "Aisle";
            // 
            // RemoveLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.BayTextBox);
            this.Controls.Add(this.BayLabel);
            this.Controls.Add(this.AisleTextBox);
            this.Controls.Add(this.AisleLabel);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "RemoveLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        public System.Windows.Forms.Button RemoveButton;
        public System.Windows.Forms.TextBox BayTextBox;
        private System.Windows.Forms.Label BayLabel;
        public System.Windows.Forms.TextBox AisleTextBox;
        private System.Windows.Forms.Label AisleLabel;
    }
}