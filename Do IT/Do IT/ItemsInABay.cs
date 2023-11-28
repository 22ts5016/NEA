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
    public partial class ItemsInABay : Form
    {
        public string isle;
        public string bay;
        public string type;
        private int i = 0;

        public ItemsInABay()
        {
            InitializeComponent();
        }

        private void ItemsInABay_Load(object sender, EventArgs e)
        {
            TypeLabel.Text = type + ':';
            if(type == "Selling")
            {
                type = "1";                
            }
            else if (type == "MultiLocation")
            {
                type = "2";
            }
            else if (type == "Overstock")
            {
                type = "3";
            }
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT Products.barcode, ProductName FROM Products, ProductLocations WHERE Isle = '{isle}' AND Bay = '{bay}' AND Type = '{type}' AND Products.barcode = ProductLocations.Barcode", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();
            string name, barcode;
            while (reader.Read())
            {
                i++;
                name = (string)reader["ProductName"];
                barcode = (string)reader["Barcode"];
                Label label = new Label();
                label.AutoSize = true;
                label.Text = (name + " - " + barcode).PadRight(500, ' ');
                label.Name = barcode + "Label";
                LayoutPanel1.Controls.Add(label);

                Button btn1 = new Button();
                btn1.Text = "View Product";
                btn1.Name = barcode + "Button";
                btn1.Margin = new Padding(3, 3, 3, 30);
                btn1.Click += ViewProductButton_Click;
                LayoutPanel1.Controls.Add(btn1);

                Button btn2 = new Button();
                btn2.Text = "Relocate Product";
                btn2.Name = barcode + "Button";
                btn2.Margin = new Padding(3, 3, 3, 30);
                btn2.Click += RelocateButton_Click;
                LayoutPanel1.Controls.Add(btn2);

                Button btn3 = new Button();
                btn3.Text = "Delocate Product";
                btn3.Name = barcode + "Button";
                btn3.Margin = new Padding(3, 3, 3, 30);
                btn3.Click += DelocateButton_Click;
                LayoutPanel1.Controls.Add(btn3);
            }
            reader.Close();
            Forms.conn.Close();
        }

        private void ViewProductButton_Click(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            Forms.conn.Open();
            string barcode = clickedbutton.Name.Split('B')[0];
            SQLiteCommand sql = new SQLiteCommand($"SELECT Products.Barcode, ProductName, ProductDescription, Price, StockCount, Image, Isle, Bay, Sequence, Type FROM Products, ProductLocations WHERE Products.Barcode = {barcode} AND ProductLocations.Barcode = {barcode}", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                Forms.productquery.FillDisplayedItemInfo(reader, true);
            }
            reader.Close();
            Forms.conn.Close();
            Forms.displayeditem.Show();
            Forms.itemsinabay = new ItemsInABay();
            this.Dispose();
        }

        private void RelocateButton_Click(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            string barcode = clickedbutton.Name.Split('B')[0];
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"DELETE FROM ProductLocations WHERE Barcode = '{barcode}' AND Isle = '{isle}' AND Bay = '{bay}' AND Type = '{type}'", Forms.conn);
            sql.ExecuteNonQuery();
            SQLiteCommand sql1 = new SQLiteCommand($"SELECT ProductName FROM Products WHERE Barcode = '{barcode}'", Forms.conn);
            SQLiteDataReader reader = sql1.ExecuteReader();
            reader.Read();
            Forms.additemtolocation.name = (string)reader["ProductName"];
            Forms.additemtolocation.barcode = barcode;
            SQLiteCommand sql2 = new SQLiteCommand($"SELECT Barcode FROM ProductLocations WHERE Barcode = '{barcode}'", Forms.conn);
            SQLiteDataReader reader2 = sql2.ExecuteReader();
            if (!reader2.Read())
            {
                SQLiteCommand sql3 = new SQLiteCommand($"UPDATE Products SET Located = 2 WHERE Barcode = '{barcode}'", Forms.conn);
                sql3.ExecuteNonQuery();
            }
            reader.Close();
            reader2.Close();
            Forms.conn.Close();
            Forms.additemtolocation.Show();
            Forms.viewemployeeactions.Action(2, $"{barcode} delocated from isle {isle} bay {bay}");
            Forms.itemsinabay = new ItemsInABay();
            this.Dispose();
        }

        private void DelocateButton_Click(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            string barcode = clickedbutton.Name.Split('B')[0];
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"DELETE FROM ProductLocations WHERE Barcode = '{barcode}' AND Isle = '{isle}' AND Bay = '{bay}' AND Type = '{type}'", Forms.conn);
            sql.ExecuteNonQuery();
            SQLiteCommand sql1 = new SQLiteCommand($"SELECT Barcode FROM ProductLocations WHERE Barcode = '{barcode}'", Forms.conn);
            SQLiteDataReader reader= sql.ExecuteReader();
            if (!reader.Read())
            {
                SQLiteCommand sql2 = new SQLiteCommand($"UPDATE Products SET Located = 'f' WHERE Barcode = {barcode}", Forms.conn);
                sql2.ExecuteNonQuery();
            }
            reader.Close();
            Forms.conn.Close();
            Forms.locationmanagement.Show();
            Forms.itemsinabay = new ItemsInABay();
            MessageBox.Show("Product Delocated");
            Forms.viewemployeeactions.Action(2, $"{barcode} delacted from isle {isle} bay {bay}");
            this.Dispose();
            
        }

        private void AddItemToLocationButton_Click(object sender, EventArgs e)
        {
            Forms.additemtolocation.IsleTextBox.Text = isle;
            Forms.additemtolocation.BayTextBox.Text = bay;
            Forms.additemtolocation.completeinfo = false;
            switch (type)
            {
                case "1":
                    Forms.additemtolocation.SellingCheck.Checked = true;
                    break;
                case "2":
                    Forms.additemtolocation.MultiLocationCheck.Checked = true;
                    Forms.additemtolocation.SequenceLabel.Visible = false;
                    Forms.additemtolocation.SequenceTextBox.Visible = false;
                    break;
                case "3":
                    Forms.additemtolocation.OverstockCheck.Checked = true;
                    Forms.additemtolocation.SequenceLabel.Visible = false;
                    Forms.additemtolocation.SequenceTextBox.Visible = false;
                    break;
            }
            Forms.additemtolocation.Show();
            Forms.itemsinabay = new ItemsInABay();
            this.Dispose();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            Forms.itemsinabay = new ItemsInABay();
            this.Dispose();
        }
    }
}
