using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
     class MathOperation
    {
        public void division (int num1)
        {
            int Result = num1 / 2;
            Console.WriteLine("Number " + num1 + " divided by " + 2 + " is " + Result);
            return;
        }
        public void multiplication (out int num1)
        {
            Console.WriteLine("Enter a number for multiplication");
            num1 = Convert.ToInt32(Console.ReadLine());
            int Result = num1 * 12;
            Console.WriteLine("Number " + num1 + " multiplied by " + 12 + " is " + Result);
        }
        public void multiplication (out int num1, out int num2)
        {
            Console.WriteLine("Enter the first number for multiplication");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number for multiplication");
            num2 = Convert.ToInt32(Console.ReadLine());
            int Result = num1 * num2;
            Console.WriteLine(num1 + " multiplied by " + num2 + " is " + Result);
        }
    }    
}