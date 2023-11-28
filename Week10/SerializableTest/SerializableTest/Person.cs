namespace SerializableTest
{
    [Serializable]
    public class Person
    {
        // fields
        private string firstName;
        private string lastName;
        private int age;
        // properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        // constructors
        public Person()
        {
            firstName = "unknown";
            lastName = "unknown";
            age = 0;
        }
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        // methods
        public override string ToString()
        {
            return $"Name: {firstName} {lastName}, Age: {age}";
        }
    }
}
