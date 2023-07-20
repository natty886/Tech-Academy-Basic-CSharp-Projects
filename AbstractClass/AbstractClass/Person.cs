using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // 1a. Create an abstract class called "Person"
    public abstract class Person
    {
        // 1b. Two properties: "string firstName" and "string lastName"
        public string firstName { get; set; }
        public string lastName { get; set; }

        // 2. Add method "SayName()"
        public abstract void SayName();

    }
}
