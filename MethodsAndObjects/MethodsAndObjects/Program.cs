using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Instantiate and initialize an Employee object with first/last name "Sample Student"
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            // 5. Call superclass method "SayName()" on Employee object.
            employee.SayName();
            
        }
    }
}
