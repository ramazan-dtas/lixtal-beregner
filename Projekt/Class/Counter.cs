using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Projekt
{
    public class Counter
    {
        public int Wordcounter { get; set; }//properti
        public int Dot { get; set; }
        public int Longword { get; set; }

        public void WordCounter(int wordCounter)
        {
            string filePath = @"..\..\Tekst.txt";//connection string
            StreamReader sr = new StreamReader(filePath);//Read file
            string line;
            wordCounter = 0;
            while ((line = sr.ReadLine()) != null)
            {
                //Splits each line into words  
                string[] words = line.Split(' ');
                //Counts each word  
                wordCounter= wordCounter + words.Length;
            }
            Wordcounter = wordCounter;//Here i do count public
            Console.WriteLine($"Antal ord: {wordCounter}");
            sr.Close();
        }

        public void DotCounter(int dot)
        {
            dot = 0;
            string filePath = @"..\..\Tekst.txt";
            if (File.Exists(filePath))
            {
                string pattern = ".".Trim();//Remove every "." 

                dot = Regex.Matches(File.ReadAllText(filePath), Regex.Escape(pattern), RegexOptions.IgnoreCase).Count;//Do not forget to escape the pattern! 
                Dot = dot;
                Console.WriteLine($"Antal punktum: {dot}");
            }
        }

        public void LongWord(int longword)
        {
            string filePath = @"..\..\Tekst.txt";
            StreamReader sr = new StreamReader(filePath);
            var text = sr.ReadToEnd();

            List<string> words;
            words = new List<string>(text.Split(new char[] { ' ', '.', '\n', '\t', '-', ',' }));//splits every time one of them is seen

            string[] wordsOverSix = words.FindAll(w => w.Length >= 6).ToArray();//Here  the program find every word there is more then 6 longth
            longword = wordsOverSix.Count();//Here it count every words that is more then 6 long
            Longword = longword;
            Console.WriteLine($"Amount of long words: {longword}");
            sr.Close();
        }

        public void Calculator(int wordcounter, int dot, int longword)
        {
            wordcounter = Wordcounter;//Here i take the numbers in the variables and put them in here
            dot = Dot;
            longword = Longword;
            int math = wordcounter / dot + (longword * 100 / wordcounter);//Lix formula

            Console.WriteLine($"Lixtallet er: {math}");   
        }
    }
}