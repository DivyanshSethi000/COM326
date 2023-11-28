using ZooLibrary;
namespace ZooTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Dog ("Fang",new DateTime(2004,02,28), 4, "Siberian Husky");
            Animal animal2 = new Cat ("Tara",new DateTime(2001,09,11),4);
            Animal animal3 = new Bird ("Janet",new DateTime(1992,09,17), 2, 12);

            Employee employee1 = new Employee ("John Doe", 50000);
            Employee employee2 = new Employee ("Jane Smith", 60000);

            Cage cage1 = new Cage (10, 6.4, 4.6, "Stainless Steel", 5, "BPA-free plastic");
            Cage cage2 = new Cage(15, 9.6, 6.9, "Stainless Steel", 7.5, "BPA-free plastic");       

            Zoo myZoo = new Zoo();

            myZoo.Animals.Add(animal1);
            myZoo.Animals.Add(animal2);
            myZoo.Animals.Add(animal3);
            myZoo.Employees.Add(employee1);
            myZoo.Employees.Add(employee2);
            myZoo.Cages.Add(cage1);
            myZoo.Cages.Add(cage2);

            myZoo.PrintAll();
        }

    }
}