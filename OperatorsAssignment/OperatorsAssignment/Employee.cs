using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    // 1a. Create "Employee" class 
    public class Employee
    {
        // 1b. Create "Id", "FirstName" and "LastName" properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // 2. Overload the "==" operator to check if two objects are equal by comparing Id
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
                return true;
            else
                return false;

        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
                return true;
            else
                return false;
        }



    }
}
