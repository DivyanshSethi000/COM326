using StudentLibrary;

namespace StudentTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("Conn Locke", 19);
            student1.Display();
            student2.Display();
            Console.WriteLine(student1.GetOlder());
            Console.WriteLine(student2.GetOlder());
            student1.Display();
            student2.Display();
        }
    }
}