using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TaigaAutotests.TestData.DTOs
{
    public class AuthRequest
    {
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
