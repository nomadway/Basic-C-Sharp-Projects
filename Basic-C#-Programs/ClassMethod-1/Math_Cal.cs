using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod_1
{
    internal class Math_Cal
    {
        public int Sum(int num1)
        {
            var Total = num1 + 40;
            return Total;
        }
        public int Difference(decimal num1)
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
