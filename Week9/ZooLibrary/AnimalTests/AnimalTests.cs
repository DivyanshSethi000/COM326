using ZooLibrary;
namespace AnimalTests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void DogSpeakMethod()
        {
            //Arrange
            var dog = new Dog();
            //Act
            string speak = dog.Speak();
            //Assert
            Assert.AreEqual("Woof", speak);
        }
        [TestMethod]
        public void CatSpeakMethod() 
        {
            //Arrange
            var cat = new Cat();
            //Act
            string speak = cat.Speak();
            //Assert
            Assert.AreEqual("Meow", speak);

        }
        [TestMethod]
        public void BirdSpeakMethod() 
        {
            //Arrange
            var bird = new Bird();
            //Act
            string speak = bird.Speak();
            //Assert
            Assert.AreEqual("Chirp", speak);
        }
    }
}