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
            this.Option1Label.Size = new System.Drawing.Size(35, 13);
            this.Option1Label.TabIndex = 1;
            this.Option1Label.Text = "label1";
            // 
            // Option2Label
            // 
            this.Option2Label.AutoSize = true;
            this.Option2Label.Location = new System.Drawing.Point(372, 174);
            this.Option2Label.Name = "Option2Label";
            this.Option2Label.Size = new System.Drawing.Size(35, 13);
            this.Option2Label.TabIndex = 2;
            this.Option2Label.Text = "label1";
            // 
            // Option3Label
            // 
            this.Option3Label.AutoSize = true;
            this.Option3Label.Location = new System.Drawing.Point(372, 196);
            this.Option3Label.Name = "Option3Label";
            this.Option3Label.Size = new System.Drawing.Size(35, 13);
            this.Option3Label.TabIndex = 3;
            this.Option3Label.Text = "label1";
            // 
            // Option5Label
            // 
            this.Option5Label.AutoSize = true;
            this.Option5Label.Location = new System.Drawing.Point(372, 240);
            this.Option5Label.Name = "Option5Label";
            this.Option5Label.Size = new System.Drawing.Size(35, 13);
            this.Option5Label.TabIndex = 4;
            this.Option5Label.Text = "label1";
            // 
            // Option4Label
            // 
            this.Option4Label.AutoSize = true;
            this.Option4Label.Location = new System.Drawing.Point(372, 218);
            this.Option4Label.Name = "Option4Label";
            this.Option4Label.Size = new System.Drawing.Size(35, 13);
            this.Option4Label.TabIndex = 5;
            this.Option4Label.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.Option4Label);
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
    }
}

