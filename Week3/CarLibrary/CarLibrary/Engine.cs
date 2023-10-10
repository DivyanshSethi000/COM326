namespace CarLibrary
{
    public class Engine
    {
        private int cylinders; //creating a field of int type 
        public int Cylinders { get { return cylinders; } set { cylinders = value; } } //creating a property for the above field

        private double horsepower; //creating a field of double type 
        public double Horsepower { get {  return horsepower; } set {  horsepower = value; } } //creating a property for the above field

        public Engine() //creating the default constructor
        {
            cylinders = 8;
            horsepower = 1000;
        }
        public Engine(int cylinders, double horsepower) //creating the custom constructor with parameters
        {
            this.cylinders = cylinders;
            this.horsepower = horsepower;
        }
        public void Start() { Console.WriteLine("Engine Starting"); } //creating method for starting the engine
        public void Stop() { Console.WriteLine("Engine Stopping"); } //creating method for stopping the engine
    }
}