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
    public partial class AddLocation : Form
    {
        public AddLocation()
        {
            InitializeComponent();
        }

        private void AddLocation_Load(object sender, EventArgs e)
        {

        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }
    }
}
