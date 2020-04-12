using System;
using System.Text.Json.Serialization;

namespace ASYNC_front1.Models
{
    public class Hotel
    {

        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("streetAddress")]
        public string StreetAddress { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("state")]

        public string State { get; set; }
        [JsonPropertyName("phone")]

        public string Phone { get; set; }
    }
}
