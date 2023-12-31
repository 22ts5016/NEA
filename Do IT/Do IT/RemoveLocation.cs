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
using System.Text.RegularExpressions;

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
            if (Regex.IsMatch(AisleTextBox.Text, RegExFormats.anynumber) && Regex.IsMatch(BayTextBox.Text, RegExFormats.anynumber))
            {
                Forms.conn.Open();
                SQLiteCommand sql = new SQLiteCommand($"SELECT Aisle, Bay FROM ValidLocations WHERE Aisle = '{AisleTextBox.Text}' AND Bay = '{BayTextBox.Text}'", Forms.conn);
                SQLiteDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    SQLiteCommand sql2 = new SQLiteCommand($"DELETE FROM ValidLocations WHERE Aisle = '{AisleTextBox.Text}' AND Bay = '{BayTextBox.Text}'", Forms.conn);
                    sql2.ExecuteNonQuery();
                    SQLiteCommand sql3 = new SQLiteCommand($"DELETE FROM ProductLocations WHERE Aisle = '{AisleTextBox.Text}' AND Bay = '{BayTextBox.Text}'", Forms.conn);
                    sql3.ExecuteNonQuery();
                    SQLiteCommand sql4 = new SQLiteCommand($"UPDATE Products SET Located = 2 WHERE Located = 1 AND Barcode NOT IN (SELECT DISTINCT Barcode FROM ProductLocations)", Forms.conn);
                    sql4.ExecuteNonQuery();
                    MessageBox.Show("Location Removed");
                    reader.Close();
                    Forms.conn.Close();
                    Forms.viewemployeeactions.Action(2, $"aisle {AisleTextBox.Text} bay {BayTextBox.Text} removed");
                }
                else
                {
                    MessageBox.Show("Invalid Location");
                    reader.Close();
                    Forms.conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}
