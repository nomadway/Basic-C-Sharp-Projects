using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod1
{
    class MathOperation
    {
        public int Sum (int num1)
        {
            var Total = num1 + 40;
            return Total;
        }
        public int Difference (decimal num1)
        {
            var Total = num1 - 30;
            return Convert.ToInt32(Total);
        }
        public int Product(string num1)
        {
            var Total = Convert.ToInt32(num1) * 20;
            return Total;
        }
    }
}