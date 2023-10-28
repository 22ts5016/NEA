using System;
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
    public partial class RemoveLocation : Form
    {
        public RemoveLocation()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Finnish this
            //
            // Need to change delocate items in that bay
            //
            // If that was only location for an item, change it to unlocated
            //

            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT Isle, Bay FROM ValidLocations WHERE Isle = '{IsleTextBox.Text}' AND Bay = '{BayTextBox.Text}')", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();

            if (reader.Read())
            {

            }
            else
            {
                MessageBox.Show("Invalid Location");
            }
        }
    }
}
