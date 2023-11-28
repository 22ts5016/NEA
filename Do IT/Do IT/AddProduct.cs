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
using System.Text.RegularExpressions;

namespace Do_IT
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private Bitmap blank;

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (CheckAllRegEx())
            {
                if (EANCheck(BarcodeTextBox.Text))
                {
                    if (!RepeatedBarcode(BarcodeTextBox.Text))
                    {
                        byte[] imageBytes;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            ImagePictureBox.Image.Save(ms, ImagePictureBox.Image.RawFormat);
                            imageBytes = ms.ToArray();
                        }
                        string description = ProductDescriptionTextBox.Text;
                        for (int i = 100; i < description.Length; i += 100)
                        {
                            if (description[i] == ' ')
                            {
                                description = description.Substring(0, i) + "\n" + description.Substring(i + 1);
                            }
                            else
                            {
                                i -= 99;
                            }
                        }
                        Forms.conn.Open();
                        using (SQLiteCommand sql = new SQLiteCommand($"INSERT INTO Products VALUES ('{BarcodeTextBox.Text}', \"{ProductNameTextBox.Text}\", \"{description}\", '{double.Parse(PriceTextBox.Text)}', '{int.Parse(StockCountTextBox.Text)}', '0',@image, 'f')", Forms.conn))
                        {
                            sql.Parameters.AddWithValue("@image", imageBytes);
                            sql.ExecuteNonQuery();
                        }
                        Forms.conn.Close();
                        MessageBox.Show("Product Added");
                        Forms.viewemployeeactions.Action(5, $"Added product {BarcodeTextBox.Text}");
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("This barcode is already in the databse");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid barcode");
                }
            }
            else
            {
                MessageBox.Show("Invalid inputs");
            }
        }

        private bool CheckAllRegEx()
        {
            if (Regex.IsMatch(BarcodeTextBox.Text, RegExFormats.anynumber))
            {
                if(Regex.IsMatch(ProductNameTextBox.Text, RegExFormats.anyproductname))
                {
                    if (Regex.IsMatch(PriceTextBox.Text, RegExFormats.anyprice))
                    {
                        if (Regex.IsMatch(StockCountTextBox.Text, RegExFormats.anynumber))
                        {
                            return true;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid price");
                    }
                }
            }
            return false;
        }

        private bool EANCheck(string barcode)
        {
            int total = 0;
            if(barcode.Length != 13)
            {
                return false;
            }
            else
            {
                for(int i = 0; i < barcode.Length - 1; i+=2)
                {
                    total += int.Parse(barcode[i].ToString());
                }
                for (int i = 1; i < barcode.Length - 1; i+=2)
                {
                    total += int.Parse(barcode[i].ToString()) * 3;
                }
                if(10 - total % 10 == int.Parse(barcode[12].ToString()))
                {
                    return true;
                }
                else if( total % 10 == 0 && barcode[12] == '0')
                {
                    return true;
                }
            }
            return false;
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "d:\\";
                ofd.Filter = "Files | *.jpg; *.jpeg; *.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImagePictureBox.Image = new Bitmap(ofd.FileName);
                }
            }
        }

        private void Reset()
        {
            BarcodeTextBox.ResetText();
            ProductNameTextBox.ResetText();
            ProductDescriptionTextBox.ResetText();
            PriceTextBox.ResetText();
            StockCountTextBox.ResetText();
            ImagePictureBox.Image = blank;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            blank =  new Bitmap(ImagePictureBox.Image);
        }

        private bool RepeatedBarcode(string barcode)
        {
            bool repeated;
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT Barcode FROM Products WHERE Barcode = '{barcode}'", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                if((string)reader["Barcode"] == barcode)
                {
                    repeated = true;
                }
                else
                {
                    repeated = false;
                }
            }
            else
            {
                repeated = false;
            }
            reader.Close();
            Forms.conn.Close();
            return repeated;
        }
    }
}
