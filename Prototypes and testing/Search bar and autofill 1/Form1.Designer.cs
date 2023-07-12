namespace Search_bar_and_autofill_1
{
    partial class Form1
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
            this.textBoxSearchBar = new System.Windows.Forms.TextBox();
            this.Option1Label = new System.Windows.Forms.Label();
            this.Option2Label = new System.Windows.Forms.Label();
            this.Option3Label = new System.Windows.Forms.Label();
            this.Option5Label = new System.Windows.Forms.Label();
            this.Option4Label = new System.Windows.Forms.Label();
            this.AddWordButton = new System.Windows.Forms.Button();
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.AddWordLabel = new System.Windows.Forms.Label();
            this.WordNameLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.ClearButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSearchBar
            // 
            this.textBoxSearchBar.Location = new System.Drawing.Point(371, 103);
            this.textBoxSearchBar.Name = "textBoxSearchBar";
            this.textBoxSearchBar.Size = new System.Drawing.Size(309, 20);
            this.textBoxSearchBar.TabIndex = 0;
            this.textBoxSearchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Option1Label
            // 
            this.Option1Label.AutoSize = true;
            this.Option1Label.Location = new System.Drawing.Point(372, 151);
            this.Option1Label.Name = "Option1Label";
            this.Option1Label.Size = new System.Drawing.Size(0, 13);
            this.Option1Label.TabIndex = 1;
            // 
            // Option2Label
            // 
            this.Option2Label.AutoSize = true;
            this.Option2Label.Location = new System.Drawing.Point(372, 174);
            this.Option2Label.Name = "Option2Label";
            this.Option2Label.Size = new System.Drawing.Size(0, 13);
            this.Option2Label.TabIndex = 2;
            // 
            // Option3Label
            // 
            this.Option3Label.AutoSize = true;
            this.Option3Label.Location = new System.Drawing.Point(372, 196);
            this.Option3Label.Name = "Option3Label";
            this.Option3Label.Size = new System.Drawing.Size(0, 13);
            this.Option3Label.TabIndex = 3;
            // 
            // Option5Label
            // 
            this.Option5Label.AutoSize = true;
            this.Option5Label.Location = new System.Drawing.Point(372, 240);
            this.Option5Label.Name = "Option5Label";
            this.Option5Label.Size = new System.Drawing.Size(0, 13);
            this.Option5Label.TabIndex = 4;
            // 
            // Option4Label
            // 
            this.Option4Label.AutoSize = true;
            this.Option4Label.Location = new System.Drawing.Point(372, 218);
            this.Option4Label.Name = "Option4Label";
            this.Option4Label.Size = new System.Drawing.Size(0, 13);
            this.Option4Label.TabIndex = 5;
            // 
            // AddWordButton
            // 
            this.AddWordButton.Location = new System.Drawing.Point(371, 619);
            this.AddWordButton.Name = "AddWordButton";
            this.AddWordButton.Size = new System.Drawing.Size(118, 73);
            this.AddWordButton.TabIndex = 6;
            this.AddWordButton.Text = "Add Word";
            this.AddWordButton.UseVisualStyleBackColor = true;
            this.AddWordButton.Click += new System.EventHandler(this.AddWordButton_Click);
            // 
            // WordTextBox
            // 
            this.WordTextBox.Location = new System.Drawing.Point(371, 491);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.Size = new System.Drawing.Size(246, 20);
            this.WordTextBox.TabIndex = 7;
            // 
            // AddWordLabel
            // 
            this.AddWordLabel.AutoSize = true;
            this.AddWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWordLabel.Location = new System.Drawing.Point(367, 421);
            this.AddWordLabel.Name = "AddWordLabel";
            this.AddWordLabel.Size = new System.Drawing.Size(133, 31);
            this.AddWordLabel.TabIndex = 8;
            this.AddWordLabel.Text = "Add Word";
            // 
            // WordNameLabel
            // 
            this.WordNameLabel.AutoSize = true;
            this.WordNameLabel.Location = new System.Drawing.Point(372, 466);
            this.WordNameLabel.Name = "WordNameLabel";
            this.WordNameLabel.Size = new System.Drawing.Size(33, 13);
            this.WordNameLabel.TabIndex = 4;
            this.WordNameLabel.Text = "Word";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(372, 525);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(41, 13);
            this.WeightLabel.TabIndex = 4;
            this.WeightLabel.Text = "Weight";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(371, 550);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(246, 20);
            this.WeightTextBox.TabIndex = 7;
            // 
            // ClearButon
            // 
            this.ClearButon.Location = new System.Drawing.Point(499, 619);
            this.ClearButon.Name = "ClearButon";
            this.ClearButon.Size = new System.Drawing.Size(118, 73);
            this.ClearButon.TabIndex = 9;
            this.ClearButon.Text = "Clear";
            this.ClearButon.UseVisualStyleBackColor = true;
            this.ClearButon.Click += new System.EventHandler(this.ClearButon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.ClearButon);
            this.Controls.Add(this.AddWordLabel);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.WordTextBox);
            this.Controls.Add(this.AddWordButton);
            this.Controls.Add(this.Option4Label);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.WordNameLabel);
            this.Controls.Add(this.Option5Label);
            this.Controls.Add(this.Option3Label);
            this.Controls.Add(this.Option2Label);
            this.Controls.Add(this.Option1Label);
            this.Controls.Add(this.textBoxSearchBar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearchBar;
        private System.Windows.Forms.Label Option1Label;
        private System.Windows.Forms.Label Option2Label;
        private System.Windows.Forms.Label Option3Label;
        private System.Windows.Forms.Label Option5Label;
        private System.Windows.Forms.Label Option4Label;
        private System.Windows.Forms.Button AddWordButton;
        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.Label AddWordLabel;
        private System.Windows.Forms.Label WordNameLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Button ClearButon;
    }
}

