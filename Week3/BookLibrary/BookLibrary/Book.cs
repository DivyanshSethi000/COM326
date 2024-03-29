﻿namespace BookLibrary
{
    public class Book
    {
        //initializing the fields and the static variable
        private string title; 
        private string author;
        private string genre;
        private int isbn;
        private int year;
        private string publisher;
        private static int bookCount = 0;

        //initializing the properties with getters and setters
        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        public string Genre { get {  return genre; } set {  genre = value; } }
        public int Isbn { get {  return isbn; }}
        public int Year { get { return year;} set { year = value; } }
        public string Publisher { get {  return publisher; } set {  publisher = value; } }

        //creating the default constructor
        public Book()
        {
            isbn = ++bookCount;//setting the isbn with increment of book count
            year = 0;
            title = string.Empty;
            author = string.Empty;
            genre = string.Empty;
            publisher = string.Empty;
        }
        //creating the custom parametric contructor 
        public Book(string title, string author, string genre, int year, string publisher)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            isbn = ++bookCount;
            this.year = year;
            this.publisher = publisher;
        }

        //creating a method for displaying the details of the books
        public void Display()
        {
            Console.WriteLine($"Book details: {isbn}: {title}, by {author}, published in {year} by {publisher}, in the {genre} genre");
        }
    }
}