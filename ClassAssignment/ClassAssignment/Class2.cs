using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Class2
    {
        public void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine(result);
        }

        public void GetTwoNumbers(out int firstNumber, out int secondNumber)
        {
            firstNumber = 10;
            secondNumber = 20;
        }

        public void display()
        {
            Console.WriteLine("This is the default display method.");
        }

        public void display(int a)
        {
            Console.WriteLine("This is the display method with one integer parameter.");
        }

        public void display(string a, string b)
        {
            Console.WriteLine("This is the display method with two string parameters.");
        }
    }
}

