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

namespace Do_IT
{
    public partial class ProductQuery : Form
    {
        public ProductQuery()
        {
            InitializeComponent();
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

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ProductNameCheckBox.Checked)
            {
                string word = SearchTextBox.Text.ToLower();
                string[] options = new string[5];
                try
                {
                    options = RootedTree.getRoot().Search(word);
                    for (int i = 0; i < options.Length; i++)
                    {
                        if (options[i] != null)
                        {
                            options[i] = word + options[i];
                        }
                    }
                    Option1Label.Text = options[0];
                    Option2Label.Text = options[1];
                    Option3Label.Text = options[2];
                    Option4Label.Text = options[3];
                    Option5Label.Text = options[4];


                }
                catch (LetterNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (IndexOutOfRangeException)
                {

                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("That is not a valid start letter, please try again");
                }
            }
        }

        public void AddWords()
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT Barcode, ProductName, Weight FROM Products", Forms.conn);
            SQLiteDataReader reader;
            reader = sql.ExecuteReader();
            while (reader.Read())
            {
                RootedTree.AddWord(Convert.ToInt32(reader["Weight"]) + "," + ((string)reader["ProductName"]).ToLower() + "*");
            }

            Forms.conn.Close();
        }

        private void ProductQuery_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (ProductNameCheckBox.Checked)
            {

            }
            else
            {
                Forms.conn.Open();
                SQLiteCommand sql = new SQLiteCommand($"SELECT Products.Barcode, ProductName, ProductDescription, Price, StockCount, Image, Isle, Bay, Sequence, Type FROM Products, Locations WHERE Products.Barcode = {SearchTextBox.Text} AND Locations.Barcode = {SearchTextBox.Text}", Forms.conn);
                SQLiteDataReader reader;
                reader = sql.ExecuteReader();
                
                if (reader.Read())
                {
                    DisplayedItemInfo.name = (string)reader["ProductName"];
                    DisplayedItemInfo.barcode = (string)reader["Barcode"];
                    DisplayedItemInfo.description = (string)reader["ProductDescription"];
                    DisplayedItemInfo.price = Convert.ToDouble(reader["Price"]);
                    DisplayedItemInfo.stock = Convert.ToInt32(reader["StockCount"]);
                    DisplayedItemInfo.isle = Convert.ToInt32(reader["Isle"]);
                    DisplayedItemInfo.bay = Convert.ToInt32(reader["Bay"]);
                    DisplayedItemInfo.sequence = Convert.ToInt32(reader["Sequence"]);
                    DisplayedItemInfo.image = new Bitmap(new MemoryStream((byte[])reader["Image"]));
                    Forms.displayitem.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid barcode");
                }
                reader.Close();
                Forms.conn.Close();
            }
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void Option1Label_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = Option1Label.Text;
        }

        private void Option2Label_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = Option2Label.Text;
        }

        private void Option3Label_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = Option3Label.Text;
        }

        private void Option4Label_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = Option4Label.Text;
        }

        private void Option5Label_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = Option5Label.Text;
        }
    }
}