using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge = 0;
            bool validAge = false;
            while (!validAge)
            {
                Console.WriteLine("Enter your age: ");
                try
                {
                    userAge = Convert.ToInt32(Console.ReadLine());
                    if (userAge == 0) throw new DivideByZeroException();
                    if (userAge < 0) throw new ArgumentOutOfRangeException();
                    validAge = true;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter your age with numbers: ");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Enter an age greater than 0: ");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Enter a positive age value: ");
                }
                catch (Exception)
                {
                    Console.WriteLine("Error!!! Enter a whole number.");
                }

            }
            var today = DateTime.Today;
            int yearOfBirth = 0;
            try
            {
                yearOfBirth = today.Year - userAge;
                if (yearOfBirth <= 0) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Your year of birth seems out of acceptable scope.You are either a vampire or a some kind of lunatic.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Is your birthday before todays date? Example: If you are born before January 1st, type Y/N: ");
            string beforeAfter = Console.ReadLine().ToLower();
            if (beforeAfter == "n") yearOfBirth--;
            Console.WriteLine("You were born in year: {0}", yearOfBirth);
            Console.ReadLine();
        }
    }
}
