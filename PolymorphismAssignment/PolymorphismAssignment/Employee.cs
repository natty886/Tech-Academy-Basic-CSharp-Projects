using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // 2a. Inherit interface
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
           
        }
        // 2b. Implement Quit() method
        public void Quit()
        {
            Console.WriteLine("I quit this");
        }
    }
 
}
