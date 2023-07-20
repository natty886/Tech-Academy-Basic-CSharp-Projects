using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    // 1a. Create a class called "Person"
    public class Person
    {
        // 1b. Two properties called "FirstName" and "LastName"
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // 2a. Void method called "SayName" that takes no parameters.
        public void SayName()
        {
            // 2b. Writes person's full name formatted "Name: [full name]"
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
