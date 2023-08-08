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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"INSERT INTO Employees VALUES ('{EmployeeIDNumberLabel.Text}', '{ForenameTextBox.Text}', '{SurnameTextBox.Text}', '{RoleComboBox.Text}', '{DepartmentComboBox.Text}', '{UsernameTextBox.Text}', '{PasswordTextBox}')", Forms.conn);
            sql.ExecuteNonQuery();
            Forms.conn.Close();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand("SELECT EmployeeID FROM Employees ORDER BY EmployeeID DESC", Forms.conn);
            SQLiteDataReader reader;
            reader = sql.ExecuteReader();
            reader.Read();
            EmployeeIDNumberLabel.Text = (int.Parse((reader["EmployeeID"].ToString())) + 1).ToString();
            Forms.conn.Close();
        }
    }
}