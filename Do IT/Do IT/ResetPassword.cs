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
            SQLiteCommand sql = new SQLiteCommand($"SELECT Role FROM Employees WHERE Username = '{UsernameTextBox.Text}'", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();

            if (reader.Read())
            {
                SQLiteCommand sql2 = new SQLiteCommand($"SELECT RoleID FROM Roles WHERE Role = '{CurrentUser.role}'", Forms.conn);
                SQLiteDataReader reader2 = sql2.ExecuteReader();
                reader2.Read();
                if (Convert.ToInt32(reader["Role"]) < Convert.ToInt32(reader2["RoleID"]) || Convert.ToInt32(reader2["RoleID"]) == 4)
                {
                    if (CheckPasswordsMatch())
                    {
                        if(PasswordTextBox.Text.Length >= 6)
                        {
                            SQLiteCommand sql3 = new SQLiteCommand($"UPDATE Employees SET Password = '{PasswordTextBox.Text}' WHERE Username = '{UsernameTextBox.Text}'", Forms.conn);
                            sql3.ExecuteNonQuery();
                            MessageBox.Show("Password reset");
                        }
                        else
                        {
                            MessageBox.Show("Please enter a password longer than 6 characters");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match");
                    }
                }
                else
                {
                    MessageBox.Show("You do not have permission to change this persons pasword");
                }
                reader2.Close();
            }
            else
            {
                MessageBox.Show("Invalid username");
            }
            reader.Close();
            Forms.conn.Close();

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
    }
}
