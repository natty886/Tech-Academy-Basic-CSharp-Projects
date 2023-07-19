using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class MyMethod
    {
        public void AddTwoIntegers(int firstInteger, int secondInteger)
        {
            int sum = firstInteger + 4;
            int number = Convert.ToInt32(secondInteger);
            Console.WriteLine("The sum of the two integers is {0}", number);
        }
    }
}
