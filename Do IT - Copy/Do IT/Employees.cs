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
            Forms.addemployee.Show();
            this.Hide();
        }

        private void ViewEmployeeActionsButton_Click(object sender, EventArgs e)
        {
            Forms.viewemployeeactions.Show();
            this.Hide();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            if(2 < CurrentUser.clearance)
            {
                ResetPasswordButton.Visible = true;
                ViewEmployeeDetailsButton.Visible = true;
                AddEmployeeButton.Visible = true;
            }
        }

        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            Forms.resetpassword.Show();
            this.Hide();
        }

        private void ViewEmployeeDetailsButton_Click(object sender, EventArgs e)
        {
            Forms.viewemployeedetails.Show();
            this.Hide();
        }
    }
}
