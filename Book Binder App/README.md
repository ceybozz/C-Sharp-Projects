# 📚 Book Binder App

A simple C# console application that models the structure of a book, including its chapters. It demonstrates core object-oriented programming concepts such as encapsulation, object relationships, and sorting logic in C#.

---

## 🚀 Description

The **Book Binder App** allows you to:

- Create `Chapter` objects with titles and numbers
- Organize these chapters in a `Book` object
- Display all chapters sorted by their assigned number

This application is great for learning and demonstrating object-oriented design using C#.

---

## 🧩 Features

- Encapsulated `Book` and `Chapter` classes
- Sort chapters by their logical sequence (chapter number)
- Clean and well-documented code for educational or demo purposes
- Extensible design: easy to add new features like user input or file saving

---

## 🗂️ Project Structure

```
Book Binder App/
│
├── Book.cs              # Defines the Book class with title, author, and chapters
├── Chapter.cs           # Defines the Chapter class with name and number
├── Program.cs           # Entry point that demonstrates how the classes work
├── Book_Binder_App.csproj # Project file for .NET build configuration
└── README.md            # You're reading it
```

---

## ⚙️ Requirements

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or later
- A C# IDE (e.g., Visual Studio, JetBrains Rider, or VS Code)

---

## 🧪 How to Run

1. Clone or download this repository.
2. Open the folder in your terminal or IDE.
3. Run the application using:

```bash
dotnet run
```

4. You should see book and chapter information printed to the console.

---

## 📌 Example Output

```
Title: Fellowship of the Ring
Author: J.R.R. Tolkien

Chapters:
Chapter 1: A Long-Expected Travel
Chapter 2: The Shadows of the Realm
Chapter 3: I See Light
```

---

## 🛠️ Potential Improvements

- Add interactive user input to create books and chapters
- Save/load data to/from files (JSON/XML)
- Create a GUI version using WPF or Windows Forms
- Add unit tests for validation

---

## 👨‍💻 Author

Created by [Your Name].  
Feel free to contribute, fork, or provide feedback!
