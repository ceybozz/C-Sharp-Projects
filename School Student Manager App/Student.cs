using System;

namespace SchoolStudentManagerApp
{
    /// <summary>
    /// Represents a student with a name, ID, and department.
    /// </summary>
    public class Student
    {
        // The student's full name
        private string name;

        // The unique ID of the student
        private int id;

        // The department the student belongs to
        private string department;

        /// <summary>
        /// Initializes a new student instance with the specified name, ID, and department.
        /// </summary>
        public Student(string name, int id, string department)
        {
            this.name = name;
            this.id = id;
            this.department = department;
        }

        /// <summary>
        /// Returns a formatted string representing the student.
        /// </summary>
        public override string ToString()
        {
            return $"Student: {name}, ID: {id}, Department: {department}";
        }
    }
}
