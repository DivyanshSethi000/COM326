﻿namespace Q1
{
    internal class Program
    {
        //Creating a Print Menu method for the menu to be printed for the user. This method is void and prints out the menu as it is.
        static void PrintMenu()
        {
            Console.WriteLine("Please enter an option from below:" +
                    "\n1.Hello in French?" +
                    "\n2.Hello in Spanish?" +
                    "\n3.Hello in German?" +
                    "\n4.Hello in Irish?" +
                    "\n0.Exit the application");
        }
        //Creating a Get Option method for reading and storing the option selected by the user after asking them to enter the option into the console.
        static int GetOption() 
        {
            Console.WriteLine("Input option:");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        //Creating a Get Message method which has a number arguement i.e. option from GetOption and uses that input in a switch code to return the required greeting to the console.
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
            //Creating and using a do while loop
            do
            {
                PrintMenu(); //Calling the print menu method
                option = GetOption(); //Calling the get option method and storing its value in a variable
                string greeting = GetMessage(option); //Calling the get message method and storing it in a variable
                Console.WriteLine(greeting); //Printing the greeting to the console.
            } while (option != 0);
           
        }
    }
}