using System;

namespace c_sharp.reyhane_core.If_Exercises._04_LogicalOperators_If
{
    public class ProgramCondition
    {
        //Write a program that takes three numbers and checks: if at least one of them is negative or
        //the sum of the three numbers is greater than 100, print "Condition met".
        public static void Condition()
        {
            Console.WriteLine("Enter three numbers:");

            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number < 0 || number2 < 0 || number3 < 0 || (number + number2 + number3) > 100)
            {
                Console.WriteLine("Condition met");
            }
        }
    }
}