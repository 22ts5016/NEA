using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Do_IT
{
    internal static class Forms
    {
        public static SQLiteConnection conn = new SQLiteConnection("Data Source=Do IT database.db;Version=3;New=True;Compress=True;");
        public static FirstScreen firstscreen = new FirstScreen();
        public static MainMenu mainmenu = new MainMenu();
        public static ProductQuery productquery = new ProductQuery();
        public static LocationManagement locationmanagement = new LocationManagement();
        public static Orders orders = new Orders();
        public static StockManagement stockmanagement = new StockManagement();
        public static CustomerDetails customerdetails = new CustomerDetails();
        public static Employees employees = new Employees();
        public static AddProduct addproduct = new AddProduct();
        public static AddLocation addlocation = new AddLocation();
        public static CreateAccount createaccount = new CreateAccount();
        public static DisplayedItem displayitem = new DisplayedItem();

        public static void CloseAll()
        {
            firstscreen.Close();
            mainmenu.Close();
            productquery.Close();
            locationmanagement.Close();
            orders.Close();
            stockmanagement.Close();
            customerdetails.Close();
            employees.Close();
            addproduct.Close();
            addlocation.Close();
            createaccount.Close();
        }
    }
}
