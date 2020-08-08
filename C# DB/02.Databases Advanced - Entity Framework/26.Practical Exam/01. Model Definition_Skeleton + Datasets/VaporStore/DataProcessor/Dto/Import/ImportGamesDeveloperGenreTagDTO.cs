using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace VaporStore.DataProcessor.Dto.Import
{
    public class ImportGamesDeveloperGenreTagDTO
    {
        [JsonProperty("Name")]
        [Required]
        public string Name { get; set; }

        [Required]
        [JsonProperty("Price")]
        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        public decimal Price { get; set; }

        [JsonProperty("ReleaseDate")]
        public string ReleaseDate { get; set; }

        [JsonProperty("Developer")]
        [Required]
        public string Developer { get; set; }

        [JsonProperty("Genre")]
        [Required]
        public string Genre { get; set; }

        [JsonProperty("Tags")]
        public string[] Tags { get; set; }
    }
}
