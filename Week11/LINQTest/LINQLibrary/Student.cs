namespace LINQLibrary
{
    public class Student
    {
        // fields
        private string id;
        private string name;
        private int age;
        private static int count = 1000;
        // properties
        public string Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Count
        {
            get { return count; }
        }
        // constructors
        public Student()
        {
            id = "B00"+ count++;
            name = "unknown";
            age = 0;
        }
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            id = "B00" + count++;
        }
        // methods
        public override string ToString()
        {
            return $"Student: { id} { name} { age}";
        }
    }
}
