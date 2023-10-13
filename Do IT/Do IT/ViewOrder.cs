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
            SQLiteCommand sql = new SQLiteCommand($"SELECT OrderID, CustomerID, OrderType, Status, OrderNumber FROM OrderInfo, OrderTypes, OrderStatusTypes Customers WHERE OrderInfo.OrderID = '{OrderNumberTextBox.Text}'", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();


            //FINISH THE SQL QUERY


            if (reader.Read())
            {
                do
                {

                }
                while(true);
            }
            else
            {
                MessageBox.Show("Invalid Order Number");
            }
        }
    }
}
