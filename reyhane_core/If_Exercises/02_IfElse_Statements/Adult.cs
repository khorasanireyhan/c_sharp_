using System;
namespace c_sharp
{
    public class Adult
    {
        /* Write a program that takes the user's age and determines:
        "Child" if under 13
        "Teenager" if between 13 and 19
        "Adult" if between 20 and 59
        "Elderly" if 60 or older */

        public static void AdultAge()
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age <= 19)  
            {
                Console.WriteLine("Teenager");
            }
            else if (age >= 20 && age <= 59)
            {
                Console.WriteLine("Adult");
            }
            else if (age >= 60)
            {
                Console.WriteLine("Elderly");
            }
        }
    }
}