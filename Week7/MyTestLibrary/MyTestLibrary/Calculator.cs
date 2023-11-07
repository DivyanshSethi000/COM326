namespace MyTestLibrary
{
    public class Calculator
    {
        public double Add(double a, double b) //Adds the two numbers 
        {
            return a + b; //returns the sum
        }
        public double Subtract(double a, double b) //Subtracts the two numbers 
        {
            return a - b; //returns the difference
        }
        public double Multiply(double a, double b) //Multiply the two numbers
        {
            return a * b; //returns the product
        }
        public double Divide(double a, double b) //Divide the two numbers
        {
            if (a == 0 || b == 0) //checking if the numerator or denominator are zero
            {
                throw new DivideByZeroException("Cannot divide by zero"); //throwing the exception back to the user
            }
            return a / b; //returns the result
        }
    }
}