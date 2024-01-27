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
        public static void AddWord(string word, int weight)
        {
            if (word.Contains("*"))
            {
                throw new FormatException();
            }
            word += "*";
            root.AddNode(word,weight);
        }
        public static Node getRoot()
        {
            return root;
        }
    }
}
