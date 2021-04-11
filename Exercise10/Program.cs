using System;
using System.IO;

namespace Exercise10
{
    class Program
    {
        static readonly string textFolder = @"C:\Temp\";
        static readonly string textFile = @"C:\Temp\Exercise10.txt";

        static void Main(string[] args)
        {
            string textString;
            int wordCount = 0;

            if(File.Exists(textFile))
            {
                textString = File.ReadAllText(textFile);
                wordCount = CountTE(textString);
            }

          
   
            Console.WriteLine("There are {0}\n words that end in t or e.", wordCount);
        }

        public static int CountTE(String str)
        {
            int wordCount = 0;
            str = str.ToLower();
            string[] words = str.Split(' ');

           foreach(var word in words)
            {
                    if(word.EndsWith("e") || word.EndsWith("t"))
                    {
                        wordCount++;
                    }
                
            }
            return wordCount;
        }
    }
}
