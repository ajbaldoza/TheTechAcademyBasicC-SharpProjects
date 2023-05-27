using System;

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

class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations mathObj = new MathOperations();

        // Call the PerformMathOperation method in the class, passing in two numbers (5 and 10)
        mathObj.PerformMathOperation(5, 10);

        // Call the PerformMathOperation method in the class, specifying the parameters by name
        mathObj.PerformMathOperation(firstNumber: 3, secondNumber: 7);
    }

}
