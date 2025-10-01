namespace ReyhaneCore.IfExercises.NestedIfStatements
{
    public class GenderAndAge
    {
        /* Write a program that takes the user's gender and age, and prints:
         "Adult Man" if male and over 18
         "Adult Woman" if female and over 18
         "Minor" for all other cases */
        public static void GenderAge()
        {
            Console.WriteLine("Enter your gender (male/female): ");
            string gender = Console.ReadLine(); 
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine()); 
            if (gender == "male" && age >= 18)
            {
                Console.WriteLine("Adult Man");
            }
            else if (gender == "female" && age >= 18)
            {
                Console.WriteLine("Adult Woman");
            }
            else
            {
                Console.WriteLine("Minor");
            }
        }
    }
}