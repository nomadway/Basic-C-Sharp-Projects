﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee info = new Employee() { firstName = "Sample", lastName = "Student" };
            info.SayName();
        }
    }
}
