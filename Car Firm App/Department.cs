using System.Collections.Generic;

namespace CarFirmApp
{
    /// <summary>
    /// Represents a department within the firm, containing employees.
    /// </summary>
    public class Department
    {
        // The name of the department
        public string Name { get; private set; }

        // A list of employees that belong to the department
        public List<Employee> Employees { get; private set; }

        /// <summary>
        /// Constructs a new Department object with a name and employee list.
        /// </summary>
        public Department(string name, List<Employee> employees)
        {
            Name = name;
            Employees = employees;
        }
    }
}
