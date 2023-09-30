using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Challenge1
            /*console application that prints a message to the user asking for their name and age. 
             * After taking user input, display their name and how old they will be in 5 years.*/
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello {name}, you will be {age + 5} in 5 years.");
        }
    }
}