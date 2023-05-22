using System;


namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean comparison using a while statement
            int counter = 0; // Initialize a counter variable to 0

            Console.WriteLine("While Loop Example:");
            while (counter < 5) // Execute the loop as long as the counter is less than 5
            {
                Console.WriteLine("Counter: " + counter);
                counter++; // Increment the counter by 1 in each iteration
            }

            Console.WriteLine("\n");

            // Boolean comparison using a do-while statement
            int number;

            Console.WriteLine("Do-While Loop Example:");
            do
            {
                Console.Write("Enter a positive number: ");
                string input = Console.ReadLine();
                number = int.Parse(input); // Read the input and convert it to an integer

            } while (number <= 0); // Repeat the loop as long as the number is less than or equal to 0

            Console.WriteLine("You entered: " + number);
        }
    }
}
