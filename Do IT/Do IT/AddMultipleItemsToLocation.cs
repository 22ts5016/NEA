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
            string aisle = AisleTextBox.Text, bay = BayTextBox.Text;
            if (LocationManagement.CheckValidLocation(aisle, bay))
            {
                string values = "";
                int type;
                string barcode;
                List<string> barcodelist = new List<string>();
                string[] items = ActualItemsLabel.Text.Split('\n');

                if (MultiLocationCheck.Checked)
                {
                    type = 2;
                }
                else
                {
                    type = 3;
                }

                Forms.conn.Open();
                SQLiteCommand sql;
                for(int i = 0; i < items.Length - 1; i++)
                {
                    if(i > 0)
                    {
                        values += ',';
                    }
                    barcode = items[i].Substring(0, 13);
                    sql = new SQLiteCommand($"UPDATE Products SET Located = '1' WHERE Barcode = '{barcode}'", Forms.conn);
                    sql.ExecuteNonQuery();
                    barcodelist.Add(barcode);
                    values += $"('{barcode}', '{aisle}', '{bay}', 'null', '{type}')";
                }

                
                SQLiteCommand sql2 = new SQLiteCommand($"INSERT INTO ProductLocations VALUES {values}", Forms.conn);
                sql2.ExecuteNonQuery();
                Forms.conn.Close();

                Forms.itemswithoutlocations = new ItemsWithoutLocations();
                Forms.itemswithoutlocations.Show();
                Forms.addmultipleitemstolocation = new AddMultipleItemsToLocation();
                
                string listofitems = "";
                for(int i = 0; i < barcodelist.Count; i++)
                {
                    listofitems += barcodelist[i];
                    if (i < barcodelist.Count - 1)
                    {
                        listofitems += ',';
                    }
                     
                }
                ViewEmployeeActions.Action(2, $"Added: {listofitems} to {aisle},{bay} type:{type}");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Invalid location");
            }
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

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }
    }
}
