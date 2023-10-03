namespace Q3
{
    internal class Program
    {
        static double CircleArea(double radius)
        {
            double area = Math.Pow(radius, radius) * Math.PI;
            return area;
        }
        static double CylinderVolume(double radius, double height)
        {
            double vol = height * Math.Pow(radius, radius) * Math.PI;
            return Math.Round(vol);
        }
        static void PrintMenu()
        {
            Console.WriteLine("Select one calculation:" +
                "\n1.Area of circle" +
                "\n2.Volume of Cylinder" +
                "\n0.Exit application");
        }
        static int GetOption()
        {
            Console.WriteLine("Input option:");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        static void GetValue(int n)
        {
            switch (n)
            {
                case 0:
                    Console.WriteLine("Goodbye!");
                    break;
                case 1:
                    Console.WriteLine("Enter the radius of your circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double area = CircleArea(radius);
                    Console.WriteLine($"The area is {area}");
                    break;
                case 2:
                    Console.WriteLine("Enter the radius of your cylinder: ");
                    radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the height of your cylinder: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    double vol = CylinderVolume(radius, height);
                    Console.WriteLine($"The volume is {vol}");
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }

        }
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                PrintMenu();
                option = GetOption();
                GetValue(option);
            } while (option != 0);
        }
    }
}