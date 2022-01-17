using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_QuoteApplicationAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight <= 50)
            {
                Console.WriteLine("Please enter the package dimensions.");
            }
            else
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Sorry for the inconvenience.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Width: ");
            int Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int dimension = height + Width + length;

            if (dimension > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express. Sorry for the inconvenience.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                int total = dimension * weight / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + total + " Thank You!");
            }

            Console.ReadLine();

        }
    }
}
