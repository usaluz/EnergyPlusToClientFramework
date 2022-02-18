﻿using Newtonsoft.Json;

namespace EnergyPlusJsonSchemas._9_5_0.Fields.Legacy
{
    public class EPLegacyAlphas
    {
        [JsonProperty("fields")]
        public string[] Fields { get; set; }

        [JsonProperty("extensions", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Extensions { get; set; }
    }
}