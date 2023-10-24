using StudentListProject; //using the custom class library
namespace StudentListTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(); //initializing a students list

            //adding all the students in the list with the apt details
            students.Add(new Student("Emily Johnson", 20)); 
            students.Add(new Student("David Martinez", 21));
            students.Add(new Student("Sarah Kim", 19));
            students.Add(new Student("James Anderson", 22));
            students.Add(new Student("Mia Patel", 20));

            //Another method where user input is used instead of hard coding
            /*
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter your name: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name) == true)
                {
                    while (string.IsNullOrWhiteSpace(name) == true) 
                    {
                        Console.WriteLine("Please enter your name: ");
                        name = Console.ReadLine();
                    }
                }
                Console.WriteLine("Please enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                students.Add(new Student(name, age));
            }*/
            
            foreach(var student in students) //using a for each loop 
            {
                student.Display(); //displaying all the students in the list 
            }
        }
    }
}
