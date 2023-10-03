namespace Q1
{
    internal class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("Please enter an option from below:" +
                    "\n1.Hello in French?" +
                    "\n2.Hello in Spanish?" +
                    "\n3.Hello in German?" +
                    "\n4.Hello in Irish?" +
                    "\n0.Exit the application");
        }
        static int GetOption() 
        {
            Console.WriteLine("Input option:");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        static string GetMessage(int n)
        {
            switch (n)
            {
                case 0:
                    return "Goodbye!";
                    break;
                case 1:
                    return "Bonjour!";
                    break;
                case 2:
                    return "Hola!";
                    break;
                case 3:
                    return "Hallo!";
                    break;
                case 4:
                    return "Dia Dhuit!";
                    break;
                default:
                    return "Please enter a valid option";
                    break;
            }
        }
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                PrintMenu();
                option = GetOption();
                string greeting = GetMessage(option);
                Console.WriteLine(greeting);
            } while (option != 0);
           
        }
    }
}