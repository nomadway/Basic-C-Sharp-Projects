using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Employee> staff = new List<Employee>();
            staff.Add(new Employee() { firstName = "Joe", lastName = "Schmidt", Id = 1 });
            staff.Add(new Employee() { firstName = "Joe", lastName = "Munich", Id = 2 });
            staff.Add(new Employee() { firstName = "Mike", lastName = "White", Id = 3 });
            staff.Add(new Employee() { firstName = "Steve", lastName = "Allan", Id = 4 });
            staff.Add(new Employee() { firstName = "Lisa", lastName = "Kim", Id = 5 });
            staff.Add(new Employee() { firstName = "Kate", lastName = "Wang", Id = 6 });
            staff.Add(new Employee() { firstName = "Sarah", lastName = "Donalds", Id = 7 });
            staff.Add(new Employee() { firstName = "Kevin", lastName = "Brown", Id = 8 });
            staff.Add(new Employee() { firstName = "Michael", lastName = "Jackson", Id = 9 });
            staff.Add(new Employee() { firstName = "Julia", lastName = "Roberts", Id = 10 });

           
            List<Employee> joes = new List<Employee>();
            foreach (Employee joe in staff)
            {

                if (joe.firstName == "Joe")
                {
                    joes.Add(joe);

                }

            }
            
            foreach (Employee newJoes in joes)
            {
                Console.WriteLine(newJoes.firstName + " " + newJoes.lastName + " " + newJoes.Id);
            }



            List<Employee> lamStaff = staff.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee lamJoe in lamStaff)
            {
                Console.WriteLine(lamJoe.firstName + " " + lamJoe.lastName + " " + lamJoe.Id);
            }


            List<Employee> greaterThan = staff.Where(x => x.Id > 5).ToList();
            foreach (Employee higher in greaterThan)
            {
                Console.WriteLine(higher.firstName + " " + higher.lastName + " " + higher.Id);
            }

            Console.ReadLine();
        }
    }
}
