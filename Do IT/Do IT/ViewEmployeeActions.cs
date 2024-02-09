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
    public partial class ViewEmployeeActions : Form
    {
        public ViewEmployeeActions()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mainmenu.Show();
            this.Hide();
        }

        public static void Action(int type, string action)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand("SELECT ActionID FROM Actions ORDER BY ActionID DESC", Forms.conn);
            SQLiteDataReader reader;
            reader = sql.ExecuteReader();
            reader.Read();
            string actionid = (int.Parse(reader["ActionID"].ToString()) + 1).ToString();
            reader.Close();
            SQLiteCommand sql2 = new SQLiteCommand($"INSERT INTO Actions VALUES ('{actionid}', '{CurrentUser.employeeID}', '{CurrentUser.clearance}', '{type}', '{action}')", Forms.conn);
            sql2.ExecuteNonQuery();
            Forms.conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecificComboBox.Items.Clear();
            Forms.conn.Open();
            switch(SearchByComboBox.SelectedIndex)
            {
                case 0:
                    SpecificComboBox.Visible = false;
                    break;
                case 1:
                    SpecificComboBox.Visible = true;
                    SQLiteCommand sql = new SQLiteCommand($"SELECT Username FROM Employees WHERE Role < '{CurrentUser.clearance}' OR 4 = '{CurrentUser.clearance}'", Forms.conn);
                    SQLiteDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        SpecificComboBox.Items.Add((string)reader["Username"]);
                    }
                    reader.Close();
                    break;
                case 2:
                    SpecificComboBox.Visible = true;
                    SQLiteCommand sql2 = new SQLiteCommand($"SELECT ActionType FROM ActionTypes", Forms.conn);
                    SQLiteDataReader reader2 = sql2.ExecuteReader();
                    while (reader2.Read())
                    {
                        SpecificComboBox.Items.Add((string)reader2["ActionType"]);
                    }
                    reader2.Close();
                    break;
            }
            Forms.conn.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            MainLayoutPanel.Controls.Clear();
            bool valid = true;
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand();
            switch (SearchByComboBox.SelectedIndex)
            {
                case 0:
                    sql = new SQLiteCommand($"SELECT Forename, Surname, Employees.EmployeeID, ActionTypes.ActionType, Action FROM Employees, Actions, ActionTypes WHERE Employees.EmployeeID = Actions.EmployeeID AND Actions.ActionType = ActionTypeID AND (Actions.Role < '{CurrentUser.clearance}' OR 4 = {CurrentUser.clearance}) ORDER BY ActionID DESC", Forms.conn);
                    break;
                case 1:
                    if(SpecificComboBox.SelectedIndex == -1)
                    {
                        valid = false;
                        break;
                    }
                    sql = new SQLiteCommand($"SELECT Forename, Surname, Employees.EmployeeID, ActionTypes.ActionType, Action FROM Employees, Actions, ActionTypes WHERE Employees.EmployeeID = Actions.EmployeeID AND Actions.ActionType = ActionTypeID AND Employees.Username = '{SpecificComboBox.Items[SpecificComboBox.SelectedIndex]}' ORDER BY ActionID DESC", Forms.conn);
                    break;
                case 2:
                    if (SpecificComboBox.SelectedIndex == -1)
                    {
                        valid = false;
                        break;
                    }
                    sql = new SQLiteCommand($"SELECT Forename, Surname, Employees.EmployeeID, ActionTypes.ActionType, Action FROM Employees, Actions, ActionTypes WHERE Employees.EmployeeID = Actions.EmployeeID AND Actions.ActionType = ActionTypeID AND ActionTypes.ActionType = '{SpecificComboBox.Items[SpecificComboBox.SelectedIndex]}' ORDER BY ActionID DESC", Forms.conn);
                    break;
                default:
                    valid = false;
                    break;
            }

            if (valid)
            {
                SQLiteDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    TableLayoutPanel table = new TableLayoutPanel();

                    table.Height = 50;
                    table.Width = 1280;
                    table.ColumnCount = 5;
                    table.RowCount = 1;
                    table.Margin = new Padding(0, 0, 0, 0);

                    Label temp = new Label();

                    temp = Forms.vieworder.CreateLabel("middle");
                    temp.Text = (string)reader["Forename"];

                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    table.Controls.Add(temp, 0, 0);
                    table.ColumnStyles[0].Width = 200;

                    temp = Forms.vieworder.CreateLabel("middle");
                    temp.Text = (string)reader["Surname"];

                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    table.Controls.Add(temp, 1, 0);
                    table.ColumnStyles[1].Width = 200;

                    temp = Forms.vieworder.CreateLabel("middle");
                    temp.Text = Convert.ToInt32(reader["EmployeeID"]).ToString();

                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    table.Controls.Add(temp, 2, 0);
                    table.ColumnStyles[2].Width = 200;

                    temp = Forms.vieworder.CreateLabel("middle");
                    temp.Text = (string)reader["ActionType"];

                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    table.Controls.Add(temp, 3, 0);
                    table.ColumnStyles[3].Width = 200;

                    temp = Forms.vieworder.CreateLabel("middle");
                    temp.Text = (string)reader["Action"];

                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                    table.Controls.Add(temp, 4, 0);
                    table.ColumnStyles[4].Width = 480;

                    MainLayoutPanel.Controls.Add(table);
                }
                reader.Close();
            }
            Forms.conn.Close();
        }
    }
}
