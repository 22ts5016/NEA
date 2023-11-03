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
            if(Regex.IsMatch(ForenameTextBox.Text, RegExFormats.anyletter) && Regex.IsMatch(SurnameTextBox.Text, RegExFormats.anyletter) && RoleComboBox.SelectedIndex != -1 && DepartmentComboBox.SelectedIndex != -1)
            {
                Forms.conn.Open();
                SQLiteCommand sql = new SQLiteCommand($"INSERT INTO Employees VALUES ('{EmployeeIDNumberLabel.Text}', '{ForenameTextBox.Text}', '{SurnameTextBox.Text}', '{RoleComboBox.Text}', '{DepartmentComboBox.Text}', '{UsernameTextBox.Text}', '{PasswordTextBox.Text}')", Forms.conn);
                sql.ExecuteNonQuery();
                MessageBox.Show("Account created!");
                Forms.conn.Close();
                Forms.viewemployeeactions.Action(4, $"Account made for {ForenameTextBox.Text} {SurnameTextBox.Text}");
            }
            else
            {
                MessageBox.Show("Invalid inputs");
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand("SELECT EmployeeID FROM Employees ORDER BY EmployeeID DESC", Forms.conn);
            SQLiteDataReader reader;
            reader = sql.ExecuteReader();
            reader.Read();
            EmployeeIDNumberLabel.Text = (int.Parse((reader["EmployeeID"].ToString())) + 1).ToString();
            reader.Close();
            Forms.conn.Close();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }
    }
}
