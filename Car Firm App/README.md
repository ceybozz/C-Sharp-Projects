# Car Firm App

A simple C# console application that models the structure of a car firm, including departments and employees.

## 🧾 Description

The **Car Firm App** simulates a basic company model using object-oriented principles in C#. It includes:

- A `Firm` class that represents the company.
- A `Department` class that holds employees.
- An `Employee` class with basic personal and work information.
- A `Program` class with a console-based entry point.

This project is designed to demonstrate object-oriented design, encapsulation, and class relationships in C#.

## 🧩 Features

- Add and structure employees across different departments.
- Automatically calculate the total number of employees in the firm.
- Clear `ToString()` output for both employees and the firm.
- Clean codebase with proper documentation and comments.

## 🗂️ Project Structure

```
CarFirmApp/
│
├── Program.cs           # Application entry point
├── Firm.cs              # Represents the firm
├── Department.cs        # Represents a department in the firm
├── Employee.cs          # Represents an employee
├── CarFirmApp.csproj    # Project configuration (optional)
└── README.md            # Project documentation
```

## 🚀 How to Run

1. Open the project in **Visual Studio** or any C# IDE.
2. Build the solution (Ctrl + Shift + B).
3. Run the application (F5 or `dotnet run`).

> .NET SDK 6.0+ is recommended.

## ✅ Example Output

```
Firm Name: QC, Address: Kungsgatan 10, URL: qualitycars.se, Org number: 9900-4565
Total number of employees in firm: 5
Employee: Kalle has ID: 4 and works in Sales
Employee: Rohan has ID: 2 and works in Mechanic
Employee: Mohammed has ID: 3 and works in Sales
Employee: Abraham has ID: 1 and works in CEO
Employee: Bertil has ID: 5 and works in Mechanic
```

## 📚 Purpose

This application is ideal for:

- Beginners learning OOP in C#.
- Demonstrating class interactions.
- Practice with class structure and clean coding.

## 🛠️ Future Improvements

- Add employee search by ID or name.
- Add support for adding/removing departments or employees at runtime.
- Save/load data to/from files (JSON or XML).
- GUI or WebAPI frontend.

## 👨‍💻 Author

Created by Ceyhun Bozkurt. For questions, feel free to reach out.
