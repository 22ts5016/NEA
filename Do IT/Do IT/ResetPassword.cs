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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT Role FROM Employees WHERE Username = '{InputTextBox.Text}' OR EmployeeID = '{InputTextBox.Text}'", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();

            if (reader.Read())
            {
                if (CheckUserClearance(Convert.ToInt32(reader["Role"])))
                {
                    if (PasswordTextBox.Text.Length >= 6)
                    {
                        if (CheckPasswordsMatch())
                        {
                            SQLiteCommand sql2 = new SQLiteCommand($"UPDATE Employees SET Password = '{PasswordTextBox.Text}' WHERE Username = '{InputTextBox.Text}' OR EmployeeID = '{InputTextBox.Text}'", Forms.conn);
                            sql2.ExecuteNonQuery();
                            MessageBox.Show("Password reset");
                            reader.Close();
                            Forms.conn.Close();
                            Forms.viewemployeeactions.Action(4, $"{InputTextBox.Text} password was reset");
                        }
                        else
                        {
                            MessageBox.Show("Passwords do not match");
                            reader.Close();
                            Forms.conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a password longer than 6 characters");
                        reader.Close();
                        Forms.conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("You do not have permission to change this persons pasword");
                    reader.Close();
                    Forms.conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid employee ID or username");
                reader.Close();
                Forms.conn.Close();
            }
        }
        private bool CheckPasswordsMatch()
        {
            if(PasswordTextBox.Text == ConfirmPasswordTextBox.Text)
            {
                return true;
            }
            return false;
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void RevealPaswordButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.UseSystemPasswordChar)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void RevealConfirmPasswordButton_Click(object sender, EventArgs e)
        {
            if (ConfirmPasswordTextBox.UseSystemPasswordChar)
            {
                ConfirmPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        public bool CheckUserClearance(int inputclearance)
        {
            if (inputclearance < CurrentUser.clearance || CurrentUser.clearance == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
