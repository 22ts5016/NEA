using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_bar_and_autofill_1
{
    internal class Node
    {
        private char name;
        private int weight;
        private bool allchildrensearched;
        private List<Node> children;

        public Node(char inname)
        {
            children = new List<Node>();
            name = inname;
            allchildrensearched = false;
        }

        public void AddNode(string word)
        {
            for(int i = 0; i < children.Count; i++)
            {
                if (word[0] == children[i].name)
                {
                    children[i].AddNode(word.Substring(1));
                    return;
                }
            }
            children.Add(new Node(word[0]));
            if (word.Length == 1)
            {
                return;
            }
            children[children.Count - 1].AddNode(word.Substring(1));
        }

        public char getName()
        {
            return name;
        }

        public int getWeight()
        {
            return weight;
        }

        public List<Node> getChildren()
        {
            return children;
        }

        public string Search(string word)
        {
            for(int i = 0; i < children.Count; i++)
            {
                if(word[0] == children[i].name)
                {
                    return word[0] + children[i].Search(word.Substring(1));
                }
            }
            throw new LetterNotFoundException();
        }

        public bool getChildrenSearched()
        {
            return allchildrensearched;
        }
    }
}
