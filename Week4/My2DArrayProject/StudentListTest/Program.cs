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

            foreach(var student in students) //using a for each loop 
            {
                student.Display(); //displaying all the students in the list 
            }
        }
    }
}