using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    class Anagram
    {
        public void Anagrams()
        {
            Console.Write("Enter first word:");
            string wordOne = Console.ReadLine();
            Console.Write("Enter second word:");
            string wordTwo = Console.ReadLine();

            char[] charOne = wordOne.ToLower().ToCharArray();
            char[] charTwo = wordTwo.ToLower().ToCharArray();  
            Array.Sort(charOne);
            Array.Sort(charTwo);

            string NewWordOne = new string(charOne);
            string NewWordTwo = new string(charTwo);
            if (NewWordOne == NewWordTwo)
            {
                Console.WriteLine("Yes! Words are Anagrams", NewWordOne, NewWordTwo);
            }
            else
            {
                Console.WriteLine("No! Words are not Anagrams", NewWordOne, NewWordTwo);
            }
            Console.ReadLine();
        }
    }
}
