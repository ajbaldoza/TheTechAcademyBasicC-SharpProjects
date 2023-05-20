using System;

namespace Math_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes an input from the user and multiplies it by 50
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            if (long.TryParse(input, out long number))
            {
                long result = number * 50;
                Console.WriteLine("Result of multiplication: " + result);
            }
        
            // Takes an input from the user and adds 25 to it
            Console.WriteLine("Enter another number:");
            input = Console.ReadLine();
            if (long.TryParse(input, out number))
            {
                long result = number + 25;
                Console.WriteLine("Result of addition: " + result);
            }
      

            // Takes an input from the user and divides it by 12.5
            Console.WriteLine("Enter another number:");
            input = Console.ReadLine();
            if (double.TryParse(input, out double doubleNumber))
            {
                double result = doubleNumber / 12.5;
                Console.WriteLine("Result of division: " + result);
            }
      

            // Takes an input from the user and checks if it is greater than 50
            Console.WriteLine("Enter another number:");
            input = Console.ReadLine();
            if (int.TryParse(input, out int intNumber))
            {
                bool isGreaterThan50 = intNumber > 50;
                Console.WriteLine("Is the number greater than 50? " + isGreaterThan50);
            }
          

            // Takes an input from the user and prints the remainder after dividing by 7
            Console.WriteLine("Enter another number:");
            input = Console.ReadLine();
            if (int.TryParse(input, out intNumber))
            {
                int remainder = intNumber % 7;
                Console.WriteLine("Remainder after division by 7: " + remainder);
            }
       

            Console.ReadLine();
        }
    }
}
