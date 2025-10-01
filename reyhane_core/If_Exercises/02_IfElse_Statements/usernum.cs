namespace c_sharp;

public class usernum
{
    //Write a program that prints "Pass"if the user's score is greater than or equal to 50, and "Fail" otherwise.
    public static void UserNumber()
    {
        Console.WriteLine("Enter your number:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number >=50)
            Console.WriteLine("Pass");
        else
        {
            Console.WriteLine("Fail");
        }
    }
}