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
    public partial class CreateAccountSignIn : Form
    {
        public CreateAccountSignIn()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT Password, Role FROM Employees WHERE Employees.Username = '{UsernameTextBox.Text.ToLower()}'", Forms.conn);
            SQLiteDataReader reader;
            bool invaid = true;
            reader = sql.ExecuteReader();
            if (reader.Read())
            {
                if ((string)reader["Password"] == PasswordTextBox.Text)
                {
                    if ((string)reader["Role"] == "Store Manager")
                    {
                        Forms.conn.Close();
                        Forms.createaccount.Show();
                        this.Hide();
                        invaid = false;
                    }
                    
                }
            }
            if (invaid)
            {
                Forms.conn.Close();
                MessageBox.Show("Invalid username, password or role");
            }
        }
    }
}
