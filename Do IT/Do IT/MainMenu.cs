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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Forms.firstscreen.Dispose();
            if(CurrentUser.role != "Customer Advisor")
            {
                EmployeesButton.Visible = true;
                if(CurrentUser.role == "Store Manager" || CurrentUser.role == "Deputy Store Manager")
                {
                    AddProductButton.Visible = true;
                    RemoveProductButton.Visible = true;
                    AddLocationButton.Visible = true;
                }
            }
        }

        private void PeoductQueryButton_Click(object sender, EventArgs e)
        {
            Forms.productquery.Show();
            Forms.mainmenu.ProductQueryButton.Select();
            this.Hide();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Forms.addproduct.Show();
            Forms.mainmenu.ProductQueryButton.Select();
            this.Hide();
        }

        private void LocationManagementButton_Click(object sender, EventArgs e)
        {
            Forms.locationmanagement.Show();
            Forms.mainmenu.ProductQueryButton.Select();
            this.Hide();
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            Forms.addlocation.Show();
            Forms.mainmenu.ProductQueryButton.Select();
            this.Hide();
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            Forms.employees.Show();
            Forms.mainmenu.ProductQueryButton.Select();
            this.Hide();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            Forms.orders.Show();
            Forms.mainmenu.ProductQueryButton.Select();
            this.Hide();
        }

        private void StockManagementButton_Click(object sender, EventArgs e)
        {
            Forms.stockmanagement.Show();
            Forms.mainmenu.ProductQueryButton.Select();
            this.Hide();
        }

        private void CustomerDetailsButton_Click(object sender, EventArgs e)
        {
            Forms.customerdetails.Show();
            Forms.mainmenu.ProductQueryButton.Select();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Forms.CloseAll();
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            Forms.removeproduct.Show();
            Forms.mainmenu.ProductQueryButton.Select();
            this.Hide();
        }
    }
}
