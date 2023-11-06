namespace Do_IT
{
    partial class StockManagement
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
            this.StockAdjustmentButton = new System.Windows.Forms.Button();
            this.StockWriteOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(1412, 759);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(160, 90);
            this.MainMenuButton.TabIndex = 0;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // StockAdjustmentButton
            // 
            this.StockAdjustmentButton.Location = new System.Drawing.Point(108, 79);
            this.StockAdjustmentButton.Name = "StockAdjustmentButton";
            this.StockAdjustmentButton.Size = new System.Drawing.Size(160, 90);
            this.StockAdjustmentButton.TabIndex = 1;
            this.StockAdjustmentButton.Text = "Stock Adjustment";
            this.StockAdjustmentButton.UseVisualStyleBackColor = true;
            this.StockAdjustmentButton.Click += new System.EventHandler(this.StockAdjustmentButton_Click);
            // 
            // StockWriteOff
            // 
            this.StockWriteOff.Location = new System.Drawing.Point(340, 79);
            this.StockWriteOff.Name = "StockWriteOff";
            this.StockWriteOff.Size = new System.Drawing.Size(160, 90);
            this.StockWriteOff.TabIndex = 2;
            this.StockWriteOff.Text = "Stock Write Off";
            this.StockWriteOff.UseVisualStyleBackColor = true;
            this.StockWriteOff.Click += new System.EventHandler(this.StockWriteOff_Click);
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.StockWriteOff);
            this.Controls.Add(this.StockAdjustmentButton);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "StockManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button StockAdjustmentButton;
        private System.Windows.Forms.Button StockWriteOff;
    }
}