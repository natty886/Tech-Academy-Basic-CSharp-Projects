using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("What number would you like to do math operations on?");
            int number = Convert.ToInt32(Console.ReadLine());

            Math.Add(number);
            Math.Subtract(number);
            Math.Divide(number);

            Console.WriteLine(Math.Add(number));
            Console.WriteLine(Math.Subtract(number));
            Console.WriteLine(Math.Divide(number));
            Console.ReadLine();

            

        }
    }
}
