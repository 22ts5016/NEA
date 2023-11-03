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
    public partial class ItemsWithoutLocations : Form
    {
        private List<string> productstobelocated = new List<string>();

        public ItemsWithoutLocations()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            Forms.itemswithoutlocations = new ItemsWithoutLocations();
            this.Dispose();
        }

        private void ItemsWithoutLocations_Load(object sender, EventArgs e)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT ProductName, Barcode FROM Products WHERE Located = '2'", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();
            string name, barcode;
            while (reader.Read())
            {
                name = (string)reader["ProductName"];
                barcode = (string)reader["Barcode"];
                Button btn = new Button();
                btn.Text = name + "     |     " + barcode;
                btn.Name = barcode + "Button";
                btn.Width = 1200; 
                btn.Height = 40;
                btn.Click += Button_Click;
                LayoutPanel.Controls.Add(btn);

                CheckBox box = new CheckBox();
                box.Name = barcode + "Check" + name;
                box.CheckedChanged += Check_Change;
                LayoutPanel.Controls.Add(box);
            }
            Forms.conn.Close();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            Forms.additemtolocation.name = clickedbutton.Text.Split('|')[0].Trim();
            Forms.additemtolocation.barcode = clickedbutton.Text.Split('|')[1].Trim();
            Forms.additemtolocation.Show();
            Forms.itemswithoutlocations = new ItemsWithoutLocations();
            this.Dispose();
        }

        private void Check_Change(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            if (box.Checked)
            {
                productstobelocated.Add(box.Name);
            }
            else
            {
                productstobelocated.Remove(box.Name);
            }
        }

        private void AddSelectedItemsToLocationButton_Click(object sender, EventArgs e)
        {
            if(productstobelocated.Count != 0)
            {
                Forms.addmultipleitemstolocation.ActualItemsLabel.Text = "";
                foreach (string a in productstobelocated)
                {
                    Forms.addmultipleitemstolocation.ActualItemsLabel.Text += a.Substring(0, 13) + " - " + a.Substring(18) + "\n";
                }
                Forms.addmultipleitemstolocation.Show();
                Forms.itemswithoutlocations = new ItemsWithoutLocations();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No Products Selected");
            }
        }
    }
}
