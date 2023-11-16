namespace ShapeLibrary
{
    public abstract class Shape
    {
        public abstract string Name { get; set; }
        public abstract string Color { get; set; }

        public Shape() { }

        public Shape(string name, string color)
        {
        }
    }
}