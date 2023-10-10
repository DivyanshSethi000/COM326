namespace CarLibrary
{
    public class Engine
    {
        private int cylinders;
        public int Cylinders { get { return cylinders; } set { cylinders = value; } }

        private double horsepower;
        public double Horsepower { get {  return horsepower; } set {  horsepower = value; } }

        public Engine()
        {
            cylinders = 8;
            horsepower = 1000;
        }
        public Engine(int cylinders, double horsepower)
        {
            this.cylinders = cylinders;
            this.horsepower = horsepower;
        }
        public void Start() { Console.WriteLine("Engine Starting"); }
        public void Stop() { Console.WriteLine("Engine Stopping"); }
    }
}