using System;
using System.Text.Json.Serialization;

namespace WEB_953505_KORZUN.Blazor.Client.Models
{
    public class DetailsViewModel
    {
        [JsonPropertyName("productName")]
        public string ProductName { get; set; } 
        [JsonPropertyName("description")]
        public string Description { get; set; } 
        [JsonPropertyName("price")]
        public double Price { get; set; }
        [JsonPropertyName("image")]
        public string Image { get; set; } 
    }
}
