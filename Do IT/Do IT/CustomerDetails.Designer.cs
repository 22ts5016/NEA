namespace Do_IT
{
    partial class CustomerDetails
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
            this.CreateCustomerButton = new System.Windows.Forms.Button();
            this.ViewCustomerButton = new System.Windows.Forms.Button();
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
            // CreateCustomerButton
            // 
            this.CreateCustomerButton.Location = new System.Drawing.Point(96, 66);
            this.CreateCustomerButton.Name = "CreateCustomerButton";
            this.CreateCustomerButton.Size = new System.Drawing.Size(160, 90);
            this.CreateCustomerButton.TabIndex = 2;
            this.CreateCustomerButton.Text = "Create Customer";
            this.CreateCustomerButton.UseVisualStyleBackColor = true;
            this.CreateCustomerButton.Click += new System.EventHandler(this.CreateCustomerButton_Click);
            // 
            // ViewCustomerButton
            // 
            this.ViewCustomerButton.Location = new System.Drawing.Point(343, 66);
            this.ViewCustomerButton.Name = "ViewCustomerButton";
            this.ViewCustomerButton.Size = new System.Drawing.Size(160, 90);
            this.ViewCustomerButton.TabIndex = 3;
            this.ViewCustomerButton.Text = "View Customer";
            this.ViewCustomerButton.UseVisualStyleBackColor = true;
            this.ViewCustomerButton.Click += new System.EventHandler(this.ViewCustomerButton_Click);
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.ViewCustomerButton);
            this.Controls.Add(this.CreateCustomerButton);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "CustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button CreateCustomerButton;
        private System.Windows.Forms.Button ViewCustomerButton;
    }
}