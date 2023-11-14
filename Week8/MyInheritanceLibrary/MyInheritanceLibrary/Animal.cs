namespace MyInheritanceLibrary
{
    public class Animal
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int numberOfLegs;
        public int NumberOfLegs
        {
            get { return numberOfLegs; }
            set { numberOfLegs = value; }
        }

        public Animal()
        {
            name= string.Empty;
            age= 0;
            numberOfLegs= 0;
        }

        public Animal(string name, int age, int numberOfLegs)
        {
            this.name = name;
            this.age = age;
            this.numberOfLegs = numberOfLegs;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Hello");
        }
    }

    public class Dog : Animal
    {
        public Dog() : base() { }
        public Dog(string name, int age, int numberOfLegs) : base(name, age, numberOfLegs) { }
        public override void Speak()
        {
            Console.WriteLine("Woof!");
        } 
    }
    public class Cat : Animal
    {
        public Cat() : base() { }
        public Cat(string  name, int age, int numberOfLegs) : base (name, age, numberOfLegs) { }
        public override void Speak()
        {
            Console.WriteLine("Meow!");
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
        public Bird() : base() { }
        public Bird(double wingspan, string name, int age, int numberOfLegs) : base(name, age, numberOfLegs) 
        {
            this.wingspan = wingspan;
        }
    }

}