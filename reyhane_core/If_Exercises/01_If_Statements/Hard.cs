namespace c_sharp.reyhane_core.If_Exercises._01_If_Statements;

public class Hard
{
    /*Write a program that checks the number entered by the user: if the number is between 1 and 50,
    print "Low"; if it is between 51 and 100, print "Medium"; and if it is greater than 100, print "High".*/

    public static void CheckProgram()
    {
        Console.WriteLine("Enter your number :");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x >= 1 && x <= 50) 
            Console.WriteLine("Low");
        if(x>=51&&x<=100)
            Console.WriteLine("Medium");
        if(x>100)  
            Console.WriteLine("High");
        

 
    }
}