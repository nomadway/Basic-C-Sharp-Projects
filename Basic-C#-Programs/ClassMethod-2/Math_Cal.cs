using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod_2
{
    class Math_Cal
    {
        public int Sum(int num1, int optionalint = 5)
        {
            var Total = num1 + 50 + optionalint;
            return Total;
        }
    }
}
