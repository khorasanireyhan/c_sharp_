namespace c_sharp.reyhane_core.Loop_Exercises._02_do_while_statements;

public class MediDoWhile
{
    /*Write a program that prints the numbers from 1 to 10, and after each number, print the sentence
    "This number is beautiful."*/

    public static void DoWhile2()
    {
        int i = 1;
        do
        {
            Console.WriteLine(i);
            Console.WriteLine("this number is Beautiful");
            i++;
        } 
        while (i <= 10);
        
        Console.WriteLine("The loop is End");
    }
}