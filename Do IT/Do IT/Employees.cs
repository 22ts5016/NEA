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
            Forms.employees = new Employees();
            this.Dispose();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            Forms.addemployee.Show();
            Forms.employees = new Employees();
            this.Dispose();
        }

        private void ViewEmployeeActionsButton_Click(object sender, EventArgs e)
        {
            Forms.viewemployeeactions.Show();
            Forms.employees = new Employees();
            this.Dispose();
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
            Forms.employees = new Employees();
            this.Dispose();
        }

        private void ViewEmployeeDetailsButton_Click(object sender, EventArgs e)
        {
            Forms.viewemployeedetails.Show();
            Forms.employees = new Employees();
            this.Dispose();
        }
    }
}
