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
using System.Text.RegularExpressions;

namespace Do_IT
{
    public partial class AddLocation : Form
    {
        public AddLocation()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(IsleTextBox.Text, RegExFormats.anynumber) && Regex.IsMatch(BayTextBox.Text, RegExFormats.anynumber))
            {
                Forms.conn.Open();
                SQLiteCommand sql = new SQLiteCommand($"SELECT Isle, Bay FROM ValidLocations WHERE Isle = '{IsleTextBox.Text}' AND Bay = '{BayTextBox.Text}'", Forms.conn);
                SQLiteDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("This location already exists");
                }
                else
                {
                    SQLiteCommand sql2 = new SQLiteCommand($"INSERT INTO ValidLocations VALUES ('{IsleTextBox.Text}', '{BayTextBox.Text}')", Forms.conn);
                    sql2.ExecuteNonQuery();
                    MessageBox.Show("Location Added");
                }
                reader.Close();
                Forms.conn.Close();
            }
            else
            {
                MessageBox.Show("Invalid inputs");
            }
        }
    }
}
