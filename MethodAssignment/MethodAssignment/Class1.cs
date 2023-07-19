using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Class1
    {
        public int Math(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Math(decimal number)
        {
            int result = Convert.ToInt32(number) + 2;
            return result;
        }

        public int Math(string number)
        {
            int result = Convert.ToInt32(number);
            return result;
        }
    }
}
