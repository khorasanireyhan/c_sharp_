using System;

namespace c_sharp.reyhane_core.If_Exercises._03_NestedIf_Statements
{
    public class max
    //Write a program that takes three numbers and displays the largest number.
    {
        public static void Maxi()
        {
            Console.WriteLine("Enter your numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            
            int Max = num1; 
            
            if (num2 > Max)
            {
                Max = num2; 
                if (num3 > Max) 
                {
                    Max = num3;
                }
            }
            if (num3 > Max) 
            {
                Max = num3;
            }
            
            Console.WriteLine("The maximum number is: " + Max);
        }
    }
}