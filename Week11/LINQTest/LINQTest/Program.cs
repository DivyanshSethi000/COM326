using LINQLibrary;
namespace LINQTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
             new Student("Daniel Smith", 22),
             new Student("John Smith", 18),
             new Student("Jane Doe", 21),
             new Student("Joe Bloggs", 22),
             new Student("John Doe", 23),
             new Student("Jenny Bloggs", 20),
             new Student("Frank Jones", 24)
            };

            var students_21 = students.Where(student => student.Age > 21);
            var sorted_21 = students_21.OrderBy(student => student.Name);
            var studentNames = sorted_21.Select(student => student.Name);
            var studentGroups = students.GroupBy(student => student.Age);
            var numGroups = studentGroups.Select(group =>
                    new { Age = group.Key, Count = group.Count() });
            //Another method of doing the above query
            //var numGroups = studentGroups.Count;

        }
    }
}
