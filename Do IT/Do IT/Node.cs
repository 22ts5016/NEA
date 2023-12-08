using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_IT
{
    internal class Node
    {
        private char name;
        private List<Node> children;
        private int[] popularW;
        private char[] popularC;
        private bool[] nodessearched = { false, false, false, false, false };

        public Node(char inname, int inweight)
        {
            children = new List<Node>();
            name = inname;
            popularW = new int[5];
            popularC = new char[5];
        }

        public void AddNode(string word, int weight)
        {
            for (int i = 0; i < children.Count; i++)
            {
                if (word[0] == children[i].name)
                {
                    Sort(weight, word[0]);
                    children[i].AddNode(word.Substring(1), weight);
                    return;
                }
            }
            Sort(weight, word[0]);
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

        public string[] Search(string word)
        {
            for (int i = 0; i < children.Count; i++)
            {
                if (word.Length == 0)
                {
                    string[] temp = new string[5];
                    for (int j = 0; j < popularC.Length; j++)
                    {
                        foreach (Node n in children)
                        {
                            if (n.name == popularC[j] && popularC != null)
                            {
                                temp[j] = n.getPopular();
                                break;
                            }
                        }
                        nodessearched[j] = true;
                    }
                    ResetBools();
                    return temp;
                }
                if (word[0] == children[i].name)
                {
                    return children[i].Search(word.Substring(1));
                }
            }
            throw new LetterNotFoundException();
        }

        public string getPopular()
        {
            for (int i = 0; i < nodessearched.Length; i++)
            {
                if (!nodessearched[i])
                {
                    if (popularC[i] == '*')
                    {
                        nodessearched[i] = true;
                        return name.ToString();
                    }
                    foreach (Node n in children)
                    {
                        if (n.name == popularC[i])
                        {
                            nodessearched[i] = true;
                            return name + n.getPopular();
                        }
                    }
                }
            }
            return "";
        }

        public bool checkDupe(string word)
        {
            for (int i = 0; i < children.Count; i++)
            {
                if (word == "" && children[i].name == '*')
                {
                    return true;
                }
                else if (word.Length != 0 && word[0] == children[i].getName())
                {
                    return children[i].checkDupe(word.Substring(1));
                }
            }
            return false;
        }

        public void Sort(int inweight, char inchar)
        {
            int compW = inweight;
            char compC = inchar;
            for (int i = 0; i < popularW.Length; i++)
            {
                if (popularW[i] <= compW)
                {
                    int tempW = popularW[i];
                    char tempC = popularC[i];
                    popularC[i] = compC;
                    popularW[i] = compW;
                    compW = tempW;
                    compC = tempC;
                }
            }
        }

        public void ResetBools()
        {
            for (int i = 0; i < nodessearched.Length; i++)
            {
                if (nodessearched[i])
                {
                    foreach (Node n in children)
                    {
                        if (n.name == popularC[i])
                        {
                            n.ResetBools();
                        }
                    }
                    nodessearched[i] = false;
                }
            }
        }

        public void ClearTree(Node node)
        {
            if(node.children.Count == 0)
            {
                return;
            }

            foreach(Node n in node.children)
            {
                ClearTree(n);
            }

            node.children.Clear();
        }

        public string SearchForStartOfRemoval(string word, int weight)
        {
            if (weight >= popularW[4])
            {
                ClearTree(this);
                return name.ToString();
            }

            foreach(Node n in children)
            {
                if(n.name == word[0])
                {
                    return name + n.SearchForStartOfRemoval(word.Substring(1), weight);
                }
            }
            return "Error";
        }
    }
}
