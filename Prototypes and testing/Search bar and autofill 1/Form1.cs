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
            string[] options = new string[5];
            try
            {
                options = RootedTree.getRoot().Search(word);
                Option1Label.Text = options[0];
                Option2Label.Text = options[1];
                Option3Label.Text = options[2];
                Option4Label.Text = options[3];
                Option5Label.Text = options[4];
                

            }
            catch (LetterNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IndexOutOfRangeException)
            {
                
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("That is not a valid start letter, please try again");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RootedTree.AddWord("56,abc*");
            RootedTree.AddWord("8,abcd*");
            RootedTree.AddWord("10,abce*");

            //MessageBox.Show(RootedTree.getRoot().getChildren()[0].getName().ToString());
            //string word = "abc*";
            //MessageBox.Show(RootedTree.getRoot().Search(word));

            //MessageBox.Show(RootedTree.getRoot().getChildren()[0].getChildren()[0].getChildren()[1].getName().ToString());
        }
    }
}
