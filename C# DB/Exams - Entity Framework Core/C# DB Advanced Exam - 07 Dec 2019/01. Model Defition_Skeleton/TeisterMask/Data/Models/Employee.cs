using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeisterMask.Data.Models
{
    public class Employee
    {
        public Employee()
        {
            this.EmployeesTasks = new HashSet<EmployeeTask>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        [RegularExpression(@"([A-Z]+|[a-z]+\d*)",
         ErrorMessage = "Only uppercase or lower Characters or digits are allowed.")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"(\d{3})-(\d{3})-(\d{4})",
         ErrorMessage = "Only digits")]
        public string Phone { get; set; }

        public ICollection<EmployeeTask> EmployeesTasks { get; set; }

    }
}
