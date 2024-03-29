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
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Data.Entity.Core.Metadata.Edm;

namespace Do_IT
{
    public partial class ProductQuery : Form
    {
        private bool labelselected = false;

        public ProductQuery()
        {
            InitializeComponent();
        }

        private void ProductNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ProductNameCheckBox.Checked)
            {
                BarcodeCheckBox.Checked = false;
                ExactProductNameCheckBox.Checked = false;
            }
            else
            {
                if (!ExactProductNameCheckBox.Checked && !BarcodeCheckBox.Checked)
                {
                    ProductNameCheckBox.Checked = true;
                }
                else
                {
                    BarcodeCheckBox.Checked = false;
                    ExactProductNameCheckBox.Checked = false;
                }
            }
        }

        private void ExactProductNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ExactProductNameCheckBox.Checked)
            {
                BarcodeCheckBox.Checked = false;
                ProductNameCheckBox.Checked = false;
            }
            else
            {
                if (!ProductNameCheckBox.Checked && !BarcodeCheckBox.Checked)
                {
                    ExactProductNameCheckBox.Checked = true;
                }
                else
                {
                    BarcodeCheckBox.Checked = false;
                    ProductNameCheckBox.Checked = false;
                }
            }
        }

        private void BarcodeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BarcodeCheckBox.Checked)
            {
                ExactProductNameCheckBox.Checked = false;
                ProductNameCheckBox.Checked = false;
            }
            else
            {
                if (!ExactProductNameCheckBox.Checked && !ProductNameCheckBox.Checked)
                {
                    BarcodeCheckBox.Checked = true;
                }
                else
                {
                    ExactProductNameCheckBox.Checked = false;
                    ProductNameCheckBox.Checked = false;
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
           LayoutPanel1.Visible = false;
            if (ProductNameCheckBox.Checked || ExactProductNameCheckBox.Checked)
            {
                if (!labelselected)
                {
                    string word = SearchTextBox.Text.ToLower();
                    if (word.Length == 0)
                    {
                        LabelStatus(false);
                    }
                    else
                    {
                        LabelStatus(true);
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
                        catch (LetterNotFoundException)
                        {
                            LabelStatus(false);
                        }
                    }
                }
                else
                {
                    labelselected = false;
                }
            }

        }

        public static void AddWords()
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT ProductName, Weight FROM Products", Forms.conn);
            SQLiteDataReader reader;
            reader = sql.ExecuteReader();
            while (reader.Read())
            {
                RootedTree.AddWord(Convert.ToInt32(reader["Weight"]), ((string)reader["ProductName"]).ToLower() + "*");
            }
            reader.Close();
            Forms.conn.Close();
        }

        private void ProductQuery_Load(object sender, EventArgs e)
        {
            ProductNameCheckBox.Checked = true;
            SortByComboBox.SelectedIndex = 0;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LayoutPanel1.Controls.Clear();
            LayoutPanel1.Visible = true;
            LabelStatus(false);
            if(SearchTextBox.Text.Length != 0)
            {
                if (ProductNameCheckBox.Checked)
                {
                    Forms.conn.Open();
                    string param = GetParameters(SearchTextBox.Text);
                    string sortby = "";
                    switch (SortByComboBox.SelectedIndex)
                    {
                        case 0:
                            sortby = "ORDER BY Weight DESC, ProductName ASC";
                            break;
                        case 1:
                            sortby = "ORDER BY Price DESC, ProductName ASC";
                            break;
                        case 2:
                            sortby = "ORDER BY Price ASC, ProductName ASC";
                            break;
                        case 3:
                            sortby = "ORDER BY ProductName ASC";
                            break;
                        case 4:
                            sortby = "AND StockCount > 0 ORDER BY StockCount DESC, ProductName ASC";
                            break;
                    }
                    SQLiteCommand sql = new SQLiteCommand($"SELECT ProductName, Barcode, Price, StockCount, Weight, Image FROM Products WHERE {param} {sortby}", Forms.conn);
                    SQLiteDataReader reader = sql.ExecuteReader();

                    string name, barcode;

                    while (reader.Read())
                    {
                        name = (string)reader["ProductName"];
                        barcode = (string)reader["Barcode"];

                        PictureBox image = new PictureBox();
                        image.Size = new Size(284, 284);
                        image.Image = new Bitmap(new MemoryStream((byte[])reader["Image"]));
                        LayoutPanel1.Controls.Add(image);

                        TableLayoutPanel table = new TableLayoutPanel();

                        table.Name = name;
                        table.Height = 284;
                        table.Width = 950;
                        table.ColumnCount = 3;
                        table.RowCount = 3;

                        Label namelabel = new Label();
                        namelabel.Name = name + "_Label";
                        namelabel.Text = name;
                        namelabel.Font = new Font(namelabel.Font.FontFamily, 13);
                        namelabel.Name = name;
                        namelabel.AutoSize = true;
                        namelabel.Margin = new Padding(0, 0, 0, 10);

                        table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                        table.Controls.Add(namelabel, 0, 0);
                        table.ColumnStyles[0].Width = 700;

                        Label barcodelabel = new Label();
                        barcodelabel.Text = barcode;
                        barcodelabel.Font = new Font(barcodelabel.Font.FontFamily, 10);
                        barcodelabel.Name = barcode + "_Label";
                        barcodelabel.AutoSize = true;
                        barcodelabel.Margin = new Padding(0, 0, 0, 150);

                        table.Controls.Add(barcodelabel, 0, 1);

                        Label stocklabel = new Label();
                        stocklabel.Text = "Stock: " + Convert.ToInt32(reader["StockCount"]);
                        stocklabel.Font = new Font(stocklabel.Font.FontFamily, 10);
                        stocklabel.Name = name + "_Stock";
                        stocklabel.AutoSize = true;

                        table.Controls.Add(stocklabel, 0, 2);

                        Label pricelabel = new Label();
                        pricelabel.Text = "£" + Convert.ToDecimal(reader["Price"]);
                        pricelabel.Font = new Font(pricelabel.Font.FontFamily, 10);
                        pricelabel.Name = name + "_Price";
                        pricelabel.AutoSize = true;
                        pricelabel.Anchor = AnchorStyles.Right;

                        table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                        table.Controls.Add(pricelabel, 1, 0);
                        table.ColumnStyles[1].Width = 125;

                        Button viewbutton = new Button();
                        viewbutton.Font = new Font(viewbutton.Font.FontFamily, 10);
                        viewbutton.Name = barcode + "_ViewItemButton";
                        viewbutton.Text = "View Product";
                        viewbutton.Size = new Size(100, 100);
                        viewbutton.Anchor = AnchorStyles.Right;

                        viewbutton.Click += ViewButton_Click;

                        table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                        table.Controls.Add(viewbutton, 1, 1);
                        table.ColumnStyles[1].Width = 125;

                        Button addtoorderbutton = new Button();
                        addtoorderbutton.Font = new Font(addtoorderbutton.Font.FontFamily, 10);
                        addtoorderbutton.Name = barcode + "_AddToOrder_Button";
                        addtoorderbutton.Text = "Add To Order";
                        addtoorderbutton.Size = new Size(100, 100);
                        addtoorderbutton.Anchor = AnchorStyles.Left;

                        addtoorderbutton.Click += AddToOrderButton_Click;

                        table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                        table.Controls.Add(addtoorderbutton, 2, 1);
                        table.ColumnStyles[2].Width = 125;

                        LayoutPanel1.Controls.Add(table);

                    }
                    Forms.conn.Close();
                    ItemCountLabel.Text = LayoutPanel1.Controls.Count / 2 + " products displayed";
                }
                else if (ExactProductNameCheckBox.Checked)
                {
                    Forms.conn.Open();
                    string name = SearchTextBox.Text;
                    SQLiteCommand sql = new SQLiteCommand($"SELECT Barcode, Weight FROM Products WHERE ProductName COLLATE NOCASE = '{name}'", Forms.conn);
                    SQLiteDataReader reader = sql.ExecuteReader();
                    if (reader.Read())
                    {
                        int weight = Convert.ToInt32(reader["Weight"]) + 1;
                        string barcode = (string)reader["Barcode"];
                        reader.Close();
                        Forms.conn.Close();

                        ShowItem(barcode);

                        Forms.conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("That is not the name of an item");
                        Forms.conn.Close();
                    }
                }
                else if (BarcodeCheckBox.Checked)
                {
                    if (Regex.IsMatch(SearchTextBox.Text, RegExFormats.anynumber))
                    {
                        if (CheckBarcodeInDatabase(SearchTextBox.Text))
                        {
                            ShowItem(SearchTextBox.Text);
                        }
                        else
                        {
                            MessageBox.Show("Invalid barcode");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a search input");
            }
        }

        private void ShowItem(string barcode)
        {
            bool located = CheckLocated(barcode, "barcode");
            Forms.conn.Open();
            SQLiteCommand sql;
            if (located)

            {
                sql = new SQLiteCommand($"SELECT Products.Barcode, ProductName, ProductDescription, Price, StockCount, Image, Aisle, Bay, Sequence, Type, Weight FROM Products, ProductLocations WHERE Products.Barcode = '{barcode}' AND Products.Barcode = ProductLocations.Barcode", Forms.conn);
            }
            else
            {
                sql = new SQLiteCommand($"SELECT Products.Barcode, ProductName, ProductDescription, Price, StockCount, Image, Weight FROM Products WHERE Products.Barcode = '{barcode}'", Forms.conn);
            }
            SQLiteDataReader reader;
            reader = sql.ExecuteReader();

            if (reader.Read())
            {
                string productname = (string)reader["ProductName"];
                int newweight = Convert.ToInt32(reader["Weight"]) + 1;

                if (located)
                {
                    FillDisplayedItemInfo(reader, true);
                    while (reader.Read())
                    {
                        FillDisplayedItemInfo(reader, true);
                    }
                }
                else
                {
                    FillDisplayedItemInfo(reader, false);
                }
                
                reader.Close();
                Forms.conn.Close();
                Forms.displayeditem.Show();
                Forms.productquery = new ProductQuery();
                UpdateWeight(productname, newweight);
                this.Dispose();
            }
            else
            {
                reader.Close();
                Forms.conn.Close();
                MessageBox.Show("Invalid barcode");
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            ShowItem(button.Name.Split('_')[0]);
        }

        private void UpdateWeight(string name, int newweight)
        {
            Forms.conn.Open();

            SQLiteCommand sql = new SQLiteCommand($"UPDATE Products SET Weight = {newweight} WHERE ProductName COLLATE NOCASE = '{name}'", Forms.conn);
            sql.ExecuteNonQuery();

            string start = "null";

            start = RootedTree.getRoot().SearchForStartOfRemoval(name.ToLower() + "*", newweight);

            SQLiteCommand sql2 = new SQLiteCommand($"SELECT ProductName, Weight FROM Products WHERE ProductName LIKE '{start.Substring(1)}%' ORDER BY Weight DESC", Forms.conn);
            SQLiteDataReader reader = sql2.ExecuteReader();

            while (reader.Read())
            {
                RootedTree.AddWord(Convert.ToInt32(reader["Weight"]), ((string)reader["ProductName"]).ToLower() + '*');
            }
            reader.Close();
            Forms.conn.Close();
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string barcode = button.Name.Split('_')[0];

            if (!Forms.createorder.barcodesandquantitydictionary.ContainsKey(barcode))
            {
                Forms.createorder.barcodesandquantitydictionary[barcode] = 1;
            }
            else
            {
                Forms.createorder.barcodesandquantitydictionary[barcode] += 1;
            }

            MessageBox.Show(barcode + " Added to order");

            ViewOrderButton.Visible = true;

            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT ProductName, Weight FROM Products WHERE Barcode = '{barcode}'", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();
            reader.Read();
            string productname = (string)reader["ProductName"];
            int weight = Convert.ToInt32(reader["Weight"]) + 1;
            reader.Close();
            Forms.conn.Close();
            UpdateWeight(productname, weight);
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void Option1Label_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = Option1Label.Text;
            ExactProductNameCheckBox.Checked = true;
            LabelStatus(false);
            labelselected = true;
        }

        private void Option2Label_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = Option2Label.Text;
            ExactProductNameCheckBox.Checked = true;
            LabelStatus(false);
            labelselected = true;
        }

        private void Option3Label_Click_1(object sender, EventArgs e)
        {
            SearchTextBox.Text = Option3Label.Text;
            ExactProductNameCheckBox.Checked = true;
            LabelStatus(false);
            labelselected = true;
        }

        private void Option4Label_Click_1(object sender, EventArgs e)
        {
            SearchTextBox.Text = Option4Label.Text;
            ExactProductNameCheckBox.Checked = true;
            LabelStatus(false);
            labelselected = true;
        }

        private void Option5Label_Click_1(object sender, EventArgs e)
        {
            SearchTextBox.Text = Option5Label.Text;
            ExactProductNameCheckBox.Checked = true;
            LabelStatus(false);
            labelselected = true;
        }

        private void LabelStatus(bool status)
        {
            if (status)
            {
                Option1Label.Visible = true;
                Option2Label.Visible = true;
                Option3Label.Visible = true;
                Option4Label.Visible = true;
                Option5Label.Visible = true;
            }
            else
            {
                Option1Label.Visible = false;
                Option2Label.Visible = false;
                Option3Label.Visible = false;
                Option4Label.Visible = false;
                Option5Label.Visible = false;
            }
        }

        public void FillDisplayedItemInfo(SQLiteDataReader reader, bool located)
        {
            Forms.displayeditem.name = (string)reader["ProductName"];
            Forms.displayeditem.barcode = (string)reader["Barcode"];
            Forms.displayeditem.description = (string)reader["ProductDescription"];
            Forms.displayeditem.price = Convert.ToDouble(reader["Price"]);
            Forms.displayeditem.stock = Convert.ToInt32(reader["StockCount"]);
            if (located)
            {
                Forms.displayeditem.type.Add(Convert.ToInt32(reader["Type"]));
                Forms.displayeditem.aisle.Add(Convert.ToInt32(reader["Aisle"]));
                Forms.displayeditem.bay.Add(Convert.ToInt32(reader["Bay"]));
                Forms.displayeditem.sequence.Add((string)reader["Sequence"]);
            }
            Forms.displayeditem.image = new Bitmap(new MemoryStream((byte[])reader["Image"]));
            Forms.displayeditem.located = located;
        }

        private string GetParameters(string text)
        {
            string query = "";
            foreach (string word in text.Split(' '))
            {
                query += "OR ProductName LIKE '%" + word + "%' ";
            }
            return query.Substring(3);
        }

        private bool CheckLocated(string name, string type)
        {
            type = type.ToLower();
            Forms.conn.Open();
            SQLiteCommand sql;
            if (type == "barcode")
            {
                sql = new SQLiteCommand($"SELECT Located FROM Products WHERE Barcode = '{name}'", Forms.conn);
            }
            else if (type == "name")
            {
                sql = new SQLiteCommand($"SELECT Located FROM Products WHERE ProductName COLLATE NOCASE = '{name}'", Forms.conn);
            }
            else
            {
                sql = null;
            }
            SQLiteDataReader reader = sql.ExecuteReader();
            reader.Read();
            if (Convert.ToInt32(reader["Located"]) == 1)
            {
                reader.Close();
                Forms.conn.Close();
                return true;
            }
            reader.Close();
            Forms.conn.Close();
            return false;
        }

        public static bool CheckBarcodeInDatabase(string barcode)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT Barcode FROM Products WHERE Barcode = {barcode}", Forms.conn);
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

        private void SortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "" && ProductNameCheckBox.Checked)
            {
                SearchButton.PerformClick();
            }
        }

        private void ViewOrderButton_Click(object sender, EventArgs e)
        {
            Forms.createorder.DisplayItemsInOrder();
            Forms.createorder.Show();
            ViewOrderButton.Visible = false;
            this.Hide();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Forms.productquery = new ProductQuery();
            Forms.productquery.Show();
            this.Dispose();
        }
    }
}