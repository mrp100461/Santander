using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Santander.Models.Response;

public class StoryResponse
{
    [JsonPropertyName("title")]
    public string Title { get; set; }= string.Empty;

    [JsonPropertyName("uri")]
    public string URI { get; set; } = string.Empty;

    [JsonPropertyName("postedBy")]
    public string PostedBy { get; set; } = string.Empty;

    [JsonPropertyName("time")]
    public Int64 UnixTime { get; set; } = 0;

    [JsonPropertyName("score")]
    public int Score { get; set; } = 0;

    [JsonPropertyName("kids")]
    public List<int> Comment { get; set; } = [];


    
}



