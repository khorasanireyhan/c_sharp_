using System;

public class GuessGame
{
    public static void PlayGuessGame()
    {
        Console.WriteLine("Choose your Challenge: Enter (0) for Easy, or (1) for Hard.");
        Random rnd = new Random();
        int choice = Convert.ToInt32(Console.ReadLine());
        int secretNumber = 0;

        if (choice == 0)
        {
            // easy level
            secretNumber = rnd.Next(1, 51); // creates a number between 1 and 50
        }
        else if (choice == 1)
        {
            // hard level
            secretNumber = rnd.Next(1, 101); // creates a number between 1 and 100
        }
        else
        {
            Console.WriteLine("Invalid choice.\nPlease enter 0 or 1.");
            return; // خروج از متد اگه انتخاب اشتباه باشه
        }

        int guess;
        int attempts = 0;
        while (true)
        {
            Console.WriteLine("Enter your guess:");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < secretNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the number in {0} attempts.", attempts);
                break; // خروج از حلقه وقتی حدس درست باشه
            }
        }

        Console.ReadKey(); // برای نگه داشتن پنجره باز
    }
}