using System;

namespace c_sharp.reyhane_core.If_Exercises._01_If_Statements
{
    class Easy
    {
        // Write a program that prints "Positive" if the number entered by the user is positive.
        public static void CheckNumber()
        {       
            // The program takes numbers from the user.
            Console.WriteLine("Enter your number:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine("Positive");
            }
        }
    }
}