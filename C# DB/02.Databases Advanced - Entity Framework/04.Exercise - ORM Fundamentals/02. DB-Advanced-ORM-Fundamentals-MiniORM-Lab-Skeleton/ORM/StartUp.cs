using MiniORM;
using ORM;
using ORM.Data;
using ORM.Data.Entities;
using System;
using System.Linq;

namespace ORMNamespace
{
    public class StartUp
    {
        public static void Main()
        {
            var connectionString = @"Server=.\SQLEXPRESS; Database=MiniORM; Integrated Security=true";

            var context = new SoftUniDbContext(connectionString);

            context.Employees.Add(new Employee
            {
                FirstName = "Gosho",
                LastName = "Petrov",
                DepartmentId = context.Departments.First().Id,
                IsEmployed = true
            });

            var employee = context.Employees.Last();
            employee.FirstName = "Pesho";

            context.SaveChanges();
        }
    }
}
