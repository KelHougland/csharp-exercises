using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string response;
            Console.WriteLine("Hello, what is your name?");
            input = Console.ReadLine();
            response = "Hello, " + input + "!";
            Console.WriteLine(response);
            Console.ReadLine();

        }
    }
}
