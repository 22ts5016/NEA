namespace Do_IT
{
    partial class DisplayedItem
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
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductImagePictureBox = new System.Windows.Forms.PictureBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ProductDescrpitionLabel = new System.Windows.Forms.Label();
            this.MainMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(292, 47);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(42, 25);
            this.ProductNameLabel.TabIndex = 0;
            this.ProductNameLabel.Text = "null";
            // 
            // ProductImagePictureBox
            // 
            this.ProductImagePictureBox.Location = new System.Drawing.Point(297, 130);
            this.ProductImagePictureBox.Name = "ProductImagePictureBox";
            this.ProductImagePictureBox.Size = new System.Drawing.Size(284, 284);
            this.ProductImagePictureBox.TabIndex = 1;
            this.ProductImagePictureBox.TabStop = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(292, 91);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(42, 25);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "null";
            // 
            // ProductDescrpitionLabel
            // 
            this.ProductDescrpitionLabel.AutoSize = true;
            this.ProductDescrpitionLabel.Location = new System.Drawing.Point(605, 146);
            this.ProductDescrpitionLabel.Name = "ProductDescrpitionLabel";
            this.ProductDescrpitionLabel.Size = new System.Drawing.Size(23, 13);
            this.ProductDescrpitionLabel.TabIndex = 3;
            this.ProductDescrpitionLabel.Text = "null";
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
            // DisplayedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.ProductDescrpitionLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ProductImagePictureBox);
            this.Controls.Add(this.ProductNameLabel);
            this.Name = "DisplayedItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayedItem";
            this.Load += new System.EventHandler(this.DisplayedItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.PictureBox ProductImagePictureBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ProductDescrpitionLabel;
        private System.Windows.Forms.Button MainMenuButton;
    }
}