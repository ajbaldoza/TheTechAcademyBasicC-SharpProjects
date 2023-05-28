using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    //Modify the Employee class to inherit the IQuittable interface
    public class Employee : Person, IQuittable
    {
        public override void Sayname()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        //Implement the Quit() method from the IQuittable interface
        public void Quittable()
        {
            throw new NotImplementedException();
        }
    }
}
