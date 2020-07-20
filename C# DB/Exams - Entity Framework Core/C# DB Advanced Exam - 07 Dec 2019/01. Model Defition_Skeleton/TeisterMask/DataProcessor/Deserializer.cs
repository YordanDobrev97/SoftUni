namespace TeisterMask.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    using Data;
    using Newtonsoft.Json;
    using TeisterMask.Data.Models;
    using TeisterMask.DataProcessor.ImportDto;
    using System.Text;
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
            throw new NotImplementedException();
        }

        public static string ImportEmployees(TeisterMaskContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            var employees = JsonConvert.DeserializeObject<EmployeeDTO[]>(jsonString);

            foreach (var employeeDTO in employees)
            {
                if (IsValid(employeeDTO))
                {
                    var employee = new Employee
                    {
                        Username = employeeDTO.Username,
                        Email = employeeDTO.Email,
                        Phone = employeeDTO.Phone
                    };

                    context.Employees.Add(employee);

                    //TODO Add task...
                }
            }

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