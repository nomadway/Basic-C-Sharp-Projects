using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int manyNumbers = Convert.ToInt32(Console.ReadLine());
                List<int> nums = new List<int>() { 200, 150, 100, 80, 40, 10 };
                foreach (int num in nums)
                {
                    {
                        int num2 = num / manyNumbers;
                        Console.WriteLine(num + " divided by " + manyNumbers + " equals " + num2);
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid Number!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Zero is not a valid number.");
            }
            Console.ReadLine();

        }
    }
}
