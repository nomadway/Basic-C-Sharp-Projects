using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    class ChainTwoConstructors
    {
        public ChainTwoConstructors(string name) : this(name, 30)
        {

        }
        public ChainTwoConstructors(string name, int age)
        {
            Name = name;
            Age = age;

        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
