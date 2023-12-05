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
            if (Regex.IsMatch(AisleTextBox.Text, RegExFormats.anynumber) && Regex.IsMatch(BayTextBox.Text, RegExFormats.anynumber))
            {
                Forms.conn.Open();
                SQLiteCommand sql = new SQLiteCommand($"SELECT Aisle, Bay FROM ValidLocations WHERE Aisle = '{AisleTextBox.Text}' AND Bay = '{BayTextBox.Text}'", Forms.conn);
                SQLiteDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("This location already exists");
                    reader.Close();
                    Forms.conn.Close();
                }
                else
                {
                    SQLiteCommand sql2 = new SQLiteCommand($"INSERT INTO ValidLocations VALUES ('{AisleTextBox.Text}', '{BayTextBox.Text}')", Forms.conn);
                    sql2.ExecuteNonQuery();
                    MessageBox.Show("Location Added");
                    reader.Close();
                    Forms.conn.Close();
                    Forms.viewemployeeactions.Action(2, $"Created Location Aisle {AisleTextBox.Text} Bay {BayTextBox.Text}");
                }
            }
            else
            {
                MessageBox.Show("Invalid inputs");
            }
        }
    }
}
