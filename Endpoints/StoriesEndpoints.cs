using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Santander.Models.DTO;
using Santander.Services;

namespace Santander.Endpoints;

public static class StoriesEndpoints
{
    public static void MapStoriesEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("api/v1").WithDescription("Stories API");
        group.MapGet(string.Empty, GetStoriesIds).WithDescription("Test Get stories IDs").CacheOutput();
        group.MapGet("/Stories/{id}", GetStoryById).WithDescription("Test Get story by Id").CacheOutput();
        group.MapGet("/Stories", GetStorys).WithDescription("Get stories desc by comment value").CacheOutput();

    }


    static async Task<Results<Ok<List<StoryDTO?>>, BadRequest>> GetStorys([FromQuery(Name = "n")] int n,IStoriesService storiesService)
    {
        var res = await storiesService.GetStoriesAsync(n);
        return res is not null ? TypedResults.Ok(res) : TypedResults.BadRequest();
    }

    static async Task<Results<Ok<List<int>>, BadRequest>> GetStoriesIds( IStoriesService storiesService)
    {
        var res = await storiesService.GetStoriesIdsAsync();
        return res is not null ?  TypedResults.Ok(res) : TypedResults.BadRequest(); 
    }
    
    public static async Task<Results<Ok<StoryDTO>?, BadRequest>> GetStoryById(int id, IStoriesService storiesService)
    {
        var res = await storiesService.GetStoryByIdAsync(id);
        return res is null ? TypedResults.BadRequest() : TypedResults.Ok(res);
    }
}
