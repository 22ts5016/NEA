using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_bar_and_autofill_1
{
    static class ListOfTrees
    {
        private static List<RootedTree> listoftrees;

        static ListOfTrees()
        {
            listoftrees = new List<RootedTree>();
            for(int i = 0; i < 26; i++)
            {
                listoftrees.Add(new RootedTree(new Node ((char)(i + 97))));
            }
        }

        public static List<RootedTree> Get()
        {
            return listoftrees;
        }
    }
}
