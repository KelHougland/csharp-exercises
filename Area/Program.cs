using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;
            double pi = 3.14;

            Console.WriteLine("What is the radius of your circle?");
            radius = double.Parse(Console.ReadLine());
            area = pi * radius * radius;

            Console.WriteLine("The area of the circle is " + area.ToString());
            Console.ReadLine();


        }
    }
}
