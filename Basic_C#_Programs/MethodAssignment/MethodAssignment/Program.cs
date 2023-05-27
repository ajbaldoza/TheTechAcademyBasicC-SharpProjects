using System;


namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations1 mathOp = new MathOperations1();
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            try
            {
                //call method with 2 parameter
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = mathOp.MathOperation(num1, num2));
                Console.WriteLine(num1 + " x " + num2 + " = " + results);
            }
            catch
            {
                //call method with one parameter
                int results = mathOp.MathOperation(num1);
                Console.WriteLine(num1 + "x Default 1 = " + results);
            }
            Console.ReadLine();


        }
        
        

    }

}