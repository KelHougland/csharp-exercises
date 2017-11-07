using System;

namespace RectArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string len_str;
            string ht_str;
            double rectl;
            double recth;
            double area;
            string response; 

            Console.WriteLine("What is the length of your rectangle?");
            len_str = Console.ReadLine();
            Console.WriteLine("And the height?");
            ht_str = Console.ReadLine();
            rectl = double.Parse(len_str);
            recth = double.Parse(ht_str);
            area = rectl * recth;
            response = "The area is " + area + ".";
            Console.WriteLine(response);
            Console.ReadLine();



        }
    }
}
