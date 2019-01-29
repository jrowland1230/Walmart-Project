using Newtonsoft.Json;

namespace Walmart.Core.Models
{
    public class Attributes
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("replenishmentEndDate")]
        public string ReplenishmentEndDate { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }
    }
}
