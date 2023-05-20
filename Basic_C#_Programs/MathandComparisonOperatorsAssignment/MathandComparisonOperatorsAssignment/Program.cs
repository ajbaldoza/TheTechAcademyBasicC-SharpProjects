using System;

namespace MathandComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hours1 = Console.ReadLine();
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52;
            Console.WriteLine("Annual Salary of Person 1:" +  salary1);
           
            Console.ReadLine();
        }
    }
}
