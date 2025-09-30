using System;

public class MathOperations
{
    public static void PerformCalculations()
    {
        int num1, num2;
        string msg1, msg2; // این متغیرها استفاده نشده، ولی نگهش می‌دارم
        num1 = 5;
        num2 = 6;
        Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, (num1 + num2));
        Console.WriteLine("The difference of {0} and {1} is {2}", num1, num2, (num1 - num2));
        Console.WriteLine("The Product of {0} and {1} is {2}", num1, num2, (num1 * num2));
        Console.WriteLine("The remainder of {0} divided {1} is {2}", num1, num2, (num1 % num2));
    }
}