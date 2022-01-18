using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable iQuite = new Employee() { firstName = "John", lastName = "Wick" };

            iQuite.Quit();
            Console.ReadLine();
        }
    }
}
