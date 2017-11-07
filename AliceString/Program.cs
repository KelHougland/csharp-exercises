using System;

namespace AliceString
{
    class Program
    {
        static void Main(string[] args)
        {
            string sent;
            string l_sent;
            string input;


            sent = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            l_sent = sent.ToLower();

            Console.WriteLine("Enter text to search for in the first sentence of 'Alice in Wonderand'");
            input = Console.ReadLine();

            if (l_sent.Contains(input.ToLower()))
            {
                Console.WriteLine("That is in the sentence!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That is not in the sentence.");
                Console.ReadLine();
            }
            
        }
    }
}
