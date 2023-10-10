namespace CarLibrary
{
    public class Car
    {
        private string make; //creating a string type field
        public string Make { get { return make; }  set { make = value; } } //creating a property for above field

        private string model; //creating a string type field
        public string Model { get { return model; } set { model = value; } } //creating a property for above field

        private int year; //creating a int type field
        public int Year { get { return year; } set { year = value; } } //creating a property for above field

        private Engine engine; //creating a Engine type field
        public Engine Engine { get { return engine; } set { engine = value; } } //creating the property for the above field

        public Car() //creating the default constructor
        {
            make = string.Empty;
            model = string.Empty;
            year = 2004;
            engine = new Engine();
        }
        public Car(string make, string model, int year, Engine engine) //creating the custom constructor with its parameters
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.engine = engine;
        }
        public void Drive() //creating a void method which uses the engine class to start the engine and print that the car is in drive mode. 
        {
            engine.Start();
            Console.WriteLine("Driving Started");
        }
        public void Stop() //creating a void method which uses the engine class to stop the engine and print that the car is in neutral mode.
        {
            engine.Stop();
            Console.WriteLine("Driving Stopped");
        }
    }
}