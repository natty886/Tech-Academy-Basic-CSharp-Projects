using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            // 2. Create a list of 10 employees. Two should be named “Joe”.
            List<string> FirstName = new List<string>() { "Anna", "Bo-Banna", "Banana", "Fana", "Fo-Fanna", "Fee-Fi", "Mo", "Manna", "Joe" , "Joe" };

            // 3. Use foreach loop, to create new list of "Joe"s (FYI refer property checked)
            List<string> joes = new List<string>();

            foreach (string name in FirstName)
            {
                if (name == "Joe")
                {
                    joes.Add(name);
                }
            }

            // 4. Same action but with lambda expression
            List<string> newList =  employee.FirstName.Where(n => n == "Joe").ToList();

            foreach (FirstName in newList)
            {
                Console.WriteLine(FirstName.n);
            }
            // 5. Use lambda to make list of all employees with Id greater than 5

            Console.ReadLine();
        }
    }
}
