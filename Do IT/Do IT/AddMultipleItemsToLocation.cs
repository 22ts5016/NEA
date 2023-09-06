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
    public partial class AddMultipleItemsToLocation : Form
    {
        public AddMultipleItemsToLocation()
        {
            InitializeComponent();
        }

        private void AddMultipleItemsToLocation_Load(object sender, EventArgs e)
        {
            MultiLocationCheck.Checked = true;
        }

        private void MultiLocationCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (MultiLocationCheck.Checked)
            {
                OverstockCheck.Checked = false;
            }
            else
            {
                OverstockCheck.Checked = true;
            }
        }

        private void OverstockCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (OverstockCheck.Checked)
            {
                MultiLocationCheck.Checked = false;
            }
            else
            {
                MultiLocationCheck.Checked = true;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (LocationManagement.CheckValidLocation(IsleTextBox.Text, BayTextBox.Text))
            {
                string values = "";
                string type;
                string[] items = ActualItemsLabel.Text.Split('\n');

                if (MultiLocationCheck.Checked)
                {
                    type = "MultiLocation";
                }
                else
                {
                    type = "Overstock";
                }

                for(int i = 0; i < items.Length - 1; i++)
                {
                    if(i > 0)
                    {
                        values += ',';
                    }
                    values += $"('{items[i].Substring(0,13)}', '{IsleTextBox.Text}', '{BayTextBox.Text}', 'null', '{type}')";
                }

                Forms.conn.Open();
                SQLiteCommand sql = new SQLiteCommand($"INSERT INTO ProductLocations VALUES {values}", Forms.conn);
                sql.ExecuteNonQuery();
                Forms.conn.Close();
            }
            else
            {
                MessageBox.Show("Invalid location");
            }
            Forms.itemswithoutlocations.Show();
            Forms.addmultipleitemstolocation = new AddMultipleItemsToLocation();
            this.Dispose();
        }

        private void UnlocatedProductsButton_Click(object sender, EventArgs e)
        {
            Forms.itemswithoutlocations.Show();
            Forms.addmultipleitemstolocation = new AddMultipleItemsToLocation();
            this.Dispose();
        }

        private void LocationManagementButton_Click(object sender, EventArgs e)
        {
            Forms.locationmanagement.Show();
            Forms.addmultipleitemstolocation = new AddMultipleItemsToLocation();
            this.Dispose();
        }
    }
}
