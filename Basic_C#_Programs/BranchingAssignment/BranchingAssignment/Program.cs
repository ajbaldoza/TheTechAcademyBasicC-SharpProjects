using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.Write("Please enter the weight of the package in pounds: ");
            decimal weight = decimal.Parse(Console.ReadLine());

          
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return; // Exit the program
            }

            Console.Write("Please enter the width of the package in inches: ");
            decimal packagewidth = decimal.Parse(Console.ReadLine());

            Console.Write("Please enter the height of the package in inches: ");
            decimal packageheight = decimal.Parse(Console.ReadLine());

            Console.Write("Please enter the length of the package in inches: ");
            decimal packagelength = decimal.Parse(Console.ReadLine());


            decimal totaldimension = packageheight + packagelength + packagewidth;

            if (totaldimension > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return; // Exit the program
            }

            decimal totalvolume = packagewidth * packageheight * packagelength;


            decimal quote = totalvolume * weight;

            decimal finalQuote = quote / 100;

            Console.WriteLine("Your estimated total for shipping this package is:" + finalQuote.ToString("$0.00"));
            Console.WriteLine("Thank you!");
            Console.ReadLine();



        }
    }
}
