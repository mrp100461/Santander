using Microsoft.AspNetCore.Http.HttpResults;
using Santander.Models.DTO;
namespace Santander.Services;

public interface IStoriesService
{

    Task<List<StoryDTO?>?> GetStoriesAsync(int n);
    Task <List<int>?> GetStoriesIdsAsync();
    Task<StoryDTO?> GetStoryByIdAsync(int id);
}