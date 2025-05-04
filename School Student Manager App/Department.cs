using System;
using System.Collections.Generic;

namespace SchoolStudentManagerApp
{
    /// <summary>
    /// Represents a department containing a list of students.
    /// </summary>
    public class Department
    {
        // The name of the department
        private string name;

        /// <summary>
        /// Gets the list of students belonging to this department.
        /// </summary>
        public List<Student> Students { get; private set; }

        /// <summary>
        /// Creates a new department instance.
        /// </summary>
        public Department(string name, List<Student> students)
        {
            this.name = name;
            Students = students;
        }

        /// <summary>
        /// Returns a summary string of the department.
        /// </summary>
        public override string ToString() => $"Department: {name}, Students: {Students.Count}";
    }
}
