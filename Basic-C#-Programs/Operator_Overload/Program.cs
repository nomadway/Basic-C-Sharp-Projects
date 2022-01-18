using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            bool equal;

            employee1.Id = 1;
            employee2.Id = 1;
            equal = employee1.Id == employee2.Id;


            Console.WriteLine("Employees with identical id number: " + equal);
            Console.ReadLine();
        }
    }
}
