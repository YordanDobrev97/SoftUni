namespace SoftUni.Models
{
    using System;
    using System.Collections.Generic;

    public class Employee
    {
        public Employee()
        {
            Departments = new HashSet<Departments>();
            EmployeesProjects = new HashSet<EmployeesProject>();
            InverseManager = new HashSet<Employee>();
        }

        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string JobTitle { get; set; }

        public int DepartmentId { get; set; }

        public int? ManagerId { get; set; }

        public DateTime HireDate { get; set; }

        public decimal Salary { get; set; }

        public int? AddressId { get; set; }

        public virtual Addresses Address { get; set; }

        public virtual Departments Department { get; set; }

        public virtual Employee Manager { get; set; }

        public virtual ICollection<Departments> Departments { get; set; }

        public virtual ICollection<EmployeesProject> EmployeesProjects { get; set; }

        public virtual ICollection<Employee> InverseManager { get; set; }
    }
}
