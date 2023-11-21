using MyInheritanceLibrary;

namespace AnimalLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>(); //initializing a new list using the animal class as its objects
            var Dog = new Dog("Luna", 3, 4); //new object from dog class
            var Cat = new Cat("Oliver", 2, 4); //new object from cat class
            var Bird = new Bird(12,"Sky", 4, 2); //new object from bird class
            //adding the new objects into the animals list
            animals.Add(Dog);
            animals.Add(Cat);
            animals.Add(Bird);

            foreach (var animal in animals) //looping through the list for each object and calling the method for each object
            {
                var speech = animal.Speak(); //storing the method call in a variable
                Console.WriteLine(speech); //printing to the console the method's return value
            }
        }
    }
}