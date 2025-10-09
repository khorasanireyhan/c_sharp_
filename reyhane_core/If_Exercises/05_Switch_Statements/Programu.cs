namespace c_sharp.reyhane_core.If_Exercises._05_Switch_Statements;

public class Programu
{
    //Write a program that takes a number between 1 and 3 and prints:
    //one → 1, two → 2, or three → 3.

    public static void NumberToWord()
    { Console.WriteLine("Enter a number between 1 to 3");
        int number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1: Console.WriteLine("one");
                break;
            case 2: Console.WriteLine("two");
                break;
            case 3: Console.WriteLine("three");
                break;
            
            default:Console.WriteLine("the number is not between 1 and 3");
                break;
        }
        


    }
}