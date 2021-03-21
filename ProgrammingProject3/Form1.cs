using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject3
{
    public partial class Form1 : Form
    {

        StreamReader inputFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            processDataLowerCase();
            processDataFirstAndLastWord();
            processDataFindLongestWord();
            processDataFindMostVowels();
            printToText();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputBox.Items.Clear();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void processDataLowerCase()
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    string lowerCase;

                    inputFile = File.OpenText(openFileDialog1.FileName);

                    while (inputFile.EndOfStream == false)
                    {
                        lowerCase = inputFile.ReadLine();

                        lowerCase = lowerCase.ToLower();
                        outputBox.Items.Add(lowerCase);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Operation canceled. ");
            }
        }

        private void processDataFirstAndLastWord()
        {
            try
            {
                string firstWord;
                string lastWord;

                List<string> wordList = new List<string>();  

                inputFile = File.OpenText(openFileDialog1.FileName);

                firstWord = inputFile.ReadLine();
                firstWord = firstWord.Substring(0, firstWord.IndexOf(" "));

                lastWord = inputFile.ReadLine();
                lastWord = lastWord.Split(' ').Last();

                wordList.Add(firstWord);
                wordList.Add(lastWord);

                wordList.Sort();

                for(int i = 0; i < wordList.Count; i++)
                {
                    outputBox.Items.Add(wordList[i]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Canceled. ");
            }
        }

        private void processDataFindLongestWord()
        {
            string longestWord;
            string[] words;
            int counter = 0;

            inputFile = File.OpenText(openFileDialog1.FileName);

            longestWord = inputFile.ReadToEnd();

            words = longestWord.Split(new[] { " " }, StringSplitOptions.None);

            foreach(String s in words)
            {
                if(s.Length > counter)
                {
                    longestWord = s;
                    counter = s.Length;
                    
                }
            }
            outputBox.Items.Add(longestWord);
        }

        private void processDataFindMostVowels()
        {
            string mostVowels;
            string[] words;
            int vowel_count = 0;
            int cons_count = 0;
            int counter = 0;

            inputFile = File.OpenText(openFileDialog1.FileName);

            mostVowels = inputFile.ReadToEnd();

            words = mostVowels.Split(new[] { " " }, StringSplitOptions.None);

            foreach(String s in words)
            {
                if (vowel_count >= counter)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                        {
                            vowel_count++;
                        }
                        else
                        {
                            cons_count++;
                        }
                    }

                    mostVowels = s;
                    counter = vowel_count;
                }
            }

            outputBox.Items.Add(mostVowels);
        }
        private void printToText()
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("Output.txt");

            foreach(String s in outputBox.Items)
            {
                outputFile.WriteLine(s);
            }

            outputFile.Close();
        }
    }
}
