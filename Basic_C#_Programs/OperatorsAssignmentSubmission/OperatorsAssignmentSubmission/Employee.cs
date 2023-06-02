using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignmentSubmission
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the "==" operator to compare Employee objects by their Id property
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // If both objects are null, or both Ids are equal, return true
            if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))
                return true;
            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
                return false;
            return employee1.Id == employee2.Id;
        }

        // Overloading the "!=" operator by using the previously overloaded "=="
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }
}
