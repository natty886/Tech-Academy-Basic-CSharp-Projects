using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the class
            MyMethod obj = new MyMethod();
            //Call the method in the class, passing in two numbers.
            obj.AddTwoIntegers(2, 4);
            //Call the method in the class, specifying the parameters by name.
            obj.AddTwoIntegers(firstInteger: 1, secondInteger: 2);
        }
    }
}
