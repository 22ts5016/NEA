using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_bar_and_autofill_1
{
    internal static class RootedTree
    {
        private static Node root = new Node(',',0);
        public static void AddWord(string word)
        {
            string[] words = word.Split(',');
            
            root.AddNode(words[1],int.Parse(words[0]));
        }
        public static Node getRoot()
        {
            return root;
        }
    }
}
