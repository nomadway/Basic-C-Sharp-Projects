using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math_Cal.Method1(userNumber));
            Console.WriteLine(Math_Cal.Method2(userNumber));
            Console.WriteLine(Math_Cal.Method3(userNumber));

            Console.ReadLine();
        }
    }
}
