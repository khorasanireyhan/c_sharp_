namespace c_sharp.reyhane_core.If_Exercises._05_Switch_Statements;

public class DayProgram
{ 
    // Write a program that takes a number between 1 and 7 from the user and prints the name of the day of the week.
    public static void day()
    {
        Console.WriteLine("Enter your day");
        string day = Console.ReadLine();
        switch (day)
        {
            case "1":Console.WriteLine("saturday");
                break;
            case "2":Console.WriteLine("sunday");
                break;
            case "3":Console.WriteLine("monday");
                break;
            case "4":Console.WriteLine("tuesday");
                break;
            case "5":Console.WriteLine("wednesday");
                break;
            case "6":Console.WriteLine("thursday");
                break;
            case "7":Console.WriteLine("friday");
                break;
            default:Console.WriteLine("invalid day");
                break;
        }
    }
}