namespace c_sharp;

public  class Medium
{ 
    //Write a program that prints "Greater than 10" if the given number is greater than 10, otherwise it prints "10 or less".
    public static void GreaterNumber()
    {
        // The program takes a number from the user and executes it.
        Console.WriteLine("Enter your number:");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x > 10)
        {
            Console.WriteLine("Greater than 10");
        }
        if (x == 10) 
        {
            Console.WriteLine("Equal to 10");
        }
        if (x < 10)
        {
            Console.WriteLine("Less than 10");
        }
    }
}