using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main()
        {


            Console.WriteLine("With a capital letter write the day of week: ");
            string entry = Console.ReadLine();

            try
            {
                Console.WriteLine(Enum.Parse(typeof(WeekDays), entry));

            }
            catch (ArgumentException)
            {
                Console.WriteLine("With a capital letter enter the actual day of week: ");

            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
