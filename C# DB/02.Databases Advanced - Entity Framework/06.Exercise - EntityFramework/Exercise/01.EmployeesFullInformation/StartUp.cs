using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        public static string GetEmployeesFullInformation(SoftUniContext db)
        {
            StringBuilder result = new StringBuilder();
            var empoyees = db.Employees
                  .Select(e => new Employee()
                  {
                      FirstName = e.FirstName,
                      LastName = e.LastName,
                      MiddleName = e.MiddleName,
                      JobTitle = e.JobTitle,
                      Salary = e.Salary
                  });

            foreach (var employee in empoyees.OrderBy(X => X.EmployeeId))
            {
                result.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:f2}");
            }

            return result.ToString();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext db)
        {
            StringBuilder sb = new StringBuilder();

            var employees = db.
                Employees
                    .Select(e => new
                    {
                        FirstName = e.FirstName,
                        Salary = e.Salary
                    })
                    .Where(e => e.Salary > 50000)
                    .OrderBy(e => e.FirstName)
                    .ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName}-{employee.Salary:f2}");
            }

            return sb.ToString();
        }

        public static void Main()
        {
            var context = new SoftUniContext();
            var result = GetEmployeesWithSalaryOver50000(context);
            Console.WriteLine(result);
        }
    }
}
