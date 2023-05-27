using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    // Create a class named MathOperations
    class MathOperations
    {
        // Create a void method named PerformMathOperation that takes two integers as parameters
        public void PerformMathOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer (e.g., multiply by 2)
            int result = firstNumber * 2;

            // Display the second integer to the screen
            Console.WriteLine("Second Number: " + secondNumber);
        }
    }

}
