namespace Do_IT
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.BarcodeTextBox = new System.Windows.Forms.TextBox();
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductDescriptionLabel = new System.Windows.Forms.Label();
            this.ProductDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.StockCountLabel = new System.Windows.Forms.Label();
            this.StockCountTextBox = new System.Windows.Forms.TextBox();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.PoundSymbolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.Location = new System.Drawing.Point(207, 55);
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(374, 20);
            this.BarcodeTextBox.TabIndex = 0;
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.AutoSize = true;
            this.BarcodeLabel.Location = new System.Drawing.Point(101, 55);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(47, 13);
            this.BarcodeLabel.TabIndex = 1;
            this.BarcodeLabel.Text = "Barcode";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(101, 102);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(75, 13);
            this.ProductNameLabel.TabIndex = 2;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(207, 102);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(374, 20);
            this.ProductNameTextBox.TabIndex = 3;
            // 
            // ProductDescriptionLabel
            // 
            this.ProductDescriptionLabel.AutoSize = true;
            this.ProductDescriptionLabel.Location = new System.Drawing.Point(101, 149);
            this.ProductDescriptionLabel.Name = "ProductDescriptionLabel";
            this.ProductDescriptionLabel.Size = new System.Drawing.Size(100, 13);
            this.ProductDescriptionLabel.TabIndex = 4;
            this.ProductDescriptionLabel.Text = "Product Description";
            // 
            // ProductDescriptionTextBox
            // 
            this.ProductDescriptionTextBox.Location = new System.Drawing.Point(207, 149);
            this.ProductDescriptionTextBox.Multiline = true;
            this.ProductDescriptionTextBox.Name = "ProductDescriptionTextBox";
            this.ProductDescriptionTextBox.Size = new System.Drawing.Size(374, 68);
            this.ProductDescriptionTextBox.TabIndex = 5;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(207, 381);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(199, 95);
            this.AddItemButton.TabIndex = 6;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(1412, 759);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(160, 90);
            this.MainMenuButton.TabIndex = 7;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(101, 233);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "Price";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(207, 233);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(374, 20);
            this.PriceTextBox.TabIndex = 9;
            // 
            // StockCountLabel
            // 
            this.StockCountLabel.AutoSize = true;
            this.StockCountLabel.Location = new System.Drawing.Point(101, 275);
            this.StockCountLabel.Name = "StockCountLabel";
            this.StockCountLabel.Size = new System.Drawing.Size(66, 13);
            this.StockCountLabel.TabIndex = 10;
            this.StockCountLabel.Text = "Stock Count";
            // 
            // StockCountTextBox
            // 
            this.StockCountTextBox.Location = new System.Drawing.Point(207, 275);
            this.StockCountTextBox.Name = "StockCountTextBox";
            this.StockCountTextBox.Size = new System.Drawing.Size(374, 20);
            this.StockCountTextBox.TabIndex = 11;
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Location = new System.Drawing.Point(101, 326);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(36, 13);
            this.ImageLabel.TabIndex = 12;
            this.ImageLabel.Text = "Image";
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.Location = new System.Drawing.Point(207, 326);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(75, 23);
            this.SelectImageButton.TabIndex = 13;
            this.SelectImageButton.Text = "Select";
            this.SelectImageButton.UseVisualStyleBackColor = true;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ImagePictureBox.Image")));
            this.ImagePictureBox.Location = new System.Drawing.Point(871, 55);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(284, 284);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImagePictureBox.TabIndex = 14;
            this.ImagePictureBox.TabStop = false;
            // 
            // PoundSymbolLabel
            // 
            this.PoundSymbolLabel.AutoSize = true;
            this.PoundSymbolLabel.Location = new System.Drawing.Point(194, 236);
            this.PoundSymbolLabel.Name = "PoundSymbolLabel";
            this.PoundSymbolLabel.Size = new System.Drawing.Size(13, 13);
            this.PoundSymbolLabel.TabIndex = 15;
            this.PoundSymbolLabel.Text = "£";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.PoundSymbolLabel);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.SelectImageButton);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.StockCountTextBox);
            this.Controls.Add(this.StockCountLabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.ProductDescriptionTextBox);
            this.Controls.Add(this.ProductDescriptionLabel);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.BarcodeLabel);
            this.Controls.Add(this.BarcodeTextBox);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BarcodeTextBox;
        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Label ProductDescriptionLabel;
        private System.Windows.Forms.TextBox ProductDescriptionTextBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label StockCountLabel;
        private System.Windows.Forms.TextBox StockCountTextBox;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Button SelectImageButton;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Label PoundSymbolLabel;
    }
}