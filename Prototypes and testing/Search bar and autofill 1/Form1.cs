using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_bar_and_autofill_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string word = textBoxSearchBar.Text.ToLower();
            try
            {
                ListOfTrees.Get()[(int)word[0] - 97].getRoot().Search(word.Substring(1));
            }
            catch (LetterNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListOfTrees.Get()[0].AddWord("abc");
            ListOfTrees.Get()[0].AddWord("abcd");
            //MessageBox.Show(ListOfTrees.Get()[0].getRoot().getChildren()[0].getName().ToString());
        }
    }
}
