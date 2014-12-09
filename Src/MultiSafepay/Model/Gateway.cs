﻿using Newtonsoft.Json;

namespace MultiSafepay.Model
{
    public class Gateway
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("markup_fee")]
        public string MarkupFee { get; set; }
    }
}