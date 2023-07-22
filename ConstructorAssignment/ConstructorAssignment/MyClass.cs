using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class MyClass
    {
        // 3. Chain two constructors together.
        public string firstName;
        public string lastName;

        public MyClass() : this("Joey", "Shabadoo")
        {
        }
        public MyClass(string firstName) : this(firstName, "Shabadoo")
        {
        }
        public MyClass(string firstName, string lastName) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        MyClass x = new MyClass(), y = new MyClass("Joey", "Jo-Jo");
    }
}
