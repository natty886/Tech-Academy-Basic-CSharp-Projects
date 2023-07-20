using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        //1. Create an enum for the days of the week
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            // 2. Prompt the user to enter the current day of the week
            Console.WriteLine("Enter the current day of the week:");
            string currentDay = Console.ReadLine();

            // 4a. Wrap in try/catch block
            try
            {
                // 3. Assign value to a variable of the enum data type
                DaysOfTheWeek day;
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), currentDay);
            }
            // 4b. Print "Please enter an actual day of the week.” if error occurs
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
            


        }

    }
}
