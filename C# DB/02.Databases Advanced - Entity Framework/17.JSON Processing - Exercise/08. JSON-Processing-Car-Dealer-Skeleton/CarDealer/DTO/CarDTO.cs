using CarDealer.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CarDealer.DTO
{
    public class CarDTO
    {

        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("travelledDistance")]
        public int TravelledDistance { get; set; }

        [JsonProperty("partsId")]
        public ICollection<int> Parts { get; set; } = new List<int>();
    }
}
