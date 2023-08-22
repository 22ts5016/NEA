namespace Do_IT
{
    partial class MainMenu
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
            this.PeoductQueryButton = new System.Windows.Forms.Button();
            this.LocationManagementButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.StockManagementButton = new System.Windows.Forms.Button();
            this.CustomerDetailsButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.AddLocationButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeoductQueryButton
            // 
            this.PeoductQueryButton.Location = new System.Drawing.Point(91, 63);
            this.PeoductQueryButton.Name = "PeoductQueryButton";
            this.PeoductQueryButton.Size = new System.Drawing.Size(181, 107);
            this.PeoductQueryButton.TabIndex = 0;
            this.PeoductQueryButton.Text = "Product Query";
            this.PeoductQueryButton.UseVisualStyleBackColor = true;
            this.PeoductQueryButton.Click += new System.EventHandler(this.PeoductQueryButton_Click);
            // 
            // LocationManagementButton
            // 
            this.LocationManagementButton.Location = new System.Drawing.Point(318, 63);
            this.LocationManagementButton.Name = "LocationManagementButton";
            this.LocationManagementButton.Size = new System.Drawing.Size(181, 107);
            this.LocationManagementButton.TabIndex = 1;
            this.LocationManagementButton.Text = "Location Management";
            this.LocationManagementButton.UseVisualStyleBackColor = true;
            this.LocationManagementButton.Click += new System.EventHandler(this.LocationManagementButton_Click);
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Location = new System.Drawing.Point(91, 472);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(181, 107);
            this.EmployeesButton.TabIndex = 2;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Visible = false;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(561, 63);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(181, 107);
            this.OrdersButton.TabIndex = 3;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // StockManagementButton
            // 
            this.StockManagementButton.Location = new System.Drawing.Point(807, 63);
            this.StockManagementButton.Name = "StockManagementButton";
            this.StockManagementButton.Size = new System.Drawing.Size(181, 107);
            this.StockManagementButton.TabIndex = 4;
            this.StockManagementButton.Text = "Stock Management";
            this.StockManagementButton.UseVisualStyleBackColor = true;
            this.StockManagementButton.Click += new System.EventHandler(this.StockManagementButton_Click);
            // 
            // CustomerDetailsButton
            // 
            this.CustomerDetailsButton.Location = new System.Drawing.Point(1053, 63);
            this.CustomerDetailsButton.Name = "CustomerDetailsButton";
            this.CustomerDetailsButton.Size = new System.Drawing.Size(181, 107);
            this.CustomerDetailsButton.TabIndex = 5;
            this.CustomerDetailsButton.Text = "Customer Details";
            this.CustomerDetailsButton.UseVisualStyleBackColor = true;
            this.CustomerDetailsButton.Click += new System.EventHandler(this.CustomerDetailsButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(318, 472);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(181, 107);
            this.AddProductButton.TabIndex = 6;
            this.AddProductButton.Text = "Add Product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Visible = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // AddLocationButton
            // 
            this.AddLocationButton.Location = new System.Drawing.Point(561, 472);
            this.AddLocationButton.Name = "AddLocationButton";
            this.AddLocationButton.Size = new System.Drawing.Size(181, 107);
            this.AddLocationButton.TabIndex = 7;
            this.AddLocationButton.Text = "Add Location";
            this.AddLocationButton.UseVisualStyleBackColor = true;
            this.AddLocationButton.Visible = false;
            this.AddLocationButton.Click += new System.EventHandler(this.AddLocationButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1412, 759);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(160, 90);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddLocationButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.CustomerDetailsButton);
            this.Controls.Add(this.StockManagementButton);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.EmployeesButton);
            this.Controls.Add(this.LocationManagementButton);
            this.Controls.Add(this.PeoductQueryButton);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PeoductQueryButton;
        private System.Windows.Forms.Button LocationManagementButton;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button StockManagementButton;
        private System.Windows.Forms.Button CustomerDetailsButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button AddLocationButton;
        private System.Windows.Forms.Button ExitButton;
    }
}