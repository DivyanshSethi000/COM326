namespace ShapeLibrary
{
    public abstract class Shape
    {
        private string name;
        private string color;
        public  string Name 
        {
            get { return name; }
            set { name = value; } 
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Shape() 
        {
            Name = "Undefined";
            Color = "Unknown";
        }

        public Shape(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public abstract double Perimeter();
        public abstract double Area();
    }
    public class Circle : Shape
    {
        private double radius;
        public double Radius 
        {
            get { return radius; }
            set { radius = value; } 
        }

        public Circle() : base() 
        {
            Radius = 0.0;
        }

        public Circle(string name, string color, double radius) : base(name, color)
        {
            this.radius = radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public Rectangle() : base() 
        {
            Length = 0.0;
            Width = 0.0;
        }

        public Rectangle(string name, string color, double length, double width) : base(name, color)
        {
            this.length = length;
            this.width = width;
        }

        public override double Perimeter()
        {
            return 2 * (length + width);
        }

        public override double Area()
        {
            return length * width;
        }
    }

    public abstract class Triangle : Shape
    {
        private double baseLength;
        private double height;

        public double BaseLength
        {
            get { return baseLength; }
            set { baseLength = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Triangle() : base() 
        {
            BaseLength = 0.0;
            Height = 0.0;
        }

        public Triangle(string name, string color, double baseLength, double height) : base(name, color) 
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override double Area()
        {
            return 0.5 * baseLength * height;
        }
    }
    public class Isosceles : Triangle
    {
        private double sideLength;
        public double SideLength
        {
            get { return sideLength; }
            set { sideLength = value; }
        }

        public Isosceles() : base() 
        {
            SideLength = 0.0;
        }

        public Isosceles(string name, string color, double baseLength, double sideLength) : base(name, color, baseLength,0)
        {
            this.sideLength = sideLength;
        }

        public override double Area()
        {
            return (0.5 * (Math.Sqrt(Math.Pow(SideLength, 2) - Math.Pow(BaseLength, 2) / 4) * BaseLength));
        }

        public override double Perimeter()
        {
            return BaseLength * (2 * SideLength);
        }
    }
}