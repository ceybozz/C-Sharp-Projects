using System;
using System.Collections.Generic;
using System.Linq;

namespace Book_Binder_App
{
    /// <summary>
    /// Represents a book that consists of a title, author, and a list of chapters.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Title of the book.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Author of the book.
        /// </summary>
        public string Author { get; private set; }

        /// <summary>
        /// List of chapters included in the book.
        /// </summary>
        public List<Chapter> Chapters { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Book class with title, author, and chapter list.
        /// </summary>
        public Book(string title, string author, List<Chapter> chapters)
        {
            Title = title;
            Author = author;
            Chapters = chapters;
        }

        /// <summary>
        /// Adds a chapter to the book.
        /// </summary>
        /// <param name="chapter">The chapter to add.</param>
        public void AddChapter(Chapter chapter)
        {
            Chapters.Add(chapter);
        }

        /// <summary>
        /// Returns all chapters ordered by their chapter number.
        /// </summary>
        /// <returns>Ordered list of chapters.</returns>
        public List<Chapter> GetAllChaptersOrdered()
        {
            return Chapters.OrderBy(c => c.Number).ToList();
        }
    }
}
