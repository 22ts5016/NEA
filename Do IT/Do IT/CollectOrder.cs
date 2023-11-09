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
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace Do_IT
{
    public partial class CollectOrder : Form
    {
        public CollectOrder()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(Regex.IsMatch(OrderNumberTextBox.Text, RegExFormats.anynumber))
            {
                Forms.conn.Open();
                SQLiteCommand sql = new SQLiteCommand($"SELECT Forename, Surname, OrderType, Status FROM Customers, OrderInfo WHERE OrderInfo.OrderID = '{OrderNumberTextBox.Text}' AND OrderInfo.CustomerID = Customers.CustomerID", Forms.conn);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    if (Convert.ToInt32(reader["OrderType"]) == 1)
                    {
                        if (Convert.ToInt32(reader["Status"]) == 1)
                        {
                            OrderNumberTextBox.ReadOnly = true;
                            CollectorderForLabel.Text += (string)reader["Forename"] + " " + (string)reader["Surname"];
                            CollectorderForLabel.Visible = true;
                            CollectButton.Visible = true;
                            ViewOrderButton.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("This order has been collected already");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This order number is not a collectable order");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid order number");
                }
                reader.Close();
                Forms.conn.Close();
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
            
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Forms.collectorder = new CollectOrder();
            Forms.collectorder.Show();
            this.Dispose();
        }

        private void CollectButton_Click(object sender, EventArgs e)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"UPDATE OrderInfo SET Status = 2 WHERE OrderID = {OrderNumberTextBox.Text}", Forms.conn);
            sql.ExecuteNonQuery();
            Forms.conn.Close();
            MessageBox.Show("Order collected!");
            Forms.collectorder = new CollectOrder();
            Forms.mainmenu.Show();
            Forms.viewemployeeactions.Action(3, $"{OrderNumberTextBox.Text} Collected");
            this.Dispose();
        }

        private void ViewOrderButton_Click(object sender, EventArgs e)
        {
            Forms.vieworder.OrderNumberTextBox.Text = OrderNumberTextBox.Text;
            Forms.vieworder.orderinprocessofcollection = true;
            Forms.vieworder.Show();
            Forms.vieworder.SearchButton.PerformClick();
            this.Hide();
        }
    }
}
