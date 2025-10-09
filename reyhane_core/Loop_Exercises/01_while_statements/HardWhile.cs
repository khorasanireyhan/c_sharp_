namespace c_sharp.reyhane_core.Loop_Exercises._01_while_statements;

public class HardWhile
{
    //
    public static void While3()
    {
        Console.WriteLine("Enter a number:");
        int n = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        int i = 1;
        while (i <= n)
        {
            fact *= i;  // fact = fact * i
            i++;
        }

        Console.WriteLine("Factorial of " + n + " is: " + fact);
    }
}