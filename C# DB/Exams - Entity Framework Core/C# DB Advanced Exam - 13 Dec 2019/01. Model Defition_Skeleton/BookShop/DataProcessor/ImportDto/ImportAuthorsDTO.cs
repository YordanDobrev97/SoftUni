using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShop.DataProcessor.ImportDto
{
    public class ImportAuthorsDTO
    {
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [EmailAddress]
        [JsonProperty("Email")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"(\d{3})-(\d{3})-(\d{4})",
         ErrorMessage = "Only digits")]
        [JsonProperty("Phone")]
        public string Phone { get; set; }

        [JsonProperty("Books")]
        public BookDTO[] Books { get; set; }
    }

    public class BookDTO
    {
        public int? Id { get; set; }
    }
}
