using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MusicHub.DataProcessor.ImportDtos
{
    public class ImportProducerAlbumDTO
    {
        [Required]
        [JsonProperty("Name")]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        [RegularExpression(@"[A-Z][a-z]+\s[A-Z][a-z]+")]
        [JsonProperty("Pseudonym")]
        public string Pseudonym { get; set; }

        [RegularExpression(@"^\+359\s(\d{3})\s(\d{3})\s(\d{3})$")]
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("Albums")]
        public AlbumsDTO[] Albums { get; set; }
    }

    public class AlbumsDTO
    {
        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        public string ReleaseDate { get; set; }
    }
}
