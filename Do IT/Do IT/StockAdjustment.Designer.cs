namespace Do_IT
{
    partial class StockAdjustment
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
            this.EnterBarcodeButton = new System.Windows.Forms.Button();
            this.ActualStockCountLabel = new System.Windows.Forms.Label();
            this.StockCountTextBox = new System.Windows.Forms.TextBox();
            this.EnterStockCountLabel = new System.Windows.Forms.Label();
            this.CurrentStockLabel = new System.Windows.Forms.Label();
            this.BarcodeTextBox = new System.Windows.Forms.TextBox();
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterBarcodeButton
            // 
            this.EnterBarcodeButton.Location = new System.Drawing.Point(373, 67);
            this.EnterBarcodeButton.Name = "EnterBarcodeButton";
            this.EnterBarcodeButton.Size = new System.Drawing.Size(80, 20);
            this.EnterBarcodeButton.TabIndex = 15;
            this.EnterBarcodeButton.Text = "Enter";
            this.EnterBarcodeButton.UseVisualStyleBackColor = true;
            this.EnterBarcodeButton.Click += new System.EventHandler(this.EnterBarcodeButton_Click);
            // 
            // ActualStockCountLabel
            // 
            this.ActualStockCountLabel.AutoSize = true;
            this.ActualStockCountLabel.Location = new System.Drawing.Point(181, 124);
            this.ActualStockCountLabel.Name = "ActualStockCountLabel";
            this.ActualStockCountLabel.Size = new System.Drawing.Size(23, 13);
            this.ActualStockCountLabel.TabIndex = 14;
            this.ActualStockCountLabel.Text = "null";
            this.ActualStockCountLabel.Visible = false;
            // 
            // StockCountTextBox
            // 
            this.StockCountTextBox.Location = new System.Drawing.Point(181, 172);
            this.StockCountTextBox.Name = "StockCountTextBox";
            this.StockCountTextBox.Size = new System.Drawing.Size(160, 20);
            this.StockCountTextBox.TabIndex = 13;
            this.StockCountTextBox.Visible = false;
            // 
            // EnterStockCountLabel
            // 
            this.EnterStockCountLabel.AutoSize = true;
            this.EnterStockCountLabel.Location = new System.Drawing.Point(78, 175);
            this.EnterStockCountLabel.Name = "EnterStockCountLabel";
            this.EnterStockCountLabel.Size = new System.Drawing.Size(97, 13);
            this.EnterStockCountLabel.TabIndex = 11;
            this.EnterStockCountLabel.Text = "Enter Stock Count:";
            this.EnterStockCountLabel.Visible = false;
            // 
            // CurrentStockLabel
            // 
            this.CurrentStockLabel.AutoSize = true;
            this.CurrentStockLabel.Location = new System.Drawing.Point(100, 124);
            this.CurrentStockLabel.Name = "CurrentStockLabel";
            this.CurrentStockLabel.Size = new System.Drawing.Size(75, 13);
            this.CurrentStockLabel.TabIndex = 12;
            this.CurrentStockLabel.Text = "Current Stock:";
            this.CurrentStockLabel.Visible = false;
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.Location = new System.Drawing.Point(181, 67);
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(160, 20);
            this.BarcodeTextBox.TabIndex = 10;
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.AutoSize = true;
            this.BarcodeLabel.Location = new System.Drawing.Point(125, 70);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(50, 13);
            this.BarcodeLabel.TabIndex = 9;
            this.BarcodeLabel.Text = "Barcode:";
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(1412, 759);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(160, 90);
            this.MainMenuButton.TabIndex = 16;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(181, 277);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(160, 90);
            this.SubmitButton.TabIndex = 17;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // StockAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.EnterBarcodeButton);
            this.Controls.Add(this.ActualStockCountLabel);
            this.Controls.Add(this.StockCountTextBox);
            this.Controls.Add(this.EnterStockCountLabel);
            this.Controls.Add(this.CurrentStockLabel);
            this.Controls.Add(this.BarcodeTextBox);
            this.Controls.Add(this.BarcodeLabel);
            this.Name = "StockAdjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Adjustment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EnterBarcodeButton;
        private System.Windows.Forms.Label ActualStockCountLabel;
        private System.Windows.Forms.TextBox StockCountTextBox;
        private System.Windows.Forms.Label EnterStockCountLabel;
        private System.Windows.Forms.Label CurrentStockLabel;
        private System.Windows.Forms.TextBox BarcodeTextBox;
        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}