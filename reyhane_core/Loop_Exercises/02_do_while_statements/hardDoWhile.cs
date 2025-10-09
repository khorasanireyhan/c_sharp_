namespace c_sharp.reyhane_core.Loop_Exercises._02_do_while_statements;

public class hardDoWhile
{
    //Write a program that takes a number n from the user and prints the Fibonacci numbers up to n using a do…while loop.

    public static void DoWhile3()
    {
            Console.Write("Enter a number (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1, sum;

            do
            {
                Console.Write(a + " ");
                sum = a + b;
                a = b;
                b = sum;
            }
            while (a <= n);

            Console.WriteLine("The Fibonacci sequence has ended.");
    }
    
}