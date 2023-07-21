using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 1. Prints the current date and time to the console
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("The current time is: " + currentDateTime);
            Console.ReadLine();

            // 2. Asks the user for a number
            Console.WriteLine("Please enter a number: ");
            int hoursToAdd = Convert.ToInt32(Console.ReadLine());

            // 3. Prints exact time it will be in X hours, X = number the user entered in step 2
            DateTime futureTime = currentDateTime.AddHours(hoursToAdd);
            Console.WriteLine("It will be {0} in {1} hours.", futureTime.ToString("h:mm tt"), hoursToAdd);

            Console.ReadLine();
        }
    }
}
