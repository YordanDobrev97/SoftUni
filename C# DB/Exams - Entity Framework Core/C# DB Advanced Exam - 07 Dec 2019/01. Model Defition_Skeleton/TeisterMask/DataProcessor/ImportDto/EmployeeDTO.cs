using System.ComponentModel.DataAnnotations;

namespace TeisterMask.DataProcessor.ImportDto
{
    public class EmployeeDTO
    {
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

        public int[] Tasks { get; set; }
    }
}
