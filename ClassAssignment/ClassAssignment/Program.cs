using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Instantiate the class
            Class2 class2 = new Class2();

            // 3a. User enters a number
            Console.WriteLine("Enter a number");
            int output1 = Convert.ToInt32(Console.ReadLine());


            // 3b. Call the method on that number. 
            class2.Method1(output1);
            Console.ReadLine();

            // 5. Overload a method
            class2.Method3(10, 5);
            Class2.Method3(10, 5, 3);
            

 
            

        }
    }
}
