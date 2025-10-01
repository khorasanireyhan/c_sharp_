namespace c_sharp.reyhane_core.If_Exercises._03_NestedIf_Statements;

public class positive
{
    //Write a program that takes two numbers and checks:
    //if the first number is positive, whether the second number is also positive or not.

    public static void positiveMethod()
    {
      Console.WriteLine("Entere youre numbers");
      int number1 = Convert.ToInt32(Console.ReadLine());
      int number2 = Convert.ToInt32(Console.ReadLine());
      if (number1>0)
      {
          if (number2>0)
          {
              Console.WriteLine("number2 is positive");
          }
          Console.WriteLine("number1 is positive");
      }
    }
}