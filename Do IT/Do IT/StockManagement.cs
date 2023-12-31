﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Do_IT
{
    public partial class StockManagement : Form
    {
        public StockManagement()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void StockAdjustmentButton_Click(object sender, EventArgs e)
        {
            Forms.stockadjustment.Show();
            this.Hide();
        }

        private void StockWriteOff_Click(object sender, EventArgs e)
        {
            Forms.stockwriteoff.Show();
            this.Hide();
        }
    }
}
