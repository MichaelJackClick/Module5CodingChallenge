using System;
using System.Collections.Generic;

// Base Book Class (Encapsulation & Abstraction)
class Book
{
    // Encapsulated properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    // Constructor
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}");
    }
}

// Inherited Class 
class EBook : Book
{
    public double FileSizeMB { get; set; }

    // Constructor that calls the base class constructor
    public EBook(string title, string author, int year, double fileSizeMB)
        : base(title, author, year)
    {
        FileSizeMB = fileSizeMB;
    }

    
    public override void DisplayDetails()
    {
        Console.WriteLine($"[E-Book] {Title} by {Author}, {Year} - {FileSizeMB}MB");
    }
}

// Library Management System
class Library
{
    private List<Book> books = new List<Book>();

    // Method to add books
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the library.");
    }

    // Display all books
    public void DisplayBooks()
    {
        Console.WriteLine("\nLibrary Books:");
        foreach (var book in books)
        {
            book.DisplayDetails();
        }
    }
}

// Main Execution
class Program
{
    static void Main()
    {
        Library library = new Library();

        // Adding Books
        library.AddBook(new Book("1984", "George Orwell", 1949));
        library.AddBook(new EBook("C# Fundamentals", "John Doe", 2021, 5.2));

        // Display Books
        library.DisplayBooks();
    }
}
