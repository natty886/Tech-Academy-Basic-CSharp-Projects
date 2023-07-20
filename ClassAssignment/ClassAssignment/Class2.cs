using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    // 1a. Create Class.
    public class Class2
    {
        // 1b. Create a void method that outputs an integer
        public void Method1(int output1)
        {
            // 1c. Divide data by 2
            int result = output1 / 2;
            // 3c. Display output
            Console.WriteLine(output1 + " divided by 2 is: " + result);

        }
        // 4. Create a method with output parameters
        public void Method2(out int parameter1, out int parameter2)
        {
            parameter1 = 100;
            parameter2 = 500;
        }
        // 5. Overload a method
        public void Method3(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        // 6. Declare a class to be static
        public static void Method3(int num1, int num2, int num3)
        {
            Console.WriteLine(num1 * num2 * num3);
        }

    }
}

