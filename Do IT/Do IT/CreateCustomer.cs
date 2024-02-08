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
    public partial class CreateCustomer : Form
    {
        private bool validdetails = false;
        private bool taggingtoorder = false;

        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            if (!Forms.createorder.customertagged)
            {
                CreateAccountAndTagToOrderButton.Visible = true;
            }
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT MAX(CustomerID) FROM Customers", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();
            reader.Read();
            CustomerIDLabel.Text = (Convert.ToInt32(reader["MAX(CustomerID)"]) + 1).ToString();
            reader.Close();
            Forms.conn.Close();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if(Regex.IsMatch(TitleTextBox.Text, RegExFormats.anyletters) && Regex.IsMatch(ForenameTextBox.Text, RegExFormats.anyletters) && Regex.IsMatch(SurnameTextBox.Text, RegExFormats.anyletters) && Regex.IsMatch(AddressTextBox.Text, RegExFormats.anyaddress) && Regex.IsMatch(PostcodeTextBox.Text, RegExFormats.anypostcode) && Regex.IsMatch(PhoneNumberTextBox.Text, RegExFormats.anyphonenumber) && Regex.IsMatch(EmailTextBox.Text, RegExFormats.anyemail))
            {
                if (!CheckExistingEmail() && !CheckExistngPhone())
                {
                    Forms.conn.Open();
                    SQLiteCommand sql = new SQLiteCommand($"INSERT INTO Customers VALUES ('{CustomerIDLabel.Text}', '{TitleTextBox.Text}', '{ForenameTextBox.Text}', '{SurnameTextBox.Text}', '{AddressTextBox.Text}', '{PostcodeTextBox.Text}' ,'{PhoneNumberTextBox.Text}' ,'{EmailTextBox.Text}')", Forms.conn);
                    sql.ExecuteNonQuery();
                    Forms.conn.Close();
                    MessageBox.Show("Account created");
                    validdetails = true;
                    ViewEmployeeActions.Action(6, $"Account Num: {CustomerIDLabel.Text} created");
                    Forms.createcustomer = new CreateCustomer();
                    if (!taggingtoorder)
                    {
                        Forms.mainmenu.Show();
                        this.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid inputs");
            }
        }

        private void CreateAccountAndTagToOrderButton_Click(object sender, EventArgs e)
        {
            taggingtoorder = true;
            CreateAccountButton.PerformClick();
            if (validdetails)
            {
                Forms.createorder.DetailsTableLayoutPanel.Controls.Clear();
                Forms.createorder.AddCustomerToOrder(int.Parse(CustomerIDLabel.Text));
                Forms.createorder.DisplayItemsInOrder();
                Forms.createorder.Show();
                this.Dispose();
            }
        }

        private bool CheckExistingEmail()
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT Email FROM Customers WHERE Email = '{EmailTextBox.Text}'", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                Forms.conn.Close();
                MessageBox.Show("Email already in use");
                return true;
            }
            else
            {
                reader.Close();
                Forms.conn.Close();
                return false;
            }
        }

        private bool CheckExistngPhone()
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT PhoneNumber FROM Customers WHERE PhoneNumber = '{PhoneNumberTextBox.Text}'", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                Forms.conn.Close();
                MessageBox.Show("Phone number already in use");
                return true;
            }
            else
            {
                reader.Close();
                Forms.conn.Close();
                return false;
            }
        }
    }
}
