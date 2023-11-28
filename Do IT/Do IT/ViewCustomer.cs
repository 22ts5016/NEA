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

namespace Do_IT
{
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        public void FillCustomerDetailsTableHeaders(TableLayoutPanel table)
        {
            Label temp = new Label();

            temp = Forms.vieworder.CreateLabel("top");
            temp.Text = "Customer ID";
            temp.Name = "CustomerIDHeaderLabel";

            table.Controls.Add(temp, 0 , 0);

            temp = Forms.vieworder.CreateLabel("top");
            temp.Text = "Title";
            temp.Name = "TitleHeaderLabel";

            table.Controls.Add(temp, 1, 0);

            temp = Forms.vieworder.CreateLabel("top");
            temp.Text = "Forename";
            temp.Name = "ForenameHeaderLabel";

            table.Controls.Add(temp, 2, 0);

            temp = Forms.vieworder.CreateLabel("top");
            temp.Text = "Surname";
            temp.Name = "SurnameHeaderLabel";

            table.Controls.Add(temp, 3, 0);

            temp = Forms.vieworder.CreateLabel("top");
            temp.Text = "Address";
            temp.Name = "AddressHeaderLabel";

            table.Controls.Add(temp, 4, 0);

            temp = Forms.vieworder.CreateLabel("top");
            temp.Text = "Postcode";
            temp.Name = "PostcodeHeaderLabel";

            table.Controls.Add(temp, 5, 0);

            temp = Forms.vieworder.CreateLabel("top");
            temp.Text = "Phone Number";
            temp.Name = "PhoneNumberHeaderLabel";

            table.Controls.Add(temp, 6, 0);

            temp = Forms.vieworder.CreateLabel("top");
            temp.Text = "Email";
            temp.Name = "EmailHeaderLabel";

            table.Controls.Add(temp, 7, 0);
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"PRAGMA table_info('Customers') ", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();

            while (reader.Read())
            {
                SearchByComboBox.Items.Add((string)reader["name"]);
            }
            reader.Close();
            Forms.conn.Close();
        }

