using System;
using System.Collections.Generic;

namespace CarFirmApp
{
    /// <summary>
    /// Entry point of the CarFirmApp console application.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create employees
            var e1 = new Employee("Kalle", 4, "Sales");
            var e2 = new Employee("Rohan", 2, "Mechanic");
            var e3 = new Employee("Mohammed", 3, "Sales");
            var e4 = new Employee("Abraham", 1, "CEO");
            var e5 = new Employee("Bertil", 5, "Mechanic");

            // Create departments and assign employees
            var sales = new Department("Sales", new List<Employee> { e1, e3 });
            var mechanic = new Department("Mechanic", new List<Employee> { e2, e5 });
            var ceo = new Department("CEO", new List<Employee> { e4 });

            // Create a list of all departments
            var departments = new List<Department> { sales, mechanic, ceo };

            // Create the firm and assign departments
            var firm = new Firm("QC", "Kungsgatan 10", "qualitycars.se", "9900-4565", departments);

            // Print firm information
            Console.WriteLine(firm);
            Console.WriteLine($"Total number of employees in firm: {firm.GetNumberOfEmployees()}");

            // Print each employee's information
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(e4);
            Console.WriteLine(e5);
        }
    }
}
