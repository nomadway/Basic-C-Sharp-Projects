using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload
{
    public class Employee : Person
    {
          
        public int Id { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool equal;
            equal = employee1 == employee2;

            return equal;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool equal;
            equal = employee1 != employee2;


            return equal;
        }

    }
}
