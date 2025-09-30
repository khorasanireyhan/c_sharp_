using System;

class DoWhileLoop
{
    public static void DoWhileLoopMethod()
    {
        int number;
        do
        {
            Console.Write("Enter a value bigger than 0: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("You must Input a value bigger than 0!!!");
            }
        } while (number <= 0); // شرط رو درست کردیم که تا وقتی عدد <= 0 باشه، ادامه بده

        Console.WriteLine("Yesss, That's the right value!"); // پیام موفقیت بعد از حلقه
    }
}