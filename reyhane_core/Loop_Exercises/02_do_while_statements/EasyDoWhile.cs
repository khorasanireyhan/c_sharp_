namespace c_sharp.reyhane_core.Loop_Exercises._02_do_while_statements;

public class EasyDoWhile
{ 
    //Write a program that takes a number from the user and keeps asking for another number
    //until the number becomes negative.

    public static void DoWhile()
    {
        int number = 0;
        do
        {
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
        } while (number >= 0);
        Console.WriteLine("the loop is End");
    }
}