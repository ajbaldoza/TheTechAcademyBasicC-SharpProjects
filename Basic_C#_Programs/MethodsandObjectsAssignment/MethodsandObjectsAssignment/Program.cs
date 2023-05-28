using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sam = new Employee() { FirstName = " Sample ", LastName = " Student " };
            sam.SayName();
            Console.ReadLine();
        }
    }
}
