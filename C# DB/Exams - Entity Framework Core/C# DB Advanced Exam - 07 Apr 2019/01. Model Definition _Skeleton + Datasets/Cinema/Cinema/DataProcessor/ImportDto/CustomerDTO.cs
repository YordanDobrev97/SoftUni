using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Cinema.DataProcessor.ImportDto
{
    [XmlType("Customer")]
    public class CustomerDTO
    {
        [XmlElement("FirstName")]
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }


        [XmlElement("LastName")]
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string LastName { get; set; }

        [XmlElement("Age")]
        [Required]
        [Range(12, 110)]
        public int Age { get; set; }

        [XmlElement("Balance")]
        [Required]
        [Range(typeof(decimal), "0.01", "10000000000000000000")]
        public decimal Balance { get; set; }

        [XmlArray("Tickets")]
        public TickerDTO[] Tickets { get; set; }
    }

    [XmlType("Ticket")]
    public class TickerDTO
    {
        [XmlElement("ProjectionId")]
        public int ProjectionId { get; set; }

        [XmlElement("Price")]
        [Required]
        [Range(typeof(decimal), "0.01", "100000000000000000000")]
        public decimal Price { get; set; }
    }
}