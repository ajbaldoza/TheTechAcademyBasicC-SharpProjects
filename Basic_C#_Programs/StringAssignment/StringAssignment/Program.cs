using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main()
        {
            // Concatenating three strings
            string string1 = "Hello";
            string string2 = " ";
            string string3 = "World";
            string result = string1 + string2 + string3; // Concatenate the three strings

            Console.WriteLine("Concatenated String: " + result);
            Console.WriteLine("\n");

            // Converting a string to uppercase
            string input = "hello world";
            string uppercase = input.ToUpper(); // Convert the string to uppercase

            Console.WriteLine("Uppercase String: " + uppercase);
            Console.WriteLine("\n");

            // Building a paragraph using StringBuilder
            StringBuilder paragraph = new StringBuilder(); // Create a StringBuilder object

            paragraph.Append("This is the first sentence. "); // Append the first sentence
            paragraph.Append("This is the second sentence. "); // Append the second sentence
            paragraph.Append("This is the third sentence. "); // Append the third sentence

            string paragraphText = paragraph.ToString(); // Convert the StringBuilder to a string

            Console.WriteLine("Paragraph Text:");
            Console.WriteLine(paragraphText);
        }
    }
}
