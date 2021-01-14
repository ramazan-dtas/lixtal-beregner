using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {//here i call every method i made
            Counter p1 = new Counter();
            p1.WordCounter(p1.Wordcounter);
            p1.DotCounter(p1.Dot);
            p1.LongWord(p1.Longword);
            p1.Calculator(p1.Wordcounter, p1.Dot, p1.Longword);

            Five.LineCounter();

            Console.ReadKey();
        }
    }
}