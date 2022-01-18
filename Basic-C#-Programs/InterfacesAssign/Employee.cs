using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssign
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            string fullName = $"{firstName} {lastName} ";
            Console.WriteLine(fullName);
        }
        public void Quit()
        {
            string iQuit = $"{firstName} {lastName} has presumably Quit";
            Console.WriteLine(iQuit);
        }
    }
}
