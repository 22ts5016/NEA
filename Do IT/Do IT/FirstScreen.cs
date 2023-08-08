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
    public partial class FirstScreen : Form
    {
        public FirstScreen()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirstScreen_Load(object sender, EventArgs e)
        {
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT EmployeeID, Forename, Role, Department, Password FROM Employees WHERE Employees.Username = '{UsernameTextBox.Text.ToLower()}'", Forms.conn);
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
    }
}
