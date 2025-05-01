using System;

namespace CarFirmApp
{
    /// <summary>
    /// Represents an employee working in a department of the firm.
    /// </summary>
    public class Employee
    {
        // The name of the employee
        public string Name { get; private set; }

        // The unique ID of the employee
        public int Id { get; private set; }

        // The department where the employee works
        public string Department { get; private set; }

        /// <summary>
        /// Constructs a new Employee object with name, ID, and department.
        /// </summary>
        public Employee(string name, int id, string department)
        {
            Name = name;
            Id = id;
            Department = department;
        }

        /// <summary>
        /// Returns a formatted string with the employee's details.
        /// </summary>
        public override string ToString()
        {
            return $"Employee: {Name} has ID: {Id} and works in {Department}";
        }
    }
}
