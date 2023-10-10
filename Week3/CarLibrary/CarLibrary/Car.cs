namespace CarLibrary
{
    public class Car
    {
        private string make;
        public string Make { get { return make; }  set { make = value; } }

        private string model;
        public string Model { get { return model; } set { model = value; } }    

        private int year;
        public int Year { get { return year; } set { year = value; } }

        private Engine engine;
        public Engine Engine { get { return engine; } set { engine = value; } }

        public Car()
        {
            make = string.Empty;
            model = string.Empty;
            year = 2004;
            engine = new Engine();
        }
        public Car(string make, string model, int year, Engine engine)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.engine = engine;
        }
        public void Drive()
        {
            engine.Start();
            Console.WriteLine("Driving Started");
        }
        public void Stop()
        {
            engine.Stop();
            Console.WriteLine("Driving Stopped");
        }
    }
}