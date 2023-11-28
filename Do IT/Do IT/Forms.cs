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
        public static ItemsWithoutLocations itemswithoutlocations = new ItemsWithoutLocations();
        public static ItemsInABay itemsinabay = new ItemsInABay();
        public static AddItemToLocation additemtolocation = new AddItemToLocation();
        public static AddMultipleItemsToLocation addmultipleitemstolocation = new AddMultipleItemsToLocation();
        public static DisplayedItem displayeditem = new DisplayedItem();
        public static Orders orders = new Orders();
        public static ViewOrder vieworder = new ViewOrder();
        public static CreateOrder createorder = new CreateOrder();
        public static CollectOrder collectorder = new CollectOrder();
        public static StockManagement stockmanagement = new StockManagement();
        public static StockAdjustment stockadjustment = new StockAdjustment();
        public static StockWriteOff stockwriteoff = new StockWriteOff();
        public static CustomerDetails customerdetails = new CustomerDetails();
        public static CreateCustomer createcustomer = new CreateCustomer();
        public static ViewCustomer viewcustomer = new ViewCustomer();
        public static ViewCustomersOrders viewcustomersorders = new ViewCustomersOrders();
        public static Employees employees = new Employees();
        public static ViewEmployeeActions viewemployeeactions = new ViewEmployeeActions();
        public static ResetPassword resetpassword = new ResetPassword();
        public static ViewEmployeeDetails viewemployeedetails = new ViewEmployeeDetails();
        public static AddEmployee addemployee = new AddEmployee();
        public static AddProduct addproduct = new AddProduct();
        public static RemoveProduct removeproduct = new RemoveProduct();
        public static AddLocation addlocation = new AddLocation();
        public static RemoveLocation removelocation = new RemoveLocation();

        public static void CreateNewForms()
        {
            productquery.Dispose();
            locationmanagement.Dispose();
            itemswithoutlocations.Dispose();
            itemsinabay.Dispose();
            additemtolocation.Dispose();
            addmultipleitemstolocation.Dispose();
            displayeditem.Dispose();
            orders.Dispose();
            vieworder.Dispose();
            createorder.Dispose();
            collectorder.Dispose();
            stockmanagement.Dispose();
            stockadjustment.Dispose();
            stockwriteoff.Dispose();
            customerdetails.Dispose();
            createcustomer.Dispose();
            viewcustomer.Dispose();
            viewcustomersorders.Dispose();
            employees.Dispose();
            viewemployeeactions.Dispose();
            resetpassword.Dispose();
            viewemployeedetails.Dispose();
            addemployee.Dispose();
            addproduct.Dispose();
            removeproduct.Dispose();
            addlocation.Dispose();
            removelocation.Dispose();

            productquery = new ProductQuery();
            locationmanagement = new LocationManagement();
            itemswithoutlocations = new ItemsWithoutLocations();
            itemsinabay = new ItemsInABay();
            additemtolocation = new AddItemToLocation();
            addmultipleitemstolocation = new AddMultipleItemsToLocation();
            displayeditem = new DisplayedItem();
            orders = new Orders();
            vieworder = new ViewOrder();
            createorder = new CreateOrder();
            collectorder = new CollectOrder();
            stockmanagement = new StockManagement();
            stockadjustment = new StockAdjustment();
            stockwriteoff = new StockWriteOff();
            customerdetails = new CustomerDetails();
            createcustomer = new CreateCustomer();
            viewcustomer = new ViewCustomer();
            viewcustomersorders = new ViewCustomersOrders();
            employees = new Employees();
            viewemployeeactions = new ViewEmployeeActions();
            resetpassword = new ResetPassword();
            viewemployeedetails = new ViewEmployeeDetails();
            addemployee = new AddEmployee();
            addproduct = new AddProduct();
            removeproduct = new RemoveProduct();
            addlocation = new AddLocation();
            removelocation = new RemoveLocation();
        }
    }
}
