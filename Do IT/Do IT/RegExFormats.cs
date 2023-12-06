using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_IT
{
    internal static class RegExFormats
    {
        public static string anyletters = "^[a-zA-Z]+$";
        public static string anynumber = @"^\d+$";
        public static string anyproductname = @"^([a-zA-Z()]|\d| |,|-|'|.)+$";
        public static string anyprice = @"^\d+(\.\d\d)?$";
        public static string anyaddress = @"^\d+ ([a-zA-Z]|'| )+$";
        public static string anypostcode = @"^[a-zA-Z]{1,2}\d{1,2} \d[a-zA-Z]{2}$";
        public static string anyphonenumber = @"^(\+\d{2} \d{4} \d{6})|(\+\d{2} \d{10})|(\d{11})|(\d{5} \d{6})$";
        public static string anyemail = @"^[^@]+@[^@]+$";
    }
}
