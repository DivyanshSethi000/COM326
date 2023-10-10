using StudentLibrary; //using the library we coded

namespace StudentTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(); //instantiating a new object using a default constructor
            Student student2 = new Student("Conn Locke", 19); //instantiating a new object using a parametric constructor
            //calling the display method for both objects
            student1.Display();  
            student2.Display();
            //printing out the age after using the get older method on the two objects
            Console.WriteLine(student1.GetOlder()); 
            Console.WriteLine(student2.GetOlder());
            //calling the display method again to check the new age of the objects
            student1.Display();
            student2.Display();
        }
    }
}