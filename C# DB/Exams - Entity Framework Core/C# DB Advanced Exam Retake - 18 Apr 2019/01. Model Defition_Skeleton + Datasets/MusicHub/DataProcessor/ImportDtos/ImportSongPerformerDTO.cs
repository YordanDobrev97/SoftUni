using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace MusicHub.DataProcessor.ImportDtos
{
    [XmlType("Performer")]
    public class ImportSongPerformerDTO
    {
        [XmlElement("FirstName")]
        [MinLength(3)]
        [MaxLength(20)]
        [Required]
        public string FirstName { get; set; }

        [MinLength(3)]
        [MaxLength(20)]
        [Required]
        [XmlElement("LastName")]
        public string LastName { get; set; }

        [XmlElement("Age")]
        [Range(18, 70)]
        [Required]
        public int Age { get; set; }

        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        public decimal NetWorth { get; set; }

        [XmlArray("PerformersSongs")]
        public PerformersSongsDTO[] PerformersSongs { get; set; }
    }

    [XmlType("Song")]
    public class PerformersSongsDTO
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}
