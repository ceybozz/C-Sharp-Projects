using System;
using System.Collections.Generic;

namespace SchoolStudentManagerApp
{
    /// <summary>
    /// Represents an institute consisting of multiple departments.
    /// </summary>
    public class Institute
    {
        // The name of the institute
        private string name;

        // List of departments in the institute
        private List<Department> departments;

        /// <summary>
        /// Creates a new institute instance.
        /// </summary>
        public Institute(string name, List<Department> departments)
        {
            this.name = name;
            this.departments = departments;
        }

        /// <summary>
        /// Calculates the total number of students in the institute.
        /// </summary>
        public int GetNumberOfStudentsInInstitute()
        {
            int numberOfStudents = 0;

            // Sum up student counts from all departments
            foreach (Department dept in departments)
            {
                numberOfStudents += dept.Students.Count;
            }

            return numberOfStudents;
        }

        /// <summary>
        /// Returns the name of the institute.
        /// </summary>
        public override string ToString() => $"Institute: {name}";
    }
}
