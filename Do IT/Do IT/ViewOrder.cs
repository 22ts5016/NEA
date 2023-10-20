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
            //SQLiteCommand sql = new SQLiteCommand($"SELECT Customers.CustomerID, OrderTypes.OrderType, Title, Forename, Surname, Address, Postcode, PhoneNumber, Email, OrderStatusTypes.Status, OrderEntry.Barcode, Image FROM OrderInfo, OrderTypes, OrderEntry, OrderStatusTypes, Customers, Products WHERE Customers.CustomerID = OrderInfo.CustomerID AND OrderInfo.OrderID = '{OrderNumberTextBox.Text}' AND EntryID = OrderInfo.OrderID", Forms.conn);
            SQLiteCommand sql = new SQLiteCommand($"SELECT Customers.CustomerID, OrderTypes.OrderType, Title, Forename, Surname, Address, Postcode, PhoneNumber, Email, OrderStatusTypes.Status, OrderEntry.Barcode, Image, Quantity FROM OrderInfo, OrderTypes, OrderEntry, OrderStatusTypes, Customers, Products WHERE Customers.CustomerID = OrderInfo.CustomerID AND OrderInfo.OrderID = '1' AND OrderEntry.OrderID = OrderInfo.OrderID AND Products.Barcode = OrderEntry.Barcode AND OrderInfo.Status = OrderStatusTypes.StatusID AND OrderInfo.OrderID = '{OrderNumberTextBox.Text}' AND OrderInfo.OrderType = OrderTypes.OrderTypeID", Forms.conn);
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
            Label temp;

            temp = CreateLabel();
            temp.Text = Convert.ToInt32(reader["CustomerID"]).ToString();
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 0, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["Title"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 1, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["Forename"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 2, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["Surname"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 3, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["Address"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 4, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["Postcode"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 5, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["PhoneNumber"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 6, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["Email"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 7, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["OrderType"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 8, 1);

            temp = CreateLabel();
            temp.Text = (string)reader["Status"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 9, 1);

            string barcode;
            do
            {
                barcode = (string)reader["Barcode"];

                PictureBox image = new PictureBox();
                image.Size = new Size(142, 142);
                image.SizeMode = PictureBoxSizeMode.Zoom;
                image.Image = new Bitmap(new MemoryStream((byte[])reader["Image"]));
                MainLayoutPanel.Controls.Add(image);

                TableLayoutPanel table = new TableLayoutPanel();

                table.Name = barcode + "_Table";
                table.Height = 142;
                table.Width = 1100;
                table.ColumnCount = 2;
                table.RowCount = 1;

                temp = CreateLabel();
                temp.Text = barcode;
                temp.Name = barcode + "_Label";

                table.Controls.Add(temp, 0, 0);

                MainLayoutPanel.Controls.Add(table);
            }
            while (reader.Read());
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
