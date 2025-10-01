using System;

namespace c_sharp;

public class EvenOdd
{
    /* Write a program that checks the number entered by the user and prints "Even" if it is even,
     and "Odd" if it is odd.*/
        
    public static void CheckEvenOdd()
    {
        Console.WriteLine("Enter your number:");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}