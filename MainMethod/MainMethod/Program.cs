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
            number = Operator.Operator(number: int, decimal, string);
            Console.WriteLine("What number would you like to do math operations on?");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(Operator.Operator(number));
            }
            Operator.Operator(number);
            Console.ReadLine();



           






        }
    }
}
