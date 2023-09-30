namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Challenge3
            /*console application that prints the uppercase and lowercase English alphabet and the corresponding 
             * ASCII value.*/
            for (int i = 65; i <= 90; i++)
            {
                Console.WriteLine($"{i}\t{(char)i}\t{(i + 32)}\t{(char)(i + 32)}"); // print all on one line
            }
        }
    }
}