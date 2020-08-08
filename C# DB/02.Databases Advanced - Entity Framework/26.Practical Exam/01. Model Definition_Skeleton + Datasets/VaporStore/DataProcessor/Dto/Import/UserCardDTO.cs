using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace VaporStore.DataProcessor.Dto.Import
{
    public class UserCardDTO
    {
        [Required]
        [JsonProperty("FullName")]
        [RegularExpression("^[A-Z][a-z]+\\s[A-Z][a-z]+$")]
        public string FullName { get; set; }

        [JsonProperty("Username")]
        [MinLength(3)]
        [MaxLength(20)]
        public string Username { get; set; }

        [JsonProperty("Email")]
        [Required]
        public string Email { get; set; }

        [JsonProperty("Age")]
        [Range(3, 103)]
        public int Age { get; set; }

        [JsonProperty("Cards")]
        public CardDTO[] Cards { get; set; }
    }

    public class CardDTO
    {
        [JsonProperty("Number")]
        [RegularExpression(@"^\d{4}\s\d{4}\s\d{4}\s\d{4}$")]
        public string Number { get; set; }

        [JsonProperty("CVC")]
        [RegularExpression(@"^\d{3}$")]
        public string CVC { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }
    }
}