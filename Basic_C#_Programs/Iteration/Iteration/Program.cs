using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //int[] testscores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testscores.Length; i++)
        //{
        //    if (testscores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testscores[i]);
        //    }
        string[] names = { "AJ", "JC", "KK", "CC" };

        for (int j = 0; j < names.Length; j++)
        {
            if (names[j] == "AJ")
            {
                Console.WriteLine(names[j]);
            }

        }

        
        Console.ReadLine();
    }
}
