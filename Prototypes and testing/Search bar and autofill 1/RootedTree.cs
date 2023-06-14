using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_bar_and_autofill_1
{
    internal class RootedTree
    {
        private Node root;

        public RootedTree(Node inroot)
        {
            root = inroot;
        }

        public Node getRoot()
        {
            return root;
        }

        public void AddWord(string word)
        {
            root.AddNode(word.Substring(1));
        }
    }
}
