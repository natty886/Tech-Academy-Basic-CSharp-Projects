using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class MyClass
    {

        public MyClass()
        {
            Console.WriteLine("Greetings!");
        }

        public MyClass(string firstName) : this()
        {
            Console.WriteLine("inputFirst");
        }

        public MyClass(string firstName, string lastName) : this()
        {
            Console.WriteLine("Nice to meet you, " + firstName + lastName);
        }
    }
}
