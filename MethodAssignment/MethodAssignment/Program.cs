using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();           

            Console.WriteLine("Enter a number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A second number (Not required)");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(obj.Method1(number1, number2));
            Console.WriteLine(obj.Method2(number1, number2));
            Console.ReadLine();
        }
    }
}
