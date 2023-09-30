namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Challenge 5
            /*A console app that uses a do-while loop to display a list of options to the user. 
             * The app must then read an integer option from the user and display the correct message based on the user’s chosen option. 
             * Once the user enters 0, you should display a “Goodbye” message and end the application.*/
            int option = 0;
            do
            {
                Console.WriteLine("Please enter an option from below:" +
                    "\n1.Hello in French?" +
                    "\n2.Hello in Spanish?" +
                    "\n3.Hello in German?" +
                    "\n4.Hello in Irish?" +
                    "\n0.Exit the application");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Goodbye!");
                        break;
                    case 1:
                        Console.WriteLine("Bonjour!");
                        break;
                    case 2:
                        Console.WriteLine("Hola!");
                        break;
                    case 3:
                        Console.WriteLine("Hallo!");
                        break;
                    case 4:
                        Console.WriteLine("Dia Dhuit!");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }
                Console.WriteLine();
            } while (option != 0);
        }
    }
}