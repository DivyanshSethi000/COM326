using System.Runtime.CompilerServices;

namespace Q3
{
    internal class Program
    {
        //This method calculates the area of a circle with a input arg of radius and returns the area in a double type.
        static double CircleArea(double radius)
        {
            double area = Math.Pow(radius, radius) * Math.PI;
            return area;
        }
        //This method calculates the volume of a cylinder with two input args of radius and height and returns the volume in a double type. .
        static double CylinderVolume(double radius, double height)
        {
            double vol = height * Math.Pow(radius, radius) * Math.PI;
            return Math.Round(vol);
        }
        //This method prints the menu and gives the options to the user on the console and is a void type.
        static void PrintMenu()
        {
            Console.WriteLine("Select one calculation:" +
                "\n1.Area of circle" +
                "\n2.Volume of Cylinder" +
                "\n0.Exit application");
        }
        //This method gets a user input of the option selected and returns the input.
        static int GetOption()
        {
            Console.WriteLine("Input option:");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        //This method uses the option's number value as the input and outputs the values according to the option selected by the user.
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
            int option = 0;//initializing the option variable
            do
            {
                PrintMenu();//Calling the print menu method
                option = GetOption();//Calling the get option method and storing it into a variable
                GetValue(option);//Calling the get value method and using the variable.
            } while (option != 0);
        }
    }
}