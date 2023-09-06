using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_IT
{
    public partial class DisplayedItem : Form
    {
        public string name;
        public string barcode;
        public string description;
        public double price;
        public int stock;
        public List<int> isle = new List<int>();
        public List<int> bay = new List<int>();
        public List<string> sequence = new List<string>();
        public List<string> type = new List<string>();
        public Bitmap image;

        public DisplayedItem()
        {
            InitializeComponent();
        }

        private void DisplayedItem_Load(object sender, EventArgs e)
        {
            ProductNameLabel.Text = name;
            BarcodeLabel.Text = barcode;
            ProductDescrpitionLabel.Text = description;
            PriceLabel.Text = '£' + price.ToString();
            CurrentStockLabel.Text = "Curent Stock: " + stock;
            ProductImagePictureBox.Image = image;

            for(int i = 0; i < isle.Count; i++)
            {
                Button btn1 = new Button();
                btn1.Name = i + "_" + isle[i] + "_Button";
                btn1.Text = isle[i].ToString();
                btn1.Width = 100;
                btn1.Click += Btn1_Click;
                LayoutPanel1.Controls.Add(btn1);

                Button btn2 = new Button();
                btn2.Name = i + "_" + isle[i] + "_" + bay[i] + "_Button";
                btn2.Text = bay[i].ToString();
                btn2.Width = 100;
                btn2.Click += Btn2_Click;
                LayoutPanel1.Controls.Add(btn2);

                Button btn3 = new Button();
                btn3.Name = i + "Sequence" + sequence[i] + "Button";
                btn3.Text = sequence[i].ToString();
                btn3.Width = 100;
                LayoutPanel1.Controls.Add(btn3);

                Button btn4 = new Button();
                btn4.Name = i + "_" + isle[i] + "_" + bay[i] + "_Type_Button";
                btn4.Text = type[i].ToString();
                btn4.Width = 100;
                btn4.Click += Btn4_Click;
                LayoutPanel1.Controls.Add(btn4);
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            Forms.locationmanagement.IsleTextBox.Text = clickedbutton.Text;
            Forms.locationmanagement.BayTextBox.Select();
            Forms.locationmanagement.Show();
            Forms.displayeditem = new DisplayedItem();
            this.Dispose();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            Forms.locationmanagement.IsleTextBox.Text = clickedbutton.Name.Split('_')[1];
            Forms.locationmanagement.BayTextBox.Text = clickedbutton.Text;
            Forms.locationmanagement.SearchButton.Select();
            Forms.locationmanagement.Show();
            Forms.displayeditem = new DisplayedItem();
            this.Dispose();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            Forms.itemsinabay.isle = clickedbutton.Name.Split('_')[1];
            Forms.itemsinabay.bay = clickedbutton.Name.Split('_')[2];
            Forms.itemsinabay.type = clickedbutton.Text;
            Forms.itemsinabay.Show();
            Forms.displayeditem = new DisplayedItem();
            this.Dispose();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            Forms.displayeditem = new DisplayedItem();
            this.Dispose();
        }
    }
}
