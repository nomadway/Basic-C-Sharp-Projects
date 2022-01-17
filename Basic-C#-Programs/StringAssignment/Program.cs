using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK-1: Concatenate 3 strings
            string mars = "Concatenate";
            mars += " 3";
            mars += " strings.\n";
            Console.WriteLine(mars);

            //TASK-2: Convert String to Upper case
            string upperword = mars.ToUpper();
            Console.WriteLine(upperword);

            //TASK-3: Create a StringBuilder and build a paragraph of text, one sentence at a time.
            StringBuilder create = new StringBuilder();
            create.AppendLine("Python is an awesome language to learn. ");
            create.AppendLine("Let me show you how to use a String Builder.");
            create.AppendLine("Did you know you could append strings on the same line of code?").AppendLine("More examples to be followed.");
            Console.Write(create);

            Console.ReadLine();

        }
    }
}
