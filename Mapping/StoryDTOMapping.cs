using Santander.Models.DTO;
using Santander.Models.Response;

namespace Santander.Mapping
{
    public class StoryDTOMapping
    {
        public static StoryDTO MapToDTO(StoryResponse storyResponse)
        {
            if (storyResponse == null)
            {
                return new StoryDTO();
            }
            return new StoryDTO
            {
                Title = storyResponse.Title,
                URI = storyResponse.URI,
                PostedBy = storyResponse.PostedBy,
                Time = DateTimeOffset.FromUnixTimeSeconds(storyResponse.UnixTime).DateTime.ToString("yyyy/MM/dd'T'HH:mm:sszzz"),
                Score = storyResponse.Score,
                CommentCount = storyResponse.Comment?.Count ?? 0
            };
        }



    }
}
