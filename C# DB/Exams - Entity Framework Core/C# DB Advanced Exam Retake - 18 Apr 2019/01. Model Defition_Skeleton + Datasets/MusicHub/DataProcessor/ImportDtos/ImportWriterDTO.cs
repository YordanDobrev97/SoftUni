using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MusicHub.DataProcessor.ImportDtos
{
    public class ImportWriterDTO
    {
        [JsonProperty("Name")]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }

        [JsonProperty("Pseudonym")]
        [RegularExpression(@"[A-Z][a-z]+\s[A-Z][a-z]+")]
        public string Pseudonym { get; set; }
    }
}
