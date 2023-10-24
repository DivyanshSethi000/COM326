using CarLibrary; //using the library we coded

namespace CarTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(4 , 210); //instantiating a new engine object using the class Engine and setting its two parameters
            Car car = new Car("Ford", "Fiesta", 2016, engine); //instantiating a new car object using the class Car and setting its parameters

            car.Drive();//calling the drive method in the class Car on the car object
            car.Stop();//calling the stop method in the class Car on the car object
            
            Car car2 = new Car("Koenigsegg", "Gemera", 2023, 3, 1400); //instantiating a new car object using the class Car and setting its parameters

            car2.Drive();//calling the drive method in the class Car on the car object
            car2.Stop();//calling the stop method in the class Car on the car object
        }
    }
}
