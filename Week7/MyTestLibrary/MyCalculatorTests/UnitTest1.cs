using MyTestLibrary;
namespace MyCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ReturnsCorrectResult() 
        {
            //Arrange
            var calculator = new Calculator(); //creating a new calc obj
            //values of the two numbers
            double a = 10;
            double b = 20;

            //Act
            double result = calculator.Add(a, b); //using the add method to get the sum 

            //Assert
            Assert.AreEqual(30, result); //checking to see if the result is same as the set result
        }
        [TestMethod]
        public void Subtract_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();//creating a new calc obj
            //values of the two numbers
            double a = 20;
            double b = 10;
            // Act
            double result = calculator.Subtract(a, b); //using the subtract method to get the diff
            // Assert
            Assert.AreEqual(10, result); //checking to see if the result is same as the set result
        }
        [TestMethod]
        public void Multiply_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();//creating a new calc obj
            //values of the two numbers
            double a = 10;
            double b = 5;
            // Act
            double result = calculator.Multiply(a, b); //using the multiply method to get the product
            // Assert
            Assert.AreEqual(50, result); //checking to see if the result is same as the set result
        }
        [TestMethod]
        public void Divide_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();//creating a new calc obj
            //values of the two numbers
            double a = 10;
            double b = 2;
            // Act
            double result = calculator.Divide(a, b); //using the divide method to get the result
            // Assert
            Assert.AreEqual(5, result); //checking to see if the result is same as the set result
        }
        [TestMethod]
        public void Divide_ReturnsCaughtException()
        {
            // Arrange
            var calculator = new Calculator();//creating a new calc obj
            //values of the two numbers
            double a = 10;
            double b = 0;
            // Act
            //using try and catch to handle exception
            try //trying to use the method on the numbers
            {
                double result = calculator.Divide(a, b); //using the divide method to get the result
            }
            catch (DivideByZeroException ex) //catching the division by zero exception
            {
                // Assert
                Assert.AreEqual("Cannot divide by zero", ex.Message); //checking to see if the exception thrown is same to the message.
            }
            
        }
    }
}