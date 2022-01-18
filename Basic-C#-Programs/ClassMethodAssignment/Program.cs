using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b;
            MathOperation n = new MathOperation();
            n.division(a);
            Console.ReadLine();

            n.multiplication(out b);
            Console.ReadLine();

            n.multiplication(out a, out b);
            Console.ReadLine();

            StaticClass.SampleStaticMethod();
            Console.ReadLine();
        }
    }
}
