namespace Q4
{
    internal class Program
    {
        static double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input the numerator: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the denominator: ");
                double b = Convert.ToDouble(Console.ReadLine());
                double result = Division(a, b);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Exception Caught: " + ex.Message);
            }
        }
    }
}