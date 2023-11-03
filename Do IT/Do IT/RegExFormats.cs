using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_IT
{
    internal static class RegExFormats
    {
        public static string anyletter = "^[a-zA-Z]+$";
        public static string anynumber = @"^\d+$";
        public static string anyprice = @"^\d+(\.\d\d)?$";
    }
}
