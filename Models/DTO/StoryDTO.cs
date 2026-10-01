using System.Text.Json.Serialization;
namespace Santander.Models.DTO;

public class StoryDTO
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("uri")]
    public string URI { get; set; } = string.Empty;

    [JsonPropertyName("postedBy")]
    public string PostedBy { get; set; } = string.Empty;

    [JsonPropertyName("time")]
    public string Time { get; set; } = string.Empty;

    [JsonPropertyName("score")]
    public int Score { get; set; } = 0;

    [JsonPropertyName("commentCount")]
    public int CommentCount { get; set; } = 0;
}
