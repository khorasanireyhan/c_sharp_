namespace c_sharp.reyhane_core.If_Exercises._05_Switch_Statements;

public class GradeEvaluator
{
    /*Write a program that takes a letter (a, b, or c) as input and prints:
        a → good
        b → excellent
        c → acceptable
        otherwise → invalid input*/
    public static void Excellent()
    {
        Console.WriteLine("Enter a letter (a,b,c,)");
        char letter = Convert.ToChar(Console.ReadLine());
        switch (letter)
        {
            case 'a': Console.WriteLine("Good");
                break;
            case 'b': Console.WriteLine("Excellent");
                break;
            case 'c': Console.WriteLine("acceptable");
                break;
            default:Console.WriteLine("invalid input");
                break;
        }
    }
    

}