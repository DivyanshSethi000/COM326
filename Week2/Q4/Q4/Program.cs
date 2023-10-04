namespace Q4
{
    internal class Program
    {
        /*This method is a return double type division accepting 2 input arguments
        including an exception throw which stops the program from crashing.*/
        static double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
        /*This method is a return int type division accepting 2 input arguments
        including an exception throw which stops the program from crashing.*/
        static int Division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
        static void Main(string[] args)
        {
            try //starting the try block
            {
                Console.WriteLine("Input the numerator: ");//Input for numerator
                var a = Convert.ToDouble(Console.ReadLine());//Storing numerator in a variable using var type
                Console.WriteLine("Input the denominator: ");//Input for denominator
                var b = Convert.ToDouble(Console.ReadLine());//Storing denominator in a variable using var type
                var result = Division(a, b);//Calling the method and using var type so that it automatically uses the required method.
                Console.WriteLine($"Result: {result}");//Outputting the result
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Exception Caught: " + ex.Message);//Catching any exception and outputting a required message
            }
        }
    }
}