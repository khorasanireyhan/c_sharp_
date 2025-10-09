namespace c_sharp.reyhane_core.Loop_Exercises._01_while_statements;

public class MediWhile
{
    // The program that takes a number n from the user and calculates the sum of numbers from 1 to n in

    public static void While2()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int x=1;
        while (x<=number)
        {
            sum += x;
            x++;
        }
        Console.WriteLine("sum is {0}", sum);
    }
}