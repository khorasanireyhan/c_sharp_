namespace c_sharp.reyhane_core.If_Exercises._04_LogicalOperators_If;

public class positiveNum
{
    public static void Num()
    {
        Console.WriteLine("Enter your numbers");
        int num1 = Convert.ToInt32(Console.ReadLine());
         int num2 = Convert.ToInt32(Console.ReadLine());
         if (num1 > 0 && num2 > 0)
         {
             Console.WriteLine("positive number");
         }
    }
        
    }
   