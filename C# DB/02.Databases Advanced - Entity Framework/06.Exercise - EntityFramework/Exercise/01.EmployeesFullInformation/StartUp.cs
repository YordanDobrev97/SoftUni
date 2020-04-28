using Microsoft.EntityFrameworkCore.Internal;
using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public static class StartUp
    {
        //03.Employees Full Information
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var empoyees = context.Employees
                  .OrderBy(x => x.EmployeeId)
                  .Select(e => new
                  {
                      e.FirstName,
                      e.LastName,
                      e.MiddleName,
                      e.JobTitle,
                      e.Salary
                  })
                  .ToList();

            StringBuilder result = new StringBuilder();
            foreach (var employee in empoyees)
            {
                result.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:f2}");
            }

            return result.ToString();
        }

        //04.Employees with Salary Over 50 000
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(x => x.Salary > 50000)
                .OrderBy(x => x.FirstName)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.Salary:f2}");
            }

            return sb.ToString();
        }

        //05.Employees from Research and Development
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var employees = context.Employees.Select(e => new
            {
                e.FirstName,
                e.LastName,
                e.Salary,
                DepartmentName = e.Department.Name
            }).Where(d => d.DepartmentName == "Research and Development")
            .OrderBy(e => e.Salary)
            .ThenByDescending(e => e.FirstName)
            .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.DepartmentName} - ${employee.Salary:f2}");
            }

            return sb.ToString();
        }

        //06.Adding a New Address and Updating Employee
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            var address = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4,
            };

            var currentEmployee = context.Employees.First(x => x.LastName == "Nakov");
            currentEmployee.Address = address;

            context.SaveChanges();

            var addresses = context.Employees.OrderByDescending(e => e.AddressId)
                .Take(10)
                .Select(e => new
                {
                    e.Address.AddressText
                })
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var addressText in addresses)
            {
                sb.AppendLine(addressText.AddressText);
            }

            return sb.ToString();
        }

        //07.Employees and Projects
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(e => e.EmployeesProjects
                .Any(p => p.Project.StartDate.Year >= 2001 && p.Project.StartDate.Year <= 2003))
                .Select(e => new
                {
                    FullName = e.FirstName + " " + e.LastName,
                    ManagerFullName = e.Manager.FirstName + " " + e.Manager.LastName,
                    EmployeesProjects = e.EmployeesProjects
                    .Select(p => new
                    {
                        Name = p.Project.Name,
                        StartDate = p.Project.StartDate,
                        EndDate = p.Project.EndDate
                    }).ToList()
                })
            .Take(10)
            .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FullName} – Manager: {employee.ManagerFullName}");
                sb.AppendLine($"{employee.FullName} – Manager: {employee.ManagerFullName}");

                foreach (var employeeProject in employee.EmployeesProjects)
                {
                    var start = employeeProject.StartDate.ToString("M/d/yyyy h:mm:ss tt",
                        CultureInfo.InvariantCulture);

                    var end = employeeProject.EndDate == null ?
                        "not finished" : employeeProject.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt",
                        CultureInfo.InvariantCulture);

                    Console.WriteLine($"--{employeeProject.Name} - {start} - {end}");
                    sb.AppendLine($"--{employeeProject.Name} - {start} - {end}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        //08.Addresses by Town
        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addresses = context.Addresses
                .Select(x => new
                {
                    TownName = x.Town.Name,
                    AddressText = x.AddressText,
                    EmployeesCount = x.Employees.Count
                })
                .OrderByDescending(x => x.EmployeesCount)
                .ThenBy(x => x.TownName)
                .ThenBy(x => x.AddressText)
                .Take(10)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var address in addresses)
            {
                sb.AppendLine($"${address.AddressText} {address.TownName} - {address.EmployeesCount} employees");
            }

            return sb.ToString();
        }

        //09.Employee 147
        public static string GetEmployee147(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(e => e.EmployeeId == 147)
            .Select(e => new
            {
                e.FirstName,
                e.LastName,
                e.JobTitle,
                Projects = e.EmployeesProjects.Select(p => p.Project.Name).OrderBy(x => x)
            }).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

                foreach (var project in employee.Projects)
                {
                    sb.AppendLine(project);
                }
            }

            return sb.ToString();
        }


        //10.Get Departments With More Than 5 Employees
        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departments = context.Departments.Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .ThenBy(d => d.Name)
                .Select(d => new
                {
                    DepartmentName = d.Name,
                    ManagerName = d.Manager.FirstName + " " + d.Manager.LastName,
                    Employees = d.Employees.Select(e => new
                    {
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        JobTitle = e.JobTitle
                    })
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                    .ToList()
                }).ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var department in departments)
            {
                sb.AppendLine($"{department.DepartmentName} - {department.ManagerName}");

                foreach (var employee in department.Employees)
                {
                    sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                }
            }

            return sb.ToString();
        }

        //11.Get Latest Projects
        public static string GetLatestProjects(SoftUniContext context)
        {
            var projects = context.Projects.OrderByDescending(p => p.StartDate)
                .Take(10)
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    p.StartDate
                })
                .OrderBy(p => p.Name)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var project in projects)
            {
                var date = project.StartDate.ToString("M/d/yyyy h:mm:ss tt");
                sb.AppendLine(project.Name);
                sb.AppendLine(project.Description);
                sb.AppendLine(date);
            }

            return sb.ToString();
        }

        //12.Increase Salaries
        public static string IncreaseSalaries(SoftUniContext context)
        {
            List<Employee> employees = context.Employees
                .Where(d => d.Department.Name == "Engineering" 
                || d.Department.Name == "Tool Design"
                || d.Department.Name == "Marketing" 
                || d.Department.Name == "Information Services ")
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            foreach (var item in employees)
            {
                item.Salary *= 1.12M;
            }

            context.SaveChanges();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:f2})");
            }

            return sb.ToString().TrimEnd();
        }

        //13.Employees By FirstName Starting With Sa
        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var employees = context.Employees.Where(e => e.FirstName.StartsWith("Sa"))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Select(e => new
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    JobTitle = e.JobTitle,
                    Salary = e.Salary
                }).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:f2})");
            }

            return sb.ToString();
        }

        //14. Delete Project ById
        public static string DeleteProjectById(SoftUniContext context)
        {
            var project = context.Projects.Find(2);

            var employeeProjects = context.EmployeesProjects
                .Where(ep => ep.ProjectId == project.ProjectId)
                .ToList();

            context.EmployeesProjects.RemoveRange(employeeProjects);
            context.Projects.Remove(project);

            context.SaveChanges();

            StringBuilder sb = new StringBuilder();

            var projects = context.Projects
                .Select(p => p.Name)
                .ToList();

            foreach (var currentProject in projects)
            {
                sb.AppendLine(currentProject);
            }

            return sb.ToString();
        }

        //15. Remove Town
        public static string RemoveTown(SoftUniContext context)
        {
            var currentTown = context.Towns.First(t => t.Name == "Seattle");

            var addresses = context.Addresses.Where(a => a.TownId == currentTown.TownId).ToList();

            foreach (var address in addresses)
            {
                var employees = context.Employees.Where(e => e.AddressId == address.AddressId)
                    .ToList();

                foreach (var employee in employees)
                {
                    employee.AddressId = null;
                }
            }

            context.Addresses.RemoveRange(addresses);
            context.Towns.Remove(currentTown);

            context.SaveChanges();

            return $"{addresses.Count} addresses in Seattle were deleted";
        }

        public static void Main()
        {
            var context = new SoftUniContext();

            var result = RemoveTown(context);
            Console.WriteLine(result);
        }
    }
}