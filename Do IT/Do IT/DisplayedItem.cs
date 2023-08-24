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
        public DisplayedItem()
        {
            InitializeComponent();
        }

        private void DisplayedItem_Load(object sender, EventArgs e)
        {
            ProductNameLabel.Text = DisplayedItemInfo.name;
            ProductDescrpitionLabel.Text = DisplayedItemInfo.description;
            PriceLabel.Text = DisplayedItemInfo.price.ToString();
            ProductImagePictureBox.Image = DisplayedItemInfo.image;
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }
    }
}
