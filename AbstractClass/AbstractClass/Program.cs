using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5a. Instantiate an Employee object with firstName “Sample” and lastName “Student”. 
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            // 5b. Call "SayName()" method on object
            employee.SayName();

        }
    }
}
