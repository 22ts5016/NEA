using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_IT
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            Forms.createaccount.Show();
            this.Hide();
        }

        private void ViewEmployeeActionsButton_Click(object sender, EventArgs e)
        {
            Forms.viewemployeeactions.Show();
            this.Hide();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand("SELECT Role FROM Roles WHERE RoleID = '1'", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();
            reader.Read();
            if(CurrentUser.role != (string)reader["Role"])
            {
                AddEmployeeButton.Visible = true;
                ResetPasswordButton.Visible = true;
            }
            reader.Close();
            Forms.conn.Close();
        }

        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            Forms.resetpassword.Show();
            this.Hide();
        }
    }
}
