namespace Do_IT
{
    partial class StockWriteOff
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
            this.SelectreasonLabel = new System.Windows.Forms.Label();
            this.WriteOffReasonComboBox = new System.Windows.Forms.ComboBox();
            this.BarcodeLabell = new System.Windows.Forms.Label();
            this.BarcodeTextBox = new System.Windows.Forms.TextBox();
            this.LayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
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
            // SelectreasonLabel
            // 
            this.SelectreasonLabel.AutoSize = true;
            this.SelectreasonLabel.Location = new System.Drawing.Point(85, 54);
            this.SelectreasonLabel.Name = "SelectreasonLabel";
            this.SelectreasonLabel.Size = new System.Drawing.Size(75, 13);
            this.SelectreasonLabel.TabIndex = 2;
            this.SelectreasonLabel.Text = "Select reason:";
            // 
            // WriteOffReasonComboBox
            // 
            this.WriteOffReasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WriteOffReasonComboBox.FormattingEnabled = true;
            this.WriteOffReasonComboBox.Location = new System.Drawing.Point(166, 51);
            this.WriteOffReasonComboBox.Name = "WriteOffReasonComboBox";
            this.WriteOffReasonComboBox.Size = new System.Drawing.Size(120, 21);
            this.WriteOffReasonComboBox.TabIndex = 3;
            // 
            // BarcodeLabell
            // 
            this.BarcodeLabell.AutoSize = true;
            this.BarcodeLabell.Location = new System.Drawing.Point(302, 54);
            this.BarcodeLabell.Name = "BarcodeLabell";
            this.BarcodeLabell.Size = new System.Drawing.Size(50, 13);
            this.BarcodeLabell.TabIndex = 4;
            this.BarcodeLabell.Text = "Barcode:";
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.Location = new System.Drawing.Point(358, 51);
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(206, 20);
            this.BarcodeTextBox.TabIndex = 5;
            // 
            // LayoutPanel1
            // 
            this.LayoutPanel1.Location = new System.Drawing.Point(88, 111);
            this.LayoutPanel1.Name = "LayoutPanel1";
            this.LayoutPanel1.Size = new System.Drawing.Size(1318, 738);
            this.LayoutPanel1.TabIndex = 6;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(596, 51);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(102, 21);
            this.EnterButton.TabIndex = 7;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(1269, 51);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(137, 21);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit Write Off\'s";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // StockWriteOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.LayoutPanel1);
            this.Controls.Add(this.BarcodeTextBox);
            this.Controls.Add(this.BarcodeLabell);
            this.Controls.Add(this.WriteOffReasonComboBox);
            this.Controls.Add(this.SelectreasonLabel);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "StockWriteOff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockWriteOff";
            this.Load += new System.EventHandler(this.StockWriteOff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label SelectreasonLabel;
        private System.Windows.Forms.ComboBox WriteOffReasonComboBox;
        private System.Windows.Forms.Label BarcodeLabell;
        private System.Windows.Forms.TextBox BarcodeTextBox;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel1;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}