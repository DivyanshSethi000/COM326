using ZooLibrary;

namespace ZooTests
{
    [TestClass]
    public class ZooTests
    {
        [TestMethod]
        public void TestAnimalToString()
        {
            //Arrange
            Animal cat = new Cat();
            //Act
            string result = cat.ToString();
            string expected = $"Name: , Birthday: {DateTime.Now}, Number of Legs: 0";
            //Assert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void TestEmployeeToString()
        {
            //Arrange
            Employee emp = new Employee();
            //Act
            string result = emp.ToString();
            string expected = $"ID: 1, Name: , Salary: 0";
            //Assert
            Assert.AreEqual(expected,result);
        }
        [TestMethod]
        public void TestCageToString() 
        {
            //Arrange
            Cage cage = new Cage();
            //Act
            string result = cage.ToString();
            string expected = $"ID: 1, Capacity: 0\nDoor:\tWidth: 0\tHeight: 0\tMaterial: unknown\nFoodBucket:\tCapacity: 0\tMaterial: unknown";
            //Assert
            Assert.AreEqual(expected,result);

        }
        [TestMethod]
        public void TestDoorToString() 
        {
            //Arrange
            Door door = new Door();
            //Act
            string result = door.ToString();
            string expected = $"Width: 0, Height: 0, Door Material: unknown";
            //Assert
            Assert.AreEqual(expected,result);
        }
        [TestMethod]
        public void TestFoodBucketToString()
        {
            //Arrange
            FoodBucket foodBucket = new FoodBucket();
            //Act
            string result = foodBucket.ToString();
            string expected = $"Capacity: 0, Material: unknown";
            //Assert
            Assert.AreEqual(expected,result);
        }
    }
}