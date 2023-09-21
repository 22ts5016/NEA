using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_IT
{
    internal class RootedTree
    {
        private static Node root = new Node(',', 0);

        public static void AddWord(int weight, string word)
        {
            if (word == "*")
            {
                throw new FormatException();
            }

            root.AddNode(word, weight);
        }
        public static Node getRoot()
        {
            return root;
        }
    }
}
