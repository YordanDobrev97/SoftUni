using Newtonsoft.Json;

namespace ProductShop.DTO
{
    public class UserProductDTO
    {
        [JsonProperty("usersCount")]
        public int UsersCount { get; set; }
    }
}
