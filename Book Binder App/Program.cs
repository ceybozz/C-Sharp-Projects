using System;
using System.Collections.Generic;

namespace Book_Binder_App
{
    /// <summary>
    /// Main entry point of the Book Binder App.
    /// Demonstrates usage of the Book and Chapter classes.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create example chapters with names and numbers
            var chapter1 = new Chapter("A Long-Expected Travel", 1);
            var chapter2 = new Chapter("The Shadows of the Realm", 2);
            var chapter3 = new Chapter("I See Light", 3);

            // Add chapters to a list in unordered sequence
            var chapters = new List<Chapter>
            {
                chapter1,
                chapter3, // Chapter 3 is intentionally added before chapter 2
                chapter2
            };

            // Create a book instance with the chapters
            var book = new Book("Fellowship of the Ring", "J.R.R. Tolkien", chapters);

            // Display book title and author
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}\n");

            // Display chapters sorted by number
            Console.WriteLine("Chapters:");
            foreach (var chapter in book.GetAllChaptersOrdered())
            {
                Console.WriteLine(chapter); // Uses Chapter.ToString()
            }

            // Wait for user to close window if run from Explorer
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
