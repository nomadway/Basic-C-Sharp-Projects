using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Julia";
            Console.WriteLine(name);

            var newDict = new Dictionary<int, string>();

            ChainTwoConstructors newCon = new ChainTwoConstructors("Julia");
            Console.ReadLine();
        }
    }
}
