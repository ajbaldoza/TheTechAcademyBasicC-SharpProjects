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
            // Use polymorphism to create an object of type IQuittable
            IQuittable quittableEmployee = new Employee();
            //Call the Quit() method on the object
            quittableEmployee.Quittable();

            Employee sam = new Employee() { firstName = "Sample", lastName = "Student" };
            sam.Sayname();
            Console.ReadLine();
        }
    }
}
