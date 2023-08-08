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
        public static CreateAccountSignIn createaccountsignin = new CreateAccountSignIn();
        public static MainMenu mainmenu = new MainMenu();
        public static CreateAccount createaccount = new CreateAccount();
    }
}
