using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 60;
            int b = 70;

            MathCal n = new MathCal();

            n.selectOne(a, b);
            n.selectOne(num2: b, num1: a);
            Console.ReadLine();
        }
    }
}
