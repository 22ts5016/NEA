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
    public partial class LocationManagement : Form
    {
        public LocationManagement()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(IsleTextBox.Text, RegExFormats.anynumber) && Regex.IsMatch(BayTextBox.Text, RegExFormats.anynumber))
            {
                if (CheckValidLocation(IsleTextBox.Text, BayTextBox.Text))
                {
                    int selling = 0, multi = 0, over = 0;
                    string type;
                    Forms.conn.Open();
                    SQLiteCommand sql = new SQLiteCommand($"SELECT LocationType FROM ProductLocations, LocationTypes WHERE Isle = '{IsleTextBox.Text}' and Bay = '{BayTextBox.Text}' AND LocationTypeID = Type", Forms.conn);
                    SQLiteDataReader reader = sql.ExecuteReader();

                    while (reader.Read())
                    {
                        type = (string)reader["LocationType"];

                        if (type == "Selling")
                        {
                            selling++;
                        }
                        else if (type == "MultiLocation")
                        {
                            multi++;
                        }
                        else if (type == "Overstock")
                        {
                            over++;
                        }
                    }
                    Forms.conn.Close();
                    SellingButton.Text = ("Selling - " + selling);
                    MultiLocationButton.Text = ("MultiLocation - " + multi);
                    OverstockButton.Text = ("Overstock - " + over);

                    SellingLabel.Visible = true;
                    SellingButton.Visible = true;
                    MultiLocationLabel.Visible = true;
                    MultiLocationButton.Visible = true;
                    OverstockLabel.Visible = true;
                    OverstockButton.Visible = true;

                    Forms.itemsinabay.isle = IsleTextBox.Text;
                    Forms.itemsinabay.bay = BayTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Invalid Location");
                }
            }
            else
            {
                MessageBox.Show("Invalid inputs");
            }
        }

        public static bool CheckValidLocation(string isle, string bay)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT Bay FROM ValidLocations WHERE Isle = '{isle}' AND Bay = '{bay}'", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                Forms.conn.Close();
                return true;
            }
            reader.Close();
            Forms.conn.Close();
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.itemswithoutlocations.Show();
            this.Hide();
        }

        private void SellingButton_Click(object sender, EventArgs e)
        {
            Forms.itemsinabay.type = "Selling";
            Forms.itemsinabay.Show();
            Reset();
            this.Hide();
        }

        private void MultiLocationButton_Click(object sender, EventArgs e)
        {
            Forms.itemsinabay.type = "MultiLocation";
            Forms.itemsinabay.Show();
            Reset();
            this.Hide();
        }

        private void OverstockButton_Click(object sender, EventArgs e)
        {
            Forms.itemsinabay.type = "Overstock";
            Forms.itemsinabay.Show();
            Reset();
            this.Hide();
        }

        private void Reset()
        {
            IsleTextBox.Text = "";
            BayTextBox.Text = "";

            SellingLabel.Visible = false;
            SellingButton.Visible = false;
            MultiLocationLabel.Visible = false;
            MultiLocationButton.Visible = false;
            OverstockLabel.Visible = false;
            OverstockButton.Visible = false;

            Forms.locationmanagement.IsleTextBox.Select();
        }
    }
}
