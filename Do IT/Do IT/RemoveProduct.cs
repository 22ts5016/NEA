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
    public partial class RemoveProduct : Form
    {
        public RemoveProduct()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void ProductNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ProductNameCheckBox.Checked)
            {
                BarcodeCheckBox.Checked = false;
            }
            else
            {
                BarcodeCheckBox.Checked = true;
            }
        }

        private void BarcodeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BarcodeCheckBox.Checked)
            {
                ProductNameCheckBox.Checked = false;
            }
            else
            {
                ProductNameCheckBox.Checked = true;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Forms.conn.Open();
            string name = RemoveTextBox.Text;
            string barcode = name;
            string start = "null";
            if (ProductNameCheckBox.Checked)
            {
                SQLiteCommand sql = new SQLiteCommand($"SELECT Weight, Barcode FROM Products WHERE ProductName COLLATE NOCASE = '{RemoveTextBox.Text}'", Forms.conn);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    barcode = (string)reader["Barcode"];
                    start = RootedTree.getRoot().SearchForStartOfRemoval(name.ToLower() + "*", Convert.ToInt32(reader["Weight"]));
                }
                else
                {
                    MessageBox.Show("Invalid Product");
                    return;
                }
                reader.Close();
            }
            else if (BarcodeCheckBox.Checked)
            {
                SQLiteCommand sql2 = new SQLiteCommand($"SELECT ProductName, Weight FROM Products WHERE Barcode = {name}", Forms.conn);
                SQLiteDataReader reader = sql2.ExecuteReader();
                if (reader.Read())
                {
                    name = ((string)reader["ProductName"]).ToLower();
                    start = RootedTree.getRoot().SearchForStartOfRemoval(name + "*", Convert.ToInt32(reader["Weight"]));
                }
                else
                {
                    MessageBox.Show("Invalid Barcode");
                    Forms.conn.Close();
                    return;
                }
                reader.Close();
            }

            SQLiteCommand sql3 = new SQLiteCommand($"DELETE FROM Products WHERE ProductName COLLATE NOCASE = '{name}'", Forms.conn);
            sql3.ExecuteNonQuery();

            SQLiteCommand sql4 = new SQLiteCommand($"DELETE FROM ProductLocations WHERE ProductLocations.Barcode = {barcode}", Forms.conn);
            sql4.ExecuteNonQuery();

            SQLiteCommand sql5 = new SQLiteCommand($"SELECT ProductName, Weight FROM Products WHERE ProductName LIKE '{start.Substring(1)}%'", Forms.conn);
            SQLiteDataReader reader2 = sql5.ExecuteReader();

            while (reader2.Read())
            {
                RootedTree.AddWord(Convert.ToInt32(reader2["Weight"]), ((string)reader2["ProductName"]).ToLower());
            }
            MessageBox.Show("Product Removed");
            Forms.conn.Close();
        }
    }
}
