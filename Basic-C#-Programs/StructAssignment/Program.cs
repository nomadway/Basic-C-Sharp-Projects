﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number()
            {
                Amount = new decimal()
            };
            number.Amount = 10.3m;

            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
