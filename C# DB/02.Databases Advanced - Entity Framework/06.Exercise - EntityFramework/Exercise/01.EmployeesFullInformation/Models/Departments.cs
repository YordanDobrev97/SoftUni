﻿namespace SoftUni.Models
{
    using System;
    using System.Collections.Generic;

    public class Departments
    {
        public Departments()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int ManagerId { get; set; }

        public virtual Employee Manager { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
