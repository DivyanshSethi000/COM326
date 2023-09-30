namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Challenge2
            /*console application that takes in a user's age, and using if-else statements and conditional 
             * operators, determines whether they are a child, teenager or adult and displays the result to 
             * the console.*/
            Console.WriteLine("What is your age");
            int age = Convert.ToInt32(Console.ReadLine());
            //Check age with if-else statements
            if (age < 13)
            {
                Console.WriteLine("You are a child.");
            }
            else if (age < 19)
            {
                Console.WriteLine("You are a teen.");
            }
            else
            {
                Console.WriteLine("You are an adult.");
            }

            //Check age with switch 
            switch(age)
            {
                case < 13:
                    Console.WriteLine("You are a child.");
                    break;  
                case < 19:
                    Console.WriteLine("You are a teen.");
                    break;
                default:
                    Console.WriteLine("You are an adult.");
                    break;
            }
        }
    }
}