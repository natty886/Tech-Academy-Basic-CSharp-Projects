using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a const variable.
            const string welcome = "Welcome!";
            Console.WriteLine(welcome);

            // 2. Create a variable using the keyword “var.”
            var askFirst = "What is your first name?";
            Console.WriteLine(askFirst);
            string inputFirst = Console.ReadLine();

            var askLast = "What is your last name?";
            Console.WriteLine(askLast);
            string inputLast = Console.ReadLine();

            // 3. Chain two constructors together.
            MyClass m1 = new MyClass(inputFirst, inputLast);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
