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
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT Customers.CustomerID, OrderTypes.OrderType, Title, Forename, Surname, Address, Postcode, PhoneNumber, Email, OrderStatusTypes.Status FROM OrderInfo, OrderTypes, OrderStatusTypes, Customers WHERE OrderInfo.OrderID = '{OrderNumberTextBox.Text}'", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();

            if (reader.Read())
            {
                AddInfoToOrderDisplay(reader);
            }
            else
            {
                MessageBox.Show("Invalid Order Number");
            }
            Forms.conn.Close();
        }

        private void AddInfoToOrderDisplay(SQLiteDataReader reader)
        {
            Label temp = new Label();

            temp = CreateLabel();
            temp.Text = Convert.ToInt32(reader["CustomerID"]).ToString();
            temp.Name = "" + "_Label";

            TableLayoutPanel.Controls.Add(temp, 0, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["Title"];
            temp.Name = "" + "_Label";

            TableLayoutPanel.Controls.Add(temp, 1, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["Forename"];
            temp.Name = "" + "_Label";

            TableLayoutPanel.Controls.Add(temp, 2, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["Surname"];
            temp.Name = "" + "_Label";

            TableLayoutPanel.Controls.Add(temp, 3, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["Address"];
            temp.Name = "" + "_Label";

            TableLayoutPanel.Controls.Add(temp, 4, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["Postcode"];
            temp.Name = "" + "_Label";

            TableLayoutPanel.Controls.Add(temp, 5, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["PhoneNumber"];
            temp.Name = "" + "_Label";

            TableLayoutPanel.Controls.Add(temp, 6, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["Email"];
            temp.Name = "" + "_Label";

            TableLayoutPanel.Controls.Add(temp, 7, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["OrderType"];
            temp.Name = "" + "_Label";

            TableLayoutPanel.Controls.Add(temp, 8, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["Status"];
            temp.Name = "" + "_Label";

            TableLayoutPanel.Controls.Add(temp, 9, 1);
        }

        private Label CreateLabel()
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.Top;
            label.AutoSize = true;
            return label;
        }
    }
}
