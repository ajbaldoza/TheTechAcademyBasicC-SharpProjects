using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class MathOperations1
    {
        // Create a void method named PerformMathOperation that takes two integers as parameters
        public int MathOperation(int k, int j = 1)
        {
            // Perform a math operation 
            int result = k * j;
            return result;

        }
    }
}
