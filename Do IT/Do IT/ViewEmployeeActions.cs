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

        public void Action(int type, string action)
        {
            Forms.conn.Open();
            SQLiteCommand sql = new SQLiteCommand("SELECT ActionID FROM Actions ORDER BY ActionID DESC", Forms.conn);
            SQLiteDataReader reader;
            reader = sql.ExecuteReader();
            reader.Read();
            string actionid = (int.Parse(reader["ActionID"].ToString()) + 1).ToString();
            reader.Close();
            SQLiteCommand sql2 = new SQLiteCommand($"INSERT INTO Actions VALUES ('{actionid}', '{CurrentUser.ID}', '{type}', '{action}')", Forms.conn);
            sql2.ExecuteNonQuery();
            Forms.conn.Close();
        }
    }
}
