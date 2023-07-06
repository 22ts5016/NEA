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
        private bool allchildrensearched;
        private List<Node> children;
        private string[] popular;

        public Node(char inname, int inweight)
        {
            children = new List<Node>();
            name = inname;
            BubbleSort(inweight);
            allchildrensearched = false;
            popular = new string[5];
        }

        public void AddNode(string word, int weight)
        {
            for (int i = 0; i < children.Count; i++)
            {
                if (word[0] == children[i].name)
                {
                    children[i].AddNode(word.Substring(1), weight);
                    return;
                }
            }
            children.Add(new Node(word[0], weight));
            if (word.Length == 1)
            {
                return;
            }
            children[children.Count - 1].AddNode(word.Substring(1), weight);
        }

        public char getName()
        {
            return name;
        }

        public List<Node> getChildren()
        {
            return children;
        }

        public string Search(string word)
        {
            for(int i = 0; i < children.Count; i++)
            {
                if (word.Length == 1)
                {
                    return null;
                }
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

        public void BubbleSort(int inweight)
        {

        }
    }
}
