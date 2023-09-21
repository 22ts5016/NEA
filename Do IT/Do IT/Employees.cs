using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if(CurrentUser.role == "Store Manager")
            {
                AddEmployeeButton.Visible = true;
                ResetPasswordButton.Visible = true;
            }
        }
    }
}
