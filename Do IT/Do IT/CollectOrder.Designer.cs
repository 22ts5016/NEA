namespace Do_IT
{
    partial class CollectOrder
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CollectOrderForLabel = new System.Windows.Forms.Label();
            this.CollectButton = new System.Windows.Forms.Button();
            this.ViewOrderButton = new System.Windows.Forms.Button();
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
            this.OrderNumberLabel.Location = new System.Drawing.Point(78, 66);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(76, 13);
            this.OrderNumberLabel.TabIndex = 3;
            this.OrderNumberLabel.Text = "Order Number:";
            // 
            // OrderNumberTextBox
            // 
            this.OrderNumberTextBox.Location = new System.Drawing.Point(160, 63);
            this.OrderNumberTextBox.Name = "OrderNumberTextBox";
            this.OrderNumberTextBox.Size = new System.Drawing.Size(157, 20);
            this.OrderNumberTextBox.TabIndex = 4;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(365, 58);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(93, 29);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(560, 58);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(93, 29);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CollectorderForLabel
            // 
            this.CollectOrderForLabel.AutoSize = true;
            this.CollectOrderForLabel.Location = new System.Drawing.Point(78, 117);
            this.CollectOrderForLabel.Name = "CollectorderForLabel";
            this.CollectOrderForLabel.Size = new System.Drawing.Size(92, 13);
            this.CollectOrderForLabel.TabIndex = 11;
            this.CollectOrderForLabel.Text = "Collect Order For: ";
            this.CollectOrderForLabel.Visible = false;
            // 
            // CollectButton
            // 
            this.CollectButton.Location = new System.Drawing.Point(201, 159);
            this.CollectButton.Name = "CollectButton";
            this.CollectButton.Size = new System.Drawing.Size(93, 29);
            this.CollectButton.TabIndex = 12;
            this.CollectButton.Text = "Collect";
            this.CollectButton.UseVisualStyleBackColor = true;
            this.CollectButton.Visible = false;
            this.CollectButton.Click += new System.EventHandler(this.CollectButton_Click);
            // 
            // ViewOrderButton
            // 
            this.ViewOrderButton.Location = new System.Drawing.Point(81, 159);
            this.ViewOrderButton.Name = "ViewOrderButton";
            this.ViewOrderButton.Size = new System.Drawing.Size(93, 29);
            this.ViewOrderButton.TabIndex = 13;
            this.ViewOrderButton.Text = "View Order";
            this.ViewOrderButton.UseVisualStyleBackColor = true;
            this.ViewOrderButton.Visible = false;
            this.ViewOrderButton.Click += new System.EventHandler(this.ViewOrderButton_Click);
            // 
            // CollectOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.ViewOrderButton);
            this.Controls.Add(this.CollectButton);
            this.Controls.Add(this.CollectOrderForLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.OrderNumberTextBox);
            this.Controls.Add(this.OrderNumberLabel);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "CollectOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collect Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label CollectOrderForLabel;
        private System.Windows.Forms.Button CollectButton;
        private System.Windows.Forms.Button ViewOrderButton;
        public System.Windows.Forms.TextBox OrderNumberTextBox;
    }
}