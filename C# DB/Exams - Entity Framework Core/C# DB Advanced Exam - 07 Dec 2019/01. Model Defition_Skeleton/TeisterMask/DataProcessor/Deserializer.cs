namespace TeisterMask.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    using Data;
    using XmlFacade;
    using TeisterMask.DataProcessor.ImportDto;
    using System.Text;
    using System.Globalization;
    using Microsoft.EntityFrameworkCore.Storage;
    using TeisterMask.Data.Models;
    using TeisterMask.Data.Models.Enums;
    using Newtonsoft.Json;
    using Microsoft.EntityFrameworkCore.Internal;
    using System.Linq;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedProject
            = "Successfully imported project - {0} with {1} tasks.";

        private const string SuccessfullyImportedEmployee
            = "Successfully imported employee - {0} with {1} tasks.";

        public static string ImportProjects(TeisterMaskContext context, string xmlString)
        {
            var data =  XmlConverter.Deserializer<ImportProjectDTO>(xmlString, "Projects");

            StringBuilder sb = new StringBuilder();
            foreach (var item in data)
            {
                if (!IsValid(item))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var validOpenDateProject = DateTime.TryParseExact(item.OpenDate.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime projectOpenDate);

                if (!validOpenDateProject)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var project = new Project
                {
                    Name = item.Name,
                    OpenDate = projectOpenDate
                };

                var validProjectDueDate = DateTime.TryParseExact(item.DueDate?.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime projectDueDate);

                if (string.IsNullOrEmpty(item.DueDate))
                {
                    project.DueDate = null;
                }
                else
                {
                    if (!validProjectDueDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    project.DueDate = projectDueDate;
                }

                foreach (var taskDTO in item.Tasks)
                {
                    if (!IsValid(taskDTO))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    var validOpenDate = DateTime.TryParseExact(taskDTO.OpenDate.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime openDate);

                    var validDueDate = DateTime.TryParseExact(taskDTO.DueDate.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dueDate);

                    if (!validOpenDate || !validDueDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    //task open date is before project open date - invalid
                    if (openDate < dueDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    //maybe due date null
                    if (projectDueDate == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    //task due date is after project due date - invalid
                    if (dueDate > projectDueDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    var validExecutionType = Enum.TryParse<ExecutionType>(taskDTO.ExecutionType.ToString(), out ExecutionType et);

                    var validLabelType = Enum.TryParse<LabelType>(taskDTO.LabelType.ToString(), out LabelType lt);

                    if (!validExecutionType || !validLabelType)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    var task = new Task
                    {
                        Name = taskDTO.Name,
                        OpenDate = openDate,
                        DueDate = dueDate,
                        ExecutionType = et,
                        LabelType = lt,
                    };

                    project.Tasks.Add(task);
                }

                if (project.Tasks.Count == 0)
                {
                    continue;
                }

                context.Projects.Add(project);
                sb.AppendLine(string.Format(SuccessfullyImportedProject, project.Name, project.Tasks.Count));
            }

            context.SaveChanges();

            return sb.ToString();
        }

        public static string ImportEmployees(TeisterMaskContext context, string jsonString)
        {
            var data = JsonConvert.DeserializeObject<ImportEmployeeDTO[]>(jsonString);

            StringBuilder sb = new StringBuilder();
            int employeeCount = 0;
            int employeeTaskCount = 0;
            foreach (var item in data)
            {
                if (!IsValid(item))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var employee = new Employee
                {
                    Email = item.Email,
                    Username = item.Username,
                    Phone = item.Phone
                };

                foreach (var task in item.Tasks.Distinct())
                {
                    if (!context.Tasks.Any(t => t.Id == task))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    var employeeTask = new EmployeeTask
                    {
                        EmployeeId = employee.Id,
                        TaskId = task
                    };

                    employee.EmployeesTasks.Add(employeeTask);
                    employeeTaskCount++;
                }

                context.Employees.Add(employee);
                sb.AppendLine(string.Format(SuccessfullyImportedEmployee, employee.Username, employee.EmployeesTasks.Count));
                employeeCount++;
            }

            context.SaveChanges();
            return sb.ToString();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}