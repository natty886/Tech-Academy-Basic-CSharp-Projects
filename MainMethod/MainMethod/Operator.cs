using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public static class Operator
    {
        public static int Operator(int number)
        {
            return number + number;
        }

        public static int Operator(decimal number)
        {
            int number = Decimal.ToInt32();
            return number;
        }

        public static int Operator(string number)
        {
            int number = Int32.Parse(number);
            return number;
        }
    }
}
