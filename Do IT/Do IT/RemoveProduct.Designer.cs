namespace Do_IT
{
    partial class RemoveProduct
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
            this.RemoveTextBox = new System.Windows.Forms.TextBox();
            this.BarcodeCheckBox = new System.Windows.Forms.CheckBox();
            this.ProductNameCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(1412, 759);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(160, 90);
            this.MainMenuButton.TabIndex = 10;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(765, 97);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(93, 29);
            this.RemoveButton.TabIndex = 14;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RemoveTextBox
            // 
            this.RemoveTextBox.Location = new System.Drawing.Point(369, 102);
            this.RemoveTextBox.Name = "RemoveTextBox";
            this.RemoveTextBox.Size = new System.Drawing.Size(371, 20);
            this.RemoveTextBox.TabIndex = 13;
            // 
            // BarcodeCheckBox
            // 
            this.BarcodeCheckBox.AutoSize = true;
            this.BarcodeCheckBox.Location = new System.Drawing.Point(273, 102);
            this.BarcodeCheckBox.Name = "BarcodeCheckBox";
            this.BarcodeCheckBox.Size = new System.Drawing.Size(66, 17);
            this.BarcodeCheckBox.TabIndex = 12;
            this.BarcodeCheckBox.Text = "Barcode";
            this.BarcodeCheckBox.UseVisualStyleBackColor = true;
            this.BarcodeCheckBox.CheckedChanged += new System.EventHandler(this.BarcodeCheckBox_CheckedChanged);
            // 
            // ProductNameCheckBox
            // 
            this.ProductNameCheckBox.AutoSize = true;
            this.ProductNameCheckBox.Checked = true;
            this.ProductNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProductNameCheckBox.Location = new System.Drawing.Point(154, 102);
            this.ProductNameCheckBox.Name = "ProductNameCheckBox";
            this.ProductNameCheckBox.Size = new System.Drawing.Size(94, 17);
            this.ProductNameCheckBox.TabIndex = 11;
            this.ProductNameCheckBox.Text = "Product Name";
            this.ProductNameCheckBox.UseVisualStyleBackColor = true;
            this.ProductNameCheckBox.CheckedChanged += new System.EventHandler(this.ProductNameCheckBox_CheckedChanged);
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Location = new System.Drawing.Point(151, 53);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(59, 13);
            this.SearchByLabel.TabIndex = 15;
            this.SearchByLabel.Text = "Search By:";
            // 
            // RemoveProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.SearchByLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.RemoveTextBox);
            this.Controls.Add(this.BarcodeCheckBox);
            this.Controls.Add(this.ProductNameCheckBox);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "RemoveProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox RemoveTextBox;
        private System.Windows.Forms.CheckBox BarcodeCheckBox;
        private System.Windows.Forms.CheckBox ProductNameCheckBox;
        private System.Windows.Forms.Label SearchByLabel;
    }
}