using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TaigaAutotests.TestData.DTOs
{
    public class User
    {
        [JsonProperty("userName", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
