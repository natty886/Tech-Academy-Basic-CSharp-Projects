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
            //Instantiate the class
            Class1 obj = new Class1();           

            //Input two numbers, one at a time.
            Console.WriteLine("Enter a number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("A second number (Not required)");
                int number2 = Convert.ToInt32(Console.ReadLine());
                //Call the method in the class, passing in the one or two numbers entered.
                Console.WriteLine(obj.Method1(number1, number2));
            }
            catch 
            {
                Console.WriteLine(obj.Method1(number1));
            }
            
            Console.ReadLine();
        }
    }
}
