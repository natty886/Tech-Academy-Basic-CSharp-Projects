using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3a. Use polymorphism to create an object
            IQuittable iquittable = new Employee();
            Employee employee = new Employee();
            // 3b. Call the Quit() method
            employee.Quit();
        }
    }
}
