using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1
            int x = 3;
            int y = 50;
            Console.WriteLine(x * y);
            Console.ReadLine();

            //Task-2
            int a = 100;
            int b = 25;
            Console.WriteLine(a + b);
            Console.ReadLine();

            //Task-3
            double quotient = 100.0 / 12.5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            //Task-4
            bool trueOrFalse = 90 > 50;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            //Task-5
            int remainder = 15 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();

        }
    }
}
