using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace TeisterMask.DataProcessor.ImportDto
{
    public class ImportEmployeeDTO
    {
        [JsonProperty("Username")]
        [MinLength(3)]
        [MaxLength(40)]
        [Required]
        [RegularExpression(@"[A-Za-z0-9]+")]
        public string Username { get; set; }

        [JsonProperty("Email")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [JsonProperty("Phone")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
        public string Phone { get; set; }

        [JsonProperty("Tasks")]
        public int[] Tasks { get; set; }
    }
}
