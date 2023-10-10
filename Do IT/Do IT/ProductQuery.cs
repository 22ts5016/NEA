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
using System.IO;

namespace Do_IT
{
    public partial class ProductQuery : Form
    {
        private int itemscount;
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
                if(!ExactProductNameCheckBox.Checked && !BarcodeCheckBox.Checked)
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
                string word = SearchTextBox.Text.ToLower();
                if(word.Length == 0)
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
                    catch (IndexOutOfRangeException)
                    {

                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("That is not a valid start letter, please try again");
                    }
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
            itemscount = 0;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LayoutPanel1.Controls.Clear();
            LayoutPanel1.Visible = true;
            LabelStatus(false);
            if (ProductNameCheckBox.Checked)
            {
                Forms.conn.Open();
                string a = GetParameters(SearchTextBox.Text);
                
                SQLiteCommand sql = new SQLiteCommand($"SELECT ProductName, Barcode, Price, StockCount, Weight, Image FROM Products WHERE {a} ORDER BY Weight DESC", Forms.conn);
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
                    table.Width = 1000;
                    table.ColumnCount = 2;
                    table.RowCount = 3;

                    Label namelabel = new Label();
                    namelabel.Text = name;
                    namelabel.Font = new Font(namelabel.Font.FontFamily, 13);
                    namelabel.Name = name;
                    namelabel.AutoSize = true;
                    namelabel.Margin = new Padding(0, 0, 0, 10);

                    table.Controls.Add(namelabel, 0, 0);

                    Label barcodelabel = new Label();
                    barcodelabel.Text = barcode;
                    barcodelabel.Font = new Font(barcodelabel.Font.FontFamily, 10);
                    barcodelabel.Name = barcode;
                    barcodelabel.AutoSize = true;
                    barcodelabel.Margin = new Padding(0, 0, 0, 150);

                    table.Controls.Add(barcodelabel, 0 , 1);

                    Label stocklabel = new Label();
                    stocklabel.Text = "Stock: " + Convert.ToInt32(reader["StockCount"]);
                    stocklabel.Font = new Font(stocklabel.Font.FontFamily, 10);
                    stocklabel.Name = name + "_Stock";
                    stocklabel.AutoSize = true;
                    
                    table.Controls.Add(stocklabel, 0, 2);

                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    table.ColumnStyles[0].Width = 800;

                    Label pricelabel = new Label();
                    pricelabel.Text = "£" + Convert.ToDecimal(reader["Price"]);
                    pricelabel.Font = new Font(pricelabel.Font.FontFamily, 10);
                    pricelabel.Name = name + "_Stock";
                    pricelabel.AutoSize = true;

                    table.Controls.Add(pricelabel, 1, 0);


                    
                    LayoutPanel1.Controls.Add(table);

                }
                Forms.conn.Close();
            }
            else if (ExactProductNameCheckBox.Checked)
            {
                Forms.conn.Open();
                string name = SearchTextBox.Text;
                SQLiteCommand sql3 = new SQLiteCommand($"SELECT Weight FROM Products WHERE ProductName COLLATE NOCASE = '{name}'", Forms.conn);
                SQLiteDataReader reader3 = sql3.ExecuteReader();
                if (reader3.Read())
                {
                    int weight = Convert.ToInt32(reader3["Weight"]) + 1;
                    SQLiteCommand sql4 = new SQLiteCommand($"UPDATE Products SET Weight = {weight} WHERE ProductName COLLATE NOCASE = '{name}'", Forms.conn);
                    sql4.ExecuteNonQuery();

                    SQLiteCommand sql5 = new SQLiteCommand($"SELECT Located FROM Products WHERE ProductName COLLATE NOCASE = '{SearchTextBox.Text}'", Forms.conn);
                    SQLiteDataReader reader5 = sql5.ExecuteReader();
                    reader5.Read();

                    SQLiteCommand sql6;
                    bool located;
                    if (Convert.ToInt32(reader5["Located"]) == 1)
                    {
                        sql6 = new SQLiteCommand($"SELECT Products.Barcode, ProductName, ProductDescription, Price, StockCount, Image, Isle, Bay, Sequence, Type FROM Products, ProductLocations WHERE ProductName COLLATE NOCASE = '{SearchTextBox.Text}' AND Products.Barcode = ProductLocations.Barcode", Forms.conn);
                        located = true;
                    }
                    else
                    {
                        sql6 = new SQLiteCommand($"SELECT Products.Barcode, ProductName, ProductDescription, Price, StockCount, Image FROM Products WHERE ProductName COLLATE NOCASE = '{SearchTextBox.Text}'", Forms.conn);
                        located = false;
                    }

                    SQLiteDataReader reader6 = sql6.ExecuteReader();
                    while (reader6.Read())
                    {
                        FillDisplayedItemInfo(reader6, located);
                    }
                    
                    reader3.Close();
                    reader5.Close();
                    reader6.Close();
                    Forms.conn.Close();
                    Forms.displayeditem.Show();
                    this.Hide();
                    LabelStatus(true);
                    SearchTextBox.Text = "";
                    

                    Forms.conn.Open();

                    string start = "null";

                    start = RootedTree.getRoot().SearchForStartOfRemoval(name.ToLower() + "*", weight);

                    SQLiteCommand sql7 = new SQLiteCommand($"SELECT ProductName, Weight FROM Products WHERE ProductName LIKE '{start.Substring(1)}%'", Forms.conn);
                    SQLiteDataReader reader7 = sql7.ExecuteReader();

                    while (reader7.Read())
                    {
                        RootedTree.AddWord(Convert.ToInt32(reader7["Weight"]), ((string)reader7["ProductName"]).ToLower() + '*');
                    }
                    reader7.Close();
                }
                else
                {
                    MessageBox.Show("That is not the name of an item");
                }
                Forms.conn.Close();
            }
            else if(BarcodeCheckBox.Checked)
            {
                bool located = CheckLocated(SearchTextBox.Text, "barcode");
                Forms.conn.Open();
                SQLiteCommand sql;
                if (located)
                {
                    sql = new SQLiteCommand($"SELECT Products.Barcode, ProductName, ProductDescription, Price, StockCount, Image, Isle, Bay, Sequence, Type FROM Products, ProductLocations WHERE Products.Barcode = '{SearchTextBox.Text}' AND Products.Barcode = ProductLocations.Barcode", Forms.conn);
                }
                else
                {
                    sql = new SQLiteCommand($"SELECT Products.Barcode, ProductName, ProductDescription, Price, StockCount, Image FROM Products WHERE Products.Barcode = '{SearchTextBox.Text}'", Forms.conn);
                }
                SQLiteDataReader reader;
                reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    

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
                    this.Hide();
                }
                else
                {
                    reader.Close();
                    Forms.conn.Close();
                    MessageBox.Show("Invalid barcode");
                }
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
            ExactProductNameCheckBox.Checked = true;
            LabelStatus(false);
        }

        private void Option2Label_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = Option2Label.Text;
            ExactProductNameCheckBox.Checked = true;
            LabelStatus(false);
        }

        private void Option3Label_Click_1(object sender, EventArgs e)
        {
            SearchTextBox.Text = Option3Label.Text;
            ExactProductNameCheckBox.Checked = true;
            LabelStatus(false);
        }

        private void Option4Label_Click_1(object sender, EventArgs e)
        {
            SearchTextBox.Text = Option4Label.Text;
            ExactProductNameCheckBox.Checked = true;
            LabelStatus(false);
        }

        private void Option5Label_Click_1(object sender, EventArgs e)
        {
            SearchTextBox.Text = Option5Label.Text;
            ExactProductNameCheckBox.Checked = true;
            LabelStatus(false);
        }

        private void LabelStatus(bool status)
        {
            if(status)
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
            if(located)
            {
                Forms.displayeditem.type.Add(Convert.ToInt32(reader["Type"]));
                Forms.displayeditem.isle.Add(Convert.ToInt32(reader["Isle"]));
                Forms.displayeditem.bay.Add(Convert.ToInt32(reader["Bay"]));
                Forms.displayeditem.sequence.Add((string)reader["Sequence"]);
            }
            Forms.displayeditem.image = new Bitmap(new MemoryStream((byte[])reader["Image"]));
        }

        private string GetParameters(string text)
        {
            string query = "";
            foreach(string word in text.Split(' '))
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

        public static bool CheckValidBarcode(string barcode)
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
    }
}
