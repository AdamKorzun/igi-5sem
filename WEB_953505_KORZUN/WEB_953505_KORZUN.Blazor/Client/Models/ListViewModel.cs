using System;
using System.Text.Json.Serialization;
namespace WEB_953505_KORZUN.Blazor.Client.Models
{
    public class ListViewModel
    {
        [JsonPropertyName("productId")]
        public int ProductId { get; set; } 
        [JsonPropertyName("productName")]
        public string ProductName { get; set; }
    }
}
