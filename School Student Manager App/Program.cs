﻿using System;
using System.Collections.Generic;

namespace SchoolStudentManagerApp
{
    /// <summary>
    /// Entry point of the School Student Manager App.
    /// Demonstrates creating students, departments, and calculating total student count.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // ============================
            // STEP 1: Create students
            // ============================

            // Students for the CSE (Computer Science & Engineering) department
            var student1 = new Student("Kalle", 1, "CSE");
            var student2 = new Student("Rohan", 2, "CSE");

            // Students for the EE (Electrical Engineering) department
            var student3 = new Student("Mohammed", 3, "EE");
            var student4 = new Student("Abraham", 4, "EE");

            // ============================
            // STEP 2: Group students by department
            // ============================

            List<Student> cseStudents = new List<Student> { student1, student2 };
            List<Student> eeStudents = new List<Student> { student3, student4 };

            // ============================
            // STEP 3: Create department objects
            // ============================

            var cseDepartment = new Department("CSE", cseStudents);
            var eeDepartment = new Department("EE", eeStudents);

            // ============================
            // STEP 4: Create the institute and add departments
            // ============================

            List<Department> departments = new List<Department> { cseDepartment, eeDepartment };
            var institute = new Institute("QTH", departments);

            // ============================
            // STEP 5: Output results
            // ============================

            // Print institute name
            Console.WriteLine(institute
