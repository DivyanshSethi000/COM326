using ShapeLibrary;
namespace ShapeTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void AreaMethod()
        {
            //Arrange
            var Circle = new Circle("","",1);
            //Act
            double area = Circle.Area();
            //Assert
            Assert.AreEqual(Math.PI, area);
        }
        [TestMethod]
        public void PerimeterMethod() 
        {
            //Arrange
            var Circle = new Circle("","",1);
            //Act
            double perimeter = Circle.Perimeter();
            //Assert
            Assert.AreEqual(2 * Math.PI, perimeter);
        }
    }
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void AreaMethod()
        {
            //Arrange
            var Rectangle = new Rectangle("", "", 1, 1);
            //Act
            double area = Rectangle.Area();
            //Assert
            Assert.AreEqual(1, area);
        }
        [TestMethod]
        public void PerimeterMethod()
        {
            //Arrange
            var Rectangle = new Rectangle("", "", 1, 1);
            //Act
            double perimeter = Rectangle.Perimeter();
            //Assert
            Assert.AreEqual(4, perimeter);
        }
    }
    [TestClass]
    public class IsoscelesTests
    {
        [TestMethod]
        public void AreaMethod()
        {
            //Arrange
            var Isosceles = new Isosceles("", "", 1, 3);
            //Act
            double area = Isosceles.Area();
            double roundedArea = Math.Round(area, 2);
            //Assert
            Assert.AreEqual(1.48, roundedArea);
        }
        [TestMethod]
        public void Perimeter()
        {
            //Arrange
            var Isosceles = new Isosceles("", "", 1, 3);
            //Act
            double perimeter = Isosceles.Perimeter();
            double roundedPerimeter = Math.Round(perimeter, 2);
            //Assert
            Assert.AreEqual(6.00, roundedPerimeter);
        }
    }
}