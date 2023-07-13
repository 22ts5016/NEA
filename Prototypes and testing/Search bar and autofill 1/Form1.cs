using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Search_bar_and_autofill_1
{
    public partial class Form1 : Form
    {
        private string fileName = "DemoWords.txt";
        private string test = "test.txt";

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
                for(int i = 0; i < options.Length; i++)
                {
                    if(options[i] != null)
                    {
                        options[i] = word + options[i];
                    }
                }
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
            AddDemoWords();
        }

        private void AddWordButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            try
            {
                RootedTree.AddWord(WeightTextBox.Text + "," + WordTextBox.Text + "*");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid word.");
                valid = false;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Duplicate word added!");
                valid = false;
            }
            if (valid)
            {
                MessageBox.Show("Word added!");
            }
        }

        private void ClearButon_Click(object sender, EventArgs e)
        {
            WordTextBox.Clear();
            WeightTextBox.Clear();
        }

        private void AddDemoWords()
        {
            Random rnd = new Random();
            string[] hold = new string[2];
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while (sr.EndOfStream == false)
                {
                    line = sr.ReadLine();
                    hold = line.Split(',');
                    RootedTree.AddWord(hold[0] + "," + hold[1].ToLower() + "*");
                }
            }
        }
    }
}
