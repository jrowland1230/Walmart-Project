using Newtonsoft.Json;
using System.Collections.Generic;

namespace Walmart.Core.Models
{
    public class SearchQuery
    {
        //public enum CategoryNode { The1085632_8486574_7292842, The976759_1086446_1229651, The976760_1172220_1895551 };

        //public enum CategoryPath { FoodCoffeeGroundCoffee, HealthHeartHealthHeartHealthyFoods, SeasonalNdTestNdTestShelf };

        public enum EntityType { Primary, Secondary };

        public enum Stock { Available, NotAvailable };

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }

        [JsonProperty("responseGroup")]
        public string ResponseGroup { get; set; }

        [JsonProperty("totalResults")]
        public long TotalResults { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("numItems")]
        public long NumItems { get; set; }

        [JsonProperty("items")]
        public List<Product> Items { get; set; }

        [JsonProperty("facets")]
        public List<object> Facets { get; set; }
    }


}