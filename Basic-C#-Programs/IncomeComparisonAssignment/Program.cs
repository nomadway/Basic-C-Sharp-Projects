using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK-1
            //Person 1
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person-1: ");
            Console.WriteLine("What is Person 1's rate per hour?");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many hours does Person-1 work per week?");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            //TASK-2
            //Person 2
            Console.WriteLine("Person-2: ");
            Console.WriteLine("What is Person 2's rate per hour?");
            int userInput3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many hours does Person-2 work per week?");
            int userInput4 = Convert.ToInt32(Console.ReadLine());

            //TASK-3
            Console.WriteLine("Annual income of Person-1 is: ");
            int income1 = userInput * userInput2 * 52;
            Console.WriteLine(income1);
            Console.WriteLine("Annual income of Person-2 is: ");
            int income2 = userInput3 * userInput4 * 52;
            Console.WriteLine(income2);

            //TASK-4
            //Boolean
            Console.WriteLine("Does Person-1 earn more than Person-2?");
            int person1 = income1;
            int person2 = income2;
            bool value = person1 > person2;
            Console.WriteLine(value);
            Console.ReadLine();



        }
    }
}
