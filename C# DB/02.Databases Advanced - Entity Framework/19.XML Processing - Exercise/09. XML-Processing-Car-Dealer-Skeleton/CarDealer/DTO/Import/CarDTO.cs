using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

namespace CarDealer.DTO.Import
{
    [XmlType("Car")]
    public class CarDTO
    {
        [XmlElement("make")]
        public string Make { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("TraveledDistance")]
        public long TraveledDistance { get; set; }

        [XmlArray("parts")]
        public PartCarDTO[] Parts { get; set; }
    }

    [XmlType("partId")]
    public class PartCarDTO
    {
        [XmlAttribute("id")]
        public int partId { get; set; }
    }
}
