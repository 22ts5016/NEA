namespace Do_IT
{
    partial class ProductQuery
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
            this.ProductNameCheckBox = new System.Windows.Forms.CheckBox();
            this.BarcodeCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.Option1Label = new System.Windows.Forms.Label();
            this.Option2Label = new System.Windows.Forms.Label();
            this.Option3Label = new System.Windows.Forms.Label();
            this.Option4Label = new System.Windows.Forms.Label();
            this.Option5Label = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductNameCheckBox
            // 
            this.ProductNameCheckBox.AutoSize = true;
            this.ProductNameCheckBox.Checked = true;
            this.ProductNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProductNameCheckBox.Location = new System.Drawing.Point(207, 60);
            this.ProductNameCheckBox.Name = "ProductNameCheckBox";
            this.ProductNameCheckBox.Size = new System.Drawing.Size(94, 17);
            this.ProductNameCheckBox.TabIndex = 0;
            this.ProductNameCheckBox.Text = "Product Name";
            this.ProductNameCheckBox.UseVisualStyleBackColor = true;
            this.ProductNameCheckBox.CheckedChanged += new System.EventHandler(this.ProductNameCheckBox_CheckedChanged);
            // 
            // BarcodeCheckBox
            // 
            this.BarcodeCheckBox.AutoSize = true;
            this.BarcodeCheckBox.Location = new System.Drawing.Point(326, 60);
            this.BarcodeCheckBox.Name = "BarcodeCheckBox";
            this.BarcodeCheckBox.Size = new System.Drawing.Size(66, 17);
            this.BarcodeCheckBox.TabIndex = 1;
            this.BarcodeCheckBox.Text = "Barcode";
            this.BarcodeCheckBox.UseVisualStyleBackColor = true;
            this.BarcodeCheckBox.CheckedChanged += new System.EventHandler(this.BarcodeCheckBox_CheckedChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(422, 60);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(371, 20);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // Option1Label
            // 
            this.Option1Label.AutoSize = true;
            this.Option1Label.Location = new System.Drawing.Point(419, 96);
            this.Option1Label.Name = "Option1Label";
            this.Option1Label.Size = new System.Drawing.Size(0, 13);
            this.Option1Label.TabIndex = 3;
            this.Option1Label.Click += new System.EventHandler(this.Option1Label_Click);
            // 
            // Option2Label
            // 
            this.Option2Label.AutoSize = true;
            this.Option2Label.Location = new System.Drawing.Point(419, 118);
            this.Option2Label.Name = "Option2Label";
            this.Option2Label.Size = new System.Drawing.Size(0, 13);
            this.Option2Label.TabIndex = 4;
            this.Option2Label.Click += new System.EventHandler(this.Option2Label_Click);
            // 
            // Option3Label
            // 
            this.Option3Label.AutoSize = true;
            this.Option3Label.Location = new System.Drawing.Point(419, 140);
            this.Option3Label.Name = "Option3Label";
            this.Option3Label.Size = new System.Drawing.Size(0, 13);
            this.Option3Label.TabIndex = 5;
            this.Option3Label.Click += new System.EventHandler(this.Option3Label_Click);
            // 
            // Option4Label
            // 
            this.Option4Label.AutoSize = true;
            this.Option4Label.Location = new System.Drawing.Point(419, 162);
            this.Option4Label.Name = "Option4Label";
            this.Option4Label.Size = new System.Drawing.Size(0, 13);
            this.Option4Label.TabIndex = 6;
            this.Option4Label.Click += new System.EventHandler(this.Option4Label_Click);
            // 
            // Option5Label
            // 
            this.Option5Label.AutoSize = true;
            this.Option5Label.Location = new System.Drawing.Point(419, 184);
            this.Option5Label.Name = "Option5Label";
            this.Option5Label.Size = new System.Drawing.Size(0, 13);
            this.Option5Label.TabIndex = 7;
            this.Option5Label.Click += new System.EventHandler(this.Option5Label_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(818, 55);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(93, 29);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(1412, 759);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(160, 90);
            this.MainMenuButton.TabIndex = 9;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // ProductQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Option5Label);
            this.Controls.Add(this.Option4Label);
            this.Controls.Add(this.Option3Label);
            this.Controls.Add(this.Option2Label);
            this.Controls.Add(this.Option1Label);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.BarcodeCheckBox);
            this.Controls.Add(this.ProductNameCheckBox);
            this.Name = "ProductQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Query";
            this.Load += new System.EventHandler(this.ProductQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ProductNameCheckBox;
        private System.Windows.Forms.CheckBox BarcodeCheckBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label Option1Label;
        private System.Windows.Forms.Label Option2Label;
        private System.Windows.Forms.Label Option3Label;
        private System.Windows.Forms.Label Option4Label;
        private System.Windows.Forms.Label Option5Label;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button MainMenuButton;
    }
}