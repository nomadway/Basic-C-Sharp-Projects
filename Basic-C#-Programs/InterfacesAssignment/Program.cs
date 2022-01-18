using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IQuittable worker = new Employees(); 
            worker.Quit();

            Employees name = new Employees() { FirstName = "Sample", LastName = "Student" }; 
            name.SayName(); 
            Console.ReadLine();
        }
    }
}
