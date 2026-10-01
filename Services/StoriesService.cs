using System.Net.Http.Json;
using Santander.Mapping;
using Santander.Models.DTO;
using Santander.Models.Response;
namespace Santander.Services;

public class StoriesService : IStoriesService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private List<int?> _storyIds = [];
    public StoriesService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
        
    }

    public async Task<List<StoryDTO?>?> GetStoriesAsync(int n)
    {
        if(n <= 0)
        {
            throw new BadHttpRequestException($"Parameter n must be greater than zero, {nameof(n)}");
        }
        var ids =  await GetStoriesIdsAsync();
        if (ids is null)
        {
            throw new BadHttpRequestException($"No ids found, {nameof(ids)}");
        }
        var stories = new List<StoryDTO>();
        foreach (var id in  ids)
        {
            var story = await GetStoryByIdAsync(id);
            if (story is not null)
            {
                stories.Add(story);
            }
        }

        if (stories.Count <= n)
        {
            throw new BadHttpRequestException($"Parameter n is too large, {nameof(n)}");
        }

        return [.. stories.OrderBy(s => s.CommentCount).Take(n)];         
    }

    public async Task<List<int>?> GetStoriesIdsAsync()
    {
        var client = _httpClientFactory.CreateClient("hackernews");
        var response = await client.GetFromJsonAsync<List<int>>("beststories.json");
        return response ?? null;
    }

    public  async Task<StoryDTO?> GetStoryByIdAsync(int id)
    {
        if (id <= 0)
        {
            throw new BadHttpRequestException($"ID must be greater than zero, {nameof(id)}");
        }
        var client = _httpClientFactory.CreateClient("hackernews");
        var response = await client.GetFromJsonAsync<StoryResponse>($"item/{id}.json");
        if (response is not null)
        {
            return StoryDTOMapping.MapToDTO(response);
           
        }

        return null;
    }   
  
}