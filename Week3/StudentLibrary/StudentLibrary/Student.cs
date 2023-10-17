namespace StudentLibrary //Creating a Student Library
{
    public class Student //Custom class Student
    {
        private int id; //creating a field of int type 'id'
        public int Id //creating the property for the field above
        { 
            get { return id; } //using 'get' to return the 'id' value
        } 

        private string name; //creating a field of string type 'name'
        public string Name //creating the property for the field above
        {
            get { return name; } //using 'get' to return the 'name' value
            set { name = value; } //using 'set' to set a new value to 'name'
        }

        private int age; //creating a field of int type 'age'
        public int Age //creating the property for the field above
        {
            get { return age; } //using 'get' to return the 'age' value
            set { age = value; } //using 'set' to set a new 'age'
        }

        private static int studentCount = 0; //creating a static int type field  
        public static int StudentCount { get { return studentCount; } } //creating the property for the field above

        public Student() //creating the default constructor
        {
            name = "John Doe";
            age = 16;
            id = ++studentCount;
        }

        public Student(string name, int age) //creating the custom constructor with parameters
        {
            this.name = name; //setting the value of 'name' acc to the parameter
            this.age = age; //setting the value of 'age' acc to the parameter
            id = ++studentCount;
        }
        public void Display() //creating the void method printing out the info of the object instantiated
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
        }
        public int GetOlder() //creating the int method which increases and returns the age of the object instantiated
        {
            age++;
            return age;
        }
    }
}
