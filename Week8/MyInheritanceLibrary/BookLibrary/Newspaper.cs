namespace BookLibrary
{
    public class Newspaper : IPrintable
    {
        private string name;
        private string description;
        private string headline;

        public Newspaper(string name, string description, string headline)
        {
            this.name = name;
            this.description = description;
            this.headline = headline;
        }

        public void Print()
        {
            Console.WriteLine($"Newspaper details: {name}, {description}\nHeadline: {headline}");
        }
    }
}
