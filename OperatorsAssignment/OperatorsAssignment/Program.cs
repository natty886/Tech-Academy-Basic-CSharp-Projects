using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3a. Instantiate two objects from Employee class and assign values
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.FirstName = "John";
            employee1.LastName = "Jingleheimer";
            employee1.Id = 72023;

            employee2.FirstName = "Jacob";
            employee2.LastName = "Smith";
            employee2.Id = 81620;

            // 3b. Compare the objects using overload operator and display results
            Console.WriteLine(employee1.Id == employee2.Id);
            Console.ReadLine();



    }
    }
}
