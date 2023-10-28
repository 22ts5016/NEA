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
    public partial class ViewEmployeeDetails : Form
    {
        public ViewEmployeeDetails()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            MainTable.Controls.Clear();
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand($"SELECT EmployeeID, Forename, Surname, Roles.Role, DepartmentTypes.Department, Username, Password FROM Employees, Roles, DepartmentTypes WHERE Username = '{InputTextBox.Text}' OR EmployeeID = '{InputTextBox.Text}' AND Employees.Role = Roles.RoleID AND Employees.Department = DepartmentTypes.DepartmentID", Forms.conn);
            SQLiteDataReader reader = sql.ExecuteReader();

            if (reader.Read())
            {
                Label temp;

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = "EmployeeID";

                MainTable.Controls.Add(temp, 0, 0);

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = "Forename";

                MainTable.Controls.Add(temp, 1, 0);

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = "Surname";

                MainTable.Controls.Add(temp, 2, 0);

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = "Role";

                MainTable.Controls.Add(temp, 3, 0);

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = "Department";

                MainTable.Controls.Add(temp, 4, 0);

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = "Username";

                MainTable.Controls.Add(temp, 5, 0);

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = "Password";

                MainTable.Controls.Add(temp, 6, 0);

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = Convert.ToInt32(reader["EmployeeID"]).ToString();

                MainTable.Controls.Add(temp, 0, 1);

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = (string)reader["Forename"];

                MainTable.Controls.Add(temp, 1, 1);

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = (string)reader["Surname"];

                MainTable.Controls.Add(temp, 2, 1);

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = (string)reader["Role"];

                MainTable.Controls.Add(temp, 3, 1);

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = (string)reader["Department"];

                MainTable.Controls.Add(temp, 4, 1);

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = (string)reader["Username"];

                MainTable.Controls.Add(temp, 5, 1);

                temp = Forms.vieworder.CreateLabel("middle");
                temp.Text = (string)reader["Password"];

                MainTable.Controls.Add(temp, 6, 1);
                reader.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or employee number");
            }
            Forms.conn.Close();
        }
    }
}
