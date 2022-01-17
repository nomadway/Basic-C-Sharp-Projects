using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assign-1
            string[] lunchMenu = { "Stake", "Dumbling", "Soup", "Burger" };
            Console.WriteLine("Please enter your preferred drink for lunch.");
            string customerDrink = Console.ReadLine();

            for (int i = 0; i < lunchMenu.Length; i++)
            {
                Console.WriteLine("Lunch combo is " + lunchMenu[i] + " and " + customerDrink);
            }
            Console.ReadLine();

            //Assign-2
            for (int j = 0; j - 1 < lunchMenu.Length; j++)
            {
                Console.WriteLine("This infinite loop works!");
            }
            Console.ReadLine();

            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine("The best combo menu is " + lunchMenu[k] + " and " + customerDrink);
            }
            Console.ReadLine();

            for (int l = 0; l <= 2; l++)
            {
                Console.WriteLine("Treat yourself with " + lunchMenu[l]);
            }
            Console.ReadLine();

            //Assign-3
            List<string> names = new List<string>() { "Lexus", "Bentley", "Toyota", "Honda" };
            Console.WriteLine("Select and type one of the following cars: Lexus, Bentley, Toyota, Honda");
            string name = Console.ReadLine();
            var m = 0;
            bool found = false;
            while (m < names.Count && found != true)
            {


                if (name == names[m])
                {
                    found = true;
                    Console.WriteLine("Your input " + name + " equales the value " + (string)names[m] + " at index " + (int)m);
                }
                m++;
            }
            if (found == false) Console.WriteLine("Your favourite car is not on the list. You have a terrible taste.");
            Console.ReadLine();

            //------------------------------------------------------
            List<string> names1 = new List<string>() { "Lexus", "Bentley", "Toyota", "Honda." };
            Console.WriteLine("Select and type one of the following cars: Lexus, Bentley, Toyota and Honda.");
            string name1 = Console.ReadLine();
            var n = 0;
            bool found1 = false;
            while (n < names1.Count)
            {
                if (name1 == names1[n])
                {
                    found1 = true;
                    Console.WriteLine("Your input " + name1 + " equales the value/values " + (string)names1[n] + " at index/indices " + (int)n);
                }
                n++;
            }
            if (found1 == false) Console.WriteLine("Your favourite cas is not on the list. You have a terribe taste.");
            Console.ReadLine();

            //---------------------------------
            List<string> spotIt = new List<string> { "Apple", "Grape", "Mango", "Lemon", "Apple" };
            Console.WriteLine("\n \n Select a pair of Fruit!\n");
            for (int show = 0; show < spotIt.Count; show++)
            {
                Console.WriteLine(spotIt[show]);
            }
            Console.WriteLine("[0], A pair of fruit!", name);
            string selectedOne = Console.ReadLine();
            foreach (string spotOne in spotIt)
            {
                if (spotOne == selectedOne)
                {
                    Console.WriteLine("[0] It is In", selectedOne);
                }
                else
                {
                    Console.WriteLine("[1] It is not In.", selectedOne);
                }
            }
            Console.ReadLine();












        }
    }
}
