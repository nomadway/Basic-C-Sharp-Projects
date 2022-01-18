using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers for math calculation one at a time. You don't need to enter anything for the second number.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int total;
            MathOperation n = new MathOperation();
            total = n.Sum(a, b);
            Console.WriteLine("Sum of " + a + " , " + 50 + " and " + "optional number " + b + " is " + total);
            total = n.Sum(a);
            Console.WriteLine("Sum of " + a + " , " + 50 + " and " + "optional number " + b + " is " + total);
            Console.ReadLine();
        }
    }
}
