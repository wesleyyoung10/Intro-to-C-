using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsInPark = 5;

            Console.WriteLine($"There are { dogsInPark } dogs in the park");

            decimal sandwiches = 1.5M;

            Console.WriteLine($"I can eat { sandwiches } sandwiches in one sitting");

            decimal money = 60.0M;

            Console.WriteLine($"A nice dinner costs ${ money } to buy");

            string colorOfCar = "black";

            Console.WriteLine($"My dream car color is { colorOfCar }");
            
            string makeOfCar = "Chevy";

            Console.WriteLine($"The make of my dream car is { makeOfCar }");

            string modelOfCar = "Silvardo";

            Console.WriteLine($"The model of my dream car is { modelOfCar }");

            DateTime today = DateTime.Now;

            Console.WriteLine($"Todays date is { DateTime.Now }");

            string letter = "W";

            Console.WriteLine($"The first letter of my name is { letter }");

            int stars = 20000000;

            Console.WriteLine($"There are { stars } stars in the sky that we can see");

            Console.Read();
        }
    }
}
