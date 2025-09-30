using System;

public class HealthCheck
{
    public static void CheckHealth()
    {
        Console.WriteLine("How many glasses of Water do you drink per day?");
        int water = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many glasses of Soda do you drink per day?");
        int soda = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many glasses of Tea do you drink per day?");
        int tea = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Can you tell me your weight?");
        int number_of_water = Convert.ToInt32(Console.ReadLine());

        int health_score = (5 * water) + (tea) - (3 * soda);
        if (health_score >= 15)
        {
            Console.WriteLine("100% healthy Choose.");
        }
        else if (health_score >= 5 && health_score < 15)
        {
            Console.WriteLine("50% healthy Choose, not bad...");
        }
        else if (health_score < 5)
        {
            Console.WriteLine("20% healthy Choose, try more!");
        }

        Console.WriteLine("Based on your weight: you should drink at least {0} glasses of water every day.", (number_of_water / 10));

        Console.ReadKey(); // اضافه کردن پرانتز برای متد
    }
}