using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> stringThings = new Employee<string>()
            {
                things = new List<string> { "Lexus ", "Bentley ", "Toyota" }
            };
            Employee<int> intThings = new Employee<int>()
            {
                things = new List<int> { 1, 3, 5 }
            };


            foreach (string item in stringThings.things)
            {
                Console.WriteLine(item + " ");
            }
            foreach (int item in intThings.things)
            {
                Console.WriteLine(item + " ");
            }

            Console.ReadLine();
        }
    }
}
