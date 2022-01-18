using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            decimal b = 4.4m;
            string c = "3";
            int total;
            Math_Cal n = new Math_Cal();
            total = n.Sum(a);
            Console.WriteLine("Sum of " + a + " and " + "40" + " is " + total);
            total = n.Difference(b);
            Console.WriteLine("Difference of " + b + " and " + "30" + " is " + total);
            total = n.Product(c);
            Console.WriteLine("Product of " + c + " and " + "20" + " is " + total);
            Console.ReadLine();

        }
    }
}
