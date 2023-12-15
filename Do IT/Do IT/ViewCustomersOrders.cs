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
    public partial class ViewCustomersOrders : Form
    {
        public ViewCustomersOrders()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            Forms.viewcustomersorders = new ViewCustomersOrders();
            this.Dispose();
        }

        public void FillMainLayoutPanelWithOrders(string customerID)
        {
            ///!!!
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT OrderInfo.OrderID, sum(Products.Price * Quantity) AS TotalPrice, OrderTypes.OrderType, OrderStatusTypes.Status FROM OrderInfo, Products, OrderEntry, OrderTypes, OrderStatusTypes WHERE OrderInfo.CustomerID = '{customerID}' AND OrderInfo.OrderID = OrderEntry.OrderID AND OrderInfo.Status = OrderStatusTypes.StatusID AND OrderEntry.Barcode = Products.Barcode AND OrderInfo.OrderType = OrderTypes.OrderTypeID GROUP BY OrderInfo.OrderID", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                string orderID = Convert.ToInt32(reader["OrderID"]).ToString();

                TableLayoutPanel table = new TableLayoutPanel();
                table.Name = orderID + "_Table";
                table.Size = new Size(500, 50);
                table.ColumnCount = 5;
                table.RowCount = 1;

                Label temp;

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = orderID;
                temp.Name = orderID + "_Label";

                table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                table.Controls.Add(temp, 0, 0);
                table.ColumnStyles[0].Width = 100;

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = '£' + Convert.ToDouble(reader["TotalPrice"]).ToString();
                temp.Name = orderID + "_TotalPrice_Label";

                table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                table.Controls.Add(temp, 1, 0);
                table.ColumnStyles[1].Width = 100;

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = (string)reader["OrderType"];
                temp.Name = orderID + "_Label";

                table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                table.Controls.Add(temp, 2, 0);
                table.ColumnStyles[2].Width = 100;

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = (string)reader["Status"];
                temp.Name = orderID + "_Label";

                table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                table.Controls.Add(temp, 3, 0);
                table.ColumnStyles[3].Width = 100;

                Button vieworderbutton = new Button();
                vieworderbutton.Size = new Size(90, 40);
                vieworderbutton.Name = orderID + "_ViewOrder_Button";
                vieworderbutton.Text = "View Order";
                vieworderbutton.Click += ViewOrderButton_Click;

                table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                table.Controls.Add(vieworderbutton, 4, 0);
                table.ColumnStyles[4].Width = 100;

                MainLayoutPanel.Controls.Add(table);
            }
            reader.Close();
            Forms.conn.Close();
        }

        private void ViewOrderButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string orderID = button.Name.Split('_')[0];
            Forms.vieworder.OrderNumberTextBox.Text = orderID;
            Forms.vieworder.Show();
            Forms.vieworder.SearchButton.PerformClick();
            Forms.viewcustomersorders = new ViewCustomersOrders();
            this.Dispose();
        }
    }
}
