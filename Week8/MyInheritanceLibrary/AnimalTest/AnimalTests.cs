using MyInheritanceLibrary;
namespace AnimalTest
{
    [TestClass]
    public class AnimalTests //animal test class
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var animal = new Animal(); //creating a new animal object
            //Act
            string speak = animal.Speak(); //storing the method call in a variable
            //Assert
            Assert.AreEqual("Hello!",speak); //asserting to check if they are equal
        }
    }
    [TestClass]
    public class DogTests
    {
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var dog = new Dog(); //creating a new dog object
            //Act
            string speak = dog.Speak(); //storing the method call in a variable
            //Assert
            Assert.AreEqual("Woof!",speak); //asserting to check if they are equal
        }
    }
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        public void TestMethod3() 
        {
            //Arrange
            var cat = new Cat(); //creating a new cat object
            //Act
            string speak = cat.Speak(); //storing the method call in a variable
            //Arrange
            Assert.AreEqual("Meow!", speak); //asserting to check if they are equal
        }
    }
    [TestClass]
    public class BirdTests
    {
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            var bird = new Bird(); //creating a new bird object
            //Act
            string speak = bird.Speak(); //storing the method call in a variable
            //Assert
            Assert.AreEqual("Chirp!", speak); //asserting to check if they are equal
        }
    }
}