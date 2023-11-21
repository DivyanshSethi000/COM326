namespace BookLibrary
{
    public class Book : IPrintable
    {
        private string title;
        private string author;
        private string genre;
        private int isbn;

        //initializing the properties with getters and setters
        public string Title 
        { 
            get { return title; } 
            set { title = value; } 
        }
        public string Author 
        { 
            get { return author; } 
            set { author = value; } 
        }
        public string Genre 
        { 
            get { return genre; } 
            set { genre = value; } 
        }
        public int Isbn 
        { 
            get { return isbn; }
            set { isbn = value; }
        }

        //creating the default constructor
        public Book()
        {
            isbn = 0;
            title = string.Empty;
            author = string.Empty;
            genre = string.Empty;
        }
        //creating the custom parametric contructor 
        public Book(string title, string author, string genre, int isbn)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.isbn = isbn;
        }

        //creating a method for displaying the details of the books
        public void Print()
        {
            Console.WriteLine($"Book details: {isbn}: {title}, by {author} of the genre {genre}");
        }
    }
    
}