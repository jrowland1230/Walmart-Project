using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart.Core.Models
{
    public class GiftOptions
    {
        [JsonProperty("allowGiftWrap")]
        public bool AllowGiftWrap { get; set; }

        [JsonProperty("allowGiftMessage")]
        public bool AllowGiftMessage { get; set; }

        [JsonProperty("allowGiftReceipt")]
        public bool AllowGiftReceipt { get; set; }
    }
}
