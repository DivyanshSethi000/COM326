namespace ZooLibrary
{
    public class Zoo
    {
        private List<Animal> animals;  //  aggregation
        public List<Animal> Animals
        {
            get { return animals; }
            set { animals = value; }
        }
        private List<Employee> employees;  //  aggregation
        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        private List<Cage> cages;  //  aggregation
        public List<Cage> Cages
        {
            get { return cages; }
            set { cages = value; }
        }
        public Zoo()  // default constructor
        {
            animals = new List<Animal>();
            employees = new List<Employee>();
            cages = new List<Cage>();
        }
        public Zoo(List<Animal> animals, List<Employee> employees, List<Cage> cages)  // custom constructor
        {
            this.animals = animals;
            this.employees = employees;
            this.cages = cages;
        }

        public void PrintAll()
        {
            Console.WriteLine("Animals: \n");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString() + "\n");
            }
            Console.WriteLine("Employees: \n");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString() + "\n");
            }
            Console.WriteLine("Cages: \n");
            foreach (Cage cage in cages)
            {
                Console.WriteLine(cage.ToString() + "\n");
            }
        }
    }
    public abstract class Animal
    {
        private string name;
        private int noOfLegs;
        private DateTime birthday;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int NoOfLegs
        {
            get { return noOfLegs; }
            set { noOfLegs = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public Animal()
        {
            Name = string.Empty;
            NoOfLegs = 0;
            Birthday = DateTime.Now;
        }

        public Animal(string name, DateTime birthday, int noOfLegs)
        {
            this.name = name;
            this.noOfLegs = noOfLegs;
            this.birthday = birthday;
        }

        public abstract void Eat(double foodAmount);
        public abstract string Speak();

        public override string ToString()
        {
            return $"Name: {name}, Birthday: {birthday}, Number of Legs: {noOfLegs}";
        }
    }

    public class Dog : Animal
    {
        private string breed;
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public Dog() : base() 
        {
            Breed = string.Empty;
        }
        public Dog(string name,DateTime birthday, int noOfLegs, string breed) : base(name,birthday, noOfLegs)
        {
            this.breed = breed;
        }

        public override void Eat(double foodAmount) { }

        public override string Speak() 
        {
            return "Woof";
        }
        public  string Speak(string message)  
        {
            return message;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Birthday: {Birthday}, Number of Legs: {NoOfLegs}, Breed: {Breed}";
        }
    }

    public class Cat : Animal
    {
        public Cat() : base() { }
        public Cat(string name, DateTime birthday, int noOfLegs) : base(name, birthday, noOfLegs) { }

        public override void Eat(double foodAmount) { }

        public override string Speak()
        {
            return "Meow";
        }
        public override string ToString()
        {
            return $"Name: {Name}, Birthday: {Birthday}, Number of Legs: {NoOfLegs}";
        }
    }

    public class Bird : Animal
    {
        private double wingspan;
        public double Wingspan
        {
            get { return wingspan; }
            set { wingspan = value; }
        }
        public Bird() : base() 
        {
            Wingspan = 0.0;
        }
        public Bird(string name, DateTime birthday, int noOfLegs, double wingspan) : base(name, birthday, noOfLegs) 
        {
            this.wingspan = wingspan;
        }

        public override void Eat(double foodAmount) { }

        public override string Speak()
        {
            return "Chirp";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Birthday: {Birthday}, Number of Legs: {NoOfLegs}, Wingspan: {wingspan}";
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
    public class Employee
    {
        private string name;
        private int id;
        private double salary;
        private static int noOfEmployees = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee()
        {
            Name = string.Empty;
            id = ++noOfEmployees;
            Salary = 0.0;
        }

        public Employee(string name, double salary)
        {
            this.name = name;
            id = ++noOfEmployees;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Salary: {salary}";
        }
    }

    public class Cage
    {
        private int id;
        private int cageCapacity;
        private static int noOfCages = 0;
        private Door door;
        private FoodBucket foodBucket;

        public int Id
        {
            get { return id; }
        }
        public int CageCapacity
        {
            get { return cageCapacity; }
            set { cageCapacity = value; }
        }
        public Door Door
        {
            get { return door; }
            set { door = value; }
        }
        public FoodBucket FoodBucket
        {
            get { return foodBucket; }
            set { foodBucket = value; }
        }

        public Cage()
        {
            id = ++noOfCages;
            cageCapacity = 0;
            Door = new Door();
            foodBucket = new FoodBucket();
        }
        public Cage(int cageCapacity, double width, double height, string doorMaterial, double bucketCapacity, string bucketMaterial)
        {
            id = ++noOfCages;
            this.cageCapacity = cageCapacity;
            door = new Door(width, height, doorMaterial);
            foodBucket = new FoodBucket(bucketCapacity, bucketMaterial);
        }

        public override string ToString()
        {
            return $"ID: {id}, Capacity: {cageCapacity}\nDoor:\tWidth: {door.Width}\tHeight: {door.Height}\tMaterial: {door.DoorMaterial}\nFoodBucket:\tCapacity: {foodBucket.BucketCapacity}\tMaterial: {foodBucket.BucketMaterial}";
        }
    }

    public class Door
    {
        private double width;
        private double height;
        private string doorMaterial;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public string DoorMaterial
        {
            get { return doorMaterial; }
            set { doorMaterial = value; }
        }
        public Door()
        {
            width = 0;
            height = 0;
            doorMaterial = "unknown";
        }
        public Door(double width, double height, string doorMaterial)
        {
            this.width = width;
            this.height = height;
            this.doorMaterial = doorMaterial;
        }
        public override string ToString()
        {
            return $"Width: {width}, Height: {height}, Door Material: {doorMaterial}";
        }
    }

    public class FoodBucket
    {
        private double bucketCapacity;
        private string bucketMaterial;

        public double BucketCapacity
        {
            get { return bucketCapacity; }
            set { bucketCapacity = value; }
        }
        public string BucketMaterial
        {
            get { return bucketMaterial; }
            set { bucketMaterial = value; }
        }

        public FoodBucket()
        {
            bucketCapacity = 0;
            bucketMaterial = "unknown";
        }

        public FoodBucket(double bucketCapacity, string bucketMaterial)
        {
            this.bucketCapacity = bucketCapacity;
            this.bucketMaterial = bucketMaterial;
        }
        public override string ToString()
        {
            return $"Capacity: {bucketCapacity}, Material: {bucketMaterial}";
        }
    }
}