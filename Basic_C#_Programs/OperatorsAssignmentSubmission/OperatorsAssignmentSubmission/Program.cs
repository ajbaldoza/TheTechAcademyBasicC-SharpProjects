using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects and assign values to their properties
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            Employee employee2 = new Employee
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Compare the two Employee objects using the overloaded operators
            bool areEqual = employee1 == employee2;
            bool areNotEqual = employee1 != employee2;

            // Display the results
            Console.WriteLine("Are the employees equal? " + areEqual);
            Console.WriteLine("Are the employees not equal? " + areNotEqual);

            Console.ReadLine();
        }
    }
}
