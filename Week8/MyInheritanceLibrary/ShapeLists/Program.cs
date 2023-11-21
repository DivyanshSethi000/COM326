using ShapeLibrary;
namespace ShapeLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>(); //initializing a new list using the shape class as its objects
            var Circle = new Circle("2DEarth","Blueish Green",17.0); //new object from circle class
            var Rectangle = new Rectangle("Chocos","Cocoa",15.0,7.0); //new object from rectangle class
            var Isosceles = new Isosceles("EquiSpace","Mystic Mauve",15.0,17.0); //new object from isosceles class
            //adding the new objects into the shapes list
            shapes.Add(Circle);
            shapes.Add(Rectangle);
            shapes.Add(Isosceles);

            foreach (var shape in shapes) //looping through the list for each object and calling the method for each object
            {
                //SHAPE'S AREA VALUE
                var shapeArea = shape.Area(); //storing the method call in a variable
                Console.WriteLine($"Area of {shape.Name}: {Math.Round(shapeArea,2)}"); //printing to the console the method's return value

                //SHAPE'S PERIMETER VALUE
                var shapePerimeter = shape.Perimeter(); //storing the method call in a variable
                Console.WriteLine($"Perimeter of {shape.Name}: {Math.Round(shapePerimeter,2)}"); //printing to the console the method's return value
            }
        }
    }
}