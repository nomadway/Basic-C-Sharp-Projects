using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            methods math = new methods();
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number plus 100 = " + math.mathCalculation1(input)); 
            Console.WriteLine("Your number subtract 100 = " + math.mathCalculation2(input)); 
            Console.WriteLine("Your number times 100 = " + math.mathCalculation3(input));
            Console.ReadLine();

        }
    }
}
