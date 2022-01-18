using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assign
{
     class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            one_file example = new one_file();
            example.IntOut(number);


            int numOut;
            int num;
            Console.WriteLine("Number: ");
            numOut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Another number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(one_file.NumberOut(out numOut, num));
            Console.ReadLine();


            string Test = "Test";
            Console.WriteLine(one_file.NumberOut(Test));
            Console.ReadLine();



            static_file.Better();

        }
    }
}
