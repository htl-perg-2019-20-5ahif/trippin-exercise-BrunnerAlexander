using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Trippin
{
    class User
    {
        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("cityName")]
        public string CityName { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
