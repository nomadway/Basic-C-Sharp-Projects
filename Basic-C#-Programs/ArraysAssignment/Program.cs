using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK-1
            
            string[] array1 = new string[] { "Good Monday!", "Enjoy Learning C#!", "I am trying to!" };

            Console.WriteLine("Type 0, 1 or 2 to display indexed text");
            string index = Console.ReadLine();
            int i = Convert.ToInt16(index);
            bool indexTrueOrFalse = i == 0 && i == 1 && i == 2;

            do
            {
                switch (i)
                {
                    case 3:
                        Console.WriteLine("Wrong index input! Try 0, 1 or 2.");
                        i = Convert.ToInt16(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Wrong index input! Try again.");
                        i = Convert.ToInt16(Console.ReadLine());
                        break;
                    case 0:
                        indexTrueOrFalse = true;
                        break;
                    case 1:
                        indexTrueOrFalse = true;
                        break;
                    case 2:
                        indexTrueOrFalse = true;
                        break;
                    default:
                        Console.WriteLine("Try another index.");
                        i = Convert.ToInt16(Console.ReadLine());
                        break;
                }
            }

            while (!indexTrueOrFalse);

            Console.WriteLine(array1[i]);
            Console.ReadLine();


            //TASK-2
            int[] array2 = new int[] { 100, 400, 10000 };

            Console.WriteLine("Select index 0, 1 or 2 to display indexed integer");
            string index1 = Console.ReadLine();
            int i1 = Convert.ToInt16(index1);
            bool indexTrueOrFalse1 = i1 == 0 && i1 == 1 && i1 == 2;

            do
            {
                switch (i1)
                {
                    case 3:
                        Console.WriteLine("Wrong index input! Try 0, 1 or 2.");
                        i1 = Convert.ToInt16(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Wrong index input! Try again.");
                        i1 = Convert.ToInt16(Console.ReadLine());
                        break;
                    case 0:
                        indexTrueOrFalse1 = true;
                        break;
                    case 1:
                        indexTrueOrFalse1 = true;
                        break;
                    case 2:
                        indexTrueOrFalse1 = true;
                        break;
                    default:
                        Console.WriteLine("Try another index.");
                        i1 = Convert.ToInt16(Console.ReadLine());
                        break;
                }
            }

            while (!indexTrueOrFalse1);

            Console.WriteLine(array2[i1]);
            Console.ReadLine();


            //TASK-3
            List<string> myList = new List<string>();
            myList.Add("Where do you live?");
            myList.Add("Do you like Python of C#?");
            myList.Add("Coding takes lots of practice to master!");

            Console.WriteLine("Select index 0, 1 or 2 to display message.");
            string index2 = Console.ReadLine();
            int i2 = Convert.ToInt16(index2);
            bool indexTrueOrFalse2 = i1 == 0 && i1 == 1 && i1 == 2;

            do
            {
                switch (i2)
                {
                    case 3:
                        Console.WriteLine("Wrong index input! Try 0, 1 or 2.");
                        i2 = Convert.ToInt16(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Wrong index input! Try again.");
                        i2 = Convert.ToInt16(Console.ReadLine());
                        break;
                    case 0:
                        indexTrueOrFalse2 = true;
                        break;
                    case 1:
                        indexTrueOrFalse2 = true;
                        break;
                    case 2:
                        indexTrueOrFalse2 = true;
                        break;
                    default:
                        Console.WriteLine("Try different index.");
                        i2 = Convert.ToInt16(Console.ReadLine());
                        break;
                }
            }

            while (!indexTrueOrFalse2);

            Console.WriteLine(myList[i2]);
            Console.ReadLine();





        }
    }
}
