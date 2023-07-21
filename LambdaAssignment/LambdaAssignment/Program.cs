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
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 0, FirstName = "Joe", LastName = "Schmoe"},
                new Employee() { Id = 1, FirstName = "Anna", LastName = "Banna" },
                new Employee() { Id = 2, FirstName = "Bo", LastName = "Banna" },
                new Employee() { Id = 3, FirstName = "Ban", LastName = "Anana" },
                new Employee() { Id = 4, FirstName = "Fan", LastName = "Nah" },
                new Employee() { Id = 5, FirstName = "Fo", LastName = "Fanna" },
                new Employee() { Id = 6, FirstName = "Fee", LastName = "Fai" },
                new Employee() { Id = 7, FirstName = "Mo", LastName = "Manna" },
                new Employee() { Id = 8, FirstName = "Joey Jo-Jo Jr", LastName = "Schabadoo" },
                new Employee() { Id = 9, FirstName = "Joe", LastName = "Dirt" }
            };


            // 3. Use foreach loop, to create new list of "Joe"s (FYI refer property checked)
            List<Employee> joes = new List<Employee>();

            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    joes.Add(emp);
                }
            }


            // 4. Same action but with lambda expression
            List<Employee> newList =  employees.Where(n => n.FirstName == "Joe").ToList();

            foreach (Employee emp in newList)
            {
                Console.WriteLine(emp.FirstName);
            }


            // 5. Use lambda to make list of all employees with Id greater than 5
            List<Employee> idsList = new List<Employee>();

            foreach (Employee id in idsList)
            {
                if (id.Id > 5)
                {
                    idsList.Add(id);
                }
            }
            Console.ReadLine();
        }
    }
}
