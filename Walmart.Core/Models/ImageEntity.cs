using Newtonsoft.Json;
using System;

namespace Walmart.Core.Models
{
    public class ImageEntity
    {
        [JsonProperty("thumbnailImage")]
        public Uri ThumbnailImage { get; set; }

        [JsonProperty("mediumImage")]
        public Uri MediumImage { get; set; }

        [JsonProperty("largeImage")]
        public Uri LargeImage { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }
    }
}
