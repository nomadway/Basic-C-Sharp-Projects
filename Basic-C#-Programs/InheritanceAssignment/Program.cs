using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Employee info = new Employee();
            info.FirstName = "Sample";
            info.LastName = "Student";
            info.SayName();

            Console.ReadLine();
        }
    }
}
