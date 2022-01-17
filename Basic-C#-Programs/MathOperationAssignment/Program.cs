
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to be mutplied by 50.");
            string inputOne = Console.ReadLine();
            int multiply = Convert.ToInt32(inputOne);
            int multiplication = multiply * 50;
            Console.WriteLine(multiplication);


            Console.WriteLine("Enter the number to be added by 25.");
            string inputTwo = Console.ReadLine();
            int add = Convert.ToInt32(inputTwo);
            int addition = add + 25;
            Console.WriteLine(addition);


            Console.WriteLine("Enter the number to be divided by 12.5.");
            string inputThree = Console.ReadLine();
            int divide = Convert.ToInt32(inputThree);
            decimal twelveFive = 12.5m;
            decimal division = divide / twelveFive;
            Console.WriteLine(division);

            Console.WriteLine("Is it greater than 50? Type Yes or No!");
            string inputFour = Console.ReadLine();
            int greaterOrLess = Convert.ToInt32(inputFour);
            bool resultOne = greaterOrLess > 50;
            Console.WriteLine(resultOne);

            Console.WriteLine("Enter number to divided by 7 and generate a reminder.");
            string inputFive = Console.ReadLine();
            int remainder = Convert.ToInt32(inputFive);
            int remaining = remainder % 7;
            Console.WriteLine(remaining);
            Console.ReadLine();


        }
    }
}