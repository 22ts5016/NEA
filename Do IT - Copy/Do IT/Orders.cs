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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void ViewOrderButton_Click(object sender, EventArgs e)
        {
            Forms.vieworder.Show();
            this.Hide();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Forms.createorder.Show();
            this.Hide();
        }
    }
}
