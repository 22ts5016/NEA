namespace Do_IT
{
    partial class Orders
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
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.ViewOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(1412, 759);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(160, 90);
            this.MainMenuButton.TabIndex = 1;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Location = new System.Drawing.Point(379, 55);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(181, 107);
            this.CreateOrderButton.TabIndex = 2;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // ViewOrderButton
            // 
            this.ViewOrderButton.Location = new System.Drawing.Point(106, 55);
            this.ViewOrderButton.Name = "ViewOrderButton";
            this.ViewOrderButton.Size = new System.Drawing.Size(181, 107);
            this.ViewOrderButton.TabIndex = 3;
            this.ViewOrderButton.Text = "View Order";
            this.ViewOrderButton.UseVisualStyleBackColor = true;
            this.ViewOrderButton.Click += new System.EventHandler(this.ViewOrderButton_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.ViewOrderButton);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Button ViewOrderButton;
    }
}