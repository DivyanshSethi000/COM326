namespace MyInheritanceLibrary
{
    public class Animal //original animal class(parent)
    {
        //initiating the fields and properties of this class
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

        public Animal() //default constructor
        {
            name= string.Empty;
            age= 0;
            numberOfLegs= 0;
        }

        public Animal(string name, int age, int numberOfLegs) //custom constructor
        {
            this.name = name;
            this.age = age;
            this.numberOfLegs = numberOfLegs;
        }

        public virtual string Speak() //virtual method with return type string
        {
            return "Hello!";
        }
    }

    public class Dog : Animal //inherited dog class(child)
    {
        public Dog() : base() { } //default constructor
        public Dog(string name, int age, int numberOfLegs) : base(name, age, numberOfLegs) { } //custom contructor
        public override string Speak() //overriding the method from parent class
        {
            return "Woof!";
        } 
    }
    public class Cat : Animal //inherited cat class(child)
    {
        public Cat() : base() { } //default constructor
        public Cat(string  name, int age, int numberOfLegs) : base (name, age, numberOfLegs) { } //custom contructor
        public override string Speak() //overriding the method from parent class
        {
            return "Meow!";
        }
    }
    public class Bird : Animal //inherited bird class(child)
    {
        //initiating a field and property associated solely to this inherited class
        private double wingspan;
        public double Wingspan
        {
            get { return wingspan; } 
            set { wingspan = value; }
        }
        public Bird() : base() { } //default constructor
        public Bird(double wingspan, string name, int age, int numberOfLegs) : base(name, age, numberOfLegs) //custom contructor
        {
            this.wingspan = wingspan;
        }

        public override string Speak() //overriding the method from parent class
        {
            return "Chirp!";
        }
    }

}