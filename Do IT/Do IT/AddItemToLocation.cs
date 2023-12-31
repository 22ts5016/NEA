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
using System.IO;
using static System.Net.WebRequestMethods;
using System.Text.RegularExpressions;

namespace Do_IT
{
    public partial class AddItemToLocation : Form
    {
        public string name;
        public string barcode;
        public bool completeinfo = true;

        public AddItemToLocation()
        {
            InitializeComponent();
        }

        private void AddItemToLocation_Load(object sender, EventArgs e)
        {
            if (completeinfo)
            {
                ItemNameTextBox.Text = name;
                BarcodeTextBox.Text = barcode;
                Forms.conn.Open();
                SQLiteCommand sql = new SQLiteCommand($"SELECT Image FROM Products WHERE Barcode = '{barcode}'", Forms.conn);
                SQLiteDataReader reader = sql.ExecuteReader();
                reader.Read();
                ImagePictureBox.Image = new Bitmap(new MemoryStream((byte[])reader["Image"]));
                reader.Close();
                Forms.conn.Close();
                SellingCheck.Checked = true;
            }
            else
            {
                AutoFillButton.Visible = true;
                ItemNameTextBox.Select();
            }
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            Forms.additemtolocation = new AddItemToLocation();
            this.Dispose();
        }

        private void LocationManagementButton_Click(object sender, EventArgs e)
        {
            Forms.locationmanagement.Show();
            Forms.additemtolocation = new AddItemToLocation();
            this.Dispose();
        }

        private void UnlocatedProductsButton_Click(object sender, EventArgs e)
        {
            Forms.itemswithoutlocations.Show();
            Forms.additemtolocation = new AddItemToLocation();
            this.Dispose();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string seq;
            int type;
            bool validsequence = true;
            barcode = BarcodeTextBox.Text;
            if(LocationManagement.CheckValidLocation(AisleTextBox.Text, BayTextBox.Text) && CheckValidItem())
            {
                if (!CheckIfAlreadyLocated())
                {
                    if (SellingCheck.Checked)
                    {
                        seq = SequenceTextBox.Text;
                        type = 1;
                        validsequence = CheckValidSequence(AisleTextBox.Text, BayTextBox.Text, seq);
                    }
                    else
                    {
                        if (MultiLocationCheck.Checked)
                        {
                            type = 2;
                        }
                        else
                        {
                            type = 3;
                        }
                        seq = "null";
                    }
                    if (validsequence)
                    {
                        Forms.conn.Open();
                        string barcode = BarcodeTextBox.Text, aisle = AisleTextBox.Text, bay = BayTextBox.Text;
                        SQLiteCommand sql = new SQLiteCommand($"INSERT INTO ProductLocations VALUES('{barcode}', '{aisle}', '{bay}', '{seq}', '{type}')", Forms.conn);
                        sql.ExecuteNonQuery();
                        SQLiteCommand sql2 = new SQLiteCommand($"UPDATE Products SET Located = '1' WHERE Barcode = {barcode}", Forms.conn);
                        sql2.ExecuteNonQuery();
                        MessageBox.Show("Item Added Successfully");
                        Forms.locationmanagement.Show();
                        Forms.additemtolocation = new AddItemToLocation();
                        SQLiteCommand sql3 = new SQLiteCommand($"SELECT LocationType FROM LocationTypes WHERE LocationtypeID = '{type}'", Forms.conn);
                        SQLiteDataReader reader = sql3.ExecuteReader();
                        reader.Read();
                        string stringtype = (string)reader["LocationType"];
                        reader.Close();
                        Forms.conn.Close();
                        Forms.viewemployeeactions.Action(2, $"{barcode} added to {aisle},{bay} type:{stringtype}");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Sequence");
                    }
                }
                else
                {
                    MessageBox.Show("This product is already located to this bay with this selling type");
                }
            }
            else
            {
                MessageBox.Show("Invalid Location");
            }
        }

        private bool CheckIfAlreadyLocated()
        {
            int type = 0;

            if (SellingCheck.Checked)
            {
                type = 1;
            }
            else if (MultiLocationCheck.Checked)
            {
                type = 2;
            }
            else if (OverstockCheck.Checked)
            {
                type = 3;
            }
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT Barcode FROM ProductLocations WHERE aisle = '{AisleTextBox.Text}' AND Bay = '{BayTextBox.Text}' AND Type = {type} AND Barcode = '{barcode}'", Forms.conn);
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

        private void SellingCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SellingCheck.Checked)
            {
                MultiLocationCheck.Checked = false;
                OverstockCheck.Checked = false;
                SequenceLabel.Visible = true;
                SequenceTextBox.Visible = true;
            }
            else
            {
                if(!MultiLocationCheck.Checked && !OverstockCheck.Checked)
                {
                    SellingCheck.Checked = true;
                }
                else
                {
                    SequenceLabel.Visible = false;
                    SequenceTextBox.Visible = false;
                }
            }
        }

        private void MultiLocationCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (MultiLocationCheck.Checked)
            {
                SellingCheck.Checked = false;
                OverstockCheck.Checked = false;
            }
            else
            {
                if (!SellingCheck.Checked && !OverstockCheck.Checked)
                {
                    MultiLocationCheck.Checked = true;
                }
            }
        }

        private void OverstockCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (OverstockCheck.Checked)
            {
                SellingCheck.Checked = false;
                MultiLocationCheck.Checked = false;
            }
            else
            {
                if (!SellingCheck.Checked && !MultiLocationCheck.Checked)
                {
                    OverstockCheck.Checked = true;
                }
            }
        }

        private bool CheckValidSequence(string aisle, string bay, string seq)
        {
            if (Regex.IsMatch(seq, RegExFormats.anynumber))
            {
                Forms.conn.Open();
                SQLiteCommand sql = new SQLiteCommand($"SELECT Barcode FROM ProductLocations WHERE aisle = '{aisle}' AND Bay = {bay} AND Sequence = {seq}", Forms.conn);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    Forms.conn.Close();
                    return false;
                }
                reader.Close();
                Forms.conn.Close();
            }
            else
            {
                return false;
            }
            return true;
        }
        
        private bool CheckValidItem()
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT Barcode FROM Products WHERE Barcode = '{BarcodeTextBox.Text}' AND ProductName COLLATE NOCASE = '{ItemNameTextBox.Text}'", Forms.conn);
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

        private void AutoFillButton_Click(object sender, EventArgs e)
        {
            Forms.conn.Open();
            if(ItemNameTextBox.Text == "")
            {
                SQLiteCommand sql = new SQLiteCommand($"SELECT ProductName, Image FROM Products WHERE Barcode = '{BarcodeTextBox.Text}'", Forms.conn);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    ItemNameTextBox.Text = (string)reader["Productname"];
                    ImagePictureBox.Image = new Bitmap(new MemoryStream((byte[])reader["Image"]));
                }
                else
                {
                    MessageBox.Show("Invalid Barcode");
                }
                reader.Close();
            }
            else if(BarcodeTextBox.Text == "")
            {
                SQLiteCommand sql = new SQLiteCommand($"SELECT Barcode, Image FROM Products WHERE ProductName COLLATE NOCASE = '{ItemNameTextBox.Text}'", Forms.conn);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    BarcodeTextBox.Text = (string)reader["Barcode"];
                    ImagePictureBox.Image = new Bitmap(new MemoryStream((byte[])reader["Image"]));
                }
                else
                {
                    MessageBox.Show("Invalid Product Name");
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("Please leave one text box blank");
            }
            Forms.conn.Close();
        }
    }
}
