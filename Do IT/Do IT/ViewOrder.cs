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
        private double totalcost;

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
            DetailsTableLayoutPanel.Controls.Clear();
            MainLayoutPanel.Controls.Clear();
            TotalCostLabel.Text = "Total Cost: £";
            totalcost = 0;
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT Customers.CustomerID, OrderTypes.OrderType, Title, Forename, Surname, Address, Postcode, PhoneNumber, Email, OrderStatusTypes.Status, OrderEntry.Barcode, ProductName, Price, Quantity, Image FROM OrderInfo, OrderTypes, OrderEntry, OrderStatusTypes, Customers, Products WHERE Customers.CustomerID = OrderInfo.CustomerID AND OrderInfo.OrderID = '1' AND OrderEntry.OrderID = OrderInfo.OrderID AND Products.Barcode = OrderEntry.Barcode AND OrderInfo.Status = OrderStatusTypes.StatusID AND OrderInfo.OrderID = '{OrderNumberTextBox.Text}' AND OrderInfo.OrderType = OrderTypes.OrderTypeID", Forms.conn);
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

            temp = CreateLabel("top");
            temp.Text = "Customer Number";

            DetailsTableLayoutPanel.Controls.Add(temp, 0, 0);

            temp = CreateLabel("top");
            temp.Text = "Title";

            DetailsTableLayoutPanel.Controls.Add(temp, 1, 0);

            temp = CreateLabel("top");
            temp.Text = "Forename";

            DetailsTableLayoutPanel.Controls.Add(temp, 2, 0);

            temp = CreateLabel("top");
            temp.Text = "Surname";

            DetailsTableLayoutPanel.Controls.Add(temp, 3, 0);

            temp = CreateLabel("top");
            temp.Text = "Address";

            DetailsTableLayoutPanel.Controls.Add(temp, 4, 0);

            temp = CreateLabel("top");
            temp.Text = "Postcode";

            DetailsTableLayoutPanel.Controls.Add(temp, 5, 0);

            temp = CreateLabel("top");
            temp.Text = "Phone Number";

            DetailsTableLayoutPanel.Controls.Add(temp, 6, 0);

            temp = CreateLabel("top");
            temp.Text = "Email Address";

            DetailsTableLayoutPanel.Controls.Add(temp, 7, 0);

            temp = CreateLabel("top");
            temp.Text = "Order Type";

            DetailsTableLayoutPanel.Controls.Add(temp, 8, 0);

            temp = CreateLabel("top");
            temp.Text = "Status";

            DetailsTableLayoutPanel.Controls.Add(temp, 9, 0);

            temp = CreateLabel("top");
            temp.Text = Convert.ToInt32(reader["CustomerID"]).ToString();
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 0, 1);

            temp = CreateLabel("top");
            temp.Text = (string)reader["Title"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 1, 1);

            temp = CreateLabel("top");
            temp.Text = (string)reader["Forename"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 2, 1);

            temp = CreateLabel("top");
            temp.Text = (string)reader["Surname"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 3, 1);

            temp = CreateLabel("top");
            temp.Text = (string)reader["Address"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 4, 1);

            temp = CreateLabel("top");
            temp.Text = (string)reader["Postcode"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 5, 1);

            temp = CreateLabel("top");
            temp.Text = (string)reader["PhoneNumber"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 6, 1);

            temp = CreateLabel("top");
            temp.Text = (string)reader["Email"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 7, 1);

            temp = CreateLabel("top");
            temp.Text = (string)reader["OrderType"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 8, 1);

            temp = CreateLabel("top");
            temp.Text = (string)reader["Status"];
            temp.Name = "" + "_Label";

            DetailsTableLayoutPanel.Controls.Add(temp, 9, 1);

            string barcode, productname;
            do
            {
                barcode = (string)reader["Barcode"];
                productname = (string)reader["ProductName"];

                TableLayoutPanel table = new TableLayoutPanel();

                table.Name = barcode + "_Table";
                table.Height = 142;
                table.Width = 1280;
                table.ColumnCount = 6;
                table.RowCount = 1;

                PictureBox image = new PictureBox();
                image.Size = new Size(142, 142);
                image.SizeMode = PictureBoxSizeMode.Zoom;
                image.Image = new Bitmap(new MemoryStream((byte[])reader["Image"]));
                image.Name = barcode + "_PictureBox";

                table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                table.Controls.Add(image, 0, 0);
                table.ColumnStyles[0].Width = 142;

                temp = CreateLabel("middle");
                temp.Text = barcode;
                temp.Name = barcode + "_Label";

                table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                table.Controls.Add(temp, 1, 0);
                table.ColumnStyles[1].Width = 158;

                temp = CreateLabel("middle");
                temp.Text = productname;
                temp.Name = productname + "_Label";

                table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                table.Controls.Add(temp, 2, 0);
                table.ColumnStyles[2].Width = 500;

                temp = CreateLabel("middle");
                temp.Text = Convert.ToInt32(reader["Quantity"]).ToString();
                temp.Name = barcode + "_Quantity_Label";

                table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                table.Controls.Add(temp, 3, 0);
                table.ColumnStyles[3].Width = 100;

                temp = CreateLabel("middle");
                temp.Text = '£' + Convert.ToDouble(reader["Price"]).ToString();
                temp.Name = barcode + "_Price_Label";

                table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                table.Controls.Add(temp, 4, 0);
                table.ColumnStyles[4].Width = 200;

                temp = CreateLabel("middle");
                totalcost += Convert.ToInt32(reader["Quantity"]) * Convert.ToDouble(reader["Price"]);
                temp.Text = '£' + (Convert.ToInt32(reader["Quantity"]) * Convert.ToDouble(reader["Price"])).ToString();
                temp.Name = barcode + "_TotalPrice_Label";

                table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                table.Controls.Add(temp, 5, 0);
                table.ColumnStyles[5].Width = 180;





                MainLayoutPanel.Controls.Add(table);
            }
            while (reader.Read());
            TotalCostLabel.Text += totalcost.ToString();
        }
        public Label CreateLabel(string type)
        {
            Label label = new Label();
            if(type == "top")
            {
                label.Anchor = AnchorStyles.Top;
            }
            else if(type == "middle")
            {
                label.Anchor = AnchorStyles.None;

            }
            label.AutoSize = true;
            return label;
        }
    }
}
