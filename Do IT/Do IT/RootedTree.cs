﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_IT
{
    internal class RootedTree
    {
        private static Node root = new Node(',', 0);
        public static void AddWord(string word)
        {
            string[] words = word.Split(',');
            if (words[1] == "*")
            {
                throw new FormatException();
            }

            root.AddNode(words[1], int.Parse(words[0]));
        }
        public static Node getRoot()
        {
            return root;
        }
    }
}
