using LetterCounterNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounter_program
{
    class Program
    {
        static void Main(string[] args)
        {
            string sample = "aaabbc"; 
            LetterCounter snample = new LetterCounter();
            Console.WriteLine(snample.Count(sample));
            Console.ReadLine(); 
        }
    }
}
