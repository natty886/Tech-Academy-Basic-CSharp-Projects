using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Operator
    {
        public int Math(int number)
        {
            return number + number;
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
