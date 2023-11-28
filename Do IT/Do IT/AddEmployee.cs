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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(ForenameTextBox.Text, RegExFormats.anyletters) && Regex.IsMatch(SurnameTextBox.Text, RegExFormats.anyletters) && Regex.IsMatch(UsernameTextBox.Text, RegExFormats.anyletters) && RoleComboBox.SelectedIndex != -1 && DepartmentComboBox.SelectedIndex != -1)
            {
                if (!CheckUserNameDupe())
                {
                    Forms.conn.Open();
                    SQLiteCommand sql = new SQLiteCommand($"SELECT RoleID, DepartmentID FROM Roles, DepartmentTypes WHERE Role = '{RoleComboBox.Text}' AND Department = '{DepartmentComboBox.Text}'", Forms.conn);
                    SQLiteDataReader reader = sql.ExecuteReader();
                    reader.Read();
                    SQLiteCommand sql2 = new SQLiteCommand($"INSERT INTO Employees VALUES ('{EmployeeIDNumberLabel.Text}', '{ForenameTextBox.Text}', '{SurnameTextBox.Text}', '{Convert.ToInt32(reader["RoleID"])}', '{Convert.ToInt32(reader["DepartmentID"])}', '{UsernameTextBox.Text}', '{PasswordTextBox.Text}')", Forms.conn);
                    sql2.ExecuteNonQuery();
                    MessageBox.Show("Account created!");
                    Forms.conn.Close();
                    Forms.viewemployeeactions.Action(4, $"Account made for {ForenameTextBox.Text} {SurnameTextBox.Text}");
                }
                else
                {
                    MessageBox.Show("This username already exists");
                }
            }
            else
            {
                MessageBox.Show("Invalid inputs");
            }
        }

        private bool CheckUserNameDupe()
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT Username FROM Employees WHERE Username = '{UsernameTextBox.Text}'", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                Forms.conn.Close();
                return true;
            }
            else
            {
                reader.Close();
                Forms.conn.Close();
                return false;
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand("SELECT MAX(EmployeeID) FROM Employees", Forms.conn);
            SQLiteDataReader reader;
            reader = sql.ExecuteReader();
            reader.Read();
            EmployeeIDNumberLabel.Text = (Convert.ToInt32(reader["MAX(EmployeeID)"].ToString()) + 1).ToString();
            reader.Close();
            Forms.conn.Close();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            Forms.addemployee = new AddEmployee();
            this.Dispose();
        }

        private void FillComboBoxes()
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand("SELECT Role FROM Roles", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();
            string role;
            while (reader.Read())
            {
                role = (string)reader["Role"];
                if (role == CurrentUser.role)
                {
                    if(role != "Store Manager")
                    {
                        break;
                    }
                }
                RoleComboBox.Items.Add((string)reader["Role"]);
            }
            reader.Close();
            SQLiteCommand sql2 = new SQLiteCommand($"SELECT Department FROM DepartmentTypes", Forms.conn);
            SQLiteDataReader reader2 = sql2.ExecuteReader();
            while (reader2.Read())
            {
                DepartmentComboBox.Items.Add((string)reader2["Department"]);
            }
            reader2.Close();
            Forms.conn.Close();
        }
    }
}