        private void SearchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SearchByComboBox.SelectedIndex != -1)
            {
                SearchByTextBoxHeaderLabel.Text = "Please enter the customer's " + SearchByComboBox.Items[SearchByComboBox.SelectedIndex].ToString() + ':';
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(SearchByComboBox.SelectedIndex != -1)
            {
                bool valid = true;

                switch (SearchByComboBox.SelectedIndex)
                {
                    case 0:
                        if (!Regex.IsMatch(SearchTextBox.Text, RegExFormats.anynumber))
                        {
                            valid = false;
                        }
                        break;
                    case 1:
                    case 2:
                    case 3:
                        if (!Regex.IsMatch(SearchTextBox.Text, RegExFormats.anyletters))
                        {
                            valid = false;
                        }
                        break;
                    case 4:
                        if (!Regex.IsMatch(SearchTextBox.Text, RegExFormats.anyaddress))
                        {
                            valid = false;
                        }
                        break;
                    case 5:
                        if (!Regex.IsMatch(SearchTextBox.Text, RegExFormats.anypostcode))
                        {
                            valid = false;
                        }
                        break;
                    case 6:
                        if (!Regex.IsMatch(SearchTextBox.Text, RegExFormats.anyphonenumber))
                        {
                            valid = false;
                        }
                        break;
                    case 7:
                        if (!Regex.IsMatch(SearchTextBox.Text, RegExFormats.anyemail))
                        {
                            valid = false;
                        }
                        break;
                }

                if (valid)
                {
                    SearchByComboBox.Enabled = false;
                    SearchTextBox.Enabled = false;
                    CustomerDetailsHeaderTable.Controls.Clear();
                    MainLayoutPanel.Controls.Clear();
                    FillCustomerDetailsTableHeaders(CustomerDetailsHeaderTable);
                    Forms.conn.Open();
                    SQLiteCommand sql = new SQLiteCommand($"SELECT * FROM Customers WHERE {SearchByComboBox.Items[SearchByComboBox.SelectedIndex]} COLLATE NOCASE = '{SearchTextBox.Text}'", Forms.conn);
                    SQLiteDataReader reader = sql.ExecuteReader();

                    while (reader.Read())
                    {
                        MainLayoutPanel.Controls.Add(NewCustomerTable(reader));
                    }
                    reader.Close();
                    Forms.conn.Close();
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
        }

        private TableLayoutPanel NewCustomerTable(SQLiteDataReader reader)
        {
            string customerID = "";
            TableLayoutPanel table = FillMainCustomerInfo(reader, ref customerID, 1300, 50, 10, 1);

            Button viewcusomersorders = new Button();
            viewcusomersorders.Size = new Size(90, 40);
            viewcusomersorders.Name = customerID + "_ViewOrders_Button";
            viewcusomersorders.Text = "View Customers Orders";
            viewcusomersorders.Click += ViewCusomersOrders_Click;

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
            table.Controls.Add(viewcusomersorders);
            table.ColumnStyles[8].Width = 100;

            if (!Forms.createorder.customertagged)
            {
                Button addcustomertoorderbutton = new Button();
                addcustomertoorderbutton.Size = new Size(90, 40);
                addcustomertoorderbutton.Name = customerID + "_TagToOrder_Button";
                addcustomertoorderbutton.Text = "Tag Customer To Order";
                addcustomertoorderbutton.Click += AddCustomerToOrderButton_Click;

                table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                table.Controls.Add(addcustomertoorderbutton);
                table.ColumnStyles[9].Width = 100;
            }

            return table;
        }

        public TableLayoutPanel FillMainCustomerInfo(SQLiteDataReader reader, ref string customerID, int len, int width, int colnum, int rownum)
        {
            TableLayoutPanel table = new TableLayoutPanel();

            customerID = Convert.ToInt32(reader["CustomerID"]).ToString();

            table.Size = new Size(len, width);
            table.Name = customerID + "_Table";
            table.ColumnCount = colnum;
            table.RowCount = rownum;

            Label temp = new Label();

            temp = Forms.vieworder.CreateLabel("middle");
            temp.Text = customerID;

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
            table.Controls.Add(temp);
            table.ColumnStyles[0].Width = 125;

            temp = Forms.vieworder.CreateLabel("middle");
            temp.Text = (string)reader["Title"];

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
            table.Controls.Add(temp);
            table.ColumnStyles[1].Width = 50;

            temp = Forms.vieworder.CreateLabel("middle");
            temp.Text = (string)reader["Forename"];

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
            table.Controls.Add(temp);
            table.ColumnStyles[2].Width = 150;

            temp = Forms.vieworder.CreateLabel("middle");
            temp.Text = (string)reader["Surname"];

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
            table.Controls.Add(temp);
            table.ColumnStyles[3].Width = 150;

            temp = Forms.vieworder.CreateLabel("middle");
            temp.Text = (string)reader["Address"];

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
            table.Controls.Add(temp);
            table.ColumnStyles[4].Width = 175;

            temp = Forms.vieworder.CreateLabel("middle");
            temp.Text = (string)reader["Postcode"];

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
            table.Controls.Add(temp);
            table.ColumnStyles[5].Width = 100;

            temp = Forms.vieworder.CreateLabel("middle");
            temp.Text = (string)reader["PhoneNumber"];

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
            table.Controls.Add(temp);
            table.ColumnStyles[6].Width = 100;

            temp = Forms.vieworder.CreateLabel("middle");
            temp.Text = (string)reader["Email"];

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
            table.Controls.Add(temp);
            table.ColumnStyles[7].Width = 250;

            return table;
        }

        private void ViewCusomersOrders_Click(object sender, EventArgs e)
        {
            Forms.conn.Open();
            Button button = sender as Button;
            FillCustomerDetailsTableHeaders(Forms.viewcustomersorders.CustomerDetailsHeaderTable);
            string customerID = button.Name.Split('_')[0];
            SQLiteCommand sql = new SQLiteCommand($"SELECT * FROM Customers WHERE {SearchByComboBox.Items[SearchByComboBox.SelectedIndex]} COLLATE NOCASE = '{SearchTextBox.Text}'", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();
            reader.Read();
            TableLayoutPanel temp = FillMainCustomerInfo(reader, ref customerID, 1100, 50, 9, 1);
            temp.Location = new Point(46, 73);
            Forms.viewcustomersorders.Controls.Add(temp);
            reader.Close();
            Forms.conn.Close();
            Forms.viewcustomersorders.FillMainLayoutPanelWithOrders(customerID);
            Forms.viewcustomersorders.Show();
            Forms.viewcustomer = new ViewCustomer();
            this.Dispose();
        }

        private void AddCustomerToOrderButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Forms.createorder.DetailsTableLayoutPanel.Controls.Clear();
            Forms.createorder.AddCustomerToOrder(int.Parse(button.Name.Split('_')[0]));
            Forms.createorder.DisplayItemsInOrder();
            Forms.createorder.Show();
            Forms.viewcustomer = new ViewCustomer();
            this.Dispose();
        }

        private void CreateCustomerAccountButton_Click(object sender, EventArgs e)
        {
            Forms.createcustomer.Show();
            Forms.viewcustomer = new ViewCustomer();
            this.Dispose();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SearchByComboBox.SelectedIndex = -1;
            SearchByTextBoxHeaderLabel.Text = "Please enter the customer's ...";
            SearchTextBox.Text = "";
            MainLayoutPanel.Controls.Clear();
            SearchByComboBox.Enabled = true;
            SearchTextBox.Enabled = true;
        }
    }
}
