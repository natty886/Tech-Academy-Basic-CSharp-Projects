using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //intList.Remove(10);

            //Console.WriteLine(intList[0]);
            //Console.ReadLine();

            //List<string> intList = new List<string>();
            //intList.Add("Hello");
            //intList.Add("Natty");
            //intList.Remove("Natty");

            //Console.WriteLine(intList[0]);
            //Console.ReadLine();
            Console.WriteLine("Console App Array Submission");

            int[] numArray = { 55, 22, 100 };
            Console.WriteLine("Integers: Please enter a number from 0 to 2.");
            int indexNum = Convert.ToInt32(Console.ReadLine());

            if (indexNum > 2)
            {
                Console.WriteLine("This index doesn't exist. ");
            }
            else
            {
                Console.WriteLine(numArray[indexNum]);
            }
            Console.ReadLine();


            string[] petArray = { "fish", "cat", "dog" };
            Console.WriteLine("Strings: Please enter a number from 0 to 2. ");
            int indexPet = Convert.ToInt32(Console.ReadLine());

            if (indexPet > 2)
            {
                Console.WriteLine("This index doesn't exist. ");
            }
            else
            {
                Console.WriteLine(petArray[indexPet]);
            }
            Console.ReadLine();
        }
    }
}
