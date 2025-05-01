using System;
using System.Collections.Generic;

namespace CarFirmApp
{
    /// <summary>
    /// Represents a car firm that consists of multiple departments.
    /// </summary>
    public class Firm
    {
        // The firm's name
        public string Name { get; private set; }

        // The firm's physical address
        public string Address { get; private set; }

        // The firm's website URL
        public string Url { get; private set; }

        // The organization's registration number
        public string OrganizationNumber { get; private set; }

        // A list of all departments in the firm
        private List<Department> departments;

        /// <summary>
        /// Constructs a new Firm object with all basic properties and departments.
        /// </summary>
        public Firm(string name, string address, string url, string orgnr, List<Department> departments)
        {
            Name = name;
            Address = address;
            Url = url;
            OrganizationNumber = orgnr;
            this.departments = departments;
        }

        /// <summary>
        /// Returns a formatted string with firm details.
        /// </summary>
        public override string ToString()
        {
            return $"Firm Name: {Name}, Address: {Address}, URL: {Url}, Org number: {OrganizationNumber}";
        }

        /// <summary>
        /// Calculates and returns the total number of employees across all departments.
        /// </summary>
        public int GetNumberOfEmployees()
        {
            int total = 0;

            // Loop through all departments and sum the number of employees
            foreach (var dept in departments)
            {
                total += dept.Employees.Count;
            }

            return total;
        }
    }
}
