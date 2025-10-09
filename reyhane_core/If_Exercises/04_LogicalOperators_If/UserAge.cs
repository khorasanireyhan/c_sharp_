namespace c_sharp.reyhane_core.If_Exercises._04_LogicalOperators_If;

public class UserAge
{
    //
    public static void AgeMetod()
    {
        Console.WriteLine("Entre your Age :");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age >= 18 && age <= 25 && age%2 == 0)
        {
            Console.WriteLine("special");
        }
    }
}