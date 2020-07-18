using Newtonsoft.Json;

namespace ProductShop.DTO
{
    public class UserSoldProductDTO
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("soldProducts")]
        public SolidProductDTO[] SolidProducts { get; set; }
    }
}
