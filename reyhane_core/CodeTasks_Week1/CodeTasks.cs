namespace c_sharp.reyhane_core.CodeTasks_Week1;

public class CodeTasks
{
    //Write a program that takes three numbers from the input and displays the maximum of them.
    public static void Maximum()
    {
         Console.WriteLine("Enter first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter third number");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int Max = num1;
        if (num2 > Max)
        {
               Max = num2;
        }
        if (num3>Max)
        {
            Max = num3;
        }
        Console.WriteLine("Max is: " + Max );
    }
}