using ZooLibrary;
namespace ZooTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Dog("Fang", DateTime.Now, 4, "Siberian Husky"));
            animalList.Add(new Cat("Tara", DateTime.Now, 4));
            animalList.Add(new Bird("Janet", DateTime.Now, 2, 12));

            foreach (var animal in animalList)
            {
                var speech = animal.Speak(); //storing the method call in a variable
                Console.WriteLine(speech); //printing to the console the method's return value
            }
        }
    }
}