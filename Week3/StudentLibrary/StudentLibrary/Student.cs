namespace StudentLibrary
{
    public class Student
    {
        private int id;
        public int Id { get { return id; } }

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

        private static int studentCount = 0;
        public static int StudentCount { get { return studentCount; } }

        public Student()
        {
            name = "John Doe";
            age = 16;
            id = ++studentCount;
        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
        }
        public int GetOlder()
        {
            age++;
            return age;
        }
    }
}