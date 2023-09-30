namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number greater than 1: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (i % 5 != 0))
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 3 != 0) && (i % 5 == 0))
                {
                    Console.WriteLine("Buzz");
                }
                else if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}