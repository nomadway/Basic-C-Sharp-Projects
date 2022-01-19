using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOAssignment
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            string entry = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Administrator\Documents\GitHub\Basic-C-Sharp-Projects\Basic-C#-Programs\module7.txt", entry);
            Console.WriteLine(File.ReadAllText(@"C:\Users\Administrator\Documents\GitHub\Basic-C-Sharp-Projects\Basic-C#-Programs\module7.txt"));
            Console.ReadLine();
        }
    }
}
