using System;

namespace GasMilage
{
    class Program
    {
        static void Main(string[] args)
        {
            string gas_str;
            string miles_str;
            double gas;
            double miles;
            double milage;
            string response;

            Console.WriteLine("How many miles have you driven?");
            miles_str = Console.ReadLine();
            Console.WriteLine("How many gallons of gas have you used?");
            gas_str = Console.ReadLine();
            gas = double.Parse(gas_str);
            miles = double.Parse(miles_str);
            milage = miles/gas;
            response = "Your gas milage is " + milage + " miles per gallon.";
            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}
