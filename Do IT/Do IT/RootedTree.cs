using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_IT
{
    internal static class RootedTree
    {
        private static Node root = new Node(',');

        public static void AddWord(int weight, string word)
        {
            root.AddNode(word, weight);
        }
        public static Node getRoot()
        {
            return root;
        }
    }
}
