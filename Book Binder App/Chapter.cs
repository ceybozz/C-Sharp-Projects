using System;

namespace Book_Binder_App
{
    /// <summary>
    /// Represents a single chapter in a book, including its name and order number.
    /// </summary>
    public class Chapter
    {
        /// <summary>
        /// The name or title of the chapter.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The chapter's sequence number in the book.
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// Initializes a new Chapter with a specific name and number.
        /// </summary>
        /// <param name="name">Name of the chapter.</param>
        /// <param name="number">Chapter number (1-based).</param>
        public Chapter(string name, int number)
        {
            Name = name;
            Number = number;
        }

        /// <summary>
        /// Returns a formatted string for display.
        /// </summary>
        public override string ToString() => $"Chapter {Number}: {Name}";
    }
}
