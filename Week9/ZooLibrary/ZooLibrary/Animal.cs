namespace ZooLibrary
{
    public abstract class Animal
    {
        private string name;
        private int numberOfLegs;
        private DateTime birthday;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int NumberOfLegs
        {
            get { return numberOfLegs; }
            set { numberOfLegs = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
        }

        public Animal()
        {
            Name = string.Empty;
            NumberOfLegs = 0;
            birthday = DateTime.Now;
        }

        public Animal(string name, DateTime birthday, int numberOfLegs)
        {
            this.Name = name;
            this.NumberOfLegs = numberOfLegs;
            this.birthday = birthday;
        }

        public abstract void Eat(double foodAmount);
        public abstract string Speak();

        public override string ToString()
        {
            return $"Name: {name}, Birthday: {birthday}, Number of Legs: {numberOfLegs}";
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
        public Dog(string name,DateTime birthday, int numberOfLegs, string breed) : base(name,birthday, numberOfLegs)
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
    }

    public class Cat : Animal
    {
        public Cat() : base() { }
        public Cat(string name, DateTime birthday, int numberOfLegs) : base(name, birthday, numberOfLegs) { }

        public override void Eat(double foodAmount) { }

        public override string Speak()
        {
            return "Meow";
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
        public Bird(string name, DateTime birthday, int numberOfLegs, double wingspan) : base(name, birthday, numberOfLegs) 
        {
            this.wingspan = wingspan;
        }

        public override void Eat(double foodAmount) { }

        public override string Speak()
        {
            return "Chirp";
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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee() { }

        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
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
        private int capacity;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public Door door;
        public FoodBucket foodBucket;

        public Cage(int id, int capacity, Door door, FoodBucket foodBucket)
        {
            this.id = id;
            this.capacity = capacity;
            this.door = door;
            this.foodBucket = foodBucket;
        }

        public override string ToString()
        {
            return $"Id: {id}, Capacity: {capacity}, Door: {door}, FoodBucket: {foodBucket}";
        }
    }

    public class Door
    {
        private double width;
        private double height;
        private string material;

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
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public Door() { }
        public Door(double width, double height,string material)
        {
            this.width = width;
            this.height = height;
            this.material = material;
        }
        public override string ToString()
        {
            return $"Width: {width}, Height: {height}, Material: {material}";
        }
    }

    public class FoodBucket
    {
        private double capacity;
        private string material;

        public double Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public FoodBucket() { }
        public FoodBucket(double capacity, string material)
        {
            this.capacity = capacity;
            this.material = material;
        }
        public override string ToString()
        {
            return $"Capacity: {capacity}, Material: {material}";
        }
    }

    public class Zoo
    {
        public List<Animal> animals;
        public List<Employee> employees;
        public List<Cage> cages;
        public Zoo() 
        {
            animals = new List<Animal>();
            employees = new List<Employee>();
            cages = new List<Cage>();
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void AddCage(Cage cage)
        {
            cages.Add(cage);
        }

        public void AddDoorToCage(Cage cage, Door door)
        {
            cage.door = door;
        }

        public void AddFoodBucketToCage(Cage cage, FoodBucket foodBucket)
        {
            cage.foodBucket = foodBucket;
        }

        public override string ToString()
        {
            string result = "";

            foreach (var employee in employees)
            {
                result += employee.ToString() + "\n";
            }

            foreach (var cage in cages)
            {
                result += cage.ToString() + "\n";
            }

            return result;
        }
    }
}