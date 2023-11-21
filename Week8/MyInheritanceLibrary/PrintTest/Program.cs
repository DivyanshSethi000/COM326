using BookLibrary;
namespace PrintTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPrintable> list = new List<IPrintable>();
            list.Add(new Book("Echoes of Eternity", "Serena Westwood", "Fantasy", 978));
            list.Add(new Newspaper("City Chronicles", "Bringing you daily updates on local and international news, politics, and culture", "Breaking News: Historic Landmark Restored After Decades of Neglect"));

            foreach (var item in list)
            {
                item.Print();
            }
        }
    }
}