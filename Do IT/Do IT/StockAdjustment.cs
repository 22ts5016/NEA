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
using System.Text.RegularExpressions;

namespace Do_IT
{
    public partial class StockAdjustment : Form
    {
        public StockAdjustment()
        {
            InitializeComponent();
        }

        private void EnterBarcodeButton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(BarcodeTextBox.Text, RegExFormats.anynumber))
            {
                Forms.conn.Open();
                SQLiteCommand sql = new SQLiteCommand($"SELECT StockCount FROM Products WHERE Barcode = '{BarcodeTextBox.Text}'", Forms.conn);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    ActualStockCountLabel.Text = Convert.ToInt32(reader["StockCount"]).ToString();

                    CurrentStockLabel.Visible = true;
                    EnterStockCountLabel.Visible = true;

                    ActualStockCountLabel.Visible = true;
                    StockCountTextBox.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid barcode");
                }
                reader.Close();
                Forms.conn.Close();
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(StockCountTextBox.Text, RegExFormats.anynumber))
            {
                Forms.conn.Open();
                SQLiteCommand sql = new SQLiteCommand($"UPDATE Products SET StockCount = '{StockCountTextBox.Text}' WHERE Barcode = '{BarcodeTextBox.Text}'", Forms.conn);
                sql.ExecuteNonQuery();
                Forms.conn.Close();
                MessageBox.Show("Stock adjusted");
                Forms.stockmanagement.Show();
                Forms.viewemployeeactions.Action(1, $"{BarcodeTextBox.Text} adjusted to {StockCountTextBox.Text}");
                Forms.stockadjustment = new StockAdjustment();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}
