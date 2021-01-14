using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projekt
{
    class Five
    {
        public static void LineCounter()
        {
            int line;
            string filePath = @"..\..\Tekst.txt";//connection String
            StreamReader sr = new StreamReader(filePath);//Den læser dokumentet
            var text = sr.ReadToEnd();//Sørger for at den læser hele filen

            List<string> words;//opretter en list af min connection string
            words = new List<string>(text.Split(new char[] {'.', ',', '!', '?', ':', ';' }));//splitter dokumentet hver gang der kommer en af tegnene
            line = words.Count();//tæller hvor mange gange den splittere

            Console.WriteLine($"Amount of line: {line}");

            sr.Close();//stopper med at læse den
        }
    }
}
