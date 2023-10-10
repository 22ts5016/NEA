﻿using System;
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
    public partial class FirstScreen : Form
    {
        private static bool AddedWords = false;

        public FirstScreen()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT EmployeeID, Forename, Roles.Role, DepartmentTypes.Department, Password FROM Employees, Roles, DepartmentTypes WHERE Username = '{UsernameTextBox.Text.ToLower()}' AND Password = '{PasswordTextBox.Text}' AND Employees.Role = RoleID AND Employees.Department = DepartmentID", Forms.conn);
            SQLiteDataReader reader; 
            bool invaid = true;
            reader = sql.ExecuteReader();
            if (reader.Read())
            {
                if ((string)reader["Password"] == PasswordTextBox.Text)
                {
                    CurrentUser.name = (string)reader["Forename"];
                    CurrentUser.role = (string)reader["Role"];
                    CurrentUser.department = (string)reader["Department"];
                    CurrentUser.ID = Convert.ToInt32(reader["EmployeeID"]);
                    reader.Close();
                    Forms.conn.Close();
                    Forms.mainmenu.Show();
                    this.Hide();
                    invaid = false;
                }
            }
            if (invaid)
            {
                Forms.conn.Close();
                MessageBox.Show("Invalid username or password");
            }
        }

        private void FirstScreen_Load(object sender, EventArgs e)
        {
            if (!AddedWords)
            {
                ProductQuery.AddWords();
                AddedWords = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Forms.CloseAll();
        }
    }
}
