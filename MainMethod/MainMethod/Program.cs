using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Operator obj = new Operator();

            Console.WriteLine(obj.Math(2));
            Console.WriteLine(obj.Math(3.4m));
            Console.WriteLine(obj.Math("4"));

            Console.ReadLine();

        }
    }
}
