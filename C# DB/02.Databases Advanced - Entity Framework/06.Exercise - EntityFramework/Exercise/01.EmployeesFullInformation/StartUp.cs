using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public static class StartUp
    {
        public static string GetEmployeesFullInformation(SoftUniContext db)
        {
            StringBuilder result = new StringBuilder();
            var empoyees = db.Employees
                  .OrderBy(x => x.EmployeeId)
                  .Select(e => new
                  {
                      FirstName = e.FirstName,
                      LastName = e.LastName,
                      MiddleName = e.MiddleName,
                      JobTitle = e.JobTitle,
                      Salary = e.Salary
                  });

            foreach (var employee in empoyees)
            {
                result.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:f2}");
            }

            return result.ToString();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext db)
        {
            StringBuilder sb = new StringBuilder();

            

            return sb.ToString();
        }

        public static void Main()
        {
            var context = new SoftUniContext();
            var employees = context.Employees.FirstOrDefault(i => i.EmployeeId == 3);

            Console.WriteLine($"");

            //var result = GetEmployeesWithSalaryOver50000(context);
            //Console.WriteLine(result);
        }
    }
}
