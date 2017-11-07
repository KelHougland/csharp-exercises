using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, give me some letters to count!");
            string input = Console.ReadLine().ToLower();
            Dictionary<char, int> letters = new Dictionary<char, int>();
            string str_inp;

            if (input == "file")
            {
                str_inp = System.IO.File.ReadAllText(@"C:\Users\knhou\source\repos\csharp-exercises\CountingCharacters\text.txt") ;
            }
            else
            {
                str_inp = input;
            }


            foreach (char c in str_inp)
            {
                bool isAlpha = char.IsLetter(c);
                if (letters.ContainsKey(c) == false && isAlpha == true) {
                    letters.Add(c, 0);
                }
                    
            }

            foreach (char c in str_inp)
            {
                bool isAlpha = char.IsLetter(c);

                if (isAlpha == true)
                {
                    letters[c] += 1;
                }

            }

            foreach (KeyValuePair<char, int> letter in letters)
            {
                Console.WriteLine(letter.Key + " : " + letter.Value);
            }

            Console.ReadLine();
        }
    }
}
